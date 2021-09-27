// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Print3DManagerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static ref readonly Guid IID_IPrinting3DManagerInterop
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x10, 0xA3, 0x9C,
                    0x84, 0x14,
                    0x87, 0x45,
                    0xB2,
                    0x6B,
                    0xDD,
                    0xDF,
                    0x9F,
                    0x9C,
                    0xAE,
                    0xCD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
