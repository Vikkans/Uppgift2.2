using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            string x = Console.ReadLine();
            double y = double.Parse(x);

            Console.WriteLine("Hur långt hoppade Alma i meter?");
            string z = Console.ReadLine();
            double g = double.Parse(z);

            double sum = y - g;

            Console.WriteLine("Elin hoppade " + sum + " meter längre än Alma");
            Console.ReadKey();

        }
        




    }



}