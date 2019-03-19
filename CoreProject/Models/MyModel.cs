using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class MyModel
    {
        [RegularExpression(@"^true", ErrorMessage = "The checkbox is required")]
      // [Required(ErrorMessage ="the checkbox is required")]
        public string IsChecked { get; set; }
    }
}
