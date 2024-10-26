using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;

namespace CoachingMentoringDomain.UserManagementContext.Shared
{
    public class PhoneBook : BaseValueObject<PhoneBook>
    {
        public PhoneBook(PhoneBookType phoneBookType, string phoneNumber)
        {
            PhoneBookType = phoneBookType;
            PhoneNumber = phoneNumber;
        }

        public PhoneBookType PhoneBookType { get; private set; }

        public string PhoneNumber { get; private set; }

        protected override IEnumerable<object> GetAttributesToBeCheckForEquality()
        {
            return new object[] { PhoneNumber };
        }

        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                throw new ArgumentNullException("A phone book should have phone number.");
            }
        }
    }
}
