using System;
using System.IO;
using Services;

namespace Commands
{
    public class Setup
    {
        private IConfigManager _config;

        private IResourceHandler _resources;

        public Setup(IConfigManager config, IResourceHandler resources)
        {
            _config = config;
            _resources = resources;
        }

        public void Execute()
        {
            _resources.Root =  _config.Get("ResourceRoot");
            _resources.Locale = _config.Get("Locale");
        }
    }
}