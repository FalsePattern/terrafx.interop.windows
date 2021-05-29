// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppxContentGroup" /> struct.</summary>
    public static unsafe class IAppxContentGroupTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxContentGroup" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppxContentGroup).GUID, Is.EqualTo(IID_IAppxContentGroup));
        }

        /// <summary>Validates that the <see cref="IAppxContentGroup" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppxContentGroup>(), Is.EqualTo(sizeof(IAppxContentGroup)));
        }

        /// <summary>Validates that the <see cref="IAppxContentGroup" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppxContentGroup).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppxContentGroup" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppxContentGroup), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppxContentGroup), Is.EqualTo(4));
            }
        }
    }
}
