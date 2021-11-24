// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public enum D3D12_DRED_ALLOCATION_TYPE
{
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_QUEUE = 19,
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_ALLOCATOR = 20,
    D3D12_DRED_ALLOCATION_TYPE_PIPELINE_STATE = 21,
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_LIST = 22,
    D3D12_DRED_ALLOCATION_TYPE_FENCE = 23,
    D3D12_DRED_ALLOCATION_TYPE_DESCRIPTOR_HEAP = 24,
    D3D12_DRED_ALLOCATION_TYPE_HEAP = 25,
    D3D12_DRED_ALLOCATION_TYPE_QUERY_HEAP = 27,
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_SIGNATURE = 28,
    D3D12_DRED_ALLOCATION_TYPE_PIPELINE_LIBRARY = 29,
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER = 30,
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_PROCESSOR = 32,
    D3D12_DRED_ALLOCATION_TYPE_RESOURCE = 34,
    D3D12_DRED_ALLOCATION_TYPE_PASS = 35,
    D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSION = 36,
    D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSIONPOLICY = 37,
    D3D12_DRED_ALLOCATION_TYPE_PROTECTEDRESOURCESESSION = 38,
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER_HEAP = 39,
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_POOL = 40,
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_RECORDER = 41,
    D3D12_DRED_ALLOCATION_TYPE_STATE_OBJECT = 42,
    D3D12_DRED_ALLOCATION_TYPE_METACOMMAND = 43,
    D3D12_DRED_ALLOCATION_TYPE_SCHEDULINGGROUP = 44,
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_ESTIMATOR = 45,
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_VECTOR_HEAP = 46,
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_EXTENSION_COMMAND = 47,
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER = 48,
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER_HEAP = 49,
    D3D12_DRED_ALLOCATION_TYPE_INVALID = unchecked((int)(0xffffffff)),
}
