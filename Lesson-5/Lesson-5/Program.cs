using System;
using System.IO;
using System.Linq;


namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Задание 1

            //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

            string fileName = "text.txt";

            Console.WriteLine("Введите произвольный текст для записи и сохранения его в файл:");
            string text = Console.ReadLine();
            File.WriteAllText(fileName, text);

            string fileText = File.ReadAllText(fileName);
            Console.WriteLine($"\nВведеный ранее текст: {fileText}\n");
            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Задание 2

            //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

            string startUp = "startup.txt";            
            DateTime date = DateTime.Now;            

            File.AppendAllText(startUp, date.ToString());
            File.AppendAllText(startUp, Environment.NewLine);

            string[] fileLines = File.ReadAllLines(startUp);

            for (int i = 0; i < fileLines.Length; i++)
            {
                Console.WriteLine(fileLines[i]);
            }

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Задание 3

            //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

            Console.WriteLine("\nВведите произвольный набор чисел от 0 до 255: ");
            string textByte = Console.ReadLine();
            int[] numArr = textByte.Split(" ").Select(int.Parse).ToArray();
            byte[] byteArr = new byte[100];

            for (int i = 0; i < numArr.Length; i++)
            {
                byteArr[i] = Convert.ToByte(numArr[i]);
            }

            File.WriteAllBytes("bytes.bin", byteArr);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");
            for (int i = 0; i < fromFile.Length; i++)
            {
                Console.Write($"{fromFile[i]} ");
            }
            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Задание 4

            //(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.

            string workDir = @"F:\ExampleDir";

            Console.WriteLine(Directory.Exists(workDir));

            string notesDir = Path.Combine(workDir, "Notes");

            Directory.CreateDirectory(notesDir); 

            string noteText = "Этот файл создан автоматически";

            string notePath = Path.Combine(notesDir, "Note 1.txt"); 

            File.WriteAllText(notePath, noteText);
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);

            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }
            Console.ReadKey();
            Console.Clear();

            #endregion


        }
    }
}
