using System;

namespace SuperFancyPants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Print();

            Console.ReadKey();
        }

        public static void Print()
        {
            Console.WriteLine("Vanuit de print methode");

            string result = Console.ReadLine();

            Console.WriteLine($"Dit was het resultaat: {result}");
        }
    }
}
