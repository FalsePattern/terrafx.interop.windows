// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FILE_DESIRED_STORAGE_CLASS_INFORMATION" /> struct.</summary>
    public static unsafe class FILE_DESIRED_STORAGE_CLASS_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="FILE_DESIRED_STORAGE_CLASS_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FILE_DESIRED_STORAGE_CLASS_INFORMATION>(), Is.EqualTo(sizeof(FILE_DESIRED_STORAGE_CLASS_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="FILE_DESIRED_STORAGE_CLASS_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FILE_DESIRED_STORAGE_CLASS_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FILE_DESIRED_STORAGE_CLASS_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FILE_DESIRED_STORAGE_CLASS_INFORMATION), Is.EqualTo(8));
        }
    }
}
