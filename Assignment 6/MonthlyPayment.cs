using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class MonthlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("WE ARE CALCULATING MONTHLY PAYMENT");
            Console.Write("Enter principle loan amount :");
            double principle = Single.Parse(Console.ReadLine());//Taking input to enter Principle Amount
            Console.Write("Enter rate :");
            double rate = Single.Parse(Console.ReadLine());//Taking input to enter Rate Per Anum
            Console.Write("Enter years :");
            double years = Single.Parse(Console.ReadLine());//Taking input to enter Years
            double r = (rate/1200);
            double x= principle * r;
            double y= (1+r);
            double a = Math.Pow(y, -12);
            double b = x / (1 - a);
            Console.WriteLine("The monthly payment to be made :"+b);
            Console.ReadLine();

        }
    }
}
