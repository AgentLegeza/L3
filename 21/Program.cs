using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            int value;
            Console.WriteLine("Здравствуйте! \nСколько карт у вас на руках?");
            byte cards = byte.Parse(Console.ReadLine());

            for (; cards != 0; cards--)
            {
                Console.WriteLine($"Ведите наминал карты {cards}, Очки: {summ}");
                string input = Console.ReadLine();

                switch (input)

                {
                    case "j": value = 2; break;
                    case "d": value = 3; break;
                    case "k": value = 4; break;
                    case "t": value = 1; break;
                    default: value = int.Parse(input); break;

                }

                summ += value;

            }
            Console.WriteLine($"Общаяя сумма ваших очков: {summ}");
            Console.ReadLine();
        }
    }
}
