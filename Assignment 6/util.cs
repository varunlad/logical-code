using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_6
{
    class util
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the case to perform :\n 1)Fibonacci Series \n 2)Perfect Number \n 3)Prime Number \n 4)Reverse a number \n 5)Coupon Numbers\n 6)Stop Watch\n 7)Vendring Machine1\n 8)Vendring Machine2\n 9)Temperature Conversion\n10)Day of Week\n11)Monthly Payment \n12)Square Root\n13)Binary");
            
            Console.Write("Enter a case :");
            int number = Convert.ToInt32(Console.ReadLine());
            switch(number)
            {
                case 1:
                    FibonacciSeries fibo = new FibonacciSeries();
                    fibo.fibonacci();
                    break;
                case 2:
                    PerfectNumber abc = new PerfectNumber();
                    abc.Perfectnumber();
                    break;
                case 3:
                    PrimeNumber primenumber = new PrimeNumber();
                    primenumber.prime();
                    break;                
                case 4:
                    ReverseNumber rev = new ReverseNumber();
                       rev.reverse();
                       break;
                case 5:
                    Coupon c = new Coupon();
                    c.coupon();
                    break;
                case 6:
                    StopWatch stopwatch = new StopWatch();
                    stopwatch.stopWatch();
                    break;
                case 7:
                    VendringMachine note = new VendringMachine();
                    note.vendringmachine();
                    break;
                case 8:
                    VendingMachine2 note2 = new VendingMachine2();
                    note2.machine();
                    break;
                case 9:
                    TenpConv temp = new TenpConv();
                    temp.temperature();
                    break;
                case 10:
                    DayOfWeek d = new DayOfWeek();
                    d.anyday();
                    break;
                case 11:
                    MonthlyPayment a = new MonthlyPayment();
                    a.Payment();
                    break;
                case 12:
                    SquareRoot b = new SquareRoot();
                    b.squareRoot();
                    break;
                case 13:
                    Binary num = new Binary();
                    num.binary();
                    break;
            }
        }
    }
}
