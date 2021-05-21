using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex2_1
    {
        // 1. 두 개 정수를 읽어 들여 같은 수이면 Same을 다른 수이면 Different를 출력하라
        static void Main4(string[] args)
        {
            Console.WriteLine("수를 하나 입력하세요");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("하나 더 입력하세요");
            int input2 = Int32.Parse(Console.ReadLine());

            if (input1==input2) {Console.WriteLine($"입력하신 두 수는 Same");}
            else {Console.WriteLine($"입력하신 두 수는 Different"); }
        }
    }
    class Ex2_2
    {
        // 2. 숫자 1개를 읽어 3의 배수, 5의 배수를 판별하라
        static void Main5(string[] args)
        {
            Console.WriteLine("숫자 하나를 입력하세요");
            int number1 = Int32.Parse(Console.ReadLine());

            if (number1 % 3 == 0)
            {
                if (number1 % 5 == 0)
                {
                    Console.WriteLine($"{number1}은 3과 5의 배수입니다.");
                    return;
                }
                Console.WriteLine($"{number1}은 3의 배수입니다.");
            }
            else if (number1 % 5 == 0)
            {
                Console.WriteLine($"{number1}은 5의 배수입니다.");
            }
            else Console.WriteLine($"{number1}은 3과 5의 배수가 아닙니다.");
        }
    }

    class Ex2_3
    {
        // 3. 숫자 1개를 읽어 1이면 spring, 2면 Summer, 3이면 Fall, 4이면 Winter  그 외는 wrong number
        static void Main6(string[] args)
        {
            Console.WriteLine("1~4까지 숫자를 입력하세요");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1: Console.WriteLine("Spring"); break;
                case 2: Console.WriteLine("Summer"); break;
                case 3: Console.WriteLine("Fall"); break;
                case 4: Console.WriteLine("Winter"); break;
                default: Console.WriteLine("wrong number"); break;
            }
        }
    }
}
