using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ISS.CMS.DAL
{
    class SqlHelper
    {
        //protected static string connectionString = ConfigurationManager.AppSettings["constr"];
        protected static string connectionKey = "constr";

        public static SqlParameter GetStoredProcedureReturn(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings[connectionKey]);
            cmd.Connection = conn;
            try
            {
                PrepareCommand(cmd, conn, null, CommandType.StoredProcedure, null, null);
                cmd.ExecuteNonQuery();
                SqlParameter result = cmd.Parameters[cmd.Parameters.Count - 1];
                cmd.Parameters.Clear();
                conn.Close();
                return result;
            }
            catch(Exception e)
            {
                string error = e.Message; 
                conn.Close();
                throw;
            }
        }

        public static DataSet GetStoredProcedureData(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings[connectionKey]);
            cmd.Connection = conn;
            try
            {
                PrepareCommand(cmd, conn, null, CommandType.StoredProcedure, null, null);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                //cmd.Parameters.Clear();
                conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                string error = e.Message;
                conn.Close();
                throw;
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(CommandType cmdType, string cmdText, params SqlParameter[] cmdParms)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings[connectionKey]);

            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                SqlDataAdapter command = new SqlDataAdapter(cmd);
                command.Fill(ds, "ds");
                cmd.Parameters.Clear();
                conn.Close();
                return ds;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(CommandType cmdType, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings[connectionKey]);

            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                object obj = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                conn.Close();
                if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                {
                    return null;
                }
                else
                {
                    return obj;
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                conn.Close();
                throw new Exception(e.Message); ;
            }
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(CommandType cmdType, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings[connectionKey]);

            // 我们在这里用 try/catch 是因为如果这个方法抛出异常，我们目的是关闭数据库连接，再抛出异常，
            // 因为这时不会有DataReader存在，此后commandBehaviour.CloseConnection将不会工作。
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                int rows = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                return rows;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        /// <summary>
        /// 用提供的函数，执行SQL命令，返回一个从指定连接的数据库记录集
        /// </summary>
        /// <remarks>
        /// 例如：
        /// SqlDataReader r = ExecuteReader(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">SqlConnection有效的SQL连接字符串</param>
        /// <param name="commandType">CommandType：CommandType.Text、CommandType.StoredProcedure</param>
        /// <param name="commandText">SQL语句或存储过程</param>
        /// <param name="commandParameters">SqlParameter[]参数数组</param>
        /// <returns>SqlDataReader：执行结果的记录集</returns>
        public static SqlDataReader ExecuteReader(CommandType cmdType, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings[connectionKey]);

            // 我们在这里用 try/catch 是因为如果这个方法抛出异常，我们目的是关闭数据库连接，再抛出异常，
            // 因为这时不会有DataReader存在，此后commandBehaviour.CloseConnection将不会工作。
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                // cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        /// <summary>
        /// 为执行命令做好准备：打开数据库连接，命令语句，设置命令类型（SQL语句或存储过程），函数语取。
        /// </summary>
        /// <param name="cmd">SqlCommand 组件</param>
        /// <param name="conn">SqlConnection 组件</param>
        /// <param name="trans">SqlTransaction 组件，可以为null</param>
        /// <param name="cmdType">语句类型：CommandType.Text、CommandType.StoredProcedure</param>
        /// <param name="cmdText">SQL语句，可以为存储过程</param>
        /// <param name="cmdParms">SQL参数数组</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            if (cmdText != null)
                cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
    }
}
