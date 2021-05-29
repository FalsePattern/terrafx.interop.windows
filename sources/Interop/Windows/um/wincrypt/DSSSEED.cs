// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DSSSEED
    {
        [NativeTypeName("DWORD")]
        public uint counter;

        [NativeTypeName("BYTE [20]")]
        public fixed byte seed[20];
    }
}
