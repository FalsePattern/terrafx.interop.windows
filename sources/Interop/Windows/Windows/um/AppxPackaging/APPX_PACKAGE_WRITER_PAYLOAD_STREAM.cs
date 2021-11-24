// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows10.0")]
public unsafe partial struct APPX_PACKAGE_WRITER_PAYLOAD_STREAM
{
    public IStream* inputStream;

    [NativeTypeName("LPCWSTR")]
    public ushort* fileName;

    [NativeTypeName("LPCWSTR")]
    public ushort* contentType;

    public APPX_COMPRESSION_OPTION compressionOption;
}
