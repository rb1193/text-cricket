using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Services;

namespace Services
{
    public class ResourceManager
    {
        private FileHandler _fileHandler;

        private JsonSerializer _serializer;

        public ResourceManager(FileHandler fileHandler, JsonSerializer serializer)
        {
            _fileHandler = fileHandler;
            _serializer = serializer;
        }
        
        public string Get(string key)
        {
            StreamReader reader = _fileHandler.Open("./Resources/en_EN/Text.json");
            string json = reader.ReadToEnd();
            Dictionary<string, string> resource = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return resource[key];
        }
    }
}