// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="STORAGE_IDENTIFIER" /> struct.</summary>
public static unsafe partial class STORAGE_IDENTIFIERTests
{
    /// <summary>Validates that the <see cref="STORAGE_IDENTIFIER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_IDENTIFIER>(), Is.EqualTo(sizeof(STORAGE_IDENTIFIER)));
    }

    /// <summary>Validates that the <see cref="STORAGE_IDENTIFIER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_IDENTIFIER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="STORAGE_IDENTIFIER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_IDENTIFIER), Is.EqualTo(20));
    }
}
