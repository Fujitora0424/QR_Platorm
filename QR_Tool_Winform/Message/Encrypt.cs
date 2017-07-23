using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Northstar.IO;
using QR_Tool_Winform.UP_SDK;

namespace QR_Tool_Winform
{
    class Encrypt
    {
       

        public static void SignByCertInfo(Dictionary<string, string> resData, Encoding encoding, ref string errorMessage)
        {
            try
            {
                //Dictionary<string, string> resData_Sign = resData;
                string signMethod = resData["signMethod"];
                string certPath = Application.StartupPath + "\\Certificate\\" + "TestSign.pfx";
                string certPwd = "00000000";


                if ("01".Equals(signMethod))
                {
                    //resData["certId"] = CertUtil.GetSignCertId(certPath, certPwd);

                    //��Dictionary��Ϣת����key1=value1&key2=value2����ʽ
                    string stringData = SDKUtil.CreateLinkString(resData, true, false, encoding);

                    byte[] signDigest = SecurityUtil.Sha256(stringData, encoding);

                    string stringSignDigest = SDKUtil.ByteArray2HexString(signDigest);

                   


                    byte[] byteSign = SecurityUtil.SignSha256WithRsa(CertUtil.GetSignKeyFromPfx(certPath, certPwd), encoding.GetBytes(stringSignDigest));

                    string stringSign = Convert.ToBase64String(byteSign);


                    //����ǩ����ֵ
                    resData["signature"] = stringSign;

                    return;


                }
                else
                {
                    return; //log.Error("Error signMethod [" + signMethod + "] in SignByCertInfo. ");
                }
            }
            catch(Exception e)
            {
                errorMessage+= e.Message;

            }
        }
    }
}
