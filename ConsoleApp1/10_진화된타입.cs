using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MySocket
    {
        public string IP;
        public int Port;
    }
    internal class _10_진화된타입
    {
        static public MySocket GetSocket()
        {
            MySocket a = new MySocket();
            a.IP = "192.168.1.11";
            a.Port = 5000;
            return a;
        }

        static public void GetSocketRef(ref string ip, ref int port)
        //static public void GetSocketRef(string &ip, int &port) // c++
        {
            ip = "192.168.1.22";
            port = 5000;
        }

        static public void GetSocketOut(out string ip, out int port)
        {
            ip = "192.168.1.33";
            port = 5000;
        }

        static void Main(string[] args)
        {
            // 두 개의 리턴을 받기
            if(false)
            {
                // 1. 구조체 1개로 받기
                MySocket sock = GetSocket(); // IP, Port
                Console.WriteLine($"주소={sock.IP}, 포트는 = {sock.Port}");

                // 2. argument로 되돌려 받기 
                string IP = "0";
                int port =0;
                GetSocketRef(ref IP, ref port);
                Console.WriteLine($"주소={IP}, 포트는 = {port}");

                // 3. out 키워드 사용하여 받기 
                string IP1="";
                int port1 =0;
                GetSocketOut(out IP1,out port1);
                Console.WriteLine($"주소={IP1}, 포트는 = {port1}");
            }
            // C#의 튜플 지원
            if(true)
            {
                var yoon = ( "독립군", "윤봉길",24 );
                Console.WriteLine(yoon);
                Console.WriteLine(yoon.Item1);
                Console.WriteLine(yoon.Item2);
                Console.WriteLine(yoon.Item3);
                Console.WriteLine("--------------------------------");

                var kim = (Name: "윤봉길", Age: 24);
                Console.WriteLine(kim);
                Console.WriteLine(kim.Item2);
                Console.WriteLine(kim.Item1);
                Console.WriteLine(kim.Item2);
                Console.WriteLine(kim.Name);
                Console.WriteLine(kim.Age);
                Console.WriteLine("--------------------------------");

                int Age = 24;
                string Name = "이봉길";
                var lee = (Age, Name);
                Console.WriteLine(lee);
                Console.WriteLine(lee.Name);
                Console.WriteLine(lee.Age);
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
