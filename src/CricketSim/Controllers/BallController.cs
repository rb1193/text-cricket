using System;
using System.IO;
using Repositories;
using Services;

namespace Controllers
{
    public class BallController
    {
        private BallRepository _repo;

        private ConsoleHandler _console;

        public BallController(BallRepository repo, ConsoleHandler console)
        {
            _repo = repo;
            _console = console;
        }

        public void Play()
        {
            var ball = _repo.Ball;

            _console.Write(ball.Prompt);
            var key = _console.Read();
            if (key.KeyChar == ' ') 
            {
                _console.Write(ball.Result);
            }
        }
    }
}