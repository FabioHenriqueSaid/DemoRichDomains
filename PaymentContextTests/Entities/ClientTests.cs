using ExchangeContextDomain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PaymentContextTests.Entities
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new Client("Fábio",
                "Henrique",
                "13227956544",
                "fabiosaid635@gmail.com",
               DateTime.Now);
        }
    }
}