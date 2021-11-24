// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_DEVICE_INTERFACE_DETAIL_DATA_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_DEVICE_INTERFACE_DETAIL_DATA32_A));
            }
            else
            {
                return (uint)(sizeof(SP_DEVICE_INTERFACE_DETAIL_DATA64_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_DEVICE_INTERFACE_DETAIL_DATA32_A _value32;

    [FieldOffset(0)]
    public SP_DEVICE_INTERFACE_DETAIL_DATA64_A _value64;

    [NativeTypeName("DWORD")]
    public ref uint cbSize
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
            }
        }
    }

    [NativeTypeName("CHAR [1]")]
    public Span<sbyte> DevicePath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.DevicePath[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.DevicePath[0], 1);
            }
        }
    }
}
