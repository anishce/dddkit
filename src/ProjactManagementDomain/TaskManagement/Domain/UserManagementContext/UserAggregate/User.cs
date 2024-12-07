using AnishCeDev.Ddd.Infra.DomainBase;
using AnishCeDev.TaskManagement.Domain.Shared;
using System.Text.RegularExpressions;

namespace AnishCeDev.TaskManagement.Domain.UserManagementContext.UserAggregate
{
    public class User : BaseEntity<int>, IAggregateRoot
    {
        public User(int id, string userName, string firstName, string lastName,
            string email, IEnumerable<Link> links, int version) : base(id, version)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Links = links;
        }

        public string UserName { get; private set; } = null!;
        public string FirstName { get; private set; } = null!;
        public string LastName { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public IEnumerable<Link> Links { get; private set; } = null!;

        protected override void ValidateEntity()
        {
            if (string.IsNullOrWhiteSpace(UserName))
            {
                throw new ArgumentNullException("UserName");
            }

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentNullException("FirstName");
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new ArgumentNullException("LastName");
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                throw new ArgumentNullException("Email");
            }

            else if (!Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                throw new ArgumentException("Invalid email.");
            }

            if (Links is null || Links?.Count() <= 0)
            {
                throw new ArgumentNullException("Links");
            }
        }
    }
}
