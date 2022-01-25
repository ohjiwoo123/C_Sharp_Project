using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// BCL Base Class Library , C++의 STL Standard Template Library
// Array List , List<T> , Queue, Stack
    
namespace ConsoleApp1
{
    internal class _09_컬렉션_inBCL
    {
        static void Main(string[] args)
        {
            // ArrayList
            if (false)
            {
                ArrayList ar = new ArrayList(10);
                ar.Add(1);
                ar.Add(3.14);
                ar.Add("홍길동");
                ar.Add(new DateTime(2021, 1, 25));
                ar.Insert(1, 100);
                foreach (var i in ar)    // int 대신 var 가능 (var는 타입을 알아서 정해줌), object도 가능
                {
                    Console.WriteLine(i);
                }

                for (int i = 0; i<ar.Count;i++)
                {
                    Console.WriteLine(ar[i]);
                }


                Console.WriteLine("개수 :" + ar.Count);
                Console.WriteLine("용량 :" + ar.Capacity);

                Console.WriteLine("-------------------------------");
            }
            if (false)
            {
                ArrayList ar = new ArrayList(10);
                ar.Add("이승만");
                ar.Add("박정희");
                ar.Add("최규하");
                ar.Add("전두환");
                ar.Add("노태우");
                ar.Add("김영삼");
                ar.Add("김대중");
                ar.Add("노무현"); 
                ar.Add("이명박");
                ar.Add("박근혜");
                ar.Add("문재인");

                Console.WriteLine("-------------------------------");

                foreach (object o in ar)
                {
                    Console.Write(o + ",");
                }
                ar.Sort();
                foreach (object o in ar)
                {
                    Console.Write(o + ",");
                }
                Console.WriteLine("-------------------------------");

                

                Console.WriteLine("-------------------------------");

                ar.Reverse();
                foreach (object o in ar)
                {
                    Console.Write(o + ",");
                }
            }

            // 2. List<T>   // <> 모형자, 템플릿
            if (false)
            {
                List<string> ar = new List<string>(10);
                ar.Add("유재석");
                ar.Add("박명수");
                ar.Add("하하");

                foreach (object o in ar) Console.Write(o + ",");
                Console.WriteLine();
            }

            // 3. Stack
            if (true)
            {
                Stack st = new Stack();

                st.Push(1);
                st.Push(2);
                st.Push(3);
                st.Push("four");
                // Console.WriteLine(st[0]);
                // Console.WriteLine(st.Pop());


                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(st.Pop());
                }
            }
            // 4. Queue
            if (true)
            {
                Queue qu = new Queue();

                qu.Enqueue(1);
                qu.Enqueue(2);
                qu.Enqueue(3);
                qu.Enqueue("four");
                // Console.WriteLine(st[0]);
                Console.WriteLine(qu.Dequeue());

            }
        }
    }
}
