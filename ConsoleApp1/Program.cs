using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Method);
            Thread thread1 = new Thread(threadStart);
            thread1.Priority = ThreadPriority.Highest;
            thread1.Start("One thread" as object);
            Thread thread2 = new Thread(threadStart);
            thread2.Priority = ThreadPriority.Lowest;
            thread2.Start("\t\tTwo thread" as object);
            Console.ReadKey();
        }

        private static void Method(object obj)
        {
            string param = obj as string;
            for (int i=0;i<100;i++)
            {
                Thread.Sleep(200);
                Console.WriteLine(param);
            }
        }
    }
}
