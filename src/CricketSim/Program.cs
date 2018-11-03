using System;
using System.IO;
using System.Resources;
using SimpleInjector;
using Newtonsoft.Json;
using Commands;
using Factories;
using Services;
using Utils;

namespace CricketSim
{
    class Program
    {
        static readonly Container container;

        static Program() {
            container = new Container();

            container.Register<IConfigManager, ConfigManager>(Lifestyle.Singleton);
            container.Register<IConsoleHandler, ConsoleHandler>(Lifestyle.Singleton);
            container.Register<IFileHandler, FileHandler>(Lifestyle.Singleton);
            container.Register<JsonSerializer>(Lifestyle.Singleton);
            container.Register<IResourceHandler, ResourceHandler>(Lifestyle.Singleton);
            container.Register<IRandomNumberGenerator, RandomNumberGenerator>(Lifestyle.Singleton);
            container.Register<ITextUtils, TextUtils>(Lifestyle.Singleton);
            container.Register<IBallFactory, BallFactory>(Lifestyle.Singleton);
            container.Register<Setup>(Lifestyle.Transient);
            container.Register<StartBall>(Lifestyle.Transient);

            container.Verify();
        }


        static void Main(string[] args)
        {
            Setup setup = container.GetInstance<Setup>();
            setup.Execute();

            StartBall startBall = container.GetInstance<StartBall>();
            startBall.Execute();
        }
    }
}
