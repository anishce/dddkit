using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;

namespace CoachingMentoringDomain.CoachingContext.CoachAggregate
{
    public class Coach : BaseEntity<int>, IAggregateRoot
    {
        public Coach(int id, string firstName, string lastName, string email, string phone, IEnumerable<int> specializationIds, IEnumerable<int> certificationIds)
        {
            
        }

        protected override void ValidateEntity()
        {
            throw new NotImplementedException();
        }
    }
}
