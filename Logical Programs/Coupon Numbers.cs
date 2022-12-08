using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Coupon_Numbers
    {
        public void CouponNumber()
        {
            Console.WriteLine("Enter Distinct Coupon Numbers");
            int Distinct=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter How many digit coupon number you need ");
            int Digit=Convert.ToInt32(Console.ReadLine());
            int Max = 10, Min = 1;
            for(int i=1;i<Digit;i++)
            {
                Max = Max * 10;
                Min = Min * 10;
            }
            Console.WriteLine("Coupon Numbers are ");
            for(int i=1;i<=Distinct;i++)
            {
                Random randm = new Random();
                int Num = randm.Next(Min, Max);
                Console.WriteLine("\n"+Num);
            }
        }

    }
}
