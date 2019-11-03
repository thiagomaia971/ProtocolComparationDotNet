using System.Collections.Generic;
using ProtocolComparationDotNet.Domain.Entities;

namespace ProtocolComparationDotNet.Domain.Repositorios
{
    public abstract class Repository<T> where T : Entidade
    {
        protected abstract IEnumerable<T> List { get; }

        public IEnumerable<T> Get()
            => List;
    }
}
