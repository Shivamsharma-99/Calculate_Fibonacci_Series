using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int len = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 0; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;      // --------> swaping
                b = c;      // --------> swaping
            }
            Console.ReadLine();
        }
    }
}
