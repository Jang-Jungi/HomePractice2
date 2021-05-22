using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex4_1
    {
        // 1. 1~30까지의 수 중 3의 배수의 합계를 구하라
        static void Main11(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine($"1~30까지 3의 배수의 합계는 {Sum} 입니다.");
        }
    }

    class Ex4_2
    {
        // 2. 1~5까지의 수의 곱을 구하는 프로그램을 작성하라
        static void Main12(string[] args)
        {
            int Multiple = 1;
            for (int i = 1; i <= 5; i++)
            {
                Multiple *= i;
            }
            Console.WriteLine($"1~5까지 곱은 {Multiple} 입니다.");
        }
    }

    class Ex4_3
    {
        // 3. 1~50까지의 수 중 3의 배수와 7의 배수의 합을 구하라
        static void Main13(string[] args)
        {
            int sum3 = 0;
            int sum7 = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i%3==0)
                {
                    sum3 += i;
                }
                
                if (i % 7 == 0)
                {
                    sum7 += i;
                }
            }
            Console.WriteLine($"3의 배수의 합 {sum3}");
            Console.WriteLine($"7의 배수의 합 {sum7}");
        }
    }
}
