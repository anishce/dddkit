// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.Ddd.Infra.DomainBase;
using System;

namespace AnishCeDev.BookStore.Domain.CategoryAggregate
{
    public class Category : EntityBase<Guid>, IAggregateRoot
    {
        public Category(Guid id, string name, string description = null, bool isFeatured = false, int displayOrder = 0, int version) : base(id, version)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            IsFeatured = isFeatured;
            DisplayOrder = displayOrder;

            base.ThrowExceptionIfInvalid();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsFeatured { get; private set; }
        public int DisplayOrder { get; private set; }

        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                base.AddBrokenValidationRule(CategoryBusinessRules.NameRequired);
            }
        }
    }
}
