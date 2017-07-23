using QR_Tool_Winform.Global;
using QR_Tool_Winform.Tcp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TLVHelper;

namespace QR_Tool_Winform.PhoneControl
{
    class PhoneControl
    {
        public static void StartScanBarCode(Dictionary<string,object> send_Dic,string encodig)
        {
            
           Task.Run(() => {
           try
           {
               TcpClient tcpclient = new TcpClient();
              tcpclient.Connect(Global.Parameters.phoneIP, 16908);
               Dictionary<string, string> new_Dic = new Dictionary<string, string>();
                new_Dic.Add("queryId", (string)send_Dic["queryId"]);
                new_Dic.Add("traceNo", (string)send_Dic["traceNo"]);
                new_Dic.Add("txnSubType", (string)send_Dic["txnSubType"]);
                new_Dic.Add("txnType", (string)send_Dic["txnType"]);
                new_Dic.Add("txnTime", (string)send_Dic["txnTime"]);
                new_Dic.Add("txnAmt", (string)send_Dic["txnAmt"]);
                new_Dic.Add("encoding", encodig);
                string transString = UP_SDK.SDKUtil.CreateLinkString(new_Dic, true, false, Encoding.UTF8);
                byte[] transByte = Encoding.Default.GetBytes(transString);
                   byte[] urlByte = Encoding.Default.GetBytes(Parameters.platformUrl);
                List<TLVMOD> packagetlvData = new List<TLVMOD>();
                List<byte> packagebytes = null;
                TLVMOD package_9F01 = new TLVMOD();
               package_9F01.Data = new byte[1] { 0x01 };
               package_9F01.Len = 1;
               package_9F01.Tag = 0x9F01;
               packagetlvData.Add(package_9F01);
               TLVMOD package_9F03 = new TLVMOD();
               package_9F03.Data = transByte;
               package_9F03.Len = transByte.Length;
               package_9F03.Tag = 0x9F03;
               packagetlvData.Add(package_9F03);
               TLVMOD package_9F05 = new TLVMOD();
               package_9F05.Data = urlByte;
                   package_9F05.Len = urlByte.Length;
                   package_9F05.Tag = 0x9F05;
                   packagetlvData.Add(package_9F05);
                   packagebytes = TLVHelper.TLVHelper.Pack(packagetlvData);
               byte[] sendData = packagebytes.ToArray();
               byte[] countBytes = new byte[4];
               byte[] sendBytes = new byte[4 + sendData.Length];
               countBytes = BitConverter.GetBytes(sendData.Length);
               if (BitConverter.IsLittleEndian)
               { Array.Reverse(countBytes); }
               countBytes.CopyTo(sendBytes, 0);
               sendData.CopyTo(sendBytes, 4);
              Stream stm = tcpclient.GetStream();
              stm.Write(sendBytes, 0, sendBytes.Length);
               }
               catch
               {

               }


           });

           

        }
    }
}
