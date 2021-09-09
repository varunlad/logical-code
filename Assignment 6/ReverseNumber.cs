using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class ReverseNumber
    {
        public void reverse()
        {
            int n, sum = 0;
            Console.Write("ENTER A NUMBER");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                int num = n % 10;
                sum = sum * 10 + num;
                n = n / 10;
            }
            Console.WriteLine("THE REVERSE OF A NUMBER IS :" + sum);
            Console.ReadLine();
        }
    }
}
