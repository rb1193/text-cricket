using System;
using System.IO;

namespace Services
{
    public class ConsoleHandler
    {
        public ConsoleKeyInfo Read()
        {
            return Console.ReadKey(true);
        }

        public void Write(String text)
        {
            Console.WriteLine(text);
        }
    }
}