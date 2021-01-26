using System;

namespace Lesson_2__3_
{
    class Program
    {
        /*
          3.Определить, является ли введённое пользователем число чётным.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое целое число");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine($"Вы ввели нечетное число: {num}");
            }
            else
            {
                Console.WriteLine($"Вы ввели четное число: {num}");
            }

            Console.ReadKey();
        }
    }
}
