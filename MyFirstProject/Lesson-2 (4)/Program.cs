using System;

namespace Lesson_2__4_
{
    class Program
    {
        /*
         4. Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
            только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные,
            которые были заранее заготовлены до вывода на консоль.
        */

        static void Main(string[] args)
        {
            Random rnd = new Random();

            string nameStore = "ООО \"Булощная\"";
            string card = "Mastercard";
            string numberCard = "************8842";
            

            int numberTicket = rnd.Next(0,10000);

            int numberTerminal = 003145;
            double sum = 116.45;
            double fee = 0.00;
            double total = sum + fee;
            DateTime date = DateTime.Now;


            Console.WriteLine("        ДОБРО ПОЖАЛОВАТЬ!");
            Console.WriteLine("*********************************");
            Console.WriteLine($"        {nameStore}");
            Console.WriteLine($"Терминал: {numberTerminal}  Чек: {numberTicket}");
            Console.WriteLine("           ОПЛАТА");
            Console.WriteLine("          ОДОБРЕНО");
            Console.WriteLine($"Сумма:                {sum} РУБ");
            Console.WriteLine($"Коммисия БАНКА:            {fee} РУБ");
            Console.WriteLine($"Итого:                {total} Руб");
            Console.WriteLine("*********************************");
            Console.WriteLine($"Карта: {card}");
            Console.WriteLine($"       {numberCard}");
            Console.WriteLine($"Дата: {date}");





        }
    }
}
