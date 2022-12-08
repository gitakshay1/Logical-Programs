using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_Number
    {
        public void Reversenumber()
        {
            Console.WriteLine("Enter the number to be reversed");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Rev = 0;
            int sum = 0;
            while (Number != 0)
            {
                Rev = Number % 10;
                sum = Rev + sum * 10;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse of the number is " + sum);
        }
    }
}
