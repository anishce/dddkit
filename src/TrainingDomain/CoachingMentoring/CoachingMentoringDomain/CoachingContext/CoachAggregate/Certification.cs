// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.DomainBase;
using System;

namespace CoachingMentoringDomain.CoachingContext.CoachAggregate
{
    public class Certification : BaseEntity<int>, IAggregateRoot
    {
        public Certification(int id, string name, string remarks, string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version) : base(id,version)
        {
            Name = name;
            Remarks = remarks;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
        }

        public string Name { get; private set; }
        public string Remarks { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string ModifiedBy { get; private set; }
        public DateTime? ModifiedDate { get; private set; }

        protected override void ValidateEntity()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }
        }
    }
}
