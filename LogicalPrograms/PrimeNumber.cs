using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void CheckPrimeNumber()
        {
            Console.WriteLine("enter the number to check for prime Number ");
            int number = Convert.ToInt32(Console.ReadLine());
            int mid = number / 2;
            int temp = 0;

            for (int i = 2; i <= mid; i++)
            {
                Console.WriteLine(i);
                if (number % i == 0)
                {
                    Console.Write("is not Prime.");
                    temp++;
                    break;
                }
            }
            if (temp == 0)
                Console.Write(" is prime number");

        }
    }
}
