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
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("Fibonacci Series is running");
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibonacciSeries();
                    break;
                        

            }
            Console.ReadLine();
        }
    }
}
