using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoachingMentoringDomain.FeedbackAndReviewContext.ReviewAggregate
{
    public class Review : BaseEntity<int>, IAggregateRoot
    {
        public Review(int id, int version) : base(id, version)
        {
            
        }
        protected override void ValidateEntity()
        {
            throw new NotImplementedException();
        }
    }
}
