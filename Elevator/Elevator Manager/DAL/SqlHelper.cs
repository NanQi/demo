using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SqlHelper
    {
        private readonly string _strConnection =
           ConfigurationManager.ConnectionStrings["connection"].ToString();

        private SqlConnection _connection;

        /// <summary>
        /// 构造函数
        /// </summary>
        public SqlHelper()
        {
            _connection = new SqlConnection(_strConnection);
        }

        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        private SqlConnection OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// 给Command对象填充参数
        /// </summary>
        /// <param name="cmd">SqlCommand对象</param>
        /// <param name="parames">参数数组</param>
        /// <returns>SqlCommand对象</returns>
        private SqlCommand ForeachParames(SqlCommand cmd, SqlParameter[] parames)
        {
            foreach (SqlParameter p in parames)
            {
                if (p != null)
                {
                    cmd.Parameters.Add(p);
                }
            }

            return cmd;
        }

        /// <summary>
        /// 执行ExecuteScalar
        /// </summary>
        /// <param name="commandText">存储过程名</param>
        /// <param name="parames">可变参数</param>
        /// <returns>第一列第一行</returns>
        public object ExecuteScalar(string commandText, params SqlParameter[] parames)
        {
            SqlCommand cmd = OpenConnection().CreateCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                return ForeachParames(cmd, parames).ExecuteScalar();
            }
            catch (SqlException e)
            {
                string error = e.ToString();
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// 返回DataTable
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="tblName">表名</param>
        /// <param name="parames">可变参</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string procName, string tblName, params SqlParameter[] parames)
        {
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;



            SqlDataAdapter adapter = new SqlDataAdapter(ForeachParames(cmd, parames));
            DataTable dt = new DataTable(tblName);

            try
            {
                adapter.Fill(dt);
                cmd.Parameters.Clear();
            }
            catch (SqlException e)
            {
                string error = e.ToString();
                throw;
            }
            return dt;
        }

        /// <summary>
        /// 执行ExecuteNonQuery
        /// </summary>
        /// <param name="commandText">存储过程名</param>
        /// <param name="parames">可变参数</param>
        /// <returns>影响行数</returns>
        public int ExecuteNonQuery(string commandText, params SqlParameter[] parames)
        {
            SqlCommand cmd = OpenConnection().CreateCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = CommandType.StoredProcedure;

            int result;

            try
            {
                result = ForeachParames(cmd, parames).ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (SqlException e)
            {
                string error = e.ToString();
                throw;
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        /// <summary>
        /// 执行ExecuteReader
        /// </summary>
        /// <param name="commandText">存储过程名</param>
        /// <param name="parames">可变参数</param>
        /// <returns>SqlDataReader对象</returns>
        public SqlDataReader ExecuteReader(string commandText, params SqlParameter[] parames)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = OpenConnection();
            cmd.CommandText = commandText;
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader;

            try
            {
                reader = ForeachParames(cmd, parames).ExecuteReader(
                   CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
            }
            catch (SqlException e)
            {
                string error = e.ToString();
                CloseConnection();
                throw;
            }
            return reader;
        }
    }
}
