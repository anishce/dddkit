using CoachingMentoringInfra.DomainBase;
using System.Collections.Generic;

namespace CoachingMentoringDomain.UserManagementContext.Shared
{
    public class PhoneBook : BaseValueObject<PhoneBook>
    {
        public PhoneBook(PhoneBookType phoneBookType, string phoneNumber)
        {
            PhoneBookType = phoneBookType;
            PhoneNumber = phoneNumber;

            ThrowExceptionIfInvalid();
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
                base.AddBrokenValidationRule("A company should have phonenumber.");
            }
        }
    }
}
