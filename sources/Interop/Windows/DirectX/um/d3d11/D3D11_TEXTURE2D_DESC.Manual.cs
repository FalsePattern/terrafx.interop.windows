// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.D3D11_BIND_FLAG;
using static TerraFX.Interop.DirectX.D3D11_USAGE;

namespace TerraFX.Interop.DirectX;

public partial struct D3D11_TEXTURE2D_DESC
{
    public D3D11_TEXTURE2D_DESC(DXGI_FORMAT format, uint width, uint height, uint arraySize = 1, uint mipLevels = 0, uint bindFlags = (uint)D3D11_BIND_SHADER_RESOURCE, D3D11_USAGE usage = D3D11_USAGE_DEFAULT, uint cpuaccessFlags = 0, uint sampleCount = 1, uint sampleQuality = 0, uint miscFlags = 0)
    {
        Width = width;
        Height = height;
        MipLevels = mipLevels;
        ArraySize = arraySize;
        Format = format;
        SampleDesc.Count = sampleCount;
        SampleDesc.Quality = sampleQuality;
        Usage = usage;
        BindFlags = bindFlags;
        CPUAccessFlags = cpuaccessFlags;
        MiscFlags = miscFlags;
    }
}
