using ExchangeContextDomain.ValueObjects.Entities;
using ExchangeContextDomain.ValueObjects.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExchangeContextTests
{
    [TestClass]
    public class DocumentTest
    {

        //Red, Green, Refactor
        [TestMethod]
        public void CNPJWhenIsInvalid()
        {
            var doc = new Document("1123",EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void CNPJWhenIsValid()
        {
            var doc = new Document("11111111111111", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }



        [TestMethod]
        public void CPFWhenIsInvalid()
        {
            Assert.Fail();
        }
    }
}
