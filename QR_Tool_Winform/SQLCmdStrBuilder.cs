using System;
using System.Data;
using System.Text;

/// <summary>
/// 生成SQL语句
/// </summary>
public class SQLCmdStrBuilder
{
    public static string Insert(string table, string[] colum,string [] value)
    {
        StringBuilder sql = new StringBuilder("insert into ");
        StringBuilder sql_l = new StringBuilder("(");
        StringBuilder sql_r = new StringBuilder("values (");
        sql.Append(table);

        for (int i = 0; i < colum.Length; i++)
        {
            if (value[i].StartsWith("@"))
            {
                if ((i + 1) == colum.Length)
                {
                    sql_l.Append(colum[i] + " ) ");
                    sql_r.Append(" " + value[i] + "  )");
                }
                else
                {
                    sql_l.Append(colum[i] + ", ");
                    sql_r.Append(" " + value[i] + " ,");
                }
            }
            else
            {
                if ((i + 1) == colum.Length)
                {
                    sql_l.Append(colum[i] + " ) ");
                    sql_r.Append("'" + value[i] + "' )");
                }
                else
                {
                    sql_l.Append(colum[i] + ", ");
                    sql_r.Append("'" + value[i] + "',"); 
                }
            }

            
        }
        return sql.Append(sql_l).Append(sql_r).ToString();
    }

    public static string Delete(string table, string[] colums,string [] value)
    {
        StringBuilder sql = new StringBuilder();
        sql.Append("delete from " + table + " where ");
        if (null == colums || colums.Length == 0)
        {
            throw new Exception("SQL删除指令未指定条件");
        }
        for (int i = 0; i < colums.Length; i++)
        {
            sql.Append(colums[i] + "= '" + value[i] + "' and ");
        }
        sql.Remove(sql.Length - 4, 4);
        return sql.ToString();
    }

    public static string Update(string table, string[] colum, string [] value, string[] rulename, string[] rulenamevalue)
    {
        StringBuilder sql = new StringBuilder("update ");
        sql.Append(table + " set ");

        for (int i = 0; i < colum.Length; i++)
        {

            if (value[i].StartsWith("@"))
            {
                sql.Append(colum[i] + "=  " + value[i] + " ,");
            }
            else
            {
                sql.Append(colum[i] + "= '" + value[i] + "',"); 
            }
        }
        sql.Remove(sql.Length - 1, 1);

        if (null != rulename && rulename.Length > 0)
        {
            sql.Append(" where ");
            for (int i = 0; i < rulename.Length; i++)
            {
                sql.Append(rulename[i] + "= '" + rulenamevalue[i] + "' and ");
            }
            sql.Remove(sql.Length - 4, 4);
        }
        return sql.ToString();
    }

    public static string Select(string table, string[] names, string[] rulename,string[] value)
    {
        StringBuilder sql = new StringBuilder();
        sql.Append("select ");
        if (null == names || 0 == names.Length)
        {
            sql.Append("* ");
        }
        else
        {
            foreach (string t in names)
            {
                sql.Append(t + ", ");
            }
            sql.Remove(sql.Length - 2, 2);
        }

        sql.Append(" from " + table);
        if (null != rulename && rulename.Length > 0)
        {
            sql.Append(" where ");
            for (int i = 0; i < rulename.Length; i++)
            {
                sql.Append(rulename[i] + " = '" + value[i] + "' and ");
            }
            sql.Remove(sql.Length - 4, 4);
        }
        return sql.ToString();
    }
}
