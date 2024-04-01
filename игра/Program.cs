using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игра
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int i = 0;
            Console.WriteLine("Введите максимальное число диапазона");
            int limit = int.Parse(Console.ReadLine());               //назначили верхний диапазон

            Random rnd = new Random();
            int randomNumber = rnd.Next(0, limit);                     //загадали число

            for (; ; )
            {

                if (i == 0) { Console.WriteLine($"Угадайте число от 0 до {limit}\n Для выхода нажмите клавишу Enter"); i++; }                    //ввод попытки

                string exit = Console.ReadLine();
                try
                {
                    input = int.Parse(exit);
                    if (input > randomNumber) { Console.WriteLine("попробуйте меньше"); }
                    else if (input < randomNumber) { Console.WriteLine("попробуйте больше"); }
                    else if (input == randomNumber) { Console.WriteLine($"ПОЗДРАВЛЯЮ \nВы победили!!!"); break; }
                }

                catch
                {
                    if (exit == "") { Console.WriteLine($"Я загадывала {randomNumber}  \nУдачи в следующий раз ;)"); break; } //Выход  
                }
            }
            Console.ReadLine();
        }
    }
}
