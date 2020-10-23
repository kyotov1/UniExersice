using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {


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
        }
    }
}
