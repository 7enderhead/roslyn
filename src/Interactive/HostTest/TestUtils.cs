﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System.IO;

namespace Microsoft.CodeAnalysis.UnitTests.Interactive
{
    internal static class TestUtils
    {
        public readonly static string HostRootPath = Path.Combine(Path.GetDirectoryName(typeof(TestUtils).Assembly.Location)!, "Host");
    }
}
