// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PROPSHEETPAGEW_V3" /> struct.</summary>
public static unsafe partial class PROPSHEETPAGEW_V3Tests
{
    /// <summary>Validates that the <see cref="PROPSHEETPAGEW_V3" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROPSHEETPAGEW_V3>(), Is.EqualTo(sizeof(PROPSHEETPAGEW_V3)));
    }

    /// <summary>Validates that the <see cref="PROPSHEETPAGEW_V3" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROPSHEETPAGEW_V3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PROPSHEETPAGEW_V3" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PROPSHEETPAGEW_V3), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(PROPSHEETPAGEW_V3), Is.EqualTo(52));
        }
    }
}
