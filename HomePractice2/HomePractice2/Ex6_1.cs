using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex6_1
    {
        // 1. Y = 1!+2!+3!+4!+5!을 구현하라
        static void Main17(string[] args)
        {
            int fact = 1;
            int factsum = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    fact *= j;
                }
                Console.Write($"{fact}\t");
                factsum += fact;
                fact = 1;
            }
            Console.WriteLine($"Y = 1!+2!+3!+4!+5! = {factsum}");
        }
    }
    class Ex6_2
    {
        // 2. 1~500까지 수를 더하는 과정에서 100단위마다 누적된 수의 합을 출력하는 프로그램
        static void Main18(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i <= 500; i++)
            {
                Sum += i;
                if (i%100==0) { Console.WriteLine(Sum); }    
            }
            
        }
    }
    class Ex6_3
    {
        // 3. 1x2+2x3+3x4+...+11x12 구현하라
        static void Main19(string[] args)
        {
            int MultipleSum = 0;
            for (int i = 1; i <= 11; i++)
            {
                MultipleSum += i * (i + 1);
            }
            Console.WriteLine($"1x2+2x3+3x4+...+11x12 = {MultipleSum}");
        }
    }
}
