// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum SYNCMGRLOGLEVEL
{
    SYNCMGRLOGLEVEL_INFORMATION = 0x1,
    SYNCMGRLOGLEVEL_WARNING = 0x2,
    SYNCMGRLOGLEVEL_ERROR = 0x3,
    SYNCMGRLOGLEVEL_LOGLEVELMAX = 0x3,
}
