// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ACTIVATION_CONTEXT_DETAILED_INFORMATION" /> struct.</summary>
    public static unsafe class ACTIVATION_CONTEXT_DETAILED_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="ACTIVATION_CONTEXT_DETAILED_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ACTIVATION_CONTEXT_DETAILED_INFORMATION>(), Is.EqualTo(sizeof(ACTIVATION_CONTEXT_DETAILED_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="ACTIVATION_CONTEXT_DETAILED_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ACTIVATION_CONTEXT_DETAILED_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ACTIVATION_CONTEXT_DETAILED_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ACTIVATION_CONTEXT_DETAILED_INFORMATION), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(ACTIVATION_CONTEXT_DETAILED_INFORMATION), Is.EqualTo(48));
            }
        }
    }
}
