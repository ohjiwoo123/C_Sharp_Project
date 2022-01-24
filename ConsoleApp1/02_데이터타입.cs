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
    enum DAY { SUN,MON,TUE=9,THUR,FRI,SAT }
    enum Direction { East=10, West, South, North }

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
            // 열거형
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
            // 구조체
            if (false)
            {
                Book b;
                b.Name = "떼돈벌기";
                b.Price = 18000;
                Console.WriteLine($"제목 {b.Name}\n가격:{b.Price}");
                Console.WriteLine("------------------------------");

                // 생성자를 부르고 있다.
                Book2 bb = new Book2("삐삐",2500);
                bb.PrintBook();
                Console.WriteLine("------------------------------");
            }
            // 배열
            if (false)
            {
                // C# 은 포인터가 없다.
                int[] ar = new int[5];

                for(int i =0; i<5;i++)
                {
                    Console.WriteLine(ar[i]);
                }
                Console.WriteLine("------------------------------");
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = i*2;
                    Console.WriteLine(ar[i]);
                }
                // Console.WriteLine(ar); System.Int32[] 가 출력됨.
            }
            // 배열2
            if (true)
            {
                int[] arScore = { 89,88,23,56,22,90,100 };
                Console.Write("정렬전 ==> ");
                for (int i=0; i<arScore.Length; i++)
                {
                    Console.Write(arScore[i]+", ");
                }
                Console.WriteLine("\n------------------------------");
                Console.Write("정렬후 ==> ");
                System.Array.Sort(arScore);
                for (int i = 0; i < arScore.Length; i++)
                {
                    Console.Write(arScore[i] + ", ");
                }
            }
        }
    }
}
