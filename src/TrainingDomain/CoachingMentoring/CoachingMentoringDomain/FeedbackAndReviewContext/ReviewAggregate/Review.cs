// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.DomainBase;
using System;

namespace CoachingMentoringDomain.FeedbackAndReviewContext.ReviewAggregate
{
    public class Review : BaseEntity<int>, IAggregateRoot
    {
        public Review(int id, int version) : base(id, version)
        {

        }
        protected override void ValidateEntity()
        {
            throw new NotImplementedException();
        }
    }
}
