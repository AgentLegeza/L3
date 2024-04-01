using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Введите целое число.");

            input = Console.ReadLine();

            int number = int.Parse(input);

            if (number % 2 == 0)
                Console.WriteLine($"Число {number} чётное!!!");
            else
                Console.WriteLine($"Число {number} нечётное!!!");

            Console.ReadKey();
        }
    }
}
