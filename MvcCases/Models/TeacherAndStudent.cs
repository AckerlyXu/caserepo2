using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCases.Models
{
    public class TeacherAndStudent
    {
       
       public  List<Student> Students { get; set; }
    
        public  List <Teacher> Teachers { get; set; }
    }
}