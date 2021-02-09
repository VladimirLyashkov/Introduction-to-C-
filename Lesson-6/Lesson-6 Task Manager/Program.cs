using System;
using System.Diagnostics;

namespace Lesson_6_Task_Manager
{
    class Program
    {
        /// <summary>
        /// Вывод процессов в консоль
        /// </summary>
        static void DisplayingProcesses()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                Console.WriteLine($"ID процесса: {p.Id} | Имя процесса: {p.ProcessName}");
            }
        }

        /// <summary>
        /// Пункты меню
        /// </summary>
        /// <returns></returns>
        static int GetUserChoice()
        {
            Console.WriteLine("0 - Завершение работы");
            Console.WriteLine("1 - Просмотр всех процессов");
            Console.WriteLine("2 - Просмотр всех процессов и завершение работы процесса по ID");
            Console.WriteLine("3 - Просмотр всех процессов и завершение работы процесса по имени");
            Console.WriteLine("4 - Очистить консоль");
            return ReadInt();
        }

        /// <summary>
        /// 
        /// </summary>
        static void ShowMenu()
        {
            int choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        DisplayingProcesses();
                        break;
                    case 2:
                        KillProcessID();
                        break;
                    case 3:
                        KillProcessName();
                        break;
                    case 4:
                        ClearConsole();
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }

        /// <summary>
        /// Метод завершающий процесс по ID
        /// </summary>
        static void KillProcessID()
        {
            DisplayingProcesses();            
            Console.WriteLine("Укажите ID процесса который надо завершить (Для возврата в меню введите 111)");
            Process[] processes = Process.GetProcesses();
            int idProcess = ReadInt();
            foreach (Process p in processes)
            {
                if (idProcess == p.Id)
                {
                    p.Kill();
                    Console.WriteLine($"Процесс с ID: {p.Id} - Завершен!");
                }
                else if(idProcess == 111)
                {
                    ClearConsole();
                    return;
                }
            }
        }

        /// <summary>
        /// Метод завершающий процесс по имени
        /// </summary>
        static void KillProcessName()
        {
            DisplayingProcesses();
            Console.WriteLine("Укажите Имя процесса который надо завершить (Для возврата в меню введите Меню)");
            Process[] processes = Process.GetProcesses();
            string nameProcess = Console.ReadLine();
            foreach (Process p in processes)
            {
                if (nameProcess == p.ProcessName)
                {
                    p.Kill();
                    Console.WriteLine($"Процесс с именем: {p.ProcessName} - Завершен!");
                }
                else if (nameProcess == "Меню" || nameProcess == "меню")
                {
                    ClearConsole();
                    return;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное имя, переходим в меню");
                    return;
                }
            }
        }
        
        /// <summary>
        /// Очищает консоль
        /// </summary>
        static void ClearConsole()
        {
            Console.Clear();
        }

        /// <summary>
        /// Конвертация Readline в Int
        /// </summary>
        /// <returns></returns>
        static int ReadInt()
        {
            int num;
            try
            {
                string str = Console.ReadLine();                
                num = Convert.ToInt32(str);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не ID, переходим в меню\nДля продолжения нажмите любую кнопку");
                Console.ReadKey();
                num = 111;                                
            }

            return num;
        }


        static void Main(string[] args)
        {
            ShowMenu();
        }
    }
}
