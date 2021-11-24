// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct WS_ENUM_DESCRIPTION
{
    public WS_ENUM_VALUE* values;

    [NativeTypeName("ULONG")]
    public uint valueCount;

    [NativeTypeName("ULONG")]
    public uint maxByteCount;

    [NativeTypeName("ULONG *")]
    public uint* nameIndices;
}
