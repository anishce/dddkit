// Ignore Spelling: bio

using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;

namespace CoachingMentoringDomain.CoachingContext.CoachAggregate
{
    public class Coach : BaseEntity<int>, IAggregateRoot
    {
        public Coach(int id, string firstName, string lastName, string email, string phone, 
            IEnumerable<Specialization> specializations, IEnumerable<Certification> certifications, int experience, string bio, double rating, int version) :base(id,version)
        {
            
        }

        protected override void ValidateEntity()
        {
            throw new NotImplementedException();
        }
    }
}
