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
    class Log
    {
        public static void InsertLog(Dictionary<string, object> dic_Log, ref string errormessage)
        {

            using (SQLiteConnection conn = new SQLiteConnection("data source="+ Application.StartupPath+@"\DataBase\TransLog.db"))
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
                        sh.Insert("Log", dic);
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


        public static void InsertLog(Dictionary<string, object> dic_Log, string dataBaseName, string tableName)
        {

            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\" + dataBaseName + ".db"))
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

                    //var dic1 = new Dictionary<string, object>();
                    //dic1["orderId"] = "20";
                    //DataTable dt = sh.Select("select * from Log where orderId = @orderId", dic1);

                    conn.Close();
                }
            }


        }
        public static void GetorgLog(Dictionary<string, object> org_Log, string orderId ,string txnTime,string queryId , ref string errormessage)
        {

            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\TransLog.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {
                        DataTable dt;
                        if (queryId.Equals(""))
                        {

                            dt = sh.Select("select * from Log where txnTime = @txnTime", new SQLiteParameter[] {
                            new SQLiteParameter("@txnTime", txnTime),
                    });
                        }
                        else
                        {
                            dt = sh.Select("select * from Log where queryId = @queryId", new SQLiteParameter[] {
                            new SQLiteParameter("@queryId", queryId)  });

                        }
                        sh.Commit();
                        org_Log.Add("queryId", dt.Rows[0]["queryId"]);
                        org_Log.Add("messageName", dt.Rows[0]["messageName"]);
                        org_Log.Add("traceNo", dt.Rows[0]["traceNo"]);
                        org_Log.Add("orderId", dt.Rows[0]["orderId"]);
                        org_Log.Add("txnType", dt.Rows[0]["txnType"]);
                        org_Log.Add("txnSubType", dt.Rows[0]["txnSubType"]);
                        org_Log.Add("txnTime", dt.Rows[0]["txnTime"]);
                        org_Log.Add("txnAmt", dt.Rows[0]["txnAmt"]);
                        org_Log.Add("qrCode", dt.Rows[0]["qrCode"]);
                        org_Log.Add("messageResult", dt.Rows[0]["messageResult"]);

                    }
                    catch(Exception e)
                    {
                        sh.Rollback();
                        errormessage += "查询不到原交易，请=确认原交易信息是否正确";
                    }

                    //var dic1 = new Dictionary<string, object>();
                    //dic1["orderId"] = "20";
                    //DataTable dt = sh.Select("select * from Log where orderId = @orderId", dic1);

                    conn.Close();
                }
            }


        }


        public static void updataMessageResult(Dictionary<string, object> updata_Log, string queryId, ref string errormessage)
        {

            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\TransLog.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {
        
                        sh.Update("Log", updata_Log, "queryId", queryId);
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



        

        public static DataTable GetDictionaryTable(string databaseName)
        {
            DataTable dt = null;
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\"+ databaseName+".db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {



                        dt = sh.Select("Select * From Log");



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


        public static void DeleteALLLog(string databaseName,bool isSqlite_Sequence)
        {

            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\" + databaseName + ".db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();
                    try
                    {
                        sh.Execute("delete from Log");
                        if (isSqlite_Sequence)
                        {
                            sh.Execute("delete from sqlite_sequence");
                        }
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

        public static void UpdateLog(DataTable dt,string databaseName)
        {

            using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\" + databaseName + ".db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText ="Select* From Log";
                    conn.Open();

                   
                    try
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        SQLiteCommandBuilder scb = new SQLiteCommandBuilder(da); 
                        da.Update(dt);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    //var dic1 = new Dictionary<string, object>();
                    //dic1["orderId"] = "20";
                    //DataTable dt = sh.Select("select * from Log where orderId = @orderId", dic1);

                    conn.Close();
                }
            }
            
        }
    }
}
