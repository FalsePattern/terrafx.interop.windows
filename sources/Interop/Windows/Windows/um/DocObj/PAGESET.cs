// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct PAGESET
{
    [NativeTypeName("ULONG")]
    public uint cbStruct;

    public BOOL fOddPages;

    public BOOL fEvenPages;

    [NativeTypeName("ULONG")]
    public uint cPageRange;

    [NativeTypeName("PAGERANGE [1]")]
    public _rgPages_e__FixedBuffer rgPages;

    public partial struct _rgPages_e__FixedBuffer
    {
        public PAGERANGE e0;

        public ref PAGERANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<PAGERANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
