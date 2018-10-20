using System;
using System.IO;
using Newtonsoft.Json;
using Models.Entities;
using Factories;
using Services;

namespace Controllers
{
    public class BallController
    {
        private BallFactory _factory;

        private ConsoleHandler _console;

        public BallController(
            BallFactory factory, ConsoleHandler console
        ) {
            _factory = factory;
            _console = console;
        }

        public void Play()
        {
            var ball = _factory.GetBall();

            _console.Write(ball.ToString());
            var key = _console.Read();
            if (key.KeyChar == ' ') 
            {
                _console.Write("Smash");
            }
        }
    }
}