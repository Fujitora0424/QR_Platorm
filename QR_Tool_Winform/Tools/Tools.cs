using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using QR_Tool_Winform.Global;

namespace QR_Tool_Winform
{
    class Tools
    {



        public static string CountNumber;//交易存储量测试计数器缓存变量
        public static byte[] StringToByte(string StringData, ref string errorMessage)//字符串转非ASC字节数组 返回值：字节数组 参数1:字符串数据 参数2：错误信息
        {

            StringData = StringData.Trim();
            char[] CharData;
            byte[] ByteData;
            if (StringData.Length % 2 != 0)
            {
                //errorMessage += "要转成BYTE数组的数据不能构成整数个字节，即存在半个字节数据，请检查\r\n";
                //不认为是错误，后补F
                ByteData = new byte[StringData.Length / 2 + 1];
                StringData = StringData.Trim() + "F";
                CharData = StringData.ToCharArray();
            }
            else
            {
                ByteData = new byte[StringData.Length / 2];
                CharData = StringData.Trim().ToCharArray();
            }
            for (int i = 0; i < CharData.Length; i++)
            {
                //ASC码转实际值
                int LeftByte = Convert.ToInt32(CharData[i]) > 0x39 ? (Convert.ToInt32(CharData[i]) > 0x46 ? Convert.ToInt32(CharData[i]) - 87 : Convert.ToInt32(CharData[i]) - 55) : Convert.ToInt32(CharData[i]) - 48;
                int RightByte = Convert.ToInt32(CharData[i + 1]) > 0x39 ? (Convert.ToInt32(CharData[i + 1]) > 0x46 ? Convert.ToInt32(CharData[i + 1]) - 87 : Convert.ToInt32(CharData[i + 1]) - 55) : Convert.ToInt32(CharData[i + 1]) - 48;
                ByteData[i / 2] = Convert.ToByte(LeftByte * 16 + RightByte);
                i++;
            }
            return ByteData;
        }

        public static byte[] NumToASCByte(long number, int ASCLength, bool isHex, ref string errorMessage)//整型转ASC码 返回值：ASC码字节数组 参数1:待转换数字 参数2：返回值长度 参数3：是否转成16进制 参数4：错误信息
        {
            Byte[] ASCByte = new Byte[ASCLength];
            int length = 0;
            if (isHex)
            {
                long CheckNumber = number;
                while (CheckNumber >= 16)
                {
                    CheckNumber = CheckNumber / 16;
                    length++;
                }
                length++;
            }
            else
            {
                long CheckNumber = number;
                while (CheckNumber >= 10)
                {
                    CheckNumber = CheckNumber / 10;
                    length++;
                }
                length++;
            }
            if (length > ASCLength)
            {
                errorMessage += "NumToASCByte（）计算出返回值长度大于指定长度，请检查\r\n";
                return null;
            }
            if (isHex)
            {
                for (int i = 0; i < ASCLength; i++)
                {
                    long ex = 1;
                    for (int j = ASCLength - 1; j > i; j--)
                    {
                        ex = ex * 16;
                    }
                    ASCByte[i] = Convert.ToByte((ex == 1 ? number % 16 : number / ex) > 9 ? (ex == 1 ? number % 16 : number / ex) + 55 : (ex == 1 ? number % 16 : number / ex) + 48);
                    number = number - (number / ex) * ex;
                }
            }
            else
            {
                for (int i = 0; i < ASCLength; i++)
                {
                    long ex = 1;
                    for (int j = ASCLength - 1; j > i; j--)
                    {
                        ex = ex * 10;
                    }
                    ASCByte[i] = Convert.ToByte((ex == 1 ? number % 10 : number / ex) + 0x30);
                    number = number - (number / ex) * ex;
                }
            }
            return ASCByte;
        }
        public static byte[] StringToASCByte(string DataStr, int length, ref string errorMessage)//字符转ASC码数组 返回值：ASC码字节数组 参数1:待转换字符串 参数2：长度信息 参数3：错误信息
        {
            Byte[] ASCByte = new Byte[length];
            try
            {
                Byte[] data = Encoding.GetEncoding("GBK").GetBytes(DataStr);
                Array.Copy(data, 0, ASCByte, 0, data.Length);
                int position = data.Length;
                while (position < length)
                {
                    ASCByte[position] = 0x20;
                    position++;
                }
            }
            catch (Exception ex)
            {
                errorMessage += ex.Message + "\r\n";
                return null;
            }
            return ASCByte;
        }
        public static Int32 HexStringToInt(string LengthStr, ref string errorMessage)//字符串格式长度转Int类型长度值
        {
            Byte[] LengthByte = StringToByte(LengthStr, ref errorMessage);
            int Exponent = LengthByte.Length;
            int LengthInt = 0;
            foreach (Byte LengthTempByte in LengthByte)
            {
                int Power = 1;
                for (int i = 0; i < Exponent - 1; i++)
                {
                    Power *= 256;
                }
                LengthInt += Convert.ToInt32(LengthTempByte) * Power;
                Exponent--;
            }
            return LengthInt;
        }


 


