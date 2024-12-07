using AnishCeDev.Ddd.Infra.DomainBase;
using AnishCeDev.TaskManagement.Domain.Shared;

namespace AnishCeDev.TaskManagement.Domain.CategoryAggregate
{
    public class Category : BaseEntity<int>
    {
        public Category(int id, string name, string description, IEnumerable<Link> links, int version) : base(id,version)
        {
            Name = name;
            Description = description;
            Links = links;
        }

        public string Name { get; private set; } = null!;
        public string? Description { get; private set; } = null;
        public IEnumerable<Link> Links { get; private set; } = null!;

        protected override void ValidateEntity()
        {
            if(string.IsNullOrWhiteSpace(Name)) {
                throw new ArgumentNullException("Name"); 
            }

            if (Links is null || Links?.Count() <= 0)
            {
                throw new ArgumentNullException("Links");
            }
        }
    }
}
