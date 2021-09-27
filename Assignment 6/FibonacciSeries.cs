using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class FibonacciSeries
    {
        public void fibonacci()
        {
            int n1 = 0, n2 = 1, n3, n;//Fibonacci Series Starts from 0 1
            Console.Write("Enter a number up to which you want the series : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(n1);
                n3 = n1 + n2; //next number is the addition of last two numbers
                n1 = n2;//first number become next mumber
                n2 = n3;//sum become last number
            }
            Console.ReadLine();
        }
    }
}
