using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CQRS.Read.Infra.Persistence.People
{
    public class PersonRepository : IPersonRepositoy
    {
        private static List<Person> listaPersonMemory = new List<Person>();
        public void Delete(Person person)
        {
            listaPersonMemory.Remove(person);
        }
        public void Delete(object id)
        {
            listaPersonMemory.Remove(this.Find(id));
        }
        public Person Find(object id)
        {
            return listaPersonMemory.AsQueryable().FirstOrDefault(p => p.Id.Equals(id));
        }
        public IQueryable<Person> Get(Expression<Func<Person, bool>> predicate = null)
        {
            return predicate != null ?
                listaPersonMemory.AsQueryable().Where(predicate) :
                listaPersonMemory.AsQueryable();
        }
        public void Insert(Person entity)
        {
            if (entity.Id == -1)
            {
                entity = new Person
                    (
                       listaPersonMemory.Count + 1, entity.Class, entity.Name, entity.Idade
                    );
            }
        }
        public void Update(Person entity)
        {
            var person = this.Find(entity.Id);
            person.Class = entity.Class;
            person.Idade = entity.Idade;
            person.Name = entity.Name;
        }
    }
}