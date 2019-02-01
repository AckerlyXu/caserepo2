using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCases.Utils
{
   public interface IDiscount
    {
        double Discount(int number, double price);
    }
}
