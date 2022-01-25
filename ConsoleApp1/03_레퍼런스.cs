using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// /////////////////////////////////////////////
/// 레퍼런스 (=참조 =별명)
/// - 값과 참조의 차이점 
/// : 데이터가 저장되는 메모리 위치
/// 
/// 1. 메모리가 할당되는 시점이 다르다.
/// - 값 타입은 선언 즉시 스택에 생성되어 바로 사용할 수 있다.
/// - 참조타입은 선언에 의해 참조 변수만 만들 뿐,
/// 데이터를 저장할 메모리는 아직 없어 new 연산자로 할당해야 한다.
/// 
/// 2. 변수가 파괴되는 시기가 다르다.
/// - 값 타입은 소속 메서드나 객체가 사라질 때, 같이 파괴 된다.
/// - 참조 타입은 더 이상 참조하는 변수가 없을 때, 가비지 컬렉터에 의해 파괴 된다.
/// 
/// 3. 같은 타입의 변수로 대입할 때의 효과가 다르다.
/// - 값 타입은 별개의 변수가 생성되어 독립적인 사본이 된다.(복사)
/// - 참조 타입은 참조자만 늘어날 뿐 메모리가 새로 할당 되는 것이 아니다.
/// 즉 한 쪽을 변경하면 다른 쪽도 같이 바뀐다.
/// </summary>

namespace ConsoleApp1
{
    internal class _03_레퍼런스
    {   
        static void Main(string[] args)
        {
            // Copy Value
            if (false)
            {
                int value = 3; // 값 변수
                int vcopy;
                vcopy = value;  // 레퍼런스 변수 , 값의 복사가 일어남.
                vcopy = 4;
                Console.WriteLine($"value={value},vcopy={ vcopy}");

                int[] ar, arCopy;
                ar = new int[] { 1, 2, 3, 4, 5 };   // new = c의 malloc 
                arCopy = ar;    // 메모리 참조 (한 놈이 변하면 다른 한놈도 변한다.)
                arCopy[1] = 1234;
                Console.WriteLine($"ar[1]={ar[1]}, arCopy[1]={arCopy[1]}");
            }
            // Compare Value
            if (false)
            {
                int value = 3, vcopy = 4;
                // 삼항 연산자
                Console.WriteLine($"값 타입:" + (value == vcopy ? "같다" : "다르다"));

                int[] ar = { 1, 2, 3, 4, 5 };
                int[] arcopy = { 1, 2, 3, 4, 5 };
                // 내용을 비교하는 것이 아니라서 다르다라고 나옴 ( 주소x 레퍼런스o)
                Console.WriteLine("참조 타입:" + (ar == arcopy ? "같다" : "다르다"));
            }
            //Value in Ref
            if (false)
            {
                Pixel p1 = new Pixel(1, 2, 3);
                Pixel p2 = p1; // 복사 ? 참조 ?

                p2.Pos.x = 1234;
                p2.Color = 5678;
                p1.OutPixel();
                p2.OutPixel();
            }
            //CallType
            if(true)
            {
                CTime C = new CTime();
                C.hour = 9;

                STime S;
                S.hour = 9;

                method1(C);  // Call by reference
                method2(S); // Call by value (복사) 

                Console.WriteLine("클래스: " + C.hour);
                Console.WriteLine("구조체: " + S.hour);
            }
        }

        // CallType
        public static void method1(CTime t)
        {
            t.hour = 12;
        }

        public static void method2(STime t)
        {
            t.hour = 12;
        }

       
    }
    class Pixel
    {
        public int x, y;
        public int Color;
        public struct Position
        {
            public int x;
            public int y;
        }
        public Position Pos;

        public Pixel(int ax, int ay, int ac)
        {
            Pos.x = ax;
            Pos.y = ay;
            Color = ac;
        }
        public void OutPixel()
        {
            Console.WriteLine($"x={Pos.x},y={Pos.y},c={Color}");
        }
    }

    class CTime
    {
        public int hour;
    }
    struct STime
    {
        public int hour;
    }
}
