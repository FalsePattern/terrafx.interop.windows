// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_LINE_SPACING" /> struct.</summary>
    public static unsafe class DWRITE_LINE_SPACINGTests
    {
        /// <summary>Validates that the <see cref="DWRITE_LINE_SPACING" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_LINE_SPACING>(), Is.EqualTo(sizeof(DWRITE_LINE_SPACING)));
        }

        /// <summary>Validates that the <see cref="DWRITE_LINE_SPACING" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_LINE_SPACING).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DWRITE_LINE_SPACING" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DWRITE_LINE_SPACING), Is.EqualTo(20));
        }
    }
}
