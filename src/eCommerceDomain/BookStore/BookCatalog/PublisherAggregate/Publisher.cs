// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AjSys.DigitalBookShop.Infrastructure.DomainBase;
using System;

namespace AnishCeDev.BookStore.Domain.PublisherAggregate
{
    public class Publisher : EntityBase<Guid>, IAggregateRoot
    {
        public Publisher(Guid id, string name, int version) : base(id,version)
        {
            Name = name;
        }

        public string Name { get; private set; }

        protected override void ValidateEntity()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                base.AddBrokenValidationRule("A book category must have name.");
            }
        }
    }
}
