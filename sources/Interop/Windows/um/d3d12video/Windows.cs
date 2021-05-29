// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG2 = new Guid(0xee27417f, 0x5e28, 0x4e65, 0xbe, 0xea, 0x1d, 0x26, 0xb5, 0x08, 0xad, 0xc9);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2 = new Guid(0x86695f12, 0x340e, 0x4f04, 0x9f, 0xd3, 0x92, 0x53, 0xdd, 0x32, 0x74, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264 = new Guid(0x1b81be68, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVE = new Guid(0xd79be8da, 0x0cf1, 0x4c81, 0xb8, 0x2a, 0x69, 0xa4, 0xe2, 0x36, 0xf4, 0x3d);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_STEREO = new Guid(0xf9aaccbb, 0xc2b6, 0x4cfc, 0x87, 0x79, 0x57, 0x07, 0xb1, 0x76, 0x05, 0x52);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEW = new Guid(0x705b9d82, 0x76cf, 0x49d6, 0xb7, 0xe6, 0xac, 0x88, 0x72, 0xdb, 0x01, 0x3c);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_VC1 = new Guid(0x1b81beA3, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_VC1_D2010 = new Guid(0x1b81beA4, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLE = new Guid(0xefd64d74, 0xc9e8, 0x41d7, 0xa5, 0xe9, 0xe9, 0xb0, 0xe3, 0x9f, 0xa3, 0x19);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMC = new Guid(0xed418a9f, 0x010d, 0x4eda, 0x9a, 0xe3, 0x9a, 0x65, 0x35, 0x8d, 0x8d, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN = new Guid(0x5b11d51b, 0x2f4c, 0x4452, 0xbc, 0xc3, 0x09, 0xf2, 0xa1, 0x16, 0x0c, 0xc0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10 = new Guid(0x107af0e0, 0xef1a, 0x4d19, 0xab, 0xa8, 0x67, 0xa1, 0x63, 0x07, 0x3d, 0x13);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP9 = new Guid(0x463707f8, 0xa1d0, 0x4585, 0x87, 0x6d, 0x83, 0xaa, 0x6d, 0x60, 0xb8, 0x9e);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2 = new Guid(0xa4c749ef, 0x6ecf, 0x48aa, 0x84, 0x48, 0x50, 0xa7, 0xa1, 0x16, 0x5f, 0xf7);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP8 = new Guid(0x90b899ea, 0x3a62, 0x4705, 0x88, 0xb3, 0x8d, 0xf0, 0x4b, 0x27, 0x44, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0 = new Guid(0xb8be4ccb, 0xcf53, 0x46ba, 0x8d, 0x59, 0xd6, 0xb8, 0xa6, 0xda, 0x5d, 0x2a);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1 = new Guid(0x6936ff0f, 0x45b1, 0x4163, 0x9c, 0xc1, 0x64, 0x6e, 0xf6, 0x94, 0x61, 0x08);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2 = new Guid(0x0c5f2aa1, 0xe541, 0x4089, 0xbb, 0x7b, 0x98, 0x11, 0x0a, 0x19, 0xd7, 0xc8);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2 = new Guid(0x17127009, 0xa00f, 0x4ce1, 0x99, 0x4e, 0xbf, 0x40, 0x81, 0xf6, 0xf3, 0xf0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420 = new Guid(0x2d80bed6, 0x9cac, 0x4835, 0x9e, 0x91, 0x32, 0x7b, 0xbc, 0x4f, 0x9e, 0xe8);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDecoderHeap = new Guid(0x0946B7C9, 0xEBF6, 0x4047, 0xBB, 0x73, 0x86, 0x83, 0xE2, 0x7D, 0xBB, 0x1F);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDevice = new Guid(0x1F052807, 0x0B46, 0x4ACC, 0x8A, 0x89, 0x36, 0x4F, 0x79, 0x37, 0x18, 0xA4);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDecoder = new Guid(0xC59B6BDC, 0x7720, 0x4074, 0xA1, 0x36, 0x17, 0xA1, 0x56, 0x03, 0x74, 0x70);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoProcessor = new Guid(0x304FDB32, 0xBEDE, 0x410A, 0x85, 0x45, 0x94, 0x3A, 0xC6, 0xA4, 0x61, 0x38);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDecodeCommandList = new Guid(0x3B60536E, 0xAD29, 0x4E64, 0xA2, 0x69, 0xF8, 0x53, 0x83, 0x7E, 0x5E, 0x53);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoProcessCommandList = new Guid(0xAEB2543A, 0x167F, 0x4682, 0xAC, 0xC8, 0xD1, 0x59, 0xED, 0x4A, 0x62, 0x09);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDecodeCommandList1 = new Guid(0xD52F011B, 0xB56E, 0x453C, 0xA0, 0x5A, 0xA7, 0xF3, 0x11, 0xC8, 0xF4, 0x72);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoProcessCommandList1 = new Guid(0x542C5C4D, 0x7596, 0x434F, 0x8C, 0x93, 0x4E, 0xFA, 0x67, 0x66, 0xF2, 0x67);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoMotionEstimator = new Guid(0x33FDAE0E, 0x098B, 0x428F, 0x87, 0xBB, 0x34, 0xB6, 0x95, 0xDE, 0x08, 0xF8);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoMotionVectorHeap = new Guid(0x5BE17987, 0x743A, 0x4061, 0x83, 0x4B, 0x23, 0xD2, 0x2D, 0xAE, 0xA5, 0x05);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDevice1 = new Guid(0x981611AD, 0xA144, 0x4C83, 0x98, 0x90, 0xF3, 0x0E, 0x26, 0xD6, 0x58, 0xAB);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoEncodeCommandList = new Guid(0x8455293A, 0x0CBD, 0x4831, 0x9B, 0x39, 0xFB, 0xDB, 0xAB, 0x72, 0x47, 0x23);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDecoder1 = new Guid(0x79A2E5FB, 0xCCD2, 0x469A, 0x9F, 0xDE, 0x19, 0x5D, 0x10, 0x95, 0x1F, 0x7E);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDecoderHeap1 = new Guid(0xDA1D98C5, 0x539F, 0x41B2, 0xBF, 0x6B, 0x11, 0x98, 0xA0, 0x3B, 0x6D, 0x26);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoProcessor1 = new Guid(0xF3CFE615, 0x553F, 0x425C, 0x86, 0xD8, 0xEE, 0x8C, 0x1B, 0x1F, 0xB0, 0x1C);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoExtensionCommand = new Guid(0x554E41E8, 0xAE8E, 0x4A8C, 0xB7, 0xD2, 0x5B, 0x4F, 0x27, 0x4A, 0x30, 0xE4);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDevice2 = new Guid(0xF019AC49, 0xF838, 0x4A95, 0x9B, 0x17, 0x57, 0x94, 0x37, 0xC8, 0xF5, 0x13);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoDecodeCommandList2 = new Guid(0x6e120880, 0xc114, 0x4153, 0x80, 0x36, 0xd2, 0x47, 0x05, 0x1e, 0x17, 0x29);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoProcessCommandList2 = new Guid(0xdb525ae4, 0x6ad6, 0x473c, 0xba, 0xa7, 0x59, 0xb2, 0xe3, 0x70, 0x82, 0xe4);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D12VideoEncodeCommandList1 = new Guid(0x94971eca, 0x2bdb, 0x4769, 0x88, 0xcf, 0x36, 0x75, 0xea, 0x75, 0x7e, 0xbc);
    }
}
