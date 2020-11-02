using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace Classes
{
    class Program
    {
        public void Count(int inVal)
        {
            Console.WriteLine("Вход: {0}", inVal);
            if (inVal == 0) return; 
            Count(inVal - 1); // Рекурсивный вызов
            Console.WriteLine("Выход: {0}", inVal);
        }

            long AddValues(long a, long b) { return a + b; }
     
        static string pa = @"http://ww17.kiril.com";
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Count(3);
            int time = Hour();
            Console.WriteLine(rnd());
            Console.WriteLine(Hour());
            /*
            var uri = new Uri("http://ww17.kiril.com");
            
            string path = uri.AbsolutePath;
            var scheme = uri.Scheme;
            var port =uri.Port;
           
            Console.WriteLine(port);
            if (scheme == Uri.UriSchemeHttp || scheme == Uri.UriSchemeHttps)                ;
            Console.WriteLine(scheme);
            if(path.Length<=1)
                path="no path";
            Console.WriteLine(path);*/

            
            Console.ReadLine();
        }
        static void Task1()
        {
            Console.WriteLine(  );
            Console.WriteLine();
        }
        static int Hour()
        {
            DateTime dt = DateTime.Now;
            return dt.Hour;
        }
        static Random rnd()
        {
            return new Random();
        }

    }
}
