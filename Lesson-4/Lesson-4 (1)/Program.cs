using System;

namespace Lesson_4__1_
{
    class Program
    {
        /* Написать метод GetFullName(string firstName, string lastName, string patronymic),
         * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
         * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
        */

        static void Main(string[] args)
        {
            (string lastName, string firstName, string patronymic)[] users = CreateUsers();
            PrintUsers(users);
        }

        static (string firstName, string lastName, string patronymic)[] CreateUsers()
        {
            Console.WriteLine("Введите количество пользователей:");
            int count = ReadInt();
            (string firstName, string lastName, string patronymic)[] users = new (string firstName, string lastName, string patronymic)[count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = GetFullName();
                Console.WriteLine($"Пользователь {FormatUserData(users[i])} сохранен");
            }

            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            return users;
        }


        static (string lastName, string firstName, string patronymic) GetFullName()
        {
            Console.Write("Введите Фамилию пользователя: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите Имя пользователя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите Отчество пользователя: ");
            string patronymic = Console.ReadLine();
            return (lastName, firstName, patronymic);
        }


        /// <summary>
        /// Метод для вывода всего массива в консоль
        /// </summary>
        /// <param name="users"></param>
        static void PrintUsers((string firstName, string lastName, string patronymic)[] users)
        {
            Console.WriteLine("Вывод базы данных:");
            for (int i = 0; i < users.Length; i++)
            {
                PrintUser(users[i]);
            }
        }

        /// <summary>
        /// Метод отображения в консоли
        /// </summary>
        /// <param name="user"></param>
        static void PrintUser((string firstName, string lastName, string patronymic) user)
        {
            Console.WriteLine(FormatUserData(user));
        }

        /// <summary>
        /// Формат вывода текста
        /// </summary>
        /// <param name="user">массив</param>
        /// <returns></returns>
        static string FormatUserData((string firstName, string lastName, string patronymic) user)
        {
            return $"{user.firstName} {user.lastName} {user.patronymic}";
        }

        /// <summary>
        /// конвертируем строку в инт
        /// </summary>
        /// <returns></returns>
        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
