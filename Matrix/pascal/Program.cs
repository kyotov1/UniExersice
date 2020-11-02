using System;

namespace pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Task();
            int n;
            do Console.Write("Enter n");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            int[][] pascal = new int[n][];


            //
            for (int i = 0; i < n; i++)
            {
                pascal[i] = new int[i + 1];
            }
            pascal[0][0] = 1;
            pascal[1][0] = 1;
            pascal[1][1] = 1;
            //
            for (int i = 2; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j || j == 0)
                    {
                        pascal[i][j] = 1;
                    }
                    else
                    {
                        pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                    }

                }
            }

            for (int i = 0; i < n; i++)
            {

                Console.Write(" ".PadLeft((n - i - 1) * 3));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0,6}", pascal[i][j]);
                }
                Console.WriteLine();
            }

        }
        static void Task()
        {
            int n;
            do Console.Write("Enter n");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            int num = 1;
           
            var arr = new int[n, n];
            for (int col = 0; col < n; col++)
            {
                if (col %2!=0)
                {
                    for (int row = 0; row < n; row++)
                    {

                        arr[row, col] = num++;

                    }
                }
                else
                {
                    for (int row = n-1; row >= 0; row--)
                    {

                        arr[row, col] = num++;
                        
                    }
                }
                 
            }
            for (int col = 0; col < n; col++, Console.WriteLine())
            {
                for (int row = 0; row < n; row++)
                {

                    Console.Write("{0,3}", arr[col, row] );

                }
            }
        }
        static void Task1()
        {
            int n;
            do Console.Write("Enter n: ");
            while (!int.TryParse(Console.ReadLine(), out n));
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                }
            }
        }
    }

}
