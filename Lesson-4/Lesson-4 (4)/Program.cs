using System;

namespace Lesson_4__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonachi(0,1,5));
        }

        static int Fibonachi(int f1,int f2, int num)
        {
            return num == 0 ? f1 : Fibonachi(f2, f1 + f2, num - 1);
        }

    }
}


// Fn=Fn-1+Fn-2
// 0 1 1 2 3 5 8
// 0 1 3 6 10