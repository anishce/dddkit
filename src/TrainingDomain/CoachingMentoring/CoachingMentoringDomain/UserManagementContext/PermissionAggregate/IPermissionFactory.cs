// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using System;

namespace CoachingMentoringDomain.UserManagementContext.PermissionAggregate
{
    public interface IPermissionFactory
    {
        Permission CreateFrom(int id, string name, string description, string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version);
    }
}