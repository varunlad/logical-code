using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Binary
    {
        public void binary()
        {
            double add = 0;
            Console.Write("Enter a number");
            double n = Convert.ToDouble(Console.ReadLine());//Taking input from User
            for(int i=10;i>=0;i--)
            {
            double a = Math.Pow(2, i); //here a=2power(i)
                while(a <= n) 
                {
                    if (n % 2 == 0)
                    {
                        n = n - a;
                        Console.WriteLine("THE POWERS OF 2 IN A NUMBER IS:" + a);//if true itis in the power of two
                        add = add + a;
                        Console.WriteLine("The addition is :" + add);
                        Console.Write(1);
                    }
                    else 
                    {
                        n = n - a;
                        Console.WriteLine("THE POWERS OF 2 IN A NUMBER IS:" + a);
                        add = add + a;
                        Console.WriteLine("The addition is :" + add);
                    }
                    if(add==n)
                    {
                        break;
                    }
                }               
            }
            Console.ReadLine();
        }
    }
}
