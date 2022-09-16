
using System;
namespace Uppgift_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket lön får Ali");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket lön får Naser");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket lön får Abdiaziz");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine((x + y + z) / 3);

        }


    }


}