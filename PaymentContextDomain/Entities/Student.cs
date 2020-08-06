using PaymentContext.Domain.ValueObjects;
using PaymentContextDomain.ValueObjects;
using PaymentContextShared.Entities;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;

namespace PaymentContextDomain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, Email email)
        {
            FirstName = name;
            LastName = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name FirstName { get; private set; }
        public Name LastName { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public  IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
       
        
        public  void AddSubscription(Subscription subscription) 
        {
            var hasSubscriptionActive = false;
            foreach (var sub in _subscriptions) 
            {
                if (sub.Active)
                    hasSubscriptionActive = true;   
            }

            AddNotifications(new Contract()
                .Requires()
                .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa")
                );

        }
    }
}

