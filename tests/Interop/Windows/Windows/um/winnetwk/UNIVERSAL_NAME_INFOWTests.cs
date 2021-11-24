// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="UNIVERSAL_NAME_INFOW" /> struct.</summary>
public static unsafe partial class UNIVERSAL_NAME_INFOWTests
{
    /// <summary>Validates that the <see cref="UNIVERSAL_NAME_INFOW" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UNIVERSAL_NAME_INFOW>(), Is.EqualTo(sizeof(UNIVERSAL_NAME_INFOW)));
    }

    /// <summary>Validates that the <see cref="UNIVERSAL_NAME_INFOW" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UNIVERSAL_NAME_INFOW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="UNIVERSAL_NAME_INFOW" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(UNIVERSAL_NAME_INFOW), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(UNIVERSAL_NAME_INFOW), Is.EqualTo(4));
        }
    }
}
