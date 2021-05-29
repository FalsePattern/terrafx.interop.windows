// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CERT_NAME_VALUE" /> struct.</summary>
    public static unsafe class CERT_NAME_VALUETests
    {
        /// <summary>Validates that the <see cref="CERT_NAME_VALUE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CERT_NAME_VALUE>(), Is.EqualTo(sizeof(CERT_NAME_VALUE)));
        }

        /// <summary>Validates that the <see cref="CERT_NAME_VALUE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CERT_NAME_VALUE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CERT_NAME_VALUE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CERT_NAME_VALUE), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(CERT_NAME_VALUE), Is.EqualTo(12));
            }
        }
    }
}
