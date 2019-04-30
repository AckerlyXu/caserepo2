using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebFormCases2.sqldbexe
{
    public class DBHelper
    {
        string ConnectionString = string.Empty;
        static SqlConnection con;
        public DBHelper()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            con = new SqlConnection(ConnectionString);
        }
        public void SetConnection()
        {
            if (ConnectionString == string.Empty)
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            }
            con = new SqlConnection(ConnectionString);
        }
        public DataTable GetDatatable(string procName, Hashtable parms)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (con == null)
            {
                SetConnection();
            }
            cmd.Connection = con;
            if (parms.Count > 0)
            {
                foreach (DictionaryEntry de in parms)
                {
                    cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                }
            }
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable GetDatatable(string procName)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (con == null)
            {
                SetConnection();
            }
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public int Insert_Update_Delete(string procName, Hashtable parms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            if (parms.Count > 0)
            {
                foreach (DictionaryEntry de in parms)
                {
                    cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                }
            }
            if (con == null)
            {
                SetConnection();
            }
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();
            int result = cmd.ExecuteNonQuery();
            return result;
        }


    }
}