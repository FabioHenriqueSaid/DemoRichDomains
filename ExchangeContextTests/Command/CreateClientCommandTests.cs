using ExchangeContextDomain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExchangeContextTests.Command
{
    [TestClass]
    class CreateClientCommandTests
    {
        [TestMethod]
        public void Teste()
        {
            var command = new CreateClientCommand();
            command.FirstName = "";
            command.Validate();

            Assert.AreEqual(false,command.Valid);
        }
    }
}
