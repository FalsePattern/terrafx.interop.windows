// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D10_SUBRESOURCE_DATA
{
    [NativeTypeName("const void *")]
    public void* pSysMem;

    public uint SysMemPitch;

    public uint SysMemSlicePitch;
}
