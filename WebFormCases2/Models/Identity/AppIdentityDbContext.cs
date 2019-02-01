using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormCases2.Models.Identity
{
    public class AppIdentityDbContext: IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext():base("Identity")
        {

        }

        public static AppIdentityDbContext Create()
        {
            return new AppIdentityDbContext();
        }
    }
}