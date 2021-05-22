using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex12_1
    {
        // 1. 2차원 배열 원하는 곳 덧셈
        static void Main34(string[] args)
        {
            int[,] arr = new int[5, 5];
            int num = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = num;
                    Console.Write($"{arr[i, j]}\t");
                    num++;
                }
                Console.WriteLine();
            }
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                        sum += arr[i, j];
                }
            }
            Console.WriteLine($"선택 영역의 합은 : {sum}");
        }
    }
    class Ex12_2
    {
        // 2. 2차원 배열 원하는 곳 덧셈
        static void Main35(string[] args)
        {
            int[,] arr = new int[5, 5];
            int num = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = num;
                    Console.Write($"{arr[i,j]}\t");
                    num++;
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i+j)%2==0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"선택 영역의 합은 : {sum}");

        }
    }
    class Ex12_3
    {
        // 3. 2차원 배열 원하는 곳 덧셈
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            int num = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0;  j < arr.GetLength(1);  j++)
                {
                    arr[i, j] = num;
                    Console.Write($"{arr[i, j]}\t");
                    num++;
                }
                Console.WriteLine();
            }
            
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        sum += arr[i, j];
                    }
                    if (((i + j) == 4))
                    {
                        sum += arr[i, j];
                    }
                }
            }
            sum = sum - arr[2, 2];
            Console.WriteLine($"합계는 {sum}");
        }

    }
}