using CoachingMentoringInfra.DomainBase;
using System.Collections.Generic;
namespace CoachingMentoringDomain.UserManagementContext.Shared
{
    public class EmailBook : BaseValueObject<EmailBook>
    {
        //[SuppressMessage("CS8618", "Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public EmailBook(EmailBookType type, string email)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Initialize(type, email);

            base.ThrowExceptionIfInvalid();
        }

        public EmailBookType Type { get; private set; }

        public string Email { get; private set; }

        protected override IEnumerable<object> GetAttributesToBeCheckForEquality()
        {
            return new object[]
            {
                Email
            };
        }

        protected override void Validate()
        {
            //string emailRegularExpression = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            if (string.IsNullOrWhiteSpace(Email))
            {
                base.AddBrokenValidationRule("An email book must have an email.");
            }
            //else if(!Regex.IsMatch(Email,emailRegularExpression))
            //{
            //    base.AddBrokenValidationRule("An email book must have a valid email.");
            //}
        }

        private void Initialize(EmailBookType type, string email)
        {
            Type = type;
            Email = email;
        }
    }
}
