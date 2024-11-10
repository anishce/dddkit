// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

// Ignore Spelling: bio

using System.Collections.Generic;

namespace CoachingMentoringDomain.CoachingContext.CoachAggregate
{
    public class CoachFactory : ICoachFactory
    {
        public Coach CreateFrom(int id, string firstName, string middleName, string lastName, string email, string phone,
            IEnumerable<Specialization> specializations, IEnumerable<Certification> certifications, int experience, string bio, double rating, int version)
        {
            return new Coach(id, firstName, middleName, lastName, email, phone, specializations, certifications, experience, bio, rating, version);
        }
    }
}
