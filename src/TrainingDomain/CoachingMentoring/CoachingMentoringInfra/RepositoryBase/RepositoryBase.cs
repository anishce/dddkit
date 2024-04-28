using CoachingMentoringInfra.DomainBase;
using CoachingMentoringInfra.Querying;
using CoachingMentoringInfra.UnitOfWork;
using System.Collections.Generic;

namespace CoachingMentoringInfra.RepositoryBase
{
    public abstract class RepositoryBase<T, TId> : IRepository<T, TId>, IUnitOfWorkRepository where T : IAggregateRoot
    {
        #region IRepository
        public abstract void Add(T entity);
        public abstract void Save(T entity);
        public abstract void Remove(T entity);

        public abstract T FindBy(TId id);
        public abstract IEnumerable<T> FindBy(Query query);
        public abstract IEnumerable<T> FindBy(Query query, int index, int count);
        public abstract IEnumerable<T> FindAll();
        #endregion

        #region IUnitOfWorkRepository
        public void PersistCreationOf(IAggregateRoot entity)
        {
            this.PersistNewItem((T)entity);
        }

        public void PersistDeletionOf(IAggregateRoot entity)
        {
            this.PersistDeletedItem((T)entity);
        }

        public void PersistUpdateOf(IAggregateRoot entity)
        {
            this.PersistUpdatedItem((T)entity);
        }
        #endregion

        #region Abstract Method
        protected abstract void PersistNewItem(T item);
        protected abstract void PersistUpdatedItem(T item);
        protected abstract void PersistDeletedItem(T item);
        #endregion
    }
}
