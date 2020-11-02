using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace Classes
{
    class Program
    {
       static string pa = @"http://ww17.kiril.com";
        static void Main(string[] args)
        {

            var uri = new Uri("http://ww17.kiril.com");
            
            string path = uri.AbsolutePath;
            var scheme = uri.Scheme;
            var port =uri.Port;
           
            Console.WriteLine(port);
            if (scheme == Uri.UriSchemeHttp || scheme == Uri.UriSchemeHttps)                ;
            Console.WriteLine(scheme);
            if(path.Length<=1)
                path="no path";
            Console.WriteLine(path);

            
            Console.ReadLine();
        }
        static void Task1()
        {

        }
    }
}
