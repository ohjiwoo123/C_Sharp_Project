using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _04_제어문
    {
        static void Main(string[] args)
        {
            //newstLoop - 구구단
            if (false)
            {
                int[] gugu_ar = { 2, 3, 4, 5, 6, 7, 8, 9 };

                for (int i = 0; i < gugu_ar.Length; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        Console.WriteLine($"{gugu_ar[i]}의 구구단, {gugu_ar[i]}*{j}={gugu_ar[i] * j}");
                    }
                }

            }
            // InfiniteLoop
            if (false)
            {
                for (; ; )
                {
                    Console.WriteLine("뭐뭐하자");
                    Console.Write("또 할래?(Y/N)");
                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.N)
                    {
                        break;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------");
            }
            // c++ : 범위기반 for
            // c# : foreach
            if (true)
            {
                int[] ar = { 29, 64, 90, 16, 78 };
                int Max = 0;

                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] > Max)
                    {
                        Max = ar[i];
                    }
                }
                Console.WriteLine($"가장 큰 값은 {Max} 입니다");
                Console.WriteLine("---------------------------");

                foreach (int i in ar)    // int 대신 var 가능 (var는 타입을 알아서 정해줌)
                {
                    if (i > Max)
                    {
                        Max = i;
                    }
                }
                Console.WriteLine($"가장 큰 값은 {Max} 입니다");
                Console.WriteLine("---------------------------");
            }
            if (true)
            {
                string s = "둘";
                switch (s)
                {
                    case "하나":
                        Console.WriteLine(1);
                        break;
                    case "둘":
                        Console.WriteLine(2);
                        break;
                    case "셋":
                        Console.WriteLine(2);
                        break;
                    default:
                        Console.WriteLine("그 외의 숫자");
                        break;
                }
            }
        }
    }
}
