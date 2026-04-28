// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.BookStore.Domain.CategoryAggregate;
using AnishCeDev.Ddd.Infra.DomainBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnishCeDev.BookStore.Domain.StockAggregate
{
    internal class StockBusinessRule
    {
        public static readonly BusinessRule QuantityMustNotBeNegative = new BusinessRule(nameof(Category.Name), "Stock quantity cannot be negative.");
    }
}
