using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Coupon
    {
        public void coupon()
        {
            int[] arr = new int[100];
            Random random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine("The array list is:");
            for (int i=0;i<=10;i++)
            {
                int num = random.Next(1, 10);
                arr[i] = num;
                
                Console.Write(" " +arr[i]);
                
            }
            Console.ReadLine();
        }
    }
}
