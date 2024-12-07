using AnishCeDev.Ddd.Infra.DomainBase;

namespace AnishCeDev.TaskManagement.Domain.Shared
{
    public class Link : BaseValueObject<Link>
    {
        public Link(string rel, string href, string title, string type)
        {
            Rel = rel;
            Href = href;
            Title = title;
            Type = type;
        }

        public string Rel { get; private set; } = null!;
        public string Href { get; private set; } = null!;
        public string Title { get; private set; } = null!;
        public string Type { get; private set; } = null!;

        protected override IEnumerable<object> GetAttributesToBeCheckForEquality()
        {
            return
           [
                Rel,
                Href,
                Title,
                Type
           ];
        }

        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Rel))
            {
                throw new ArgumentNullException("A link must have a rel.");
            }

            if (string.IsNullOrWhiteSpace(Href))
            {
                throw new ArgumentNullException("A link must have a rel href.");
            }

            if (string.IsNullOrWhiteSpace(Title))
            {
                throw new ArgumentNullException("A link must have a title.");
            }

            if (string.IsNullOrWhiteSpace(Type))
            {
                throw new ArgumentNullException("A link must have a type.");
            }

        }
    }
}
