// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_ARM64_NT_NEON128" /> struct.</summary>
    public static unsafe class _ARM64_NT_NEON128Tests
    {
        /// <summary>Validates that the <see cref="_ARM64_NT_NEON128" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_ARM64_NT_NEON128>(), Is.EqualTo(sizeof(_ARM64_NT_NEON128)));
        }

        /// <summary>Validates that the <see cref="_ARM64_NT_NEON128" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(_ARM64_NT_NEON128).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="_ARM64_NT_NEON128" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(_ARM64_NT_NEON128), Is.EqualTo(16));
        }
    }
}
