// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WINHTTP_REQUEST_STATS32" /> struct.</summary>
public static unsafe partial class WINHTTP_REQUEST_STATS32Tests
{
    /// <summary>Validates that the <see cref="WINHTTP_REQUEST_STATS32" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINHTTP_REQUEST_STATS32>(), Is.EqualTo(sizeof(WINHTTP_REQUEST_STATS32)));
    }

    /// <summary>Validates that the <see cref="WINHTTP_REQUEST_STATS32" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_REQUEST_STATS32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WINHTTP_REQUEST_STATS32" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WINHTTP_REQUEST_STATS32), Is.EqualTo(272));
    }
}
