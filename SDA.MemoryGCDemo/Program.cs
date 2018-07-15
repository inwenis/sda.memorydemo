using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.MemoryGCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Console.WriteLine("Press [enter] to exit");
            Console.ReadLine();
        }

        private static void Test1()
        {
            var list = new List<BigClass>();
            while (true)
            {
                var objects = Create1024Objects();
                list.AddRange(objects);
                var megabytes = list.Count / 1024;
                Console.WriteLine("using " + megabytes + " MB");
                var consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.E)
                {
                    break;
                }
            }
        }

        private static void Test2()
        {
            var list = new List<BigClass>();
            while (true)
            {
                var objects = Create1024Objects();
                list.AddRange(objects);
                var megabytes = list.Count / 1024;
                Console.WriteLine("using " + megabytes + " MB");
                var consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }

        private static IEnumerable<BigClass> Create1024Objects()
        {
            var array = new BigClass[1024];
            for (int i = 0; i < 1024; i++)
            {
                array[i] = new BigClass();
            }
            return array;
        }
    }

    class BigClass
    {
        private byte[] _bytes;

        public BigClass()
        {
            _bytes = new byte[1024];
        }
    }
}
