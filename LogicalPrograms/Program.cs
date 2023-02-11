using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("2. Perfect Number");
            Console.WriteLine("3. Prime Number");
            Console.WriteLine("4. Reverse Number");
            Console.WriteLine("5. Coupon Number");
            Console.WriteLine("6. Stop Watch");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Fibonacci Series is running");
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibonacciSeries();
                    break;

                case 2:
                    Console.WriteLine("Perfect Number is running");
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.PerfectNumberSeries();
                    break;

                case 3:
                    Console.WriteLine("prime Number is running");
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.CheckPrimeNumber();
                    break;
                case 4:
                    Console.WriteLine("Reverse number is running");
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.CalculateReverseNumber();
                    break;
                case 5:
                    Console.WriteLine("Coupon Number is running");
                    CouponNumber couponNumber = new CouponNumber();
                    couponNumber.GenerateCouponNumber();
                    break;
                case 6:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.RunStopWatch();
                    break;
            }
            Console.ReadLine();
        }
    }
}
