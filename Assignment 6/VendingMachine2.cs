﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class VendingMachine2
    {
        public void machine()
        {
            int one = 0, two = 0, five = 0, ten = 0,twenty=0, fifty = 0, hundred = 0, fiveHundred = 0, thousand = 0;
            int[] arr = new int[10];//creating array  
            arr[0] = 1;//initializing array  
            arr[1] = 2;
            arr[2] = 5;
            arr[3] = 10; 
            arr[4] = 20;
            arr[5] = 50;
            arr[6] = 100;
            arr[7] = 500;
            arr[8] = 1000;
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //traversing array  
            while(n>0)
            {
                if (n > arr[8])
                {
                    thousand = thousand + 1;
                    n = n - 1000;
                }
                else if (n >= arr[7] && n < arr[8])
                {
                    fiveHundred = fiveHundred + 1;
                    n = n - 500;
                }
                else if (n >= arr[6] && n < arr[7])
                {
                    hundred = hundred + 1;
                    n = n - 100;
                }
                else if (n >= arr[5] && n < arr[6])
                {
                    fifty = fifty + 1;
                    n = n - 50;
                }
                else if (n >= arr[4] && n < arr[5])
                {
                    twenty = twenty + 1;
                    n = n - 20;
                }
                else if (n >= arr[3] && n < arr[4])
                {
                    ten = ten + 1;
                    n = n - 10;
                }
                else if (n >= arr[2] && n < arr[3])
                {
                    five = five + 1;
                    n = n - 2;
                }
                else if (n >= arr[1] && n < arr[2])
                {
                    two = two + 1;
                    n = n - 2;
                }
                else  
                {
                    one = one + 1;
                    n = n - 1;
                }

            }
            Console.WriteLine(" The number of one rupee notes are :" + one);
            Console.WriteLine(" The number of two rupee notes are :" + two);
            Console.WriteLine(" The number of five rupee notes are :" + five);
            Console.WriteLine(" The number of ten rupee notes are :" + ten);
            Console.WriteLine(" The number of twenty rupee notes are :" + twenty);
            Console.WriteLine(" The number of fifty rupee notes are :" + fifty);
            Console.WriteLine(" The number of hundred rupee notes are :" + hundred);
            Console.WriteLine(" The number of thousand rupee notes are :" + fiveHundred);
            Console.WriteLine(" The number of thousand rupee notes are :" + thousand);
            Console.ReadLine();
        }
        }
    }
