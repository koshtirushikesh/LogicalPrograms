using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacci
    {
        public void FibonacciSeries()
        {
            Console.WriteLine("Enter the n number ");
            int number= Convert.ToInt32(Console.ReadLine());
            
            int n1=0 , n2=1 , n3=0 ;
            Console.Write($"{n1} {n2}");
            for (int i =2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(" "+n3);
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
