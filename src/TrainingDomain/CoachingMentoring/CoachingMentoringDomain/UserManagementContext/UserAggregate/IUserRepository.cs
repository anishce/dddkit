// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.Querying;
using System.Collections.Generic;

namespace CoachingMentoringDomain.UserManagementContext.UserAggregate
{
    public interface IUserRepository<TId>
    {
        void Add(User user);
        IEnumerable<User> FindAll();
        IEnumerable<User> FindBy(string query, int index, int count);
        IEnumerable<User> FindBy(string query, int index, int count, out long totalRows);
        IEnumerable<User> FindBy(Query criteria, out long totalRows);
        User FindBy(TId id);
        User FindBy(string userName);
        IEnumerable<User> FindBy(bool isActive);
        bool Remove(TId id, int version);
        void Save(User user);
    }
}
