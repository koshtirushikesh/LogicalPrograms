using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumber
    {
        public void GenerateCouponNumber() 
        {
            Console.WriteLine("Enter the number of coupen to generate");
            int number= Convert.ToInt32(Console.ReadLine());
            int[] Coupens = new int[number];
            int i = 0, count = 0;
            while (true)
            {
                Random random = new Random();
                int newCoupen =random.Next(1, number+1);
                
                if (!Coupens.Contains(newCoupen) )
                {
                    Coupens[i] = newCoupen;
                    i++;
                }
                count++;

                if (Coupens[number-1] != 0) break;
            }
            foreach(int coupen in Coupens)
            {
                Console.WriteLine(coupen);
            }

            Console.WriteLine($"no of time try: {count}");
        
        }   
    }
}
