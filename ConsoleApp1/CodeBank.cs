using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CodeBank
    {
        public int Id { get; set; }
        public string referenceId { get; set; }
        public string productCode { get; set; }
        public int quantity { get; set; }
        public string version { get; set; }
        public DateTime? requestDateTime { get; set; } = DateTime.Now;
        public int? customerID { get; set; }
        public string password { get; set; }
        public DateTime? responseDateTime { get; set; } = DateTime.Now;
        public string initiationResultCode { get; set; }
        public string companyToken { get; set; }
        public int used { get; set; }
        public string productDescription { get; set; }
        public string currency { get; set; }
        public double unitPrice { get; set; }
        public double totalPrice { get; set; }
        public  virtual List<CodeBankCoupon> coupons { get; set; }
    }

    public class CodeBankCoupon
    {
        public int Id { get; set; }
        public int CodeBankID { get; set; }
        public List<string> serials { get; set; }
        public List<string> pins { get; set; }
        public virtual CodeBank codeBank { get; set; }
        public DateTime? expiryDate { get; set; }
        [NotMapped]
        public List<string> StringsSerial
        {
            get { return serials; }
            set { serials = value; }
        }
        [NotMapped]
        public List<string> StringsPin
        {
            get { return pins; }
            set { pins = value; }
        }
        [NotMapped]
        [Required]
        public string Serial
        {
            get { return String.Join(",", serials); }
            set { serials = value.Split(',').ToList(); }
        }
        [Required]
        [NotMapped]
        public string Pin
        {
            get { return String.Join(",", pins); }
            set { pins = value.Split(',').ToList(); }
        }
    }

}
