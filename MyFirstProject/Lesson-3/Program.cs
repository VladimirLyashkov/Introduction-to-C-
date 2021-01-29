using System;

namespace Lesson_3
{
    class Program
    {        
static void Main(string[] args)
        {

            #region Задание 1

            //Написать программу, выводящую элементы двухмерного массива по диагонали.
            
            Console.WriteLine("Укажите размерность массива:");
            int n = Convert.ToInt32(Console.ReadLine());            
            
            int[,] matrix = new int[n, n];
            
            //Заполняем массив случаными числами от 0 до 9
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Random rand = new Random();
                    matrix[i, j] = rand.Next(1,9);
                }
            }

            Console.WriteLine("Вывод массива в консоль с случаными числами от 1 до 9 \n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Выводим главную диагональ массива:");            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }                    
                }
                
            }
            
            Console.WriteLine();
            Console.WriteLine("Выводим побочную диагональ массива:");            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - i - 1)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            #endregion

            #region Задание 2

            /*
               Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий
               список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона / e - mail.
            */

            int height = 5;
            int width = 2;

            string[,] phoneBook = new string[height, width];

            string name;
            string numberPhone;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Введите имя:");
                        name = Console.ReadLine();
                        if (name != "")
                        {
                            phoneBook[i, j] = name;
                        }
                        else
                        {
                            Console.WriteLine("Вы не ввели данные");
                        }
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("Введите номер телефона или email:");
                        numberPhone = Console.ReadLine();
                        if (numberPhone != "")
                        {
                            phoneBook[i, j] = numberPhone;
                        }
                        else
                        {
                            Console.WriteLine("Вы не ввели данные");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }

                }
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{phoneBook[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Задание 3

            //Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).

            string greeting = "Hello";

            Console.WriteLine("Выводим Hello в правильном порядке");
            for (int i = 0; i < greeting.Length; i++)
            {
                Console.Write(greeting[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Выводим Hello в обратном порядке");
            for (int i = greeting.Length - 1; i >= 0; i--)
            {
                Console.Write(greeting[i]);
            }

            Console.WriteLine();
            Console.ReadKey();

            #endregion

            #region Задание 4

            //«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

            int b = 10;
            char[,] box = new char[b,b];
            char o = 'O';
            char x = 'X';

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    box[i, j] = o;
                }
            }

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{box[i, j]} ");
                }
                Console.WriteLine();
            }

            //Random body = new Random();
            //int bodyShip = body.Next(0, box.Length - 1);

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (box[i, j] == o)
                    {
                        box[i, j] = x;
                    }                    
                }
            }

            Console.WriteLine();

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{box[i, j]} ");
                }
                Console.WriteLine();
            }

            #endregion

        }
    }
}
