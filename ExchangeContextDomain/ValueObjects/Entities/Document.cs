﻿namespace ExchangeContextDomain.ValueObjects.Entities
{
    public class Document
    {
        public Document(string number)
        {
            Number = number;
        }
        public string Number { get; set; }
    }
}
