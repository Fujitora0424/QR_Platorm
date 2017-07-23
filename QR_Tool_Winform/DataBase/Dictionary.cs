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
    class Dictionary
    {
        public static DataTable  GetDictionaryTable(string tableName)
        {
            DataTable dt=null;
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\Dictionary.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {



                        dt = sh.Select("Select * From"+" "+ tableName);



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

        public static void InsertLog(Dictionary<string, object> dic_Log, string tableName)
        {


            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\Dictionary.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {
                        var dic = new Dictionary<string, object>(dic_Log);
                        sh.Insert(tableName, dic);
                        sh.Commit();
                    }
                    catch
                    {
                        sh.Rollback();
                    }



                    conn.Close();
                }


            }
        }

        public static void UpdateLog(Dictionary<string, object> dic_Log, string tableName)
        {


            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\Dictionary.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {
                        var dic = new Dictionary<string, object>(dic_Log);
                        sh.Update(tableName, dic_Log, "testCaseName", dic_Log["testCaseName"]);
                        sh.Commit();
                    }
                    catch
                    {
                        sh.Rollback();
                    }



                    conn.Close();
                }


            }
        }
    }
}
