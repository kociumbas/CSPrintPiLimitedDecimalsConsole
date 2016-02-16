using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2WyswietlPi
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Pi = " + Math.Round(pi, 5));   //or
            Console.WriteLine("Pi = {0:#.#####}",pi);
            Console.ReadLine();
        }
    }
}
