using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models
{    
    public class Ball
    {
        public String Action { get; set; }
        public string Prompt { get; set; }
        public string Result { get; set; }
    }
}