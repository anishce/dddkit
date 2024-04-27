using System;

namespace CoachingMentoringInfra.DomainBase
{
    public class EntityInvalidException : Exception
    {
        public EntityInvalidException(string message) : base(message)
        {

        }
    }
}
