using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebFormCases2.Models.Identity
{
    public class AppPasswordValidator :PasswordValidator
    {
        public override Task<IdentityResult> ValidateAsync(string item)
        {
           Task<IdentityResult> result=  base.ValidateAsync(item);
         
            
            return Task.FromResult(IdentityResult.Failed("your password is not in good format :" + item));
                
        }
    }
}