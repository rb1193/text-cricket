using System;
using System.IO;
using Xunit;
using Services;
using Moq;
using Newtonsoft.Json;

namespace CricketSimTests
{
    public class ResourceHandler_GetShould
    {
        private readonly ResourceHandler _rm;

        public ResourceHandler_GetShould()
        {
            var fileHandler = new Mock<IFileHandler>();
            var sr = new StreamReader("../../../Unit/Services/data/en_EN/key.json");
            fileHandler.Setup(fh => fh.Open("./data/en_EN/key.json")).Returns(sr);
            var serializer = new JsonSerializer();

            _rm = new ResourceHandler(fileHandler.Object, serializer);
            _rm.Root = "data";
            _rm.Locale = "en_EN";
        }
        
        [Fact]
        public void ReturnDictionaryValue()
        {
            string expected = "text";
            var actual = _rm.Get("key.example");
            Assert.Equal(expected, actual);
        }
    }
}