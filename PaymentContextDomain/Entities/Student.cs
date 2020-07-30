using PaymentContext.Domain.ValueObjects;
using PaymentContextDomain.ValueObjects;
using PaymentContextShared.Entities;
using System.Collections.Generic;
using System.Linq;

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
            //Se já tiver uma assinatura ativa, cancela.
            //Cancela todas as outras assinaturas, e coloca essa como principal
            foreach (var sub in Subscriptions) {
                sub.Inactivate();
            }
            _subscriptions.Add(subscription);
        }
    }
}

