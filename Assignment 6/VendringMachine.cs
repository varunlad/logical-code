﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class VendringMachine
    {
        public void vendringmachine()
        {
            int one=0, two=0, five=0, ten=0,twenty=0, fifty=0, hundred=0, fiveHundred=0, thousand=0;
            Console.Write("Enter the Amount: ");//Here we enter the amount
            int n = Convert.ToInt32(Console.ReadLine());
            while(n>0)//continue the loop till amount become zero
            {
                if(n>1000)//Starting to count from 1000 to 1 rupee note
                {
                    thousand = thousand + 1;
                    n = n - 1000;
                }
                else if (n >= 500 && n < 1000)
                {
                    fiveHundred = fiveHundred + 1;
                    n = n - 500;
                }
                else if (n >= 100 && n < 500)
                {
                    hundred = hundred + 1;
                    n = n - 100;
                }
                else if (n >= 50 && n < 100)
                {
                    fifty = fifty + 1;
                    n = n - 50;
                }
                else if (n >= 20 && n < 50)
                {
                    twenty = twenty + 1;
                    n = n - 20;
                }
                else if (n >= 10 && n < 20)
                {
                    ten = ten + 1;
                    n = n - 10;
                }
                else if (n >= 5 && n < 10)
                {
                    five = five + 1;
                    n = n - 10;
                }
                else if (n >=2 && n<5 )
                {
                    two = two + 1;
                    n = n - 2;
                }
                else if (n == 1)
                {
                    one = one + 1;
                    n = n - 1;
                }

            }
            //Printing the Number Of Notes For given Amount
            Console.WriteLine(" The number of one notes are :" + one);
            Console.WriteLine(" The number of two notes are :" + two);
            Console.WriteLine(" The number of five notes are :" + five);
            Console.WriteLine(" The number of ten notes are :" + ten);
            Console.WriteLine(" The number of twenty notes are :" + twenty);
            Console.WriteLine(" The number of fifty notes are :" + fifty);
            Console.WriteLine(" The number of hundred notes are :" + hundred);
            Console.WriteLine(" The number of thousand notes are :" + fiveHundred);
            Console.WriteLine(" The number of thousand notes are :" + thousand);
            Console.ReadLine();
        }

    }
}
