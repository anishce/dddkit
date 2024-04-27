using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoachingMentoringInfra.DomainBase
{
    public abstract class BaseEntity<TId> : IEntity
    {
        private IList<string> brokenValidationRules;

        public BaseEntity(TId id,int version)
        {
            Id = id;
            Version = version;

            brokenValidationRules = new List<string>();
        }

        public TId Id { get; private set; } = default!;

        //For Pessimistic Concurrency control
        //Upon an update, the version number of the business entity will
        //be compared to the version number residing in the database before committing a change.This ensures
        //that the business entity has not been modified since being retrieved.
        public int Version { get; private set; }

        protected void ThrowExceptionIfInvalid()
        {
            ValidateEntity();

            if (brokenValidationRules.Count() > 0)
            {
                var brokenValidationRulesBuilder = new StringBuilder();

                foreach (var brokenValidationRule in brokenValidationRules)
                {
                    brokenValidationRulesBuilder.Append($"{brokenValidationRule}{Environment.NewLine}");
                }

                throw new EntityInvalidException(brokenValidationRulesBuilder.ToString());
            }
        }


        protected abstract void ValidateEntity();

        protected IEnumerable<string> GetBrokenValidationRules()
        {
            return brokenValidationRules;
        }

        protected void AddBrokenValidationRule(string brokenValidationRule)
        {
            this.brokenValidationRules.Add(brokenValidationRule);
        }

        public override bool Equals(object entity)
        {
            return entity != null
               && entity is BaseEntity<TId>
               && this == (BaseEntity<TId>)entity;
        }

        public override int GetHashCode()
        {
            return Id!.GetHashCode();
        }

        public static bool operator ==(BaseEntity<TId> entity1,
           BaseEntity<TId> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
            {
                return true;
            }

            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }

            if (entity1?.Id!.ToString() == entity2?.Id!.ToString())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(BaseEntity<TId> entity1,
            BaseEntity<TId> entity2)
        {
            return (!(entity1 == entity2));
        }
    }

}
