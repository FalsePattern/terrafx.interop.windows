// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMECHARPOSITION" /> struct.</summary>
public static unsafe partial class IMECHARPOSITIONTests
{
    /// <summary>Validates that the <see cref="IMECHARPOSITION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMECHARPOSITION>(), Is.EqualTo(sizeof(IMECHARPOSITION)));
    }

    /// <summary>Validates that the <see cref="IMECHARPOSITION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMECHARPOSITION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMECHARPOSITION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMECHARPOSITION), Is.EqualTo(36));
    }
}
