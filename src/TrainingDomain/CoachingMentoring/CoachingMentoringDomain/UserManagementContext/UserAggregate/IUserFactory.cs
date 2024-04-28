
namespace AjSys.TaskManagement.User.Domain.Models.UserAggregate
{
    public interface IUserFactory
    {
        User CreateFrom(int id, string firstName, string middleName, string lastName, string userName, string password, int roleId, UserContact contact, IEnumerable<UserAddress> addresses, 
            bool isActive, string remarks, string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version);
    }
}