// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct REG_PROVIDER
{
    [NativeTypeName("PQUERYHANDLER")]
    public delegate* unmanaged<void*, val_context*, uint, void*, uint*, uint, uint> pi_R0_1val;

    [NativeTypeName("PQUERYHANDLER")]
    public delegate* unmanaged<void*, val_context*, uint, void*, uint*, uint, uint> pi_R0_allvals;

    [NativeTypeName("PQUERYHANDLER")]
    public delegate* unmanaged<void*, val_context*, uint, void*, uint*, uint, uint> pi_R3_1val;

    [NativeTypeName("PQUERYHANDLER")]
    public delegate* unmanaged<void*, val_context*, uint, void*, uint*, uint, uint> pi_R3_allvals;

    [NativeTypeName("DWORD")]
    public uint pi_flags;

    [NativeTypeName("LPVOID")]
    public void* pi_key_context;
}
