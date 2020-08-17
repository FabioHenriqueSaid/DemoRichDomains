using ExchangeContextDomain.Entities;
using ExchangeContextDomain.ValueObjects.Entities;
using ExchangeContextDomain.ValueObjects.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExchangeContextTests
{
    [TestClass]
    public class DocumentTest
    {
        [TestMethod]
        public void TestClient() {
            Name name = new Name("Fábio","Henrique");
            Email email = new Email("fabiosaid635@gmail.com");
            Document document = new Document("13227956659",EDocumentType.CPF);
            Client client = new Client(name,document,email,DateTime.Now);
            Assert.IsTrue(client.Valid);
        }
    }
}
