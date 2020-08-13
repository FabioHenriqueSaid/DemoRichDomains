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
            var doc = new Document("2323",EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }


        [TestMethod]
        public void CNPJWhenIsValid()
        {
            var doc = new Document("11222", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }
    }
}
