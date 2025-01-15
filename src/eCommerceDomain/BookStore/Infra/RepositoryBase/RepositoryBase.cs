// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.Ddd.Infra.DomainBase;
using AnishCeDev.Ddd.Infra.Querying;
using System.Collections.Generic;

namespace AnishCeDev.Ddd.Infra.RepositoryBase
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
