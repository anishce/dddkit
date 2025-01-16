// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;

namespace CoachingMentoringDomain.CoachingContext.CoachAggregate
{
    public class Coach : BaseEntity<int>, IAggregateRoot
    {
        public Coach(int id, string firstName, string middleName, string lastName, string email, string phone,
            IEnumerable<Specialization> specializations, IEnumerable<Certification> certifications, int experience, string bio, double rating, int version) : base(id, version)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string FirstName { get; private set; } = null!;
        public string? MiddleName { get; private set; }
        public string LastName { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string? PhoneNumber { get; private set; }
        public IEnumerable<Specialization> Specializations { get; private set; } = null!;
        public IEnumerable<Certification> Certifications { get; private set; } = null!;

        protected override void ValidateEntity()
        {
            throw new NotImplementedException();
        }
    }
}
