using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex3_1
    {
        // 1. 1~10까지 수의 합계를 구하는 프로그램을 작성하세요

        static void Main7(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i <= 10; i++) { Sum += i; }
            Console.WriteLine($"1~10까지 합계는 { Sum } 입니다.");
        }
    }
    class Ex3_2
    {        
        // 2. 1~10까지의 수 중 짝수의 합을 구하라

        static void Main8(string[] args)
        {
            int Sum1 = 0;
            for (int i = 1; i <= 10; i++) { if (i%2==0) {Sum1 += i;} }
            Console.WriteLine($"1~10까지 짝수의 합계는 { Sum1 } 입니다.");
        }

    }
    class Ex3_3
    {
        // 3. 1~10까지의 수 중 홀수의 합을 구하라

        static void Main9(string[] args)
        {
            int Sum2 = 0;
            for (int i = 1; i <= 10; i++) { if (i % 2 == 1) { Sum2 += i; } }
            Console.WriteLine($"1~10까지 홀수의 합계는 { Sum2 } 입니다.");
        }

    }
    class Ex3_4
    {
        // 4. 1~50까지의 숫자들의 평균을 구하라

        static void Main(string[] args)
        {
            int Sum3 = 0;
            for (int i = 1; i <= 50; i++)
            { Sum3 += i; }
            double avg = Sum3 / 50;
            Console.WriteLine($"1~50까지의 숫자들의 평균은 { avg } 입니다.");
        }

    }
}
