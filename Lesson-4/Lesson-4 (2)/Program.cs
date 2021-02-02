using System;
using System.Linq;

namespace Lesson_4__2_
{
    class Program
    {
        /*Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
         * и возвращающую число — сумму всех чисел в строке. 
         * Ввести данные с клавиатуры и вывести результат на экран.
        */


        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел через пробел которые хотите просуммировать: ");
            int sum = ReadInt();

            Console.WriteLine($"Сумма чисел равна: {sum}");
        }
                
        static int ReadInt()
        {
            int sum = 0;
            string setNum = Console.ReadLine();
            int[] numArr = setNum.Split(" ").Select(int.Parse).ToArray();
            
            for (int i = 0; i < numArr.Length; i++)
            {                
               sum += numArr[i]; 
            }
            return sum;
        }
    }
}
