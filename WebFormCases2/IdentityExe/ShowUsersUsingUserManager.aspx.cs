using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models.Identity;

namespace WebFormCases2.IdentityExe
{
    public partial class ShowUsersUsingUserManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserManager.Users.Where(user => user.UserName == "ackerly").Count() == 0)
                {
                    AppUser user = new AppUser() { UserName = "ackerly", Email = "ackerly@gmail.com" };
                    UserManager.CreateAsync(user, "123wre");

                }
                //The model backing the 'AppIdentityDbContext' context has changed since the database was created. Consider using Code First Migrations to update the database(http://go.microsoft.com/fwlink/?LinkId=238269).

                 RoleManager.Create(new AppRole("admin"));
                RoleManager.Create(new AppRole("normal"));

                BindUsers();
            }
            Response.Write(AuthManager);
           
        }

        private AppUserManager UserManager
        {
            get
            {
                IOwinContext content = HttpContext.Current.GetOwinContext();
                
               return content.GetUserManager<AppUserManager>();
              
            }
        }
        private void BindUsers()
        {
            //, Role = et.Roles.Count() == 0?"":et.Roles.ToList()[0].

            var query  = UserManager.Users.Select(et => new
            {
                et.UserName,
                et.PasswordHash,
                et.Email,
                et.Id
                
                
            }).ToList();

            List<UserModel> arrayList = new List<UserModel>();
            foreach (var item in query)
            {
                // use UserManager's GerRoles method to get the Role of a user
                string role = UserManager.GetRoles(item.Id).Count == 0 ? "have no role" : UserManager.GetRoles(item.Id)[0];
                arrayList.Add(new UserModel { Email = item.Email,PasswordHash= item.PasswordHash, Username = item.UserName, Id= item.Id, Role = role });
            }
            GridView1.DataSource = arrayList;
            GridView1.DataBind();
        }
        private AppRoleManager RoleManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().GetUserManager<AppRoleManager>();
            }
        }

       
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridViewRow row = GridView1.Rows[e.NewEditIndex];
           
            // rebind the gridview
            BindUsers();
          
        }

      
      public class UserModel
        {
            public string Email { get; set; }
            public string PasswordHash { get; set; }
            public string Username { get; set; }
            public string Id { get; set; }

            public string Role { get; set; }
        }

      
        // in rowdatabound , bind the dropdownlist of role
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (GridView1.EditIndex != -1 && e.Row.RowIndex == GridView1.EditIndex)
            {

                GridViewRow row = e.Row;
                // get the current usermodel
                UserModel model = row.DataItem as UserModel;
                // get the dropdow
                DropDownList dropdown = row.FindControl("DropDownList1") as DropDownList;
                // get all the roles through rolemanager
                var query = RoleManager.Roles.Select(r => new { r.Id, r.Name }).ToList();
                query.Add(new { Id = "no role", Name = "no role" });

                // get the roleid of current user 's role
                string roleId = RoleManager.Roles.Where(r => r.Name == model.Role).Select(r => r.Id).FirstOrDefault();
                // if the user has no role
                if (model.Role == "have no role")
                {
                    dropdown.SelectedValue = "no role";

                }
                else
                {
                    // set current user's role selected
                    dropdown.SelectedValue = roleId;
                }
               
                dropdown.DataValueField = "Id";
                dropdown.DataTextField = "Name";
                dropdown.DataSource = query;
                dropdown.Items.Add(new ListItem("no role", "no role"));
                dropdown.DataBind();
                
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            string id = e.Keys[0].ToString();
            string userName = (row.Cells[1].Controls[0] as TextBox).Text;
            string password = (row.Cells[2].Controls[0] as TextBox).Text;
            // use UserManager's PasswordHasher to hash the user's password
            string passwordHash = UserManager.PasswordHasher.HashPassword(password);
            string email = (row.Cells[3].Controls[0] as TextBox).Text;
            DropDownList drop = row.FindControl("DropDownList1") as DropDownList;
            // update the user


            //////////
            try
            {
                AppUser user =  UserManager.FindById(id);
                user.Email = email;
                user.UserName = userName;
                user.PasswordHash = passwordHash;
                IdentityResult result = UserManager.Update(user);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception exe)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                
               
            }
            //////////////
           
          
          
                 // get the current user's roles
               IList<string> roles = UserManager.GetRoles(id);
            // if has role, remove the role at first
                if (roles.Count > 0)
                {
                    UserManager.RemoveFromRole(id, roles[0]);
                }

            if (drop.SelectedValue != "no role")
            {
                // add the user into  the selected role user UserManager's AddToRole method
                UserManager.AddToRole(id, drop.SelectedItem.Text);
            }

            GridView1.EditIndex = -1;

            BindUsers();
        }
        private IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }
    }
}