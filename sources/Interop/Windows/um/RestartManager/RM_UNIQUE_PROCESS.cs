// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RM_UNIQUE_PROCESS
    {
        [NativeTypeName("DWORD")]
        public uint dwProcessId;

        public FILETIME ProcessStartTime;
    }
}
