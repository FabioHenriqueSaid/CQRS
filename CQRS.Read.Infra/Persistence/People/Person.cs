using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace CQRS.Read.Infra.Persistence.People
{
    [Flags]
    public enum PersonClass
    {
        Comun,
        Admin
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public class Person
    {
        public int Id { get; set; }
        public PersonClass Class { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }
        public Person(int id, PersonClass personClass, string name, int idade) 
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");
           
            this.Id = id;
            this.Class = personClass;
            this.Name = name;
        }
        public Person(PersonClass personClass, string name, int idade)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");

            this.Id = -1;
            this.Class = personClass;
            this.Name = name;
            this.Idade = idade;
        }
        public override string ToString()
        {
            return $"{ this.Class } : [Class]{this.Class}, [Name]{this.Name},[Idade]{this.Idade}";
        }
    }
}