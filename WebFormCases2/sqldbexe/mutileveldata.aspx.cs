using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using (SqlConnection con = new SqlConnection(constr))
//                {
//                    using (SqlCommand com = new SqlCommand("select * from table1 where account_name = @name", con))
//                    {

//                        con.Open();



//                        using (SqlDataReader reader =com.ExecuteReader())
//                        {

//                        } 



                       

//                    }
//                } 
namespace WebFormCases2.sqldbexe
{
    //https://forums.asp.net/t/2154320.aspx
    public partial class mutileveldata : System.Web.UI.Page
    {
        public Node RootNode = new Node { Level = 1, NodeName = "assets" ,ChildNodes=new List<Node>()};
        private static string constr = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand com = new SqlCommand("select name from table1 where account_name = @name", con))
                    {

                        con.Open();
                        com.Parameters.AddWithValue("name", "assets");
                        using (SqlDataReader reader =com.ExecuteReader())
                        {
                            while (reader.Read()) {
                                // get child node of assets
                                Node mainGroupNode = new Node { Level = 2, NodeName = reader["name"].ToString(),ChildNodes= new List<Node>()};
                                // add child node to root node
                                RootNode.ChildNodes.Add(mainGroupNode);

                                // start to add the next level
                                using (SqlConnection con1 = new SqlConnection(constr))
                                {
                                    using (SqlCommand com1 = new SqlCommand("select name from maingroup where sub_group = @name", con1))
                                    {

                                        con1.Open();

                                        com1.Parameters.AddWithValue("name", mainGroupNode.NodeName);

                                        using (SqlDataReader reader1 = com1.ExecuteReader())
                                        {
                                            while (reader1.Read())
                                            {
                                                // get child node of maingroup
                                                Node subgroupnode = new Node { Level = 3, NodeName = reader1["name"].ToString(), ChildNodes = new List<Node>() };
                                                // add subgroup to maingroup
                                                mainGroupNode.ChildNodes.Add(subgroupnode);

                                                // start to add next level
                                                using (SqlConnection con2 = new SqlConnection(constr))
                                                {
                                                    using (SqlCommand com2 = new SqlCommand("select name from subgroup where sub_item = @name", con2))
                                                    {

                                                        con2.Open();
                                                        com2.Parameters.AddWithValue("name", subgroupnode.NodeName);
                                                        using (SqlDataReader reader2 = com2.ExecuteReader())
                                                        {
                                                            while (reader2.Read())
                                                            {
                                                                // get the child node of  subgroup
                                                                Node sub_item = new Node { Level = 4, NodeName = reader2["name"].ToString() };
                                                                 // add child node  to subgroup
                                                                subgroupnode.ChildNodes.Add(sub_item);
                                                            }
                                                           
                                                        }


                                                    }
                                                }

                                            }
                                        }


                                    }
                                }



                            }
                        } 

                    }
                } 
              
            }
         }


        
    }

    public class Node
    {
        public int Level { get; set; }
        public string NodeName { get; set; }
        public List<Node> ChildNodes { get; set; }
    }
}