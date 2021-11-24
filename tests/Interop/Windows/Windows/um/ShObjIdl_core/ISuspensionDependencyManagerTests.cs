// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISuspensionDependencyManager" /> struct.</summary>
public static unsafe partial class ISuspensionDependencyManagerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISuspensionDependencyManager" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISuspensionDependencyManager).GUID, Is.EqualTo(IID_ISuspensionDependencyManager));
    }

    /// <summary>Validates that the <see cref="ISuspensionDependencyManager" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISuspensionDependencyManager>(), Is.EqualTo(sizeof(ISuspensionDependencyManager)));
    }

    /// <summary>Validates that the <see cref="ISuspensionDependencyManager" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISuspensionDependencyManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISuspensionDependencyManager" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISuspensionDependencyManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISuspensionDependencyManager), Is.EqualTo(4));
        }
    }
}
