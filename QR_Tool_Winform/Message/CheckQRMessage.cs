using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using QR_Tool_Winform.Certificate;
using QR_Tool_Winform.UP_SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Tool_Winform.Message
{
    class CheckQRMessage
    {

      static public bool ValidateSign(Dictionary<string,string> recData,  Encoding encoding, ref string errorMessage)
        {
            Dictionary<string, string> reqData = new Dictionary<string, string>(recData);

            if (!reqData.ContainsKey("signMethod") || !reqData.ContainsKey("signature") || !reqData.ContainsKey("version"))
            {
                errorMessage+= "signMethod或signature或version为空，无法验证签名。"+"\r\n";
                return false;
            }
            string signMethod = reqData["signMethod"];
            string version = reqData["version"];
            bool result = false;

            if ("01".Equals(signMethod))
            {

                if ("5.0.0".Equals(version))
                {
                    string signValue = reqData["signature"];
                    byte[] signByte = Convert.FromBase64String(signValue);
                    reqData.Remove("signature");
                    string stringData = SDKUtil.CreateLinkString(reqData, true, false, encoding);

                    byte[] signDigest = SecurityUtil.Sha1(stringData, encoding);
                    string stringSignDigest = SDKUtil.ByteArray2HexString(signDigest);
                    AsymmetricKeyParameter key = CertUtil.GetValidateKeyFromPath(reqData["certId"]);
                    if (null == key)
                    {
                        errorMessage = "未找到证书，无法验签，验签失败。";
                        return false;
                    }
                    result = SecurityUtil.ValidateSha1WithRsa(key, signByte, encoding.GetBytes(stringSignDigest));
                }
                else
                {
                    string signValue = reqData["signature"];

                    byte[] signByte = Convert.FromBase64String(signValue);
                    reqData.Remove("signature");
                    string stringData = SDKUtil.CreateLinkString(reqData, true, false, encoding);
                    byte[] signDigest = SecurityUtil.Sha256(stringData, encoding);
                    string stringSignDigest = SDKUtil.ByteArray2HexString(signDigest);
                    //string signPubKeyCert = reqData["signPubKeyCert"];
                    //X509Certificate x509Cert = CertUtil.VerifyAndGetPubKey(signPubKeyCert);
                    string filepath = Application.StartupPath + "\\Certificate\\" + "商户898310173990680证书.pfx";
                    X509Certificate x509Cert = CertUtil.ReadCertFromFile(filepath, "690085");

                    if (x509Cert == null)
                    {
                        errorMessage += "获取验签证书失败，无法验签，验签失败。" + "\r\n";
                        return false;
                    }
                    result = SecurityUtil.ValidateSha256WithRsa(x509Cert.GetPublicKey(), signByte, encoding.GetBytes(stringSignDigest));
                }
            }
            else if ("11".Equals(signMethod) || "12".Equals(signMethod))
            {
                errorMessage+= "不支持此种算法" + "\r\n";
                return false;

            }
            else
            {
                errorMessage += "Error signMethod [" + signMethod + "] in Validate. " + "\r\n";
                return false;

            }
            if (!result)
            {
                errorMessage+= "验签失败" + "\r\n";


            }
           
         
            return result;

        }
    }
}
