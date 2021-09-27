using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class TenpConv
    {
        public void temperature()

        {
            Console.Write("Enter a Temperature in Celsius:");
           double celsius = Single.Parse(Console.ReadLine());//Reading from usre Temperature in Celsius
            double convert1 = (celsius * 9 / 5) + 32;//Conversion of Celsius to Fahrenheit
            Console.WriteLine(" The Conversion of Celsius to Fahrenheit :" +convert1);
            Console.Write("Enter a Temperature in Fahrenheit:");
            double fahrenheit = Single.Parse(Console.ReadLine());//Reading from usre Temperature in Fahrenheit
            double convert2 = fahrenheit-32 ;
            double convert3 = convert2 *0.55;//Conversion of Fahrenheit to Celsius
            Console.WriteLine(" The Conversion of Celsius to Fahrenheit :" + convert3);
            Console.ReadLine();
        }
    }
}
