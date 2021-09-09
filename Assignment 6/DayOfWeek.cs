using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class DayOfWeek
    {
        public void anyday()
        {
            Console.WriteLine("ENTER A DATE");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER A MONTH");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER A YEAR");
            int year = Convert.ToInt32(Console.ReadLine());
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m = month + (12 * (14 - month)) / 12 - 2;
            int d0=((day+x+31*m/12)%7);
            switch(d0)
            {
                case 5:
                    Console.WriteLine("Its sunday");
                    break;
                case 6:
                    Console.WriteLine("Its monday");
                    break;
                case 7:
                    Console.WriteLine("Its Tuesday");
                    break;
                case 8:
                    Console.WriteLine("Its wednesday");
                    break;
                case 9:
                    Console.WriteLine("Its Thusday");
                    break;
                case 2:
                    Console.WriteLine("Its Friday");
                    break;
                case 3:
                    Console.WriteLine("Its Saturday");
                    break;
            }
            Console.ReadLine();
        }
    }
}
