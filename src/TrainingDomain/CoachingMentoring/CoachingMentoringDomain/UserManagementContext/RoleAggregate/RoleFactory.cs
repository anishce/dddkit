﻿// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using System;

namespace CoachingMentoringDomain.UserManagementContext.RoleAggregate
{
    public class RoleFactory : IRoleFactory
    {
        public Role CreateFrom(int id, string name, string remarks,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, int version
            )
        {
            return new Role(id, name, remarks, createdBy, createdDate, modifiedBy, modifiedDate, version);
        }
    }
}
