using System;
using System.IO;
using Newtonsoft.Json;
using Models;
using Repositories;
using Services;

namespace Controllers
{
    public class BallController
    {
        private BallRepository _repo;

        private ConsoleHandler _console;

        private JsonSerializer _serializer;

        public BallController(
            BallRepository repo, ConsoleHandler console, JsonSerializer serializer
        ) {
            _repo = repo;
            _console = console;
            _serializer = serializer;
        }

        public void Play()
        {
            Ball ball = JsonConvert.DeserializeObject<Ball>(_repo.Ball);

            _console.Write(ball.Prompt);
            var key = _console.Read();
            if (key.KeyChar == ' ') 
            {
                _console.Write(ball.Result);
            }
        }
    }
}