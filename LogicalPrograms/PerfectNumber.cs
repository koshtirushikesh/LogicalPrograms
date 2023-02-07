using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void PerfectNumberSeries() 
        {
            
            Console.WriteLine("Enter the min number :");
            int N_min=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the max number :");
            int N_max= Convert.ToInt32(Console.ReadLine());

            for (int number=N_min ; number<=N_max; number++) 
            {
                
                int sum = 0;
                for(int i=1; i<number;i++)
                {
                    if (number % i == 0)
                        sum = sum + i;
                }
                if (sum == number)
                    Console.WriteLine($" {number}");
            }
        
        }
    }
}
