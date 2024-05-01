using CoachingMentoringInfra.DomainBase;
using System.Collections.Generic;

namespace CoachingMentoringDomain.UserManagementContext.UserAggregate
{
    public class UserAddress : BaseValueObject<UserAddress>
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public UserAddress(AddressType addressType, string street, string city, string state, string postalCode) : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Initialize(addressType, street, city, state, postalCode);

        }
        public AddressType TypeOfAddress { get; private set; }

        public string Street { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }

        public string PostalCode { get; private set; }

        protected override IEnumerable<object> GetAttributesToBeCheckForEquality()
        {
            return new object[] { Street, City, State, PostalCode };
        }

        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Street))
            {
            }

            if (string.IsNullOrWhiteSpace(City))
            {
            }

            if (string.IsNullOrWhiteSpace(State))
            {
            }

            if (string.IsNullOrWhiteSpace(PostalCode))
            {
            }
        }

        private void Initialize(AddressType addressType, string street, string city, string state, string postalCode)
        {
            TypeOfAddress = addressType;
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
        }
    }
}
