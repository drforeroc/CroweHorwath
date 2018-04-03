using System;
using HelloWorldAPI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldAPI.UnitTest
{
    [TestClass]
    public class ReadServiceTest
    {
        [TestMethod]
        public void Read_ReadFromConfiguration_ReturnsHelloWorld()
        {
            var readService = new ReadService();

            var message = readService.Read();

            Assert.AreEqual(message.Message, "Hello World");
        }
    }
}
