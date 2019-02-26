using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class ParallelForEachStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Model> list = new List<Model>
            {
                new Model{Id=1,Name="David"},
                new Model{Id=2, Name="Jerry"},
                new Model {Id = 3,Name="Nancy"},

                new Model{Id=4,Name="Miki"},
                new Model{Id=5, Name="Teddy"},
                new Model {Id = 6,Name="Jack"},

                new Model{Id=7,Name="Mike"},
                new Model{Id=8, Name="Angle"},
                new Model {Id = 9,Name="IZake"},

                new Model{Id=10,Name="Redy"},
                new Model{Id=11, Name="Tady"},
                new Model {Id = 12,Name="Nerly"}
            };
            list.AsParallel().AsOrdered().WithDegreeOfParallelism(10).Where(en => en.Id > 5)
                  .ToList().ForEach(
                     ent =>
                     {
                         (ent.Id + ent.Name).AsParallel().AsOrdered().WithDegreeOfParallelism(10).ToList().ForEach(
                             re => Response.Write(re + " ")
                             );
                         Response.Write("<br/>");
                     }
                 );
           
            Response.Write( "<br/>");
            list.AsParallel().AsOrdered().WithDegreeOfParallelism(10).Where(en => en.Id > 5)
                    .ToList().ForEach(
                       ent =>
                       {
                           (ent.Id + ent.Name).AsParallel().WithDegreeOfParallelism(10).ToList().ForEach(
                               re => Response.Write(re + " ")
                               );
                           Response.Write("<br/>");
                       }
                   );

        }

        public class Model
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}