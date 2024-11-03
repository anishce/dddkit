// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using System;

namespace CoachingMentoringDomain.UserManagementContext.RoleAggregate
{
    public interface IRoleFactory
    {
        Role CreateFrom(int id, string name, string remarks, string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version);
    }
}