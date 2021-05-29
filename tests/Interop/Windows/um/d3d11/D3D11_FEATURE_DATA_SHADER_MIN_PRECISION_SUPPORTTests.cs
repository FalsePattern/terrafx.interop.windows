// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT" /> struct.</summary>
    public static unsafe class D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORTTests
    {
        /// <summary>Validates that the <see cref="D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT>(), Is.EqualTo(sizeof(D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT)));
        }

        /// <summary>Validates that the <see cref="D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT), Is.EqualTo(8));
        }
    }
}
