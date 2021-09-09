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
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (n % sum == 0)
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
