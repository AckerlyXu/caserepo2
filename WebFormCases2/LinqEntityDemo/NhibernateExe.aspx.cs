using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Mapping.Attributes;
using System;
using System.Reflection;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class NhibernateExe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
             var cfg = new Configuration();
            HbmSerializer.Default.Validate = true;
            HbmSerializer.Default.Serialize(System.Environment.CurrentDirectory, Assembly.GetExecutingAssembly());
            cfg.AddDirectory(new System.IO.DirectoryInfo(System.Environment.CurrentDirectory));
            cfg.DataBaseIntegration(
                x =>
                {

                    x.ConnectionString = @"data source=(localdb)\MSSQLLocalDB;initial catalog=EntityExe;integrated security=True";
                    x.Driver<NHibernate.Driver.SqlClientDriver>();
                    x.Dialect<MsSql2008Dialect>();
                });
            cfg.AddAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            var sefact = cfg.BuildSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                  Product product =  session.Get<Product>(1);
                   
                    Product product1 = new Product()
                    {
                        ProductName = "NEW",
                        Price = 1.2M,
                        Date = DateTime.Now,
                        Date2 = DateTime.Now
                    };
                    session.Save(product1);
                   
                    tx.Commit();
                }
            }
        }
    }
  [Class]
    public class Product
    {
        [Id(0,Name ="Id",TypeType =typeof(int),Column ="id")]
        [Generator(1,Class = "identity")]
        public virtual int Id { get; set; }
        [Property(Column ="productname")]
        public virtual string ProductName { get; set; }
        [Property(Column = "Price")]
        public virtual decimal Price { get; set; }
        [Property(Column = "Date")]
        public virtual DateTime Date { get; set; }
        [Property(Column = "Date2")]
        public virtual DateTime Date2 { get; set; }
    }
}