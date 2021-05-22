using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePractice2
{
    class Ex11_1
    {
        // 1. 2차원 배열 원하는 곳 덧셈
        static void Main31(string[] args)
        {
            int[,] arr = new int[5, 5]; // 행5, 열5의 배열생성
            int num = 1;
            for (int i = 0; i < arr.GetLength(0); i++) // 행
            {
                for (int j = 0; j < arr.GetLength(1); j++) // 열
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
                    if (i == j )
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"선택 영역의 합은 : {sum}");
        }
    }
    class Ex11_2
    {
        // 2. 2차원 배열 원하는 곳 덧셈
        static void Main32(string[] args)
        {
            int[,] arr = new int[5, 5]; // 행5, 열5의 배열생성
            int num = 1;
            for (int i = 0; i < arr.GetLength(0); i++) // 행
            {
                for (int j = 0; j < arr.GetLength(1); j++) // 열
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
                    if (!((i >= 1 && i <= 3) && (j >= 1 && j <= 3)))
                        sum += arr[i, j];
                }
            }
            Console.WriteLine($"선택 영역의 합은 : {sum}");
        }
    }
    class Ex11_3
    {
        // 3. 2차원 배열 원하는 곳 덧셈
        static void Main44(string[] args)
        {
            int[,] arr = new int[5, 5]; // 행5, 열5의 배열생성
            int num = 1;
            for (int i = 0; i < arr.GetLength(0); i++) // 행
            {
                for (int j = 0; j < arr.GetLength(1); j++) // 열
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
                    if (i%2==0)
                        sum += arr[i, j];
                }
            }
            Console.WriteLine($"선택 영역의 합은 : {sum}");
        }
    }
}
