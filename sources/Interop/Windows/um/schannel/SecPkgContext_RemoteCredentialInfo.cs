// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SecPkgContext_RemoteCredentialInfo
    {
        [NativeTypeName("DWORD")]
        public uint cbCertificateChain;

        [NativeTypeName("PBYTE")]
        public byte* pbCertificateChain;

        [NativeTypeName("DWORD")]
        public uint cCertificates;

        [NativeTypeName("DWORD")]
        public uint fFlags;

        [NativeTypeName("DWORD")]
        public uint dwBits;
    }
}
