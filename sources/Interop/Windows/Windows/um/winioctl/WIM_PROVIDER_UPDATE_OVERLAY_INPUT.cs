// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct WIM_PROVIDER_UPDATE_OVERLAY_INPUT
{
    public LARGE_INTEGER DataSourceId;

    [NativeTypeName("DWORD")]
    public uint WimFileNameOffset;

    [NativeTypeName("DWORD")]
    public uint WimFileNameLength;
}
