// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.TestUtilities;
using Microsoft.EntityFrameworkCore.Utilities;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class InheritanceRelationshipsQueryInMemoryFixture : InheritanceRelationshipsQueryFixtureBase
    {
        protected override ITestStoreFactory<TestStore> TestStoreFactory => InMemoryTestStoreFactory.Instance;
    }
}
