using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Travel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any vehicle to travel");
            Console.WriteLine("1.Taxi");
            Console.WriteLine("2.Bus");
            Console.WriteLine("3.Train");
            int opt = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("d.day");
            Console.WriteLine("n.night");
            Console.WriteLine("Enter day or night");
          
            
            char time = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter distance to be travelled");

            int dis = Convert.ToInt32(Console.ReadLine());

            if (opt == 1)
            {
                if (time == 'd')
                {
                    double d = 0.7 * dis;
                    Console.WriteLine($"Amount to be paid={d}");
                }
                else if (time == 'n')
                {
                    double d = 0.9 * dis;
                    Console.WriteLine($"Amount to be paid={d}");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
                

            }
            else if(opt == 2)
            {
                if(time =='d'&& dis >= 20)
                {
                    double d = 0.09 * dis;
                    Console.WriteLine($"Amount to be paid={d}");
                }
                else if (time=='n' && dis >=20)
                {
                    double d = 0.09 * dis;
                    Console.WriteLine($"Amount to be paid={d}");
                }
                else
                {
                    Console.WriteLine("invalid option");
                }
                
             
            }
            else if (opt == 3)
            {
                if (time == 'd' && dis >= 100)
                {
                    double d = 0.06 * dis;
                    Console.WriteLine($"Amount to be paid={d}");
                }
                else if(time=='n' && dis >= 100)
                {
                    double d = 0.06 * dis;
                    Console.WriteLine($"Amount to be paid={d}");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
