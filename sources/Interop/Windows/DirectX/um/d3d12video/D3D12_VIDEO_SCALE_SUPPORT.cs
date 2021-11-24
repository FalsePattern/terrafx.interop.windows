// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public partial struct D3D12_VIDEO_SCALE_SUPPORT
{
    public D3D12_VIDEO_SIZE_RANGE OutputSizeRange;

    public D3D12_VIDEO_SCALE_SUPPORT_FLAGS Flags;
}
