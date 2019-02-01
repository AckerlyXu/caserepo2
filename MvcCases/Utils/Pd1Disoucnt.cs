using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCases.Utils
{
    public class Pd3Discount : IDiscount
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        
        public Pd3Discount(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public double Discount(int number, double price)
        {
            int realNumber =  (int)(number / Denominator * Numerator);
           
            return realNumber * price;
        }
    }

    public class Pd1Discount : IDiscount
    {
        public double DropTo { get; set; }
        public  int DropStart { get; set; }
        public Pd1Discount(double dropTo, int dropStart)
        {
            this.DropTo = dropTo;
            this.DropStart = dropStart;
        }
        public double Discount(int number, double price)
        {
            if (number > DropStart)
            {
                return DropTo * number;
            }
            else
            {
                return number * price;
            }
        }
    }

    public class Pd4Discount : IDiscount
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public int FreeCount { get;private set; }
        public Pd4Discount(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public double Discount(int number, double price)
        {
            this.FreeCount = (int)(number / Denominator * Numerator);
            return number * price;
        }
    }
}