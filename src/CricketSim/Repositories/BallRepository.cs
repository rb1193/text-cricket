using System;
using System.IO;
using Models;
using Services;

namespace Repositories
{
    public class BallRepository
    {
        private FileHandler _fileHandler;

        private string filePath = "locale/en_EN/ball.json";

        public string Ball {
            get {
                using (StreamReader stream = _fileHandler.Open(filePath)) {
                    return stream.ReadToEnd();
                }
            }
        }

        public BallRepository(FileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }
    }
}