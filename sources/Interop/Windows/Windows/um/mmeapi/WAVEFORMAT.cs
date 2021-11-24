// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEFORMAT
{
    [NativeTypeName("WORD")]
    public ushort wFormatTag;

    [NativeTypeName("WORD")]
    public ushort nChannels;

    [NativeTypeName("DWORD")]
    public uint nSamplesPerSec;

    [NativeTypeName("DWORD")]
    public uint nAvgBytesPerSec;

    [NativeTypeName("WORD")]
    public ushort nBlockAlign;
}
