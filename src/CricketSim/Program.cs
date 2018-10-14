using System;
using System.IO;
using SimpleInjector;
using Newtonsoft.Json;
using Controllers;
using Repositories;
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
            container.Register<BallRepository>(Lifestyle.Singleton);
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
