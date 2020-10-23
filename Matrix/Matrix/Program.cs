using System;

namespace Matrix
{
    class Program
    {
        static void PrintMatr(int[,] matr)
        {
            for (int row = 0; row < matr.GetLength(0); row++, Console.WriteLine())
            {

                for (int col = 0; col < matr.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matr[col, row]);
                }
            }
        }
        static void Main(string[] args)
        {


            Task1();
            Task2();
        }
        /// <summary>
        /// Матрицы. Индексы элементов матриц
        /// </summary>
        static void Task1()
        {
            var matr = new int[3, 4] { { 0, 1, 3, 4 }, { 5, 6, 7, 8 }, { 9, -1, -2, -3 } };
            Console.WriteLine("Martrix rank " + matr.Rank);
            Console.WriteLine("All elements " + matr.Length);
            Console.WriteLine("Matrix type" + matr.GetType());
            Console.WriteLine("Matrix is fixedSize" + matr.IsFixedSize);
            Console.WriteLine("GetLenth(1) " + matr.GetLength(1));
            Console.WriteLine("GetLenth(0)" + matr.GetLength(0));
            Console.WriteLine("GetUpperBounr(0)" + matr.GetUpperBound(1));
            for (int i = 0; i < matr.GetLength(0); i++, Console.WriteLine())
            {
                for (int k = 0; k < matr.GetLength(1); k++)
                {
                    Console.Write("{0,3}", matr[i, k]);
                }
            }
        }
        /// <summary>
        /// Matrix from 1 to n, and every rol stars with upper +1
        /// </summary>
        static void Task2()
        {
            int N;
            do Console.Write("Write N");
            while (!int.TryParse(Console.ReadLine(), out N));
            var matr = new int[N, N];
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    matr[col, row] = (col + row) % N + 1;
                }
            }
            PrintMatr(matr);
        }
    }
}
