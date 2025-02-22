﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore;

#if !EXCLUDE_ON_MAC

public class GrpcInMemoryTest : GrpcTestBase<GrpcInMemoryTest.GrpcInMemoryFixture>
{
    public GrpcInMemoryTest(GrpcInMemoryFixture fixture)
        : base(fixture)
    {
    }

    public class GrpcInMemoryFixture : GrpcFixtureBase
    {
        protected override ITestStoreFactory TestStoreFactory
            => InMemoryTestStoreFactory.Instance;
    }
}

#endif
