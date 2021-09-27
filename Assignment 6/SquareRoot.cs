using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class SquareRoot
    {
        public void squareRoot()
        {
            Console.WriteLine("Enter a number:");
            double n = Convert.ToDouble(Console.ReadLine());
            double l = 0.00001;
            // Assuming the sqrt of n as n only
            double x = n;

            // The closed guess will be stored in the root
            double root;

            // To count the number of iterations
            int count = 0;

            while (true)
            {
                count++;

                // Calculate more closed x
                root = 0.5 * (x + (n / x));

                // Check for closeness
                if (Math.Abs(root - x) < l)//Returns the absolute value of a specified number.
                    break;

                // Update root
                x = root;
            }

            
            Console.WriteLine("Square root is :"+x);
            Console.ReadLine();
        }
       

    
        
        
    }
}

