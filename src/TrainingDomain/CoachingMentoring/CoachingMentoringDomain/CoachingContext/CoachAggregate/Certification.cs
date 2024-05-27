// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;

namespace CoachingMentoringDomain.CoachingContext.CoachAggregate
{
    public class Certification : BaseValueObject<Certification>
    {
        public Certification(string name, string issuingOrganization, DateTime dateObtained, string remarks) : base()
        {
            Name = name;
            IssuingOrganization = issuingOrganization;
            DateObtained = dateObtained;
            Remarks = remarks;
        }

        public string Name { get; private set; }
        public string IssuingOrganization { get; set; }

        public DateTime DateObtained { get; set; }
        public string Remarks { get; private set; }

        protected override IEnumerable<object> GetAttributesToBeCheckForEquality()
        {
            return new object[] { Name };
        }

        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }
        }
    }
}
