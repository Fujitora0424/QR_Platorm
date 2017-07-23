using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Tool_Winform.DataBase
{
    class TestCaseDataBase
    {

        public static void InitTestCase()
        {
            
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\TestCase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {



                        Global.Parameters.dtPOSTestCase = sh.Select("Select * From PosTestCase");
                        Global.Parameters.dtOnlineDeviceCase = sh.Select("Select * From OnlineDeviceTestCase");
                        Global.Parameters.dtOfflineDeviceCase= sh.Select("Select * From OfflineDeviceTestCase");



                        sh.Commit();


                    }
                    catch
                    {
                        sh.Rollback();
                    }

                    //var dic1 = new Dictionary<string, object>();
                    //dic1["orderId"] = "20";
                    //DataTable dt = sh.Select("select * from Log where orderId = @orderId", dic1);

                    conn.Close();
                }
            }
          
        }

        public static DataTable GetTestCase(string tableName)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\TestCase.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {


                        string sql = string.Format("Select * From {0}", tableName);
                        dt= Global.Parameters.dtPOSTestCase = sh.Select(sql);
                       



                        sh.Commit();


                    }
                    catch
                    {
                        sh.Rollback();
                    }

                    //var dic1 = new Dictionary<string, object>();
                    //dic1["orderId"] = "20";
                    //DataTable dt = sh.Select("select * from Log where orderId = @orderId", dic1);

                    conn.Close();
                }
            }

            return dt;

        }
    }
}
