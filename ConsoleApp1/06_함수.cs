using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# 여기파트 현재 ref와 프로퍼티 외에 새로운 것 아직 없음 

namespace ConsoleApp1
{
    internal class _06_함수
    {
        public static int CalcSum(int a, int b)
        {
            return a+b;
        }
        public static int CalcSum(int a, int b, int c=2)
        {
            int sum = 0;
            for (int i=a; i<=b; i++)
            {
                if (i%c==0)
                {
                    continue;
                }
                else
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static int Add(int a, int b)
        {
            return a+b;
        }
        public static double Add(double a, double b)
        {
            return a+b;
        }

        public static string Add(string a, string b)
        {
            return a+b;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T Temp;
            Temp = a;
            a = b;
            b = Temp;
        }

        public static void Swap2<T>(ref T aa, ref T bb)
        {
            T Temp;
            Temp = aa;
            aa = bb;
            bb = Temp;
        }

        class Time
        {
            private int hour;
            private int min;
            private int sec;

            public Time(int a, int b, int c)
            {
                hour = a;
                min = b;
                sec = c;
            }
            public void SetHour(int a)
            {
                hour =a;
            }

            public void SetMin(int a)
            {
                min = a;
            }

            public void SetSec(int a)
            {
                sec = a;
            }

            public int GetHour(int a)
            {
                return hour;
            }

            public int GetMin(int a)
            {
                return min;
            }

            public int GetSec(int a)
            {
                return sec;
            }

            public void OutTime()
            {
                Console.WriteLine($"현재시간은 hour={hour}, min={min}, sec={sec}");
            }
        }

        class Time2
        {
            private int hour;
            private int min;
            private int sec;

            public int Hour // Property (프라이빗 변수 이름과 비슷하게 지음)
            {
                get { return hour; }    // get , set 중 하나만 있어도 된다.
                set { if (value < 24) hour = value; }
            }

            public int Min // Property
            {
                get { return min; }
                set { if (value < 60) min = value; }
            }

            public int Sec // Property
            {
                get { return sec; }
                set { if (value < 60) min = value; }
            }
            public Time2(int a, int b, int c)
            {
                hour = a;
                min = b;
                sec = c;
            }
            public void OutTime()
            {
                Console.WriteLine($"현재시간은 hour={hour}, min={min}, sec={sec}");
            }
        }

        class Human
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Intro()
            {
                Console.WriteLine($"이름은 {Name}, 나이는 {Age}");
            }
        }

        static void Main(string[] args)
        {
            // Calc Sum
            if (false)
            {
                Console.WriteLine($"합계 = " + CalcSum(1, 100));
                Console.WriteLine("-----------------------");
            }
            if (true)
            {
                Console.WriteLine("1+2는 {0}입니다.", Add(1, 2));
                Console.WriteLine("1.2+3.4는 {0}입니다.", Add(1.2, 3.4));
                string a = "우리나라";
                string b = "대한민국";
                Console.WriteLine("{0}+{1}은 {2}입니다.", a, b, Add(a, b));
            }
            // OptionArg (선택적 인수)
            if (true)
            {
                Console.WriteLine($"1+10 = {CalcSum(1, 10)}");
                Console.WriteLine($"1~10 홀수의 합 = {CalcSum(1, 10,2)}");
            }
            if (false)
            {
                int a = 100;
                int b = 200;
                Console.WriteLine($"스왑 전 a={a},b={b}");
                Swap<int>(ref a, ref b);
                Console.WriteLine($"스왑 후 a={a},b={b}");

                string aa = "홍길동";
                string bb = "대장";
                Console.WriteLine($"스왑 전 a={aa},b={bb}");
                Swap2<string>(ref aa, ref bb);
                Console.WriteLine($"스왑 전 a={aa},b={bb}");
            }

            // 프로퍼티1 (Properties)
            if (false)
            {
                Time now= new Time(13,30,45);
                Time then= new Time(15,77,55);

                now.SetHour(20);
                then.SetMin(40);

                now.OutTime();
                then.OutTime();

                //////////////////////
                Time2 now2 = new Time2(13, 30, 45);
                Time2 then2 = new Time2(15, 77, 55);

                // 프라이빗 변수에 접근할 수 있는 것 ==> 프로퍼티
                now2.Hour = 20;
                then2.Hour = now2.Hour + 2;

                now2.OutTime();
                then2.OutTime();
            }
            // 프로퍼티 2 
            if (false)
            {
                Human kim = new Human();
                kim.Name = "홍길동";
                kim.Age = 20;
                kim.Intro();
            }
        }
    }
}
