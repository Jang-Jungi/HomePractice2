using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex8_1
    {
        // 1. 이중 포문을 이용하여 출력
        static void Main23(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }
    }

    class Ex8_2
    {
        // 2. 이중 포문을 이용하여 출력
        static void Main24(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Ex8_3
    {
        // 3. 이중 포문을 이용하여 출력
        static void Main25(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j%2==1) {Console.Write("$");}
                    else { Console.Write("\\"); }
                }
                Console.WriteLine();
            }
        }
    }
}
