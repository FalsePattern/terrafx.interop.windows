// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MFT_OUTPUT_STREAM_INFO" /> struct.</summary>
    public static unsafe class MFT_OUTPUT_STREAM_INFOTests
    {
        /// <summary>Validates that the <see cref="MFT_OUTPUT_STREAM_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MFT_OUTPUT_STREAM_INFO>(), Is.EqualTo(sizeof(MFT_OUTPUT_STREAM_INFO)));
        }

        /// <summary>Validates that the <see cref="MFT_OUTPUT_STREAM_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MFT_OUTPUT_STREAM_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MFT_OUTPUT_STREAM_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MFT_OUTPUT_STREAM_INFO), Is.EqualTo(12));
        }
    }
}
