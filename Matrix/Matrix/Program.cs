using System;
using System.Text;

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
                    Console.Write("{0,6}", matr[row, col]);
                }
            }
        }
        static void PrintMatr(uint[,] matr)
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
            Console.OutputEncoding = Encoding.UTF8;
            Task5();
            Task4();
            Task3();
            Task2();
            Task1();            
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
        
        static void Task3()
        {
            char[][][] ch = {
                new char[][] {   new char[] { 'a', 'b' },
                                 new char[] { 'c', 'd' },
                                 new char[] { 'e','f'} },
                 new char[] []{  new char[] { 'g','h','i'},
                                 new char[] { 'j','k'} },
                  new char[][] { new char[] {'l','m' }, new char[] { 'n','o'}  },
                  new char[][] { new char[] {'p','q' }, new char[] { 'r','s'}  },
            };
            Console.WriteLine("RAnk " + ch.Rank);
            Console.WriteLine("ch[0] rank "+ch[0].Rank);
            Console.WriteLine("ch[0][0] rank " + ch[0][0].Rank);
            Console.WriteLine("Type " + ch.GetType());
            Console.WriteLine("ch[1][2][3] " +ch[1][1][1]);
            Console.WriteLine("lenth" +ch.Length);
            Console.WriteLine("lenth(0)" +ch.GetLength(0));
            Console.WriteLine(ch[1].GetLength(0) + " __ch[1].GEt lenth(0)" );
            Console.WriteLine(ch[1][0].GetLength(0));

            foreach(char[][] memb1 in ch)
            {
                Console.WriteLine("Level 1:");
                foreach(char[] memb2 in memb1)
                {
                    Console.Write("\tLevel 2:\t");
                    foreach(char memb3 in memb2)
                    {
                        Console.Write("{0,3}", memb3);
                    }
                    Console.WriteLine();
                }
            }
           
        }
        
        static void Task4()
        {
            do
            {
                uint N, M;
                do Console.Write("N=");
                while (!uint.TryParse(Console.ReadLine(), out N)|| N==0);
                do Console.Write("M=");
                while (!uint.TryParse(Console.ReadLine(), out M)|| M==0);
                var matrix = new int[N, M];
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < M; j++)
                        matrix[i, j] = (i + 1) * (2 * j + 1);

                
                Console.WriteLine("Rank: "+matrix.Rank);
                Console.WriteLine("Length: "+matrix.Length);
                PrintMatr(matrix);
                Console.WriteLine("Esc for exit");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        static void Task5()
        {

        }

    }
}
