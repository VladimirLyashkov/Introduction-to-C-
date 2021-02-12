using System;

namespace Lesson_4__3_
{
    class Program
    {
        /* Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
         * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
         * Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
         * Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. Если введено некорректное число,
         * вывести в консоль текст «Ошибка: введите число от 1 до 12».
        */
        public enum Season
        {
            Зима,
            Весна,
            Лето,
            Осень            
        }

        public enum Months
        {
            Январь,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {
            int monht = NumMonth();
            int numSeason = SetSeason(monht);
            Announcement(monht, numSeason);

            Console.ReadKey();

        }

        static int NumMonth()
        {
            Console.WriteLine("Укажите порядковый номер текущего месяца");
            int numberMonth = Convert.ToInt32(Console.ReadLine());
            while (numberMonth < 0 || numberMonth > 12 || numberMonth == 0)
            {
                Console.WriteLine("Вы не коректно указали порядковый номер текущего месяца");
                Console.WriteLine("Укажите порядковый номер текущего месяца");
                numberMonth = Convert.ToInt32(Console.ReadLine());
            }

            int numMonth = Convert.ToInt32((Months)numberMonth);

            return numMonth;
        }

        static int SetSeason(int numberMonth)
        {
            if (numberMonth == 12 || numberMonth == 1|| numberMonth == 2)
            {
                return 1;
            }
            else if (numberMonth == 3 || numberMonth == 4 || numberMonth == 5)
            {
                return 2;
            }
            else if (numberMonth == 6 || numberMonth == 7 || numberMonth == 8)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        static void Announcement(int month, int numSeason)
        {
            if (numSeason < 0)
            {
                numSeason++;
            }

            Console.WriteLine($"Текущий месяц: {(Months)month-1}");            
            Console.WriteLine($"Время года: {(Season)numSeason-1}");
        }

    }
}
