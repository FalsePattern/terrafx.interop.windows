// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_THUMBNAIL_PROPERTIES
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    public RECT rcDestination;

    public RECT rcSource;

    public byte opacity;

    public BOOL fVisible;

    public BOOL fSourceClientAreaOnly;
}
