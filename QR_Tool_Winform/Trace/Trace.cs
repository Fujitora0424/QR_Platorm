using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Tool_Winform
{
    class Trace
    {
        public static void SaveDefaultTrace(string log,int type,string mestype)
        {
  
            string time= DateTime.Now.ToString("yyyyMMddhhmmss");
            string drName = time.Substring(0, 8);
            string traceName = time.Substring(8, 6);

            if (Directory.Exists(Application.StartupPath+@"\Log\" + drName) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory((Application.StartupPath + @"\Log\" + drName));
            }
            if(type==0)
            {
                Global.Parameters.LogName = Application.StartupPath + @"\Log\" + drName + "\\" + mestype+traceName + ".txt";              
            }

            StreamWriter sw = new StreamWriter(Global.Parameters.LogName, true);
            sw.Write(log);
            sw.Close();


        }

        public static void WriteWrongTrace(string exMessage)
        {

            string path = Application.StartupPath + @"\Wrong\" + "WrongMessage.txt";
            if (File.Exists(path) == false)//如果不存在就创建file文件夹
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                fs.Dispose();
            }

         

            using (StreamWriter sw = new StreamWriter(path, true))
            {
            sw.Write(exMessage + "\r\n");
           
              }

        }


    }
}
