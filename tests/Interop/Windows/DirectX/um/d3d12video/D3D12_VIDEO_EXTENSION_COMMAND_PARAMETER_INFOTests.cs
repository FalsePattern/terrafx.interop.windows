// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO" /> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFOTests
{
    /// <summary>Validates that the <see cref="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO>(), Is.EqualTo(sizeof(D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO)));
    }

    /// <summary>Validates that the <see cref="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO), Is.EqualTo(12));
        }
    }
}
