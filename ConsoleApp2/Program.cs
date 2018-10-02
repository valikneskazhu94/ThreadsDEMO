using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            Console.WriteLine("Сейчас будет запущен поток!");
            t.Start();
            Thread.Sleep(200);
            //..
            //..
            //..
            //..
            Console.WriteLine("ожидаем завершения работы потока!");
            //t.Join();
            Console.WriteLine("завершение потока метода main!");
            Console.ReadKey();

        }

        private static void Method()
        {
            Console.WriteLine("поток начинает работать!");
            Thread.Sleep(2000);
            Console.WriteLine("поток завершает работу!");
        }
    }
}
