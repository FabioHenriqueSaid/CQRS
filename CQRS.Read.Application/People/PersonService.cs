using CQRS.Read.Infra.Persistence.People;
using System.Linq;

namespace CQRS.Read.Application.People
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepositoy personRepositoy;

        public PersonService(IPersonRepositoy personRepositoy)
        {
            this.personRepositoy = personRepositoy;
        }
        public void Delete(int id)
        {
            personRepositoy.Delete(id);
        }

        public Person Find(int id)
        {
            return personRepositoy.Find(id);
        }

        public IQueryable<Person> GetAll()
        {
            return personRepositoy.Get();
        }

        public IQueryable<Person> GetByName(string name)
        {
            return personRepositoy.Get(x => x.Name.ToUpper().Contains(name.ToUpper()));
        }

        public void Insert(Person person)
        {
            personRepositoy.Insert(person);
        }

        public void Update(Person person)
        {
            personRepositoy.Update(person);
        }
    }
}