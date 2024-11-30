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
        public int Rating { get; private set; } = null!;

    }
}
