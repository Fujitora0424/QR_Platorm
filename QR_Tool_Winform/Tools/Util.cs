using System;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using System.Security.Cryptography;
namespace Northstar.IO
{
    /// <summary>
    /// Util 的摘要说明。
    /// </summary>
    public class Util
    {
        static SHA1 sha1 = new SHA1CryptoServiceProvider();
        static Random random = new Random();
        public Util()
        {
            //result = sha.ComputeHash(data);

            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public static byte[] Sha1Digest(byte[] data)
        {
            sha1 = new SHA1CryptoServiceProvider();
            return (byte[])sha1.ComputeHash(data).Clone();
        }
        static public byte[] generateRandomNumber(int len)
        {
            byte[] data = new byte[len]; ;
            random.NextBytes(data);
            return data;
        }
        public static byte[] StrToByteArray(string str)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(str);
        }
        public static String ByteArrayToString(byte[] bytes)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetString(bytes);
        }
        static public byte[] SubBytes(byte[] bytes, int length)
        {
            byte[] data = new byte[length];
            Array.Copy(bytes, data, length);
            return data;
        }
        static public byte[] SubBytes(byte[] bytes, int from, int length)
        {
            byte[] data = new byte[length];
            Array.Copy(bytes, from, data, 0, length);
            return data;
        }
        static public byte[] BytesConcate(byte[] bytes1, byte[] bytes2)
        {
            if ((bytes1 == null) && (bytes2 == null))
                return null;
            if (bytes1 == null)
                return (byte[])bytes2.Clone();
            if (bytes2 == null)
                return (byte[])bytes1.Clone();
            byte[] data = new byte[bytes1.Length + bytes2.Length];
            Array.Copy(bytes1, 0, data, 0, bytes1.Length);
            Array.Copy(bytes2, 0, data, bytes1.Length, bytes2.Length);
            return data;
        }
        static public String ByteToHexString(byte b)
        {
            String s = null;
            s += b.ToString("X2");
            return s;
        }

        static public String BytesToHexString(byte[] bytes, int len)
        {
            
            if (bytes == null)
            {
                return "";
            }

            byte[] bb = new byte[len];
            if (len > bytes.Length)
            {
                return "";
            }

            for (int i = 0; i < len; i++)
            {
                bb[i] = bytes[i];
            }

            return BytesToHexString(bb);
        }

        static public String BytesToHexString(byte[] bytes, int index, int len)
        {
           
            if (bytes == null)
            {
                return "";
            }

            byte[] bb = new byte[len];
            if (len > bytes.Length)
            {
                return "";
            }

            for (int i = 0; i < len; i++)
            {
                bb[i] = bytes[index + i];
            }

            return BytesToHexString(bb);
        }



        static public String CharsToHexString(char[] bytes, int len)
        {
           
            if (bytes == null)
            {
                return "";
            }


            byte[] bb = new byte[len];
            if (len > bytes.Length)
            {
                return "";
            }

            for (int i = 0; i < len; i++)
            {
                bb[i] = (byte)bytes[i];
            }

            return BytesToHexString(bb);
        }

        static public String BytesToHexString(byte[] bytes)
        {
            String s = null;
            if (bytes == null)
            {
                return "";
            }
            foreach (byte b in bytes)
            {
                s += b.ToString("X2");
            }
            return s;
        }

        static public String BytesToString(byte[] bytes)
        {
            String s = null;
            s = System.Text.Encoding.Default.GetString(bytes);
            return s;
        }


        static public String BytesToString(byte[] bytes, int len)
        {
            String s = null;
            s = System.Text.Encoding.Default.GetString(bytes).Substring(0, len * 2);
            return s;
        }


        static public byte[] HexStringToBytes(String s)
        {

            byte[] bytes;
            int z = s.Length;
            if (s.Length % 2 != 0)
                return null;
            bytes = new byte[s.Length / 2];
            for (int i = 0; i < s.Length / 2; i++)
            {
                String sub = s.Substring(2 * i, 2);
                bytes[i] = byte.Parse(sub, NumberStyles.HexNumber);
            }
            return bytes;
        }
        static public byte[] AsciiStringToBytes(String s)
        {
            byte[] data = new byte[s.Length];
            int i = 0;
            foreach (char c in s)
            {
                data[i++] = CharToByte(c);
            }
            return data;

        }

        static public byte CharToByte(char c)
        {
            return Convert.ToByte(c);
        }
        static public char ByteToChar(byte b)
        {
            return Convert.ToChar(b);
        }
        static public bool BytesEquals(byte[] b1, byte[] b2)
        {
            if (b1.Length != b2.Length)
                return false;
            for (int i = 0; i < b1.Length; i++)
                if (b1[i] != b2[i])
                    return false;
            return true;
        }
        /// <summary>
        /// 仅用于2位转换 [9/19/2010 Johnson Zhang]
        /// </summary>
        static public byte IntToByte(int num)
        {
            Byte[] b;
            b = BitConverter.GetBytes(num);
            return b[0];
        }

        /// <summary>
        /// 2字节的int转换string的方法
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static public string IntToHexString2(int num)
        {
            string rtn = "";
            if (num > 255)
            {
                rtn = IO.Util.ByteToHexString(IO.Util.IntToByte(num / 256));
                rtn += IO.Util.ByteToHexString(IO.Util.IntToByte(num % 256));
            }
            else
            {
                rtn = "00" + IO.Util.ByteToHexString(IO.Util.IntToByte(num));
            }


            return rtn;
        }

        static public string IntToHexString1(int num)
        {
            string rtn = "";
            if (num <= 255)
            {
                rtn = IO.Util.ByteToHexString(IO.Util.IntToByte(num));
            }
            else
            {
                rtn = "";
            }


            return rtn;
        }

        static public byte xor(byte b1, byte b2)
        {
            return Northstar.IO.Util.IntToByte(
                    Northstar.IO.Util.ByteToInt(b1) ^ Northstar.IO.Util.ByteToInt(b2)
                );
        }
     

        static public string xor(string s1, string s2)
        {
            byte[] bs1 = Northstar.IO.Util.HexStringToBytes(s1);
            byte[] bs2 = Northstar.IO.Util.HexStringToBytes(s2);
            for (int i = 0; i < bs1.Length; i++)
            {
                bs1[i] = xor(bs1[i], bs2[i]);
            }
            return Northstar.IO.Util.BytesToHexString(bs1);
        }

        /// <summary> [10/7/2010/ Johnson]
        /// 
        /// </summary> [10/7/2010/ Johnson]
        static public int ByteToInt(byte num)
        {
            return Int32.Parse(num.ToString());
        }

        static public uint BytesToInt(byte[] bnum)
        {
            int rtn = 0;
            int basen = 1;
            for (int i = 1; i <= bnum.Length; i++)
            {
                basen = 1;
                for (int j = 0; j < (bnum.Length - i); j++)
                {
                    basen = basen * 256;
                }


                rtn = rtn + basen * bnum[i - 1];
            }
            return ((uint)rtn);
        }

        static public int StringToInt(string txt)
        {
            return Int32.Parse(txt);
        }

        static public string HexStringToString(string hex)
        {
            return BytesToInt(HexStringToBytes(hex)).ToString();
        }

        static public uint HexStringToInt(string hex)
        {
            return BytesToInt(HexStringToBytes(hex));
        }


        /// <summary>
        /// hexString 转换成asciistring [10/14/2010 Johnson Zhang]
        /// </summary>
        static public string HexStringToAsciiString(string txt)
        {
            Encoding en = Encoding.ASCII;
            return en.GetString(HexStringToBytes(txt));
        }


        static public ArrayList SplitByChar(string txt, string splitTxt)
        {
            ArrayList al_rtn = new ArrayList();
            try
            {
                string tmp = txt;
                string t = "";
                if (tmp.IndexOf(splitTxt) == -1)
                {
                    return al_rtn;
                }
                do
                {
                    t = txt.Substring(0, txt.IndexOf(splitTxt));
                    al_rtn.Add(t);
                    txt = txt.Substring(txt.IndexOf(splitTxt) + splitTxt.Length, txt.Length - txt.IndexOf(splitTxt) - splitTxt.Length);

                } while (txt.Length != 0);

            }
            catch 
            {

            }
            return al_rtn;
        }


        /// <summary>
        /// 用于检测是否全是00 [11/4/2010 Johnson Zhang]
        /// </summary>
        public static bool StringIsFullOfZero(string txt)
        {
            string tmp = txt;
            try
            {
                if (tmp.Substring(0, 2) != "00")
                {
                    return false;
                }
                do
                {
                    tmp = tmp.Substring(2);
                } while (tmp.Length != 0 && tmp.Substring(0, 2) == "00");
                if (tmp.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }


        static public string getStringWithOutEndOfStr1(string txt, string str1)
        {
            string rtn = txt;

            try
            {
                string endWord = txt.Substring(txt.Length - 1);
                // 没有00的情况 [10/13/2010 Johnson Zhang]
                if (endWord != str1)
                {
                    return txt;
                }
                while (endWord == str1)
                {
                    endWord = rtn.Substring(rtn.Length - 1);
                    rtn = rtn.Substring(0, rtn.Length - 1);

                }
                rtn = rtn + endWord;
            }
            catch 
            {

                rtn = txt;
            }

            return rtn;
        }




        public static byte[] StringToBytes(string txt)
        {
            return System.Text.Encoding.Default.GetBytes(txt);
        }

        public static string GetLength(string t)
        {
            return (t.Length / 2).ToString("X2");
        }


        static public string DelTailByte00(string txt)
        {

            string tmp = "";
            txt += "\0";
            txt = "#" + txt;
            string rtn = txt;
            do
            {
                tmp = rtn.Substring(rtn.Length - 1, 1);
                if (tmp != "\0")
                {
                    break;
                }
                rtn = rtn.Substring(0, rtn.Length - 1);
            } while (true);
            rtn = rtn.Substring(1, rtn.Length - 1);
            return rtn;


        }

        /// <summary>
        /// 分割字符
        /// 将t根据id分解为list
        /// </summary>
        /// <param name="t">输入数据</param>
        /// <param name="id">分割标示</param>
        /// <returns></returns>
        public static List<string> separateStringById(string t, string id)
        {
            //             if (t==null||id==null)
            //             {
            //                 return null;
            //             }
            //             List<string> rtn = new List<string>();
            //             string tmp = "";
            //             try
            //             {
            //                 do
            //                 {
            //                     if (t.IndexOf(id) >= 0)
            //                     {
            //                         tmp = t.Substring(0, t.IndexOf(id));
            //                         t = t.Substring(t.IndexOf(id) + id.Length);
            //                         rtn.Add(tmp);
            //                     }
            //                     else
            //                     {
            //                         rtn.Add(t);
            //                         break;
            //                     }
            // 
            //                 } while (true);
            //             }
            //             catch (System.Exception e)
            //             {
            //                 rtn = null;
            //             }
            //             return rtn;
            if ((t == null) || (id == null))
            {
                return null;
            }
            List<string> list = new List<string>();
            string item = "";
            try
            {
                while (t.IndexOf(id) >= 0)
                {
                    item = t.Substring(0, t.IndexOf(id));
                    t = t.Substring(t.IndexOf(id) + id.Length);
                    if (item.Trim() != "")
                    {
                        list.Add(item);
                    }
                }
                if (t.Trim() != "")
                {
                    list.Add(t);
                }
            }
            catch (Exception)
            {
                list = null;
            }
            return list;
        }

        public static List<string> separateStringById(string t, char id)
        {
            /*
                        if (t == null || id == null)
                        {
                            return null;
                        }
                        List<string> rtn = new List<string>();
                        string tmp = "";
                        try
                        {
                            do
                            {
                                if (t.IndexOf(id) >= 0)
                                {
                                    tmp = t.Substring(0, t.IndexOf(id));
                                    t = t.Substring(t.IndexOf(id) + 1);
                                    rtn.Add(tmp);
                                }
                                else
                                {
                                    rtn.Add(t);
                                    break;
                                }

                            } while (true);
                        }
                        catch (System.Exception e)
                        {
                            rtn = null;
                        }
                        return rtn;*/
            if (t == null)
            {
                return null;
            }
            List<string> list = new List<string>();
            string item = "";
            try
            {
                while (t.IndexOf(id) >= 0)
                {
                    item = t.Substring(0, t.IndexOf(id));
                    t = t.Substring(t.IndexOf(id) + 1);
                    if (item.Trim() != "")
                    {
                        list.Add(item);
                    }
                }
                if (t.Trim() != "")
                {
                    list.Add(t);
                }
            }
            catch (Exception)
            {
                list = null;
            }
            return list;
        }


    }
}
