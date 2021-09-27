using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class PerfectNumber
    {
        public void Perfectnumber()
        {
            int n, sum = 0;
            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());//Taking input from the user
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)//checking for the Factors
                {
                    sum = sum + i;
                }
            }
            if (n % sum == 0)//if the number equal to the sum of factors then its perfect number 
            {
                Console.WriteLine("THE NUMBER IS PERFECT NUMBER");
            }
            else
            {
                Console.WriteLine("THE NUMBER IS NOT PERFECT NUMBER");
            }
            Console.ReadLine();

        }
    }
}
