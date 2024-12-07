using AnishCeDev.Ddd.Infra.DomainBase;
using AnishCeDev.TaskManagement.Domain.Shared;
using AnishCeDev.TaskManagement.Domain.TaskManagementContext.CategoryAggregate;
using AnishCeDev.TaskManagement.Domain.TaskManagementContext.PriorityAggregate;
using AnishCeDev.TaskManagement.Domain.TaskManagementContext.StatusAggregate;

namespace AnishCeDev.TaskManagement.Domain.TaskManagementContext.TaskAggregate
{
    public class Task : BaseEntity<int>, IAggregateRoot
    {
        public Task(int id, string subject, DateTime? startDate, DateTime? dueDate, DateTime? completedDate,
            IEnumerable<Category> categories, Priority priority, Status status, IEnumerable<Link> links,
            IEnumerable<int> assignees, int version) : base(id, version)
        {
            Subject = subject;
            StartDate = startDate;
            DueDate = dueDate;
            CompletedDate = completedDate;
            Categories = categories;
            Priority = priority;
            Links = links;
            Assignees = assignees;
        }

        public string Subject { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public IEnumerable<Category> Categories { get; set; } = null!;
        public Priority Priority { get; set; } = null!;
        public Status Status { get; set; } = null!;
        public IEnumerable<Link> Links { get; set; } = null!;
        public IEnumerable<int> Assignees { get; set; } = null!;

        protected override void ValidateEntity()
        {
            if (string.IsNullOrWhiteSpace(Subject))
            {
                throw new ArgumentNullException("Subject");
            }

            if (Categories is null || Categories?.Count() <= 0)
            {
                throw new ArgumentNullException("Categories");
            }

            if (Priority is null)
            {
                throw new ArgumentNullException("Priority");
            }

            if (Status is null)
            {
                throw new ArgumentNullException("Status");
            }

            if (Links is null || Links?.Count() <= 0)
            {
                throw new ArgumentNullException("Links");
            }

            if (Assignees is null || Assignees?.Count() <= 0)
            {
                throw new ArgumentNullException("Assignees");
            }
        }
    }
}
