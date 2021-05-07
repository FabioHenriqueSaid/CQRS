using CQRS.Read.Infra.Persistence.People;
using System.Linq;

namespace CQRS.Read.Application.People
{
    public interface IPersonService : IApplicationService<Person>
    {
        Person Find(int id);
        IQueryable<Person> GetByName(string nome);
        IQueryable<Person> GetAll();
        void Insert(Person person);
        void Update(Person person);
        void Delete(int id);
    }
}