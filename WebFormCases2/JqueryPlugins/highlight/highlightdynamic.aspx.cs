using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.JqueryPlugins.highlight
{
    public partial class highlightdynamic : System.Web.UI.Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<MapImage> images = new List<MapImage>();
                // fill images data from database
                using (SqlConnection con = new SqlConnection(constr))
                {


                    using (SqlCommand com = new SqlCommand("select * from images", con))
                    {

                        con.Open();



                        using (SqlDataReader reader = com.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MapImage image = new MapImage();
                                image.Id = reader.GetInt32(0);
                                image.Path = reader.GetString(1);

                                image.Areas = new List<Area>();
                                using (SqlConnection con1 = new SqlConnection(constr))
                                {

                                     // query for the areas of an image
                                    using (SqlCommand com1 = new SqlCommand("select shape,coords  from areas where image_id = @id", con1))
                                    {

                                        con1.Open();

                                        com1.Parameters.AddWithValue("id", image.Id);


                                        using (SqlDataReader reade1 = com1.ExecuteReader())
                                        {
                                            while (reade1.Read()) // add every area to current image
                                            {
                                                Area area = new Area();
                                                area.Shape = reade1.GetString(0);
                                                area.Coords = reade1.GetString(1);
                                                image.Areas.Add(area);
                                            }
                                        }




                                    }





                                    images.Add(image);// add all images to the list
                                }

                            }




                        }

                    }
                }

                Repeater3.DataSource = images; // bind repeater3 to show all the images
                Repeater3.DataBind();

                Repeater1.DataSource = images; // bind repeater1 to bind areas and images
                Repeater1.DataBind();
                Repeater4.DataSource = new List<MapImage> { images[0] }; // show default image
                Repeater4.DataBind();
            }
        }

        public class MapImage  // define a model to represent Image
        {
            public int Id { get; set; }
            public string Path { get; set; }
            public List<Area> Areas { get; set; } // an image has many areas
        }

        public class Area  // define a model to represent an area
        {
            public string Shape { get; set; }
            public string Coords { get; set; }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
            // bind the areas  of an image
        {
            if(e.Item.ItemType == ListItemType.Item  || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                MapImage mapImage = e.Item.DataItem as MapImage;
              Repeater repeater =  e.Item.FindControl("Repeater2") as Repeater;
                repeater.DataSource = mapImage.Areas;
                repeater.DataBind();
               
            }
        }
    }
}