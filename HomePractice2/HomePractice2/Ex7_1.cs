using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex7_1
    {
        // 1. 1~100까지의 수중 5의 배수의 합과 7의 배수의 합을 구해 둘 중 더 큰 값을 출력하는 프로그램
        static void Main20(string[] args)
        {
            int sum5 = 0;
            int sum7 = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i%5==0){ sum5 += i; } 
                if (i%7==0){ sum7 += i; }
            }
            Console.WriteLine($"5의 배수의 합은{sum5}");
            Console.WriteLine($"7의 배수의 합은{sum7}");
            if (sum5<sum7) {Console.WriteLine($"5의 배수와 7의 배수 중 큰 값은{sum7}");}
            else if (sum5>sum7) {Console.WriteLine(($"5의 배수와 7의 배수 중 큰 값은{sum5}"));}
            else {Console.WriteLine("같습니다."); }
        }
    }
    class Ex7_2
    {
        // 2. 1+2+3+...+n 까지의 합이 500을 넘는 최초의 n과 n까지의 합을 구하는 프로그램
        static void Main21(string[] args)
        {
            int nsum = 0;
            int n = 0;
            while(nsum<500) // 부호가 반대라고 생각이 들지만 아님 0에서 끝나버림
            {
                n++;
                nsum += n;
            }
            Console.WriteLine($"n : {n}, 합은 : {nsum}");
        }
    }
    class Ex7_3
    {
        // 3. 두 정수를 입력받아 입력받은 수들의 최대값을 구하는 프로그램
        static void Main22(string[] args)
        {
            Console.WriteLine("숫자 두개를 입력하세요. 더 큰 값을 보여줍니다.");
            int input = int.Parse(Console.ReadLine());          
            int max = 0;
            while (input > max)
            {
                max = input;
                max = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"최댓값은 {max}");
        }
    }
}
