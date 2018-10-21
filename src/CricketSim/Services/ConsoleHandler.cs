using System;
using System.IO;

namespace Services
{
    public class ConsoleHandler : IConsoleHandler
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