// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D10_TEX2DMS_ARRAY_SRV" /> struct.</summary>
    public static unsafe class D3D10_TEX2DMS_ARRAY_SRVTests
    {
        /// <summary>Validates that the <see cref="D3D10_TEX2DMS_ARRAY_SRV" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D10_TEX2DMS_ARRAY_SRV>(), Is.EqualTo(sizeof(D3D10_TEX2DMS_ARRAY_SRV)));
        }

        /// <summary>Validates that the <see cref="D3D10_TEX2DMS_ARRAY_SRV" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D10_TEX2DMS_ARRAY_SRV).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D10_TEX2DMS_ARRAY_SRV" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D10_TEX2DMS_ARRAY_SRV), Is.EqualTo(8));
        }
    }
}
