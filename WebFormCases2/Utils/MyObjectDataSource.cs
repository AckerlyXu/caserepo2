
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace MyWebFormCases.Utils
{
    public class MyObjectDataSource
    {
       
        //private static string constr = ConfigurationManager.ConnectionStrings["supplyModel"].ConnectionString;

        //public List<Fruit> getAll()
        //{
        //    List<Fruit> list = new List<Fruit>();
        //    SqlConnection con = new SqlConnection(constr);
        //    using (SqlCommand com = new SqlCommand("select * from fruits", con))
        //    {
               
        //            con.Open();

        //        using (SqlDataReader reader = com.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Fruit fruit = new Fruit();
        //                fruit.itemid = reader.GetInt32(3);
        //                fruit.ItemName = reader.GetString(0);
        //                fruit.Qunatity = reader.GetInt32(2);
        //                fruit.BelongsTo = reader.GetString(1);
        //                list.Add(fruit);
        //            }
        //        }
        //        return list;

        //    }
        //}

        //public int update(Fruit fruit)
        //{
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand com = new SqlCommand("update fruits set itemname=@name,qunatity=@qunatity,belongsTo=@to where itemid=@id", con))
        //        {
        //            com.Parameters.AddWithValue("name", fruit.ItemName);
        //            com.Parameters.AddWithValue("qunatity", fruit.Qunatity);
        //            com.Parameters.AddWithValue("to", fruit.BelongsTo);
        //            com.Parameters.AddWithValue("id", fruit.itemid);
        //            con.Open();

        //            return com.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public int delete(Fruit fruit) {
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand com = new SqlCommand("delete from fruits where itemid=@id", con))
        //        {
        //            com.Parameters.AddWithValue("id",fruit.itemid);
        //            con.Open();
        //            return com.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}