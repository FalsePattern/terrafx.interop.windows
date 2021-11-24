// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct EMRPOLYDRAW16
{
    public EMR emr;

    public RECTL rclBounds;

    [NativeTypeName("DWORD")]
    public uint cpts;

    [NativeTypeName("POINTS [1]")]
    public _apts_e__FixedBuffer apts;

    [NativeTypeName("BYTE [1]")]
    public fixed byte abTypes[1];

    public partial struct _apts_e__FixedBuffer
    {
        public POINTS e0;

        public ref POINTS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<POINTS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
