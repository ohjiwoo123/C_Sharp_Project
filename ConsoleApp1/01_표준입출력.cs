using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 출력----------------------------------------------------------
            // WriteLine
            if (false)
            {
                Console.WriteLine("Hello C#\n");

                int i = 1234;
                double d = 5.6789;
                string s = "문자열";

                Console.WriteLine(i);
                Console.WriteLine(d);
                Console.WriteLine(s);
                Console.WriteLine("------------------------");
            }
            // Write
            // WriteLine
            if (false)
            {
                Console.WriteLine("헬로우 C#\n");

                int i = 1234;
                double d = 5.6789;
                string s = "문자열";

                Console.Write(i);
                Console.Write(d);
                Console.Write(s);
                Console.WriteLine("------------------------");
            }
            // stringFormat
            if (false)
            {
                int i = 1234;
                double d = 5.6789;

                Console.WriteLine("정수는 " + i + "이고 실수는 " + d + "이다");
                Console.WriteLine("정수는 {0}이고 실수는 {1}이다.", i, d);
                // X : 핵사로 찍어달라, F2 : 소수점 2자리까지 
                Console.WriteLine("정수는 {0:X}이고 실수는 {1:F2}이다.", i, d);
                Console.WriteLine("------------------------");
            }
            // Interpolation (문자열 보간) $
            if (false)
            {
                int age = 18;
                string name = "김한솔";

                Console.WriteLine("안녕하세요 {0}세 {1}입니다.", age, name);
                Console.WriteLine($"안녕하세요 {age + 2}세 {name}입니다.");
                Console.WriteLine("------------------------");
            }

            // 입력--------------------------------------------------------------
            // ReadLine
            if (false)
            {
                Console.Write("이름을 입력하세요 : ");
                string Name = Console.ReadLine();

                Console.Write("나이을 입력하세요 : ");
                string sAge = Console.ReadLine();
                int Age = Convert.ToInt32(sAge);

                Console.WriteLine($"안녕하세요 {Age}세 {Name}님");
                Console.WriteLine("---------------------------");
            }
            // ReadKey
            if (false)
            {
                ConsoleKeyInfo cki;
                int x = 40, y = 12;

                for(; ; )
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write('#');

                    cki = Console.ReadKey(true);
                    switch(cki.Key)
                    {
                        case ConsoleKey.LeftArrow:  x--;     break;
                        case ConsoleKey.RightArrow: x++;     break;
                        case ConsoleKey.UpArrow:    y--;     break;
                        case ConsoleKey.DownArrow:  y++;     break;
                        case ConsoleKey.Q: return;
                    }
                }
            }
            // Console Member
            // Console = cout + cin + 콘솔하면전체 제어 
            if (false)
            {
                Console.Title = "콘솔 테스트";
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.Beep();
                Console.WriteLine("반가워요");
                Console.ReadLine(); // enter 입력
                Console.ResetColor();
                Console.SetCursorPosition(10, 10);
                Console.WriteLine("디폴트 색상입니다.");

                Console.WriteLine("---------------------");
            }

            // 네임스페이스 ------------------------------------
;            if (true)
            {
                System.Console.WriteLine("안녕하세요.");
                Console.WriteLine("안녕하세요.");
                WriteLine("안녕하세요.");

            }
        }
    }
}