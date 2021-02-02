using System;

namespace Lesson_1
{
    class Program
    {
        /*Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%». 
         * Имя пользователя сохранить из консоли в промежуточную переменную. 
         * Поставить точку останова и посмотреть значение этой переменной в режиме отладки. 
         * Запустить исполняемый файл через системный терминал.
         */


        static void Main(string[] args)
        {

            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now} ");
            Console.ReadKey();

        }
    }
}
