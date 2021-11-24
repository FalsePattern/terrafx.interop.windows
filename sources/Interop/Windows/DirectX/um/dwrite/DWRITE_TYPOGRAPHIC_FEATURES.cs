// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DWRITE_TYPOGRAPHIC_FEATURES
{
    public DWRITE_FONT_FEATURE* features;

    [NativeTypeName("UINT32")]
    public uint featureCount;
}
