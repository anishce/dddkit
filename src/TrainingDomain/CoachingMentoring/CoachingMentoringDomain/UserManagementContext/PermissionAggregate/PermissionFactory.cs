// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using System;

namespace CoachingMentoringDomain.UserManagementContext.PermissionAggregate
{
    public class PermissionFactory : IPermissionFactory
    {
        public Permission CreateFrom(int id, string name, string description,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version)
        {
            return new Permission(id, name, description, createdBy, createdDate, modifiedBy, modifiedDate, version);
        }
    }
}
