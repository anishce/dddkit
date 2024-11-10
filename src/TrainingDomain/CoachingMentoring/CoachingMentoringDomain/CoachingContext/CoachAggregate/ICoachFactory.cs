// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using System.Collections.Generic;

namespace CoachingMentoringDomain.CoachingContext.CoachAggregate
{
    public interface ICoachFactory
    {
        Coach CreateFrom(int id, string firstName, string middleName, string lastName, string email, string phone, IEnumerable<Specialization> specializations, IEnumerable<Certification> certifications, int experience, string bio, double rating, int version);
    }
}