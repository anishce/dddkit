// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.DomainBase;
using CoachingMentoringInfra.Querying;
using System.Collections.Generic;

namespace CoachingMentoringInfra.RepositoryBase
{
    public abstract class RepositoryBase<T, TId> : IRepository<T, TId> where T : IAggregateRoot
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
    }
}
