using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFormCases2.Models.school
{
    public class ServiceConfiguration
    {
        [Key]
        public int Id { get; set; }
      
        public string SeviceName { get; set; }
     
       
        public string DisplayName { get; set; }
     
        public string MachineName { get; set; }
        [EnumDataType(typeof(ServiceType)), Display(Name = "Service Type")]
        public ServiceType Type { get; set; }
      
        public string Parameter { get; set; }
    }

    public enum ServiceType
    {
        Update,
        Create,
        Demand
    }
}