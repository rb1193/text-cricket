using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Services;

namespace Services
{
    public class ResourceHandler : IResourceHandler
    {
        private IFileHandler _fileHandler;

        private JsonSerializer _serializer;

        public string Locale { get; set; }

        public string Root { get; set; }

        public ResourceHandler(IFileHandler fileHandler, JsonSerializer serializer)
        {
            _fileHandler = fileHandler;
            _serializer = serializer;
        }
        
        public string Get(string key)
        {
            var fileName = key.Split(".")[0];
            StreamReader reader = _fileHandler.Open("./" + Root + "/" + Locale +
                "/" + fileName + ".json");
            string json = reader.ReadToEnd();
            Dictionary<string, string> resource = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return resource[key];
        }
    }
}