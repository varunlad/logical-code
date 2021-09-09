using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class PrimeNumber
    {
        public void prime()
        {

            int n, num = 0;
            Console.Write("ENTER A NUMBER");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("THE NUMBER IS NOT A PRIME NUMBER");
                    num = num + 1;
                    break;
                }
            }
            if (num == 0)
            {
                Console.WriteLine("THE NUMBER IS A PRIME NUMBER");
            }
            Console.ReadLine();
        }
    }
}
