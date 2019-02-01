//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace MyWebFormCases.Utils
{
    public class MySqlUtil
    {
        private static string constr = ConfigurationManager.ConnectionStrings["mySqlConnectionString"].ConnectionString;
        //public static int ExecuteNonQuery(string sql,params MySqlParameter[] sqlParameters)
        //{

            
        //    using (MySqlConnection con=new MySqlConnection(constr))
        //    {
        //        using (MySqlCommand com = new MySqlCommand(sql, con))
        //        {
        //            com.Parameters.AddRange(sqlParameters);
        //            con.Open();
        //            return com.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public static int ExcuteNunQueryPro(string sql, params MySqlParameter[] sqlParameters)
        //{
        //    using (MySqlConnection con = new MySqlConnection(constr))
        //    {
        //        using (MySqlCommand com = new MySqlCommand(sql, con))
        //        {
        //            com.CommandType = CommandType.StoredProcedure;
        //            com.Parameters.AddRange(sqlParameters);
        //            con.Open();
        //            return com.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public static DataTable getDataTable(string sql, params MySqlParameter[] sqlParameters)
        //{

        //    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, constr))
        //    {

        //        adapter.SelectCommand.Parameters.AddRange(sqlParameters);
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        return table;
        //    }
        //}


        //public static DataTable getDataTablePro(string sql, params MySqlParameter[] sqlParameters)
        //{

        //    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, constr))
        //    {

        //        adapter.SelectCommand.Parameters.AddRange(sqlParameters);
        //        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        return table;
        //    }
        //}

        //public static Object ExcuteScalar(string sql, params MySqlParameter[] sqlParameters)
        //{
        //    using (MySqlConnection con = new MySqlConnection(constr))
        //    {
        //        using (MySqlCommand com = new MySqlCommand(sql, con))
        //        {
        //            com.Parameters.AddRange(sqlParameters);
        //            con.Open();
        //            return com.ExecuteScalar();
        //        }

        //    }

        //}

        //public static Object ExcuteScalarPro(string sql, params MySqlParameter[] sqlParameters)
        //{
        //    using (MySqlConnection con = new MySqlConnection(constr))
        //    {
        //        using (MySqlCommand com = new MySqlCommand(sql, con))
        //        {
        //            com.CommandType = CommandType.StoredProcedure;
        //            com.Parameters.AddRange(sqlParameters);
        //            con.Open();
        //            return com.ExecuteScalar();
        //        }

        //    }

        //}


        //public static MySqlDataReader GetSqlDataReader(string sql, params MySqlParameter[] sqlParameters)
        //{


        //    MySqlConnection con = new MySqlConnection(constr);
        //    MySqlCommand com = new MySqlCommand(sql, con);
            
        //        try
        //        {
        //            con.Open();

        //            com.Parameters.AddRange(sqlParameters);

        //            return com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //        }
        //        catch (Exception)
        //        {
        //            con.Close();
        //            con.Dispose();

        //            throw;
        //        }

            

        //}

        //public static MySqlDataReader GetSqlDataReaderPro(string sql, params MySqlParameter[] sqlParameters)
        //{


        //    MySqlConnection con = new MySqlConnection(constr);
        //    using (MySqlCommand com = new MySqlCommand(sql, con))
        //    {
        //        try
        //        {
        //            com.CommandType = CommandType.StoredProcedure;
        //            con.Open();

        //            com.Parameters.AddRange(sqlParameters);

        //            return com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //        }
        //        catch (Exception)
        //        {
        //            con.Close();
        //            con.Dispose();

        //            throw;
        //        }

        //    }

        //}

    }
}