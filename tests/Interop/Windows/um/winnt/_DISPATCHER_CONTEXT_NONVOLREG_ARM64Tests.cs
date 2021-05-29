// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_DISPATCHER_CONTEXT_NONVOLREG_ARM64" /> struct.</summary>
    public static unsafe class _DISPATCHER_CONTEXT_NONVOLREG_ARM64Tests
    {
        /// <summary>Validates that the <see cref="_DISPATCHER_CONTEXT_NONVOLREG_ARM64" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_DISPATCHER_CONTEXT_NONVOLREG_ARM64>(), Is.EqualTo(sizeof(_DISPATCHER_CONTEXT_NONVOLREG_ARM64)));
        }

        /// <summary>Validates that the <see cref="_DISPATCHER_CONTEXT_NONVOLREG_ARM64" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(_DISPATCHER_CONTEXT_NONVOLREG_ARM64).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="_DISPATCHER_CONTEXT_NONVOLREG_ARM64" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(_DISPATCHER_CONTEXT_NONVOLREG_ARM64), Is.EqualTo(152));
        }
    }
}