        public static string Xor(string LeftBlock, string RightBlock)

        {
            byte[] ByteLeft = Tools.StringToBytes(LeftBlock);
            byte[] ByteRight = Tools.StringToBytes(RightBlock);

            byte[] block = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                block[i] = (byte)(ByteLeft[i] ^ ByteRight[i]);
            }
            string result = Tools.BytesToHexString(block);
            return result;
        }
        static public byte[] StringToBytes(string s)
        {
            byte[] bytes;
            if (s.Length % 2 != 0)
                return null;
            bytes = new byte[s.Length / 2];
            for (int i = 0; i < s.Length / 2; i++)
            {
                bytes[i] = Convert.ToByte(s.Substring(i * 2, 2), 16);
            }
            return bytes;
        }
        static public string BytesToHexString(byte[] bytes)
        {
            String s = null;
            if (null == bytes)
            {
                return "";
            }
            foreach (byte b in bytes)
            {
                s += b.ToString("X2");
            }
            return s;
        }
        static public string AscStringtoHexstring(string Ascstring)
        {
            byte[] buff = new byte[Ascstring.Length / 2];
            int index = 0;
            for (int i = 0; i < Ascstring.Length; i += 2)
            {

                buff[index] = Convert.ToByte(Ascstring.Substring(i, 2), 16);
                ++index;

            }
            string result = Encoding.Default.GetString(buff);
            return result;

        }




        static public bool PortinUse(int port)//判断端口是否被占用
        {
            bool inUse = false;
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndpoints = ipProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endPoint in ipEndpoints)
            {
                if (endPoint.Port == port)
                {
                    inUse = true;
                    break;


                }


            }
            return inUse;


        }
        public static string DataTableToString(DataTable dt)//转换
        {
            string dtstring = "";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dtstring = dtstring + dt.Columns[i].ColumnName + "\t";
            }
            dtstring = dtstring + "\r\n";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dtstring = dtstring + dt.Rows[i][j] + "\t";
                }
                dtstring = dtstring + "\r\n";
            }
            return dtstring + "\r\n" + "\r\n";


        }


        public static string GenerateRandomNumber(int Length, string Type)
        {
            char[] constant = null;

            if (Type.Equals("number"))
            {
                constant = new char[]
 {
 '0','1','2','3','4','5','6','7','8','9',

};
            }
            else if (Type.Equals("letter"))
            {
                constant = new char[]
{

 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
};
            }
            else
            {
                constant = new char[]
  {
 '0','1','2','3','4','5','6','7','8','9',
 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
 };

            }
            StringBuilder newRandom = new StringBuilder(62);
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(constant.Length)]);
            }
            return newRandom.ToString();
        }

        public static string GetRespMsg(string respCode)
        {
            string respMsg = "";
            try
            {
                string selectcomand = string.Format("respCode = '{0}'", respCode);
                DataRow dr = Parameters.dtResponse.Select(selectcomand)[0];
                respMsg = (string)dr["respMsg"];
            }
            catch(Exception e)
            {
                respMsg = "未知";


            }
            return respMsg;


        }

        public static string GetTestCaseManualMessage(string testCaseName)
        {

            var testCaseManualMessage = "";
            try
            {
                testCaseManualMessage = (string)Parameters.dtOnlineDeviceTestCaseList.Select(String.Format("testCaseName = '{0}'", testCaseName))[0]["testCaseManualMessage"];
            }
            catch
            {
                testCaseManualMessage = "不存在";
            }
            return testCaseManualMessage;

        }
    }
}
