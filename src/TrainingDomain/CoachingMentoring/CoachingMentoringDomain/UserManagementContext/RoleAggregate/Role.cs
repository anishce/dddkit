// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.DomainBase;
using System;

namespace CoachingMentoringDomain.UserManagementContext.RoleAggregate
{
    public class Role : BaseEntity<int>, IAggregateRoot
    {
        public Role(int id, string name, string remarks,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version) : base(id, version)
        {
            Initialize(name, remarks, createdBy, createdDate, modifiedBy, modifiedDate);
        }

        public string Name { get; private set; } = null!;
        public string? Remarks { get; private set; }
        public string CreatedBy { get; private set; } = null!;
        public DateTime CreatedDate { get; private set; }
        public string ModifiedBy { get; private set; } = null!;
        public DateTime? ModifiedDate { get; private set; }

        protected override void ValidateEntity()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }
        }

        private void Initialize(string name, string remarks,
           string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate)
        {
            Name = name;
            Remarks = remarks;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
        }
    }
}
