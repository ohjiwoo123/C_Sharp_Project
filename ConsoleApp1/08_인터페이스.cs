using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // C++ 에서 클라스의 모든 것이 다 순수가상함수일 경우 == Interface 
    interface IUnit 
    {
        void Move(int x, int y);
        void Attack(int x, int y);
        void Die();
        int Energy { get; } // 프로퍼티 , 읽기 전용 
    }

    class Marine: IUnit
    {
        public void Move(int x, int y) { Console.WriteLine("부릉부릉"); }
        public void Attack(int x, int y) { Console.WriteLine("두두두두"); }
        public void Die() { Console.WriteLine("꽥"); }
        private int Life = 100;
        public int Energy { get { return Life; } }
    }
    internal class _08_인터페이스
    {
        static void Main(string[] args)
        {

        }
    }
}
