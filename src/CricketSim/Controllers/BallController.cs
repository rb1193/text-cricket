using System;
using System.IO;
using Newtonsoft.Json;
using Models;

namespace Controllers
{
    public class BallController
    {
        private StreamReader ballConfig = File.OpenText("locale/en_EN/ball.json");
        private Ball ball;
        private JsonSerializer serializer = new JsonSerializer();

        public string LoadBall()
        {
            using (ballConfig) {
                ball = (Ball)serializer.Deserialize(ballConfig, typeof(Ball));
            }
            return ball.Prompt;
        }

        public string PlayBall()
        {
            var key = Console.ReadKey(true);
            if (key.KeyChar == ' ') 
            {
                return ball.Result;
            }
            return null;
        }
    }
}