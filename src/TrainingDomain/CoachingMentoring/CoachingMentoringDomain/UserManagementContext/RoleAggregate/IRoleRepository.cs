using System.Collections.Generic;

namespace CoachingMentoringDomain.UserManagementContext.RoleAggregate
{
    public interface IRoleRepository<TId>
    {
        void Add(Role role);
        IEnumerable<Role> FindAll();
        IEnumerable<Role> FindBy(string query, int index, int count);
        IEnumerable<Role> FindBy(string query, int index, int count, out long totalRows);
        Role FindBy(TId id);
        bool Remove(TId id, int version);
        void Save(Role role);
    }
}
