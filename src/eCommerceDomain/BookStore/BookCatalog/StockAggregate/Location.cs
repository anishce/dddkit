// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.Ddd.Infra.DomainBase;
using System;

namespace AnishCeDev.BookStore.Domain.StockAggregate
{
    internal class Location : EntityBase<Guid>
    {
        public Location(Guid id, string name, LocationType typeOfLocation, string address, int version) : base(id, version)
        {
            Name=name;
            TypeOfLocation=typeOfLocation;
            Address=address;
        }
        public string Name { get; set; } // e.g., "Main Warehouse", "Store #2"
        public LocationType TypeOfLocation { get; set; }
        public string Address { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
