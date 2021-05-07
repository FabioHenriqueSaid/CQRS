using CQRS.Read.Infra.Persistence.People;
using System;

namespace CQRS.Read.Infra.Persistence
{
    public class Contexto : IContext
    {
        public IPersonRepositoy People { get; set; }

        public Contexto(IPersonRepositoy personRepositoy)
        {
            this.People = personRepositoy;
        }
    }
}