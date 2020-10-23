using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniExercise
{
    class Program
    {
        double proba;
        void print()
        {

            Console.WriteLine(proba);
        }
       
        
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            
            ConsoleKeyInfo keyToExit;
            double a, // first number
                b; // second number
                   // 2.1 Ввод
            do
            {
                Console.Write("Введите число a: ");
                double.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите число b: ");
                double.TryParse(Console.ReadLine(), out b);
                // 2.2 Обработка
                double geomMean = Math.Sqrt(a * b);
                // 2.3 Вывод
                Console.WriteLine("Среднее геометрическое равно: " + geomMean);
                // 2.4 Эпилог
                Console.WriteLine("Для выхода нажмите Escape....");
                keyToExit = Console.ReadKey();
            } while (keyToExit.Key != ConsoleKey.Escape);
            a = int.Parse(Console.ReadLine());
            var result = (a < b) ? "correct" : "ERROR";
            Console.WriteLine(result);
            Type type;

        }
        static void StringFormat()
        {
            int a = 3;
            double b = 0.5;

            Console.WriteLine("C: " + (2.0 / 3).ToString("C"));
            // Console.WriteLine("E: " + (5.0 / 3).ToString("D"));
            Console.WriteLine("E: " + (2.0 / 3).ToString("E"));
            Console.WriteLine("F: " + (2.0 / 3).ToString("F"));
            Console.WriteLine("G: " + (2.0 / 3).ToString("G"));
            Console.WriteLine("N: " + (2.0 / 3).ToString("N3"));
            Console.WriteLine("P: " + (2.0 / 3).ToString("P8"));
            Console.WriteLine("R: " + (2.0 / 3).ToString("R"));
            Console.WriteLine("X: " + (255).ToString("X"));
            Console.WriteLine();
            Console.WriteLine("C: " + (10).ToString("C"));
            Console.WriteLine("E: " + (10).ToString("D8"));
            Console.WriteLine("E: " + (10).ToString("E"));
            Console.WriteLine("F: " + (10).ToString("F"));
            Console.WriteLine("G: " + (10).ToString("G"));
            Console.WriteLine("N: " + (10000).ToString("N3"));
            Console.WriteLine("P: " + (10).ToString("P8"));
            Console.WriteLine("R: " + (10.0).ToString("R"));
            Console.WriteLine("X: " + (10).ToString("X"));
        }
    }
}
