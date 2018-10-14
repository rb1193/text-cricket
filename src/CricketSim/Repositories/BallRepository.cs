using System;
using Newtonsoft.Json;
using Models;
using Services;

namespace Repositories
{
    public class BallRepository
    {
        private JsonSerializer _serializer;

        private FileHandler _fileHandler;

        private string filePath = "locale/en_EN/ball.json";

        public Ball Ball {
            get {
                using (var json = _fileHandler.Open(filePath)) {
                    return (Ball)_serializer.Deserialize(json, typeof(Ball));
                }
            }
        }

        public BallRepository(JsonSerializer serializer, FileHandler fileHandler)
        {
            _serializer = serializer;
            _fileHandler = fileHandler;
        }
    }
}