using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCases.Extensions
{
    public class MyRoleFilter : FilterAttribute, IActionFilter
    {
        private static List<FilterUser> FilterUsers;
         static  MyRoleFilter()
        {
            List<FilterUser> users = new List<FilterUser>();
            FilterUser user1 = new FilterUser() { UserId = 1, UserName = "user1",FilterRoles = new List<FilterRole>() };
            FilterUser user2 = new FilterUser() { UserId = 2, UserName = "user2", FilterRoles = new List<FilterRole>() };
            users.Add(user1);  
            users.Add(user2);
            FilterRole role1 = new FilterRole { Id = 1, RoleName = "Role1", FilterActions = new List<FilterAction>() };
            FilterRole role2 = new FilterRole { Id = 2, RoleName = "Role2", FilterActions = new List<FilterAction>() };
            user1.FilterRoles.Add(role1);   // user1 have role1
            user2.FilterRoles.Add(role2);

            FilterAction action1 = new FilterAction() { ActionId = 1, Path = "/demo1/Index" };
            FilterAction action2 = new FilterAction() { ActionId = 2, Path = "/demo1/PageDataShow" };
            role1.FilterActions.Add(action1);// role1 could access "/demo1/Index"
            role2.FilterActions.Add(action2);
            FilterUsers = users;
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //string controllerName = filterContext.RouteData.Values["controller"].ToString().ToLower();
            //string actionName = filterContext.RouteData.Values["action"].ToString().ToLower();
            //// get all the actions of user (say id=1)
            //List<string> pathes = FilterUsers.Where(u => u.UserId == 1).SelectMany(user => user.FilterRoles).SelectMany(role => role.FilterActions).Select(action => action.Path.ToLower()).ToList();
            //// if the user doesn't have the action ,send an aunauthorizedResult back to client
            //if (!pathes.Contains("/" + controllerName + "/" + actionName))
            //{
            //    filterContext.Result = new HttpUnauthorizedResult("you are not authorized");
            //}
        }
    }
    public class FilterUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        // a user has many roles
        public List<FilterRole> FilterRoles { get; set; }
    }

   public class FilterRole{
        public int Id { get; set; }
        public string RoleName { get; set; }
        // a role has many actions
        public List<FilterAction> FilterActions { get; set; }

    }
    public class FilterAction
    {
        public string Path { get; set; }
        public int ActionId  { get; set; }
        public List<FilterRole> FilterRoles { get; set; }
    }
}