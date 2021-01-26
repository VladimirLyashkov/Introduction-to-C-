using System;

namespace Lesson_2__6_
{
    class Program
    {
        /*
         6.* Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, к примеру, чтобы описать работу какого либо офиса. 
           Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до воскресенья.
         */

        [Flags]
        public enum Weekday
        {
            // Для читаемости разряды можно разделять знаком подчёркивания.
            // Они никак не влияют на значение.
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000,
        }
        static void Main(string[] args)
        {
            Weekday workday = Weekday.Понедельник | Weekday.Вторник | Weekday.Среда | Weekday.Четверг | Weekday.Пятница;
            Weekday weekends = Weekday.Суббота | Weekday.Воскресенье;

            Weekday allweekday = (Weekday)0b1111111;

            Weekday office1 = workday;
            Weekday office2 = allweekday;

            Console.WriteLine($"Дни недели: {allweekday}");

            Console.WriteLine($"Офис номер один работает: {office1}");

            Console.WriteLine($"Офис номер два работает: {office2}");

        }
    }
}
