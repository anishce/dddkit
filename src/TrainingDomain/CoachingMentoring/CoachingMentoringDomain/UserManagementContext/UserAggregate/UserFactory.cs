namespace AjSys.TaskManagement.User.Domain.Models.UserAggregate
{
    public class UserFactory : IUserFactory
    {
        public User CreateFrom(int id, string firstName, string middleName, string lastName, string userName, string password,
            int roleId, UserContact contact, IEnumerable<UserAddress> addresses, bool isActive, string remarks,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version)
        {
            return new User(id, firstName, middleName, lastName, userName, password, roleId, contact, addresses, isActive, remarks,
                createdBy, createdDate, modifiedBy, modifiedDate, version);
        }

    }
}
