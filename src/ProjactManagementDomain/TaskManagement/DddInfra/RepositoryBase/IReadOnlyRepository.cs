using AnishCeDev.Ddd.Infra.DomainBase;
using AnishCeDev.Ddd.Infra.Querying;
using System.Collections.Generic;

namespace AnishCeDev.Ddd.Infra.RepositoryBase
{
    public interface IReadOnlyRepository<T, TId> where T : IAggregateRoot 
    {
        T FindBy(TId id);
        IEnumerable<T> FindAll();        
        IEnumerable<T> FindBy(Query query);
        IEnumerable<T> FindBy(Query query, int index, int count);
    }
}
