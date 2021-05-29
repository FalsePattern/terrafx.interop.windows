// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DML_BUFFER_ARRAY_BINDING" /> struct.</summary>
    public static unsafe class DML_BUFFER_ARRAY_BINDINGTests
    {
        /// <summary>Validates that the <see cref="DML_BUFFER_ARRAY_BINDING" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DML_BUFFER_ARRAY_BINDING>(), Is.EqualTo(sizeof(DML_BUFFER_ARRAY_BINDING)));
        }

        /// <summary>Validates that the <see cref="DML_BUFFER_ARRAY_BINDING" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DML_BUFFER_ARRAY_BINDING).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DML_BUFFER_ARRAY_BINDING" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DML_BUFFER_ARRAY_BINDING), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(DML_BUFFER_ARRAY_BINDING), Is.EqualTo(8));
            }
        }
    }
}
