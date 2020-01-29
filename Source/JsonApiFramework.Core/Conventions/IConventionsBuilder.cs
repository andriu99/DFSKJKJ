// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.
namespace JsonApiFramework.Conventions
{
    public interface IConventionsBuilder
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Methods
        INamingConventionsBuilder ApiAttributeNamingConventions();
        INamingConventionsBuilder ApiTypeNamingConventions();
        IComplexTypeConventionsBuilder ComplexTypeConventions();
        IResourceTypeConventionsBuilder ResourceTypeConventions();
        #endregion
    }
}