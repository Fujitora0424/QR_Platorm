using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Tool_Winform.Global
{
    class ResultConfig
    {
        public string projectName;
        public Dictionary<string, string> result;
        public ResultConfig()
       {
            projectName = "";
            result = new Dictionary<string, string>();
        }


    }
}
