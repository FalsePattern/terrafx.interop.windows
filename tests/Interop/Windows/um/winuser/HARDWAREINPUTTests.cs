// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HARDWAREINPUT" /> struct.</summary>
    public static unsafe class HARDWAREINPUTTests
    {
        /// <summary>Validates that the <see cref="HARDWAREINPUT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HARDWAREINPUT>(), Is.EqualTo(sizeof(HARDWAREINPUT)));
        }

        /// <summary>Validates that the <see cref="HARDWAREINPUT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HARDWAREINPUT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HARDWAREINPUT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HARDWAREINPUT), Is.EqualTo(8));
        }
    }
}
