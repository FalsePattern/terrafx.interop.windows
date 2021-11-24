// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="KDHELP" /> struct.</summary>
public static unsafe partial class KDHELPTests
{
    /// <summary>Validates that the <see cref="KDHELP" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KDHELP>(), Is.EqualTo(sizeof(KDHELP)));
    }

    /// <summary>Validates that the <see cref="KDHELP" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KDHELP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="KDHELP" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KDHELP), Is.EqualTo(64));
    }
}
