using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoachingMentoringDomain.FeedbackAndReviewContext.FeedbackAggregate
{
    public class Feedback : BaseEntity<int>, IAggregateRoot
    {
        public Feedback(int id, int version) : base(id, version)
        {

        }
        protected override void ValidateEntity()
        {
            throw new NotImplementedException();
        }

        public string Content { get; private set; } = null!;
        public int Rating { get; private set; }
        public FeedBackType FeedBackType { get; private set; }

        public IEnumerable<string> Strengths { get; private set; } = null!;

        public IEnumerable<string> AreasOfImprovement { get; private set; } = null!;

        public string? Suggestion { get; private set; }

        public int Status {  get; private set; }

        public int Visibility { get; private set; }
    }
}
