using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.IO;
using System.Data;

namespace QR_Tool_Winform.Global
{
    class Parameters
    {
       public struct MessageEncode
        {
           public static string strValue = "UTF-8";
           public static Encoding encValue = Encoding.UTF8;

        }
        public static string phoneIP = "";
        public static string platformUrl = "";
        public static bool phoneToggle = false;
   

        public static DataTable dtDictionnary = null;
        public static DataTable dtResponse = null;
        public static DataTable dtOnlineDeviceTestCaseList = null;
        public static DataTable dtLog = null;
        public static DataTable dtPOSTestCase = null;
        public static DataTable dtOnlineDeviceCase = null;
        public static DataTable dtOfflineDeviceCase= null;

        public static string dbTestCaseSoure = "";
        public static string LogName = "";

    }

}
