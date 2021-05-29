// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CERT_PRIVATE_KEY_VALIDITY" /> struct.</summary>
    public static unsafe class CERT_PRIVATE_KEY_VALIDITYTests
    {
        /// <summary>Validates that the <see cref="CERT_PRIVATE_KEY_VALIDITY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CERT_PRIVATE_KEY_VALIDITY>(), Is.EqualTo(sizeof(CERT_PRIVATE_KEY_VALIDITY)));
        }

        /// <summary>Validates that the <see cref="CERT_PRIVATE_KEY_VALIDITY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CERT_PRIVATE_KEY_VALIDITY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CERT_PRIVATE_KEY_VALIDITY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CERT_PRIVATE_KEY_VALIDITY), Is.EqualTo(16));
        }
    }
}
