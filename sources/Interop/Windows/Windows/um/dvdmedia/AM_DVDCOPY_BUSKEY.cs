// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct AM_DVDCOPY_BUSKEY
{
    [NativeTypeName("BYTE [5]")]
    public fixed byte BusKey[5];

    [NativeTypeName("BYTE [1]")]
    public fixed byte Reserved[1];
}
