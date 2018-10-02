using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //если не нужно передавать параметры
            //делегать без параметров
            ThreadStart threadStart = new ThreadStart(Method);
            //поток
            Thread thread = new Thread(threadStart);
            //запуск потока
            thread.Start();

            for(int i=0;i<1000;i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("hello in main");
            }
            Console.ReadLine();
        }

        private static void Method()
        {
            for(int i=0;i<1000;i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("\t\tHello in thread");
            }
            
        }
    }
}
