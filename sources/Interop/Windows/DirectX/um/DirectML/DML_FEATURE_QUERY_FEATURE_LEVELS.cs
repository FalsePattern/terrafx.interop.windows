// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DML_FEATURE_QUERY_FEATURE_LEVELS
{
    public uint RequestedFeatureLevelCount;

    [NativeTypeName("const DML_FEATURE_LEVEL *")]
    public DML_FEATURE_LEVEL* RequestedFeatureLevels;
}
