using CQRS.Read.Infra.Persistence.People;

namespace CQRS.Read.Infra.Persistence
{
    public interface IContext
    {
        IPersonRepositoy People { get; set; }
    }
}
