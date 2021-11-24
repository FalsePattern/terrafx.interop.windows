// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct MODLOAD_DATA
{
    [NativeTypeName("DWORD")]
    public uint ssize;

    [NativeTypeName("DWORD")]
    public uint ssig;

    [NativeTypeName("PVOID")]
    public void* data;

    [NativeTypeName("DWORD")]
    public uint size;

    [NativeTypeName("DWORD")]
    public uint flags;
}
