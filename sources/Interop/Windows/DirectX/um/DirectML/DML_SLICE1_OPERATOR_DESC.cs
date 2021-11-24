// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DML_SLICE1_OPERATOR_DESC
{
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    public uint DimensionCount;

    [NativeTypeName("const UINT *")]
    public uint* InputWindowOffsets;

    [NativeTypeName("const UINT *")]
    public uint* InputWindowSizes;

    [NativeTypeName("const INT *")]
    public int* InputWindowStrides;
}
