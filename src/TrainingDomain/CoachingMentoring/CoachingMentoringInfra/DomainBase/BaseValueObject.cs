using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace CoachingMentoringInfra.DomainBase
{
    public abstract class BaseValueObject<T> where T: BaseValueObject<T>
    {
        private IList<string> brokenValidationRules;

        public BaseValueObject()
        {
            brokenValidationRules = new List<string>();
        }

        protected abstract IEnumerable<object> GetAttributesToBeCheckForEquality();

        public virtual bool Equals(T other)
        {
            if (other == null)
            {
                return false;
            }
            return GetAttributesToBeCheckForEquality().SequenceEqual(other.GetAttributesToBeCheckForEquality());
        }

        protected abstract void Validate();

        protected IEnumerable<string> GetBrokenValidationRules()
        {
            return brokenValidationRules;
        }

        protected void AddBrokenValidationRule(string brokenValidationRule)
        {
            brokenValidationRules.Add(brokenValidationRule);
        }


        protected void ThrowExceptionIfInvalid()
        {
            Validate();

            if (brokenValidationRules.Count() >0)
            {
                var brokenValidationRulesBuilder = new StringBuilder();

                foreach(var brokenValidationRule in GetBrokenValidationRules())
                {
                    brokenValidationRulesBuilder.Append($"{brokenValidationRule}{Environment.NewLine}");
                }

                throw new ValueObjectIsInvalidException(brokenValidationRulesBuilder.ToString());
            }
        }
    }
}