using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class ProfitAndLoss
    {
        static void Main(string[] args)
        {
            double cp, sp;
            Console.WriteLine("Enter cost price");
            cp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter selling price");
            sp = Convert.ToDouble(Console.ReadLine());

            if (cp > sp)
            {
                double loss = cp - sp;
                Console.WriteLine($"loss={loss}");
            }
            else
            {
                double profit = sp - cp;
                Console.WriteLine($"profit={profit}");
            }
        }
    }
}
