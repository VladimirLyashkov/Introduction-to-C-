using System;

namespace lesson_2
{
    class Program
    {
        /*
         1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
         2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
         5.* Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
        */

        static void Main(string[] args)
        {

            #region Задание №1
            Console.WriteLine("Укажите минимальную температуру за сутки");
            int minTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите максимальную температуру за сутки");
            int maxTemp = Convert.ToInt32(Console.ReadLine());

            double averageTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Среднесуточная температура составляет: {averageTemp}°C");
            #endregion

            #region Задание №2
            Console.WriteLine("Укажите порядковый номер текущего месяца");
            int numberMonth = Convert.ToInt32(Console.ReadLine());
            while (numberMonth < 0 || numberMonth > 12)
            {
                Console.WriteLine("Вы не коректно указали порядковый номер текущего месяца");
                Console.WriteLine("Укажите порядковый номер текущего месяца");
                numberMonth = Convert.ToInt32(Console.ReadLine());
            }

            string month = "";
            switch (numberMonth)
            {
                case 1:
                    month = "Январь";
                    break;
                case 2:
                    month = "Февраль";
                    break;
                case 3:
                    month = "Март";
                    break;
                case 4:
                    month = "Апрель";
                    break;
                case 5:
                    month = "Май";
                    break;
                case 6:
                    month = "Июнь";
                    break;
                case 7:
                    month = "Июль";
                    break;
                case 8:
                    month = "Август";
                    break;
                case 9:
                    month = "Сентябрь";
                    break;
                case 10:
                    month = "Октябрь";
                    break;
                case 11:
                    month = "Ноябрь";
                    break;
                case 12:
                    month = "Декабрь";
                    break;
            }
            Console.WriteLine($"Текущий месяц: {month}");
            #endregion

            #region Задание №5 (*)
            if (numberMonth == 12 || numberMonth == 1 || numberMonth == 2 & averageTemp > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            else if (numberMonth == 6 || numberMonth == 7 || numberMonth == 8 & averageTemp < 0)
            {
                Console.WriteLine("Очень холодное лето");
            }
            #endregion









        }
    }
}
