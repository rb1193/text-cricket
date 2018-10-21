using System;
using System.Configuration;
using System.Collections.Specialized;

namespace Services
{
    public class ConfigManager
    {
        private NameValueCollection _config;
        
        public ConfigManager() {
            _config = ConfigurationManager.AppSettings;
        }

        public string Get(string key)
        {
            return _config[key]; 
        }

        public void Set(string key, string value)
        {
            _config[key] = value;
        }
    }
}