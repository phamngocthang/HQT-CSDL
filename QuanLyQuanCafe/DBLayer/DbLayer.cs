using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    class DbLayer
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        string connString = "Data Source=(local);Initial Catalog=QuanLyCafe;Integrated Security=True";

        public DbLayer ()
        {
            conn = new SqlConnection(connString);
            cmd = conn.CreateCommand();
        }
        
        public DataTable ExecuteQuery (string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            conn.Close();
        }

        public DataTable SelectWhere(string strSQL, CommandType ct,
            params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            SqlDataReader data = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(data);
            return dt;
            conn.Close(); 
        }
        public SqlDataReader SelectWhere1(string strSQL, CommandType ct,
            params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
            conn.Close();
        }
        public bool ExecuteNonQuery(string strSQL, CommandType ct, ref string error, 
            params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // cmd
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            // add parameters
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            // run command
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
