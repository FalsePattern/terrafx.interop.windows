// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IN_RECVERR" /> struct.</summary>
public static unsafe partial class IN_RECVERRTests
{
    /// <summary>Validates that the <see cref="IN_RECVERR" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IN_RECVERR>(), Is.EqualTo(sizeof(IN_RECVERR)));
    }

    /// <summary>Validates that the <see cref="IN_RECVERR" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IN_RECVERR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IN_RECVERR" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IN_RECVERR), Is.EqualTo(12));
    }
}
