using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void CalculateReverseNumber()
        {
            Console.WriteLine("Enter the reverse number ");
            int number= Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while(number!=0)
            {
                int remander = number % 10;
                reverse = reverse* 10+ remander;
                number= number / 10;
            }

            Console.WriteLine($"the revers number is : {reverse}");
        }


    }
}
