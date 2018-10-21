using System;
using System.IO;

namespace Services
{
    public class FileHandler : IFileHandler
    {
        public StreamReader Open(String path)
        {
            return File.OpenText(path);
        }
    }
}