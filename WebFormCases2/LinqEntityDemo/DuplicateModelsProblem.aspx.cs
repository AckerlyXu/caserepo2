using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class DuplicateModelsProblem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (var context = new OrdersContext())
            {
               // try
                //{
                    Database.SetInitializer(new CreateDatabaseIfNotExists<OrdersContext>());
                    context.Database.Initialize(false);

                MoveAnItem(context);
   
             

                //}
                //catch (DataException ex)
                //{
                //    if (ex.InnerException == null)
                //        Console.WriteLine("DataException: " + ex.Message);
                //    else
                //        Console.WriteLine(string.Format("DataException: {0}, inner {1}: {2}",
                //            ex.Message, ex.InnerException.GetType().FullName,
                //            ex.InnerException.Message));
                //    return;
                //}
                //catch (SqlException ex)
                //{
                //    Console.WriteLine("SqlException: " + ex.Message);
                //    return;
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.GetType().FullName + ": " + ex.Message);
                //    return;
                //}
            }
        }

        private static void MoveAnItem(OrdersContext db)
        {
       
           
                OrderItem ItemMoving = db.OrderItems.OrderByDescending(p => p.ListIndex).FirstOrDefault();
                Console.WriteLine($"Moving Id: {ItemMoving.Id}, ListIndex: {ItemMoving.ListIndex}, Name: {ItemMoving.Name}");
                IEnumerable<OrderItem> items =
                    (from s in db.OrderItems
                    orderby s.ListIndex descending
                    select s).ToList();
                Console.WriteLine("\tData before resequence");
                foreach (OrderItem item in items)
                    Console.WriteLine($"{item.Id} {item.ListIndex} {item.Name}");
                int lastIndex = ItemMoving.ListIndex;
              //  int newx = 1;
                ItemMoving.ListIndex =ItemMoving.ListIndex+1;
            db.SaveChanges();
            foreach (OrderItem s in items)
                {
                    if (s.Id != ItemMoving.Id)
             s.ListIndex = lastIndex--;
                db.SaveChanges();

            }
            
            ItemMoving.ListIndex = 1;
            db.SaveChanges();
            //IEnumerable<DbEntityEntry> TrackEntries = db.ChangeTracker.Entries();
            //foreach (DbEntityEntry e in TrackEntries)
            //{
            //    OrderItem s;
            //    if ((s = e.Entity as OrderItem) is OrderItem)
            //        Console.WriteLine($"{s.Id} {s.ListIndex} {e.State} {s.Name}");
            //    else
            //        Console.WriteLine($"Type {e.GetType().Name} is not OrderItem");
            //}
            db.SaveChanges();
            
           
        }

        private static void WalkExceptions(Exception ex)
        {
            Console.WriteLine("\tException tree:");
            Console.WriteLine(ex.GetType().FullName + ": " + ex.Message);
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                Console.WriteLine(ex.GetType().FullName + ": " + ex.Message);
            }
        }
        class OrdersContext : DbContext
        {
            public OrdersContext() : base("name=DbContext11") { }
            public DbSet<OrderItem> OrderItems { get; set; }
        }

        public class OrderItem
        {
            public OrderItem()
            {
                this.ListIndex = 0;
                this.Name = string.Empty;
            }
            public OrderItem(int ListIndex, string Name)
            {
                this.ListIndex = ListIndex;
                this.Name = Name;
            }
            [Key]
            public int Id { get; set; }
            [Required, Index(IsUnique = true)]
            public int ListIndex { get; set; }
            [Required]
            public string Name { get; set; }
        }
    }
}