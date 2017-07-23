using QR_Tool_Winform.Certificate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Tool_Winform.Global
{
    class Field
    {

        //请求域配置值
        private static string reqReserved = "";
        private static string encoding = "";
        private static string accessType = "0";
        private static string bizType = "000000";
        private static string currencyCode = "156";
        private static string version = "5.1.0";
        private static string backUrl = "";
        private static string channelType = "07";//渠道类型
        private static string merId = "123456789012345";
        private static string termId = "12345678";
        private static string signMethod = "01";



        public static string Encoding { get => encoding; set => encoding = value; }
        public static string AccessType { get => accessType; set => accessType = value; }
        public static string CurrencyCode { get => currencyCode; set => currencyCode = value; }
        public static string Version { get => version; set => version = value; }
        public static string BackUrl { get => backUrl; set => backUrl = value; }
        public static string ChannelType { get => channelType; set => channelType = value; }
        public static string MerId { get => merId; set => merId = value; }
        public static string BizType { get => bizType; set => bizType = value; }
        public static string TermId { get => termId; set => termId = value; }
        public static string SignMethod { get => signMethod; set => signMethod = value; }
        public static string ReqReserved { get => reqReserved; set => reqReserved = value; }

        public static string SignPubKeyCert
        {
            get
            {
                string cerPath = Application.StartupPath + "\\Certificate\\" + "TestSign.cer";
                return DataCertificate.GetCertificateString(cerPath);
            }
        }

        public static string CertId
        {
            get
            {
                string certPath = Application.StartupPath + "\\Certificate\\" + "商户898310173990680证书.pfx";
                return UP_SDK.CertUtil.GetSignCertId(certPath, "690085");

            }
        }
    }
     
}
