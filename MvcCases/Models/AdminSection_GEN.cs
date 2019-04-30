using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCases.Models
{
    public class AdminSection_GEN
    {
        [Key]
        public int BintId_Pk { get; set; }
        public string ViewTitle { get; set; }
        public int IntParentId_FK { get; set; }
    }
}