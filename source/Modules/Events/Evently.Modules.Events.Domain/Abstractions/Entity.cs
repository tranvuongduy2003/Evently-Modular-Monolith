namespace Evently.Modules.Events.Domain.Abstractions;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = [];

    protected Entity()
    {
    }

    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.ToList();

    public void ClearDomainEvent()
    {
        _domainEvents.Clear();
    }

    protected void Raise(IDomainEvent eventDomain)
    {
        _domainEvents.Add(eventDomain);
    }
}
