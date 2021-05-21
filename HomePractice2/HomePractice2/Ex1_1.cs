using System;

namespace HomePractice2
{
   
    class Ex1_1
    {
        // 1.시간을 입력 받아 시간과 분으로 출력하는 프로그램을 작성하시오.

        static void Main1(string[] args)
        {
            Console.WriteLine("값을 입력하세요");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            int hour = number / 60;
            int minute = number % 60;
            Console.WriteLine($"{hour}시간 {minute}분");
        }
    }
    class Ex1_2
    {
        // 2.숫자 1개를 읽어 들여 짝수이면 Even number라고 출력되고 홀수이면  Odd number라고 출력되게 프로그램을 작성하라

        static void Main2(string[] args)
        {
            Console.WriteLine("숫자을 입력하세요");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number % 2 == 0) { Console.WriteLine($"{input}은 짝수입니다."); }
            if (number % 2 == 1) { Console.WriteLine($"{input}은 홀수입니다."); }
        }
    }

    class Ex1_3
    {
        // 3.두 개 정수를 읽어 들여 두 개 중 큰 수를 화면으로 출력하는 프로그램을 작성하시오
        static void Main3(string[] args)
        {
            Console.WriteLine("숫자 1개를 입력하세요");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("숫자 1개 더 입력하세요");
            int number2 = Int32.Parse(Console.ReadLine());

            if (number1 > number2) { Console.WriteLine($"{number1}(이)가 더 큽니다."); }
            else if (number1 < number2) { Console.WriteLine($"{number2}(이)가 더 큽니다."); }
            else { Console.WriteLine($"{number1}과 {number2}는 같습니다."); }
        }
    }
}
