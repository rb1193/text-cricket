using System;
using Xunit;
using TeleprompterConsole;

namespace TeleprompterConsoleTests
{
    public class TeleprompterConfigTest
    {
        [Fact]
        public void SetDone_SetsDoneToTrue()
        {
            var config = new TeleprompterConfig();
            config.SetDone();

            Assert.True(config.Done);
        }
    }
}
