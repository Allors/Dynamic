﻿namespace Allors.Dynamic.Meta
{
    using System;

    public class DynamicUnitAssociationType : IDynamicOneToAssociationType
    {
        public DynamicUnitAssociationType(DynamicObjectType objectType, DynamicUnitRoleType roleType)
        {
            this.ObjectType = objectType;
            roleType.AssociationType = this;
            this.RoleType = roleType;
            this.SingularName = roleType.SingularNameForAssociation(objectType);
            this.PluralName = roleType.PluralNameForAssociation(objectType);
        }

        public DynamicObjectType ObjectType { get; }

        IDynamicRoleType IDynamicAssociationType.RoleType => this.RoleType;

        public DynamicUnitRoleType RoleType { get; }

        public string Name => this.SingularName;

        public string SingularName { get; }

        public string PluralName { get; }

        public bool IsOne => true;

        public bool IsMany => false;

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
