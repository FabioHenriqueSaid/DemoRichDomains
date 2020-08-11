﻿using ExchangeContextDomain.ValueObjects.Enums;

namespace ExchangeContextDomain.ValueObjects.Entities
{
    public class Document
    {
        public Document(string number)
        {
            Number = number;
        }
        public string Number { get; private set; }
        public EDocumentType MyProperty { get; private set; }
    }
}
