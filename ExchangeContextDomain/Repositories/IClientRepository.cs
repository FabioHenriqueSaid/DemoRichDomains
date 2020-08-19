namespace ExchangeContextDomain.Repositories
{
    public interface IClientRepository
    {
        bool DocumentExists(string document);
        bool EmailExists(string email);
    }
}
