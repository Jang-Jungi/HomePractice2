using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex9_1
    {
        // 1. 이중 포문을 이용하여 출력
        static void Main26(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == j) { Console.Write(i); }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

    class Ex9_2
    {
        // 2. 이중 포문을 이용하여 출력
        static void Main27(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i==j){Console.Write("@");}
                    else { Console.Write("$"); }
                }
                Console.WriteLine();
            }
        }
    }

    class Ex9_3
    {
        // 3. 이중 포문을 이용하여 출력
        static void Main28(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= j) Console.Write("$");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
