// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.Ddd.Infra.DomainBase;

namespace AnishCeDev.BookStore.Domain.CategoryAggregate
{
    internal class CategoryBusinessRules
    {
        public static readonly BusinessRule NameRequired = new BusinessRule(nameof(Category.Name), "A book category must have name.");
    }
}
