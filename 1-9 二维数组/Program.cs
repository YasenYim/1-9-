using System;

namespace _1_9_二维数组
{
    class Program
    {
        static void PrintArray2d(int[,] a2d)
        {
            for(int i = 0;i<a2d.GetLength(0);i++)
            {
                for (int j= 0;j<a2d.GetLength(1);j++)
                {
                    Console.Write(a2d[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // 1. 初始化
            int[,] array2d = new int[4, 5];
            // int[,] map = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            array2d[0, 0] = 5;
            array2d[3, 4] = 99;

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = i * array2d.GetLength(1) + j;
                }
            }

            //Console.WriteLine(array2d[0, 0]);
            PrintArray2d(array2d);

            Console.ReadKey();
        }
    }
}
