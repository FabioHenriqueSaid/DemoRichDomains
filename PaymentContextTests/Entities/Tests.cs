﻿using ExchangeContextDomain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PaymentContextTests.Entities
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod()
        {
            var wallet = new Wallet();
            wallet.Orders;
        }
    }
}