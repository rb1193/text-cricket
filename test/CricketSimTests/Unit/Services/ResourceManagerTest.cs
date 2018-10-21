using System;
using System.IO;
using Xunit;
using Services;
using Moq;
using Newtonsoft.Json;

namespace CricketSimTests
{
    public class ResourceManager_GetShould
    {
        private readonly ResourceManager _rm;

        public ResourceManager_GetShould()
        {
            var fileHandler = new Mock<FileHandler>();
            var streamReader = new Mock<StreamReader>();
            var serializer = new Mock<JsonSerializer>();

            streamReader.Setup(sr => sr.ReadToEnd()).Returns("{\"key\":\"text\"}");
            fileHandler.Setup(fh => fh.Open("./Resources/en_EN/Text.json")).Returns(streamReader.Object);
            _rm = new ResourceManager(fileHandler.Object, serializer.Object);
        }
        
        [Fact]
        public void ReturnDictionaryValue()
        {
            string expected = "text";
            var actual = _rm.Get("key");
            Assert.Equal(expected, actual);
        }
    }
}