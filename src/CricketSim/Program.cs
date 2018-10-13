using System;
using System.IO;
using Controllers;

namespace CricketSim
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayBall();
        }

        private static void PlayBall()
        {
            var ball = new BallController();
            Console.WriteLine(ball.LoadBall());
            Console.WriteLine(ball.PlayBall());
        }

    }
}
