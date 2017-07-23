using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Tool_Winform.Global
{
    class TestConfig
    {
        private static string deviceType = "";
        private static string testCaseTitle = "";
        private static DataTable nowDeviceDataTable = null;
        private static int macQRCode = 100;
    

        private static bool stableTest = false;

        public static string DeviceType { get => deviceType; set => deviceType = value; }
        public static DataTable NowDeviceDataTable { get => nowDeviceDataTable; set => nowDeviceDataTable = value; }
        public static string TestCaseTitle { get => testCaseTitle; set => testCaseTitle = value; }
        public static int MacQRCode { get => macQRCode; set => macQRCode = value; }
        public static bool StableTest { get => stableTest; set => stableTest = value; }
     
    }
    
}
