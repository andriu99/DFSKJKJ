﻿// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using System.Collections.Generic;

using JsonApiFramework.TestData.ClrResources;

using Xunit;

namespace JsonApiFramework.TestAsserts.ClrResources
{
    public static class StoreAssert
    {
        // PUBLIC METHODS ///////////////////////////////////////////////////
        #region Assert Methods
        public static void Equal(Store expected, Store actual)
        {
            // Handle when 'expected' is null.
            if (expected == null)
            {
                Assert.Null(actual);
                return;
            }
            Assert.NotNull(actual);

            Assert.Equal(expected.StoreId, actual.StoreId);
            Assert.Equal(expected.StoreName, actual.StoreName);
            Assert.Equal(expected.Address, actual.Address);
            Assert.Equal(expected.City, actual.City);
            Assert.Equal(expected.State, actual.State);
            Assert.Equal(expected.ZipCode, actual.ZipCode);
        }

        public static void Equal(IEnumerable<Store> expected, IEnumerable<Store> actual)
        {
            if (expected == null)
            {
                Assert.Null(actual);
                return;
            }
            Assert.NotNull(actual);

            var expectedCollection = expected.SafeToList();
            var actualCollection = actual.SafeToList();

            Assert.Equal(expectedCollection.Count, actualCollection.Count);

            var count = expectedCollection.Count;
            for (var index = 0; index < count; ++index)
            {
                var expectedItem = expectedCollection[index];
                var actualItem = actualCollection[index];

                StoreAssert.Equal(expectedItem, actualItem);
            }
        }
        #endregion
    }
}