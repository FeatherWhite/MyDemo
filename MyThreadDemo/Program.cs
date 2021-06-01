using System;
using System.Threading;

namespace MyThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            t.Start();
            for (var i = 0; i < 100; i++)
            {
                Console.Write("x");
            }
        }
        static void WriteY()
        {
            for (var i = 0; i < 100; i++)
            {
                Console.Write("y");
            }
        }
    }
}
