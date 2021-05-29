// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CRYPT_PROVIDER_REGDEFUSAGE" /> struct.</summary>
    public static unsafe class CRYPT_PROVIDER_REGDEFUSAGETests
    {
        /// <summary>Validates that the <see cref="CRYPT_PROVIDER_REGDEFUSAGE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CRYPT_PROVIDER_REGDEFUSAGE>(), Is.EqualTo(sizeof(CRYPT_PROVIDER_REGDEFUSAGE)));
        }

        /// <summary>Validates that the <see cref="CRYPT_PROVIDER_REGDEFUSAGE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CRYPT_PROVIDER_REGDEFUSAGE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CRYPT_PROVIDER_REGDEFUSAGE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CRYPT_PROVIDER_REGDEFUSAGE), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(CRYPT_PROVIDER_REGDEFUSAGE), Is.EqualTo(20));
            }
        }
    }
}
