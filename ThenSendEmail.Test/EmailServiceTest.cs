using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThenSendEmail.Test
{
    [TestClass]
    public class EmailServiceTest
    {
        private EmailService service { get; set; }

        [TestInitialize]
        public void Setup()
        {
            service = new EmailService();
        }

        //[TestMethod]
        public void ShouldSendEmail()
        {
            service.SendEmail("maswaffer@unco.edu", "hello!");
        }
    }
}
