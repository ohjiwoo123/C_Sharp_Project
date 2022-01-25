using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human{
        public String Name;
        public int Age;
        public void Intro()
        {
            Console.WriteLine($"{Age}살, {Name}입니다.");
        }
    }
    partial class Human2
    {
        public String Name;
        public int Age;
    }
    partial class Human2
    {
        public void Intro()
        {
            Console.WriteLine($"{Age}살, {Name}입니다.");
        }
    }
    class Human3
    {
        public String Name;
        public int Age;
        public Human3(string a, int b)
        {
            Name = a;
            Age = b;
        }
        public Human3(string a)
        {
            Name = a;
            Age = 0;
        }
        public void Intro()
        {
            Console.WriteLine($"{Age}살, {Name}입니다.");
        }
        ~Human3()
        {
            Console.WriteLine("Bye");
        }
    }
    class Fish
    {
        public string Flavor;
        public int Size;
        public static int count;    // 정적 멤버 변수 : 클래스의 멤버 변수 --> 클래스 내에서 글로벌이 됨.
        public Fish(string a, int b)
        {
            Flavor = a;
            Size = b;
            count++;
        }
        public void PrintFish()
        {
            Console.WriteLine($"저는 {Flavor} 맛 사이즈는 {Size} 입니다.");
        }
        public static void TotalSaleCount()
        {
            Console.WriteLine($"총 붕어빵 판매 개수는 {count} 입니다.");
        }

    }
    internal class _05_클래스
    {
        static void Main(string[] args)
        {
            // Human
            if(false)
            {
                Human Kim;
                Kim = new Human();
                Kim.Name = "홍길동";
                Kim.Age = 25;
                Kim.Intro();

                Console.WriteLine("------------------------");
            }
            // Partial(분할선언)
            if(false)
            {
                Human2 Kim;
                Kim = new Human2();
                Kim.Name = "홍길동";
                Kim.Age = 25;
                Kim.Intro();

                Console.WriteLine("------------------------");
            }
            // 생성자와 소멸자 
            if(false)
            {
                Human3 Kim;
                Kim = new Human3("강호동",32);
                Kim.Intro();

                Human3 Lee;
                Lee = new Human3("이승철");
                Lee.Intro();

                Console.WriteLine("------------------------");
            }
            // 정적멤버1
            if (true)
            {
                Fish.TotalSaleCount();
                Fish a = new Fish("단팥",1);  // 1이 대자, 2가 소자 
                Fish b = new Fish("크림맛",2);
                Fish c = new Fish("초코",1);

                a.PrintFish();
                b.PrintFish();
                c.PrintFish();
                Fish.TotalSaleCount();
            }
        }
    }
}
