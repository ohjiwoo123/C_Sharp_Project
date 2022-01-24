using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 
/// 데이터 타입
/// 1. 기본 데이터 타입(내장형)
//// 1) 정수형 - int
//// 2) 실수형 - float, double
//// 3) 논리형 - BOOL(boolean)
//// 4) 문자형 - char
/// 2. 사용자 정의 데이터 타입
//// 1) 열거형(enum)
//// 2) 구조체(struct)
//// 3) 클래스(class)
/// 3. 배열(Array : [])
/// vs 링크드리스트(LinkedList)
/// vs 스택과 큐(Stack & Queue)

namespace ConsoleApp1
{
    enum DAY { SUN, MON, TUE = 9, THUR, FRI, SAT }
    enum Direction { East = 10, West, South, North }

    // 구조체 : 이형의 자료를 모아서 관리함
    struct Book
    {
        public string Name;
        public int Price;
    };

    // 구조체의 발전 : 자료 + 함수 (-->OOP의 1단계 : 캡슐화)
    // 2,3단계는 따라갈 수 없음
    struct Book2
    {
        public string Name;
        public int Price;

        // 생성자는 리턴이 없다.
        public Book2(string a, int b)
        {
            Name = a;
            Price = b;
        }
        public Book2(string a, double b)
        {
            Name = a;
            Price = (int)b;
        }
        public void PrintBook()
        {
            Console.WriteLine($"이름 = {Name}, 가격 = {Price}");
        }
    }
    internal class _02_데이터타입
    {
        static void Main(string[] args)
        {
            // 열거형 (enum)
            if (false)
            {
                //int myBirthDay = (int)DAY.SAT;
                //Console.Write(myBirthDay);

                DAY myBirthDay;
                myBirthDay = DAY.SAT;

                Direction myHouse = Direction.North;
                string temp = myHouse.ToString();

                Console.WriteLine(myBirthDay);
                Console.WriteLine((int)myHouse);
                Console.WriteLine(myHouse);
                Console.WriteLine(temp);

            }

            // 구조체 (struct)
            if (false)
            {
                Book b;
                b.Name = "떼돈벌기";
                b.Price = 18000;
                Console.WriteLine($"제목 {b.Name}\n가격:{b.Price}");
                Console.WriteLine("------------------------------");

                // 생성자를 부르고 있다.
                Book2 bb = new Book2("삐삐", 2500);
                bb.PrintBook();
                Console.WriteLine("------------------------------");
            }

            // 배열 (array)
            if (false)
            {
                // C# 은 포인터가 없다.
                int[] ar = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(ar[i]);
                }
                Console.WriteLine("------------------------------");
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = i * 2;
                    Console.WriteLine(ar[i]);
                }
                // Console.WriteLine(ar); System.Int32[] 가 출력됨.
            }

            // 배열2 (array2)
            if (false)
            {
                int[] arScore = { 89, 88, 23, 56, 22, 90, 100 };
                Console.Write("정렬전 ==> ");
                for (int i = 0; i < arScore.Length; i++)
                {
                    Console.Write(arScore[i] + ", ");
                }
                Console.WriteLine("\n------------------------------");
                Console.Write("정렬후 ==> ");
                System.Array.Sort(arScore);
                System.Array.Reverse(arScore);
                for (int i = 0; i < arScore.Length; i++)
                {
                    Console.Write(arScore[i] + ", ");
                }
            }

            // 배열의 배열, 2차원배열 (2 Dimensional Array)
            if (false)
            {
                // int** pp;
                // int[][] ar = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
                int[,] ar = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(ar[i, j] + ", ");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("----------------------");

                int[][] aar = new int[3][];
                aar[0] = new int[] { 1, 2, 3, 4 };
                aar[1] = new int[] { 5, 6 };
                aar[2] = new int[] { 7, 8, 9, 10, 11, 12 };
                Console.WriteLine(aar[0][1]);   // 2
                Console.WriteLine(aar[2][3]);   // 10
                Console.WriteLine("----------------------");
            }

            // 클래스 (Class)
            if (false)
            {
                Time now;
                // 디폴트 생성자가 있음.
                now = new Time();
                now.OutTime();
                now.hour = 24;
                now.min = 30;
                now.sec = 45;
                now.OutTime();
                Console.WriteLine("----------------------");
                Time prev = new Time(3, 30, 22);
                prev.OutTime();

                Time next = new Time(5, 30, 22);
                next.OutTime();
                Console.WriteLine("----------------------");
            }

            // 클래스2 (class 2)
            if (true)
            {
                string str1;
                str1 = "홍길동"; // 대입 연산자를 통해 대입
                Console.WriteLine(str1);

                string str2 = "우리대장"; // 초기화 
                Console.WriteLine(str2);

                string str3;
                str3 = str1 + str2; // 연결->대입
                Console.WriteLine(str3);
            }
        }
    }
    class Time
    {
        public int hour;
        public int min;
        public int sec;

        public Time()
        {
            hour = 0;
            min = 0;
            sec = 0;
        }

        // 디폴트 생성자 외에 하나 더 만들어 
        public Time(int a, int b, int c)
        {
            hour = a;
            min = b;
            sec = c;
        }
        public void OutTime()
        {
            if (hour > 12)
                Console.WriteLine($"현재시간은 오후{hour-12}시 {min}분 {sec}초 입니다.");
            else if (hour <= 12)
                Console.WriteLine($"현재시간은 오전{hour}시 {min}분 {sec}초 입니다.");

        }
    }
}