using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Alphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabet");
            char a=Convert.ToChar(Console.ReadLine());
            if(a>='A'&&a<='Z')
            {
                Console.WriteLine($"{a} is in uppercase");
            }
            else if (a >= 'a' && a <= 'z')
            {
                Console.WriteLine($"{a} is in lowecase");
            }
            else
            {
                Console.WriteLine($"{a} is not an alphabet");
            }
        }
    }
}
