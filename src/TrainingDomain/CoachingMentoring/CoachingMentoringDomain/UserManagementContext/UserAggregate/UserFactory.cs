using CoachingMentoringDomain.UserManagementContext.UserAggregate;
using System;
using System.Collections.Generic;

namespace CoachingMentoringDomain.UserManagementContext.UserAggregate
{
    public class UserFactory : IUserFactory
    {
        public User CreateFrom(int id, string firstName, string middleName, string lastName, string userName, string password,
            int roleId, IEnumerable<int> permissionIds, UserContact contact, IEnumerable<UserAddress> addresses, bool isActive, string remarks,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version)
        {
            return new User(id, firstName, middleName, lastName, userName, password, roleId, permissionIds, contact, addresses, isActive, remarks,
                createdBy, createdDate, modifiedBy, modifiedDate, version);
        }

    }
}
