// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;

namespace CoachingMentoringDomain.CoachingContext.CoachAggregate
{
    internal class AvailabilitySlot : BaseValueObject<AvailabilitySlot>
    {
        protected override IEnumerable<object> GetAttributesToBeCheckForEquality()
        {
            throw new NotImplementedException();
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
