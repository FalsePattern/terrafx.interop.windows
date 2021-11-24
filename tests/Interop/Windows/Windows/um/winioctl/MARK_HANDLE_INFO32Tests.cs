// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MARK_HANDLE_INFO32" /> struct.</summary>
[SupportedOSPlatform("windows8.0")]
public static unsafe partial class MARK_HANDLE_INFO32Tests
{
    /// <summary>Validates that the <see cref="MARK_HANDLE_INFO32" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MARK_HANDLE_INFO32>(), Is.EqualTo(sizeof(MARK_HANDLE_INFO32)));
    }

    /// <summary>Validates that the <see cref="MARK_HANDLE_INFO32" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MARK_HANDLE_INFO32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MARK_HANDLE_INFO32" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MARK_HANDLE_INFO32), Is.EqualTo(12));
    }
}
