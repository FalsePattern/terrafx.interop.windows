// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct DLLVERSIONINFO2
{
    public DLLVERSIONINFO info1;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("ULONGLONG")]
    public ulong ullVersion;
}
