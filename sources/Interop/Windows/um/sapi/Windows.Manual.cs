// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static ulong SPFEI(int SPEI_ord) => ((1UL << SPEI_ord) | SPFEI_FLAGCHECK);

        public static ref Guid LIBID_SpeechLib
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0xCA, 0x66, 0xC8,
                    0xF7, 0x32,
                    0xD2, 0x11,
                    0x96,
                    0x02,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
