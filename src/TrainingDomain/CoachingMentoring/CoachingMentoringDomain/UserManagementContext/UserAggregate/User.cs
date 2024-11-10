using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CoachingMentoringDomain.UserManagementContext.UserAggregate
{ 
    public class User : BaseEntity<int>, IAggregateRoot
    {
        public User(int id, string firstName, string middleName, string lastName, string userName, string password, int roleId,
            IEnumerable<int> permissionIds, UserContact contact, IEnumerable<UserAddress> addresses, bool isActive, string remarks,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version) : base(id, version)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            RoleId = roleId;
            PermissionIds = permissionIds;
            Contact = contact;
            Addresses = addresses;
            IsActive = isActive;
            Remarks = remarks;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public int RoleId { get; private set; }
        public IEnumerable<int> PermissionIds { get; private set; }
        public UserContact Contact { get; private set; }
        public IEnumerable<UserAddress> Addresses { get; private set; }
        public bool IsActive { get; private set; }
        public string Remarks { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string ModifiedBy { get; private set; }
        public DateTime? ModifiedDate { get; private set; }

        protected override void ValidateEntity()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentNullException(nameof(FirstName));
            }

            if (string.IsNullOrWhiteSpace(MiddleName))
            {
                throw new ArgumentNullException(nameof(MiddleName));
            }

            if (string.IsNullOrWhiteSpace(UserName))
            {
                throw new ArgumentNullException(nameof(UserName));
            }

            if (Contact is null)
            {
                throw new ArgumentNullException(nameof(Contact));
            }

            if (Addresses is null || Addresses?.Count() == 0)
            {
                throw new ArgumentNullException(nameof(Addresses));
            }
        }
    }
}
