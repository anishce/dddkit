﻿using CoachingMentoringDomain.UserManagementContext.Shared;
using CoachingMentoringInfra.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoachingMentoringDomain.UserManagementContext.UserAggregate
{
    public class UserContact : BaseValueObject<UserContact>
    {
        public UserContact(IEnumerable<EmailBook> emailBooks, IEnumerable<PhoneBook> phoneBooks, string faxNumber, string remarks)
        {
            EmailBooks = emailBooks;
            PhoneBooks = phoneBooks;
            FaxNumber = faxNumber;
            Remarks = remarks;

            base.ThrowExceptionIfInvalid();
        }
        public IEnumerable<EmailBook> EmailBooks { get; private set; }

        public IEnumerable<PhoneBook> PhoneBooks { get; private set; }

        public string FaxNumber { get; private set; }

        public string Remarks { get; private set; }


        protected override IEnumerable<object> GetAttributesToBeCheckForEquality()
        {
            throw new NotImplementedException();
        }

        protected override void Validate()
        {
            if(EmailBooks is null || EmailBooks?.Count()==0)
            {
                base.AddBrokenValidationRule("No email id provided.");
            }

            if (PhoneBooks is null || PhoneBooks?.Count() == 0)
            {
                base.AddBrokenValidationRule("No phone number provided.");
            }
        }
    }
}
