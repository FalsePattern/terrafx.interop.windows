// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TS_ATTRVAL
    {
        [NativeTypeName("TS_ATTRID")]
        public Guid idAttr;

        [NativeTypeName("DWORD")]
        public uint dwOverlapId;

        public VARIANT varValue;
    }
}
