using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace минМакс
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            Console.WriteLine("Введите длинну последовательности.");
            int Length = int.Parse(Console.ReadLine());



            while (Length != 0)
            {
                Console.WriteLine("Введите целое число.");
                int input = int.Parse(Console.ReadLine());
                Length--;

                if (input < min) { min = input; }

                else { }





            }
            Console.WriteLine($"Наименьшее число в последовательности: {min}");
            Console.ReadLine();
        }
    }
}
