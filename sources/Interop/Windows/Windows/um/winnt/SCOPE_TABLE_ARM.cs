// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct SCOPE_TABLE_ARM
{
    [NativeTypeName("DWORD")]
    public uint Count;

    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:4455:5) [1]")]
    public _ScopeRecord_e__FixedBuffer ScopeRecord;

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint BeginAddress;

        [NativeTypeName("DWORD")]
        public uint EndAddress;

        [NativeTypeName("DWORD")]
        public uint HandlerAddress;

        [NativeTypeName("DWORD")]
        public uint JumpTarget;
    }

    public partial struct _ScopeRecord_e__FixedBuffer
    {
        public _Anonymous_e__Struct e0;

        public ref _Anonymous_e__Struct this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<_Anonymous_e__Struct> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
