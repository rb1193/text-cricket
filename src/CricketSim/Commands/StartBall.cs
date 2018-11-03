using System;
using System.IO;
using Models.Entities;
using Factories;
using Services;

namespace Commands
{
    public class StartBall
    {
        private IBallFactory _factory;

        private IConsoleHandler _console;

        public StartBall(
            IBallFactory factory,
            IConsoleHandler console
        ) {
            _factory = factory;
            _console = console;
        }

        public void Execute()
        {
            Ball ball = _factory.MakeBall();

            _console.Write(ball.ToString());
            ConsoleKeyInfo key = _console.Read();
            if (key.KeyChar == ' ') 
            {
                _console.Write("Smash");
            }
        }
    }
}