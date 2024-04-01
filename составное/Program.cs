using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace составное
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = true;

            Console.WriteLine("Введите число:");

            int n = int.Parse(Console.ReadLine());

            int i = 2;

            while (i <= n - 1)
            {
                if (n % i == 0)
                {
                    result = false;
                    break;
                }
                i++;
            }
            if (result)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число составное");
            }
            Console.ReadKey();
        }
    }
}
