using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void exercice1(int n)
        {
            int d = 2;
            bool p = true;
            while (d * d <= n && p)
            {
                if (n % d == 0)
                {
                    p = false;
                }
                d++;
            }
            Console.WriteLine(p);
        }
        static void Main(string[] args)
        {
            exercice1(7);
        }
    }
}
