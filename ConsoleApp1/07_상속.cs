using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human
    {
        protected string Name;
        protected int Age;

        public Human(string aName, int aAge)
        {
            //onsole.WriteLine("Human" = 생성자);
            Name = aName;
            Age = aAge;
        }
        public virtual void Intro()
        {
            Console.WriteLine($"{Age}살 {Name}입니다.");
        }
    }

    class Student : Human
    {
        protected int StNum;
        public Student(string aName, int aAge,int aStNum)
            : base(aName, aAge)
        {
            Console.WriteLine("생성자");
            StNum = aStNum;
        }
        public void Study()
        {
            Console.WriteLine("열심히 공부합니다.");
        }
        public override void Intro()
        {
            Console.WriteLine($"{Age}살 {Name}입니다.");
            Console.WriteLine($"학번은 {StNum} 입니다.");
        }
    }

    // is (is, as 연산자)
    class MyHuman { }
    class MyStudent : MyHuman { }       // 등록
    class MyGraduate : MyStudent { }    // 등록
    class MyAssistant : MyHuman { }     // 등록

    class MyProfessor : MyHuman { }
    class MySuwi : MyHuman { }


    internal class _07_상속
    {
        static  void Register(MyHuman X)    
        {
            if (X is MyStudent || X is MyAssistant) // is 연산자 
            {
                Console.WriteLine("등록한다.");
            }
            else
            {
                Console.WriteLine("등록안됨.");
            }
        }
        static void Main(string[] args)
        {
            // 상속
            if (false)
            {
                Student kim = new Student("김기영", 12, 1234);
                kim.Intro();
                kim.Study();
            }
            // 상속의 관계에서 어디 속해져 있는지 확인 
            if (true)
            {
                MyGraduate Kim = new MyGraduate();
                MyAssistant Lee = new MyAssistant();
                MyProfessor Park = new MyProfessor();
                MySuwi Choi = new MySuwi();

                Register(Kim);
                Register(Lee);
                Register(Park);
                Register(Choi);
            }
        }
    }
}
