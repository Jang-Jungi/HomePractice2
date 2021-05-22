using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex5_1
    {
        // 1. 숫자 10부터 1까지 거꾸로 출력하는 프로그램을 작성하라.
        static void Main14(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{ i}");
            }
        }
    }
    class Ex5_2
    {
        // 2. 2의 5승 값을 구하는 프로그램 작성
        static void Main15(string[] args)
        {
            int Exp = 1;
            for (int i = 1; i <= 5; i++)
            {
                Exp = Exp * 2;
            }
            Console.WriteLine($"2의 5승은 {Exp}");
        }
    }
    class Ex5_3
    {
        // 3. 7!=7*6*5*4*3*2*1을 만들어라
        static void Main16(string[] args)
        {
            int Fac = 1;
            for (int i = 1; i <= 7; i++)
            {
                Fac = Fac * i;
            }
            Console.WriteLine($"7!={Fac}");
        }
    }
}
