using System;
using System.IO;
using System.Resources;
using SimpleInjector;
using Newtonsoft.Json;
using Controllers;
using Factories;
using Services;

namespace CricketSim
{
    class Program
    {
        static readonly Container container;

        static Program() {
            container = new Container();

            container.Register<ConsoleHandler>(Lifestyle.Singleton);
            container.Register<FileHandler>(Lifestyle.Singleton);
            container.Register<JsonSerializer>(Lifestyle.Singleton);
            container.Register<RandomNumberGenerator>(Lifestyle.Singleton);
            container.Register<BallFactory>(Lifestyle.Singleton);
            container.Register<BallController>(Lifestyle.Singleton);

            container.Verify();
        }


        static void Main(string[] args)
        {
            var controller = container.GetInstance<BallController>();
            controller.Play();
        }
    }
}
