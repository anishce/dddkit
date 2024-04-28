namespace CoachingMentoringDomain.UserManagementContext.UserAggregate
{
    public interface IUserRepository<TId>
    {
        void Add(User user);
        IEnumerable<UserDto> FindAll();
        IEnumerable<User> FindBy(string query, int index, int count);
        IEnumerable<User> FindBy(string query, int index, int count, out long totalRows);
        IEnumerable<UserDto> FindBy(UserSearchCriteria criteria, out long totalRows);
        User FindBy(TId id);
        LoginDto FindBy(string userName);
        IEnumerable<UserDto> FindBy(bool isActive);
        bool Remove(TId id, int version);
        void Save(User user);
    }
}
