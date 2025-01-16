// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.DomainBase;
using System;

namespace CoachingMentoringDomain.UserManagementContext.PermissionAggregate
{
    public class Permission : BaseEntity<int>, IAggregateRoot
    {
        public Permission(int id, string name, string description, string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version) : base(id, version)
        {
            Initialize(name, description, createdBy, createdDate, modifiedBy, modifiedDate);
        }

        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
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

        private void Initialize(string name, string description,
           string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate)
        {
            Name = name;
            Description = description;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
        }
    }
}
