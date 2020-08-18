﻿using ExchangeContextDomain.ValueObjects.Entities;
using ExchangeContextShared;
using ExchangeContextShared.ValueObjects;
using System;

namespace ExchangeContextDomain.Entities
{
    public class Client : Entity
    {
        public Client(
            Name name, 
            Document document, 
            Email email,
            DateTime birthDate
            )
        {
            CreationDate = DateTime.Now;
            FirstName = name;
            LastName = name;
            Document = document;
            Email = email;
            BirthDate = birthDate;

            AddNotifications(name,document,email);
        }

        public DateTime CreationDate { get; set; }
        public Name FirstName { get; private set; }
        public Name LastName { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private  set; }
        public DateTime BirthDate { get; private set; }
        public Wallet Wallet { get; private set; }
       
    }
}