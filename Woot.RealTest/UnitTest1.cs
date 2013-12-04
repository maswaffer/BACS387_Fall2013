using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Woot.RealTest
{
    [TestClass]
    public class EmailServiceTest
    {
        private WootService service { get; set; }

        [TestInitialize]
        public void Setup()
        {
            service = new EmailService();
        }

        //[TestMethod]
        public void ShouldSendEmail()
        {
            service.SendEmail("maswaffer@gmail.com", "hello!");
        }
    }
}
