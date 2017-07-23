using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

/// <summary>
/// DBC 的摘要说明
/// </summary>
public class CDBControl
{
    private SqlConnection conn;
    public SqlCommand comm;
    public SqlDataReader dr;
    public DataSet ds;
    public SqlDataAdapter dad;
    private string sql;
    private string connStr;   /* 数据库联接字符串 */
    private string errInfo = "";
    public List<SqlParameter> lstSqlPara;

    public CDBControl()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
        this.ConnStr = "Server=" + "100.100.100.1" +
                             "; User ID =" + "iccspyii" +
                             "; PWD=" + "iccspyii" +
                             "; Database=" + "testwork" +
                             "; Connection Timeout=2"; 
        lstSqlPara = new List<SqlParameter>();
	}

    public string ErrInfo
    {
       get
       {
        return errInfo;
       }
    }

      /* 要操作的Sql语句 */
      public string Sql
      {
       get{
        return sql;
       }
       set{
        sql = value;
       }
      }

      /* 数据库链接字符串 */
      public string ConnStr
      {
       get
       {
        return connStr;
       }
       set
       {
        connStr = value;
       }
      }

      private void connDb()
      {
          if (conn != null) return;

       conn = new SqlConnection(connStr);
       try
       {
        conn.Open();
       }
       catch(SqlException e)
       {
        for(int i=0;i<e.Errors.Count;i++)
        {
         errInfo += "错误序号："+i+"\n"+
                           "出错信息："+e.Errors[i].Message+"\n"+
                           "出错来源："+e.Errors[i].Source+"\n"+
                           "程序："+e.Errors[i].Procedure;
        }
        conn.Close();
       }
      }


      /* 用于窗体绑定 */
      public void dataView()
      {
       connDb();
       dad = new SqlDataAdapter(sql,conn);
       ds  = new DataSet();
       dad.Fill(ds);
       DataView dv = new DataView(ds.Tables[0]);
      }

      /* 执行SQL语句，返回结果 */
      public void readerData()
      {
       connDb();
       comm = new SqlCommand(sql, conn);
       comm.Parameters.AddRange(lstSqlPara.ToArray());
       dr   = comm.ExecuteReader();
      }
      /* 执行SQL语句，不返回结果 */
      public void exeSql()
      {
       connDb();
       comm = new SqlCommand(sql, conn);
       comm.Parameters.AddRange(lstSqlPara.ToArray());
       comm.ExecuteNonQuery();
      }

      /* 关闭链接 */
      public void clear()
      {
       conn.Close();
      }
     }

