using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoachingMentoringDomain.UserManagementContext.UserAggregate
{ 
    public class User : BaseEntity<int>, IAggregateRoot
    {
        public User(int id, string firstName, string middleName, string lastName, string userName, string password, int roleId,
            UserContact contact, IEnumerable<UserAddress> addresses, bool isActive, string remarks,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version) : base(id, version)
        {
            Initialize(firstName, middleName, lastName, userName, password, roleId, contact, addresses, isActive, remarks,
                createdBy, createdDate, modifiedBy, modifiedDate);

            base.ThrowExceptionIfInvalid();
        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public int RoleId { get; private set; }
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
                base.AddBrokenValidationRule("First name is required.");
            }

            if (string.IsNullOrWhiteSpace(MiddleName))
            {
                base.AddBrokenValidationRule("Middle name is required.");
            }

            if (string.IsNullOrWhiteSpace(UserName))
            {
                base.AddBrokenValidationRule("User name is required.");
            }

            if (Contact is null)
            {
                base.AddBrokenValidationRule("No contact details provided.");
            }

            if (Addresses is null || Addresses?.Count() == 0)
            {
                base.AddBrokenValidationRule("No address details provided.");
            }
        }

        private void Initialize(string firstName, string middleName, string lastName, string userName, string password,
            int roleId, UserContact contact, IEnumerable<UserAddress> addresses, bool isActive, string remarks,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            RoleId = roleId;
            Contact = contact;
            Addresses = addresses;
            IsActive = isActive;
            Remarks = remarks;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
        }
    }
}
