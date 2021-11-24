// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum EC_HOST_UI_MODE
{
    ECHUIM_DESKTOP = 0,
    ECHUIM_IMMERSIVE = (ECHUIM_DESKTOP + 1),
    ECHUIM_SYSTEM_LAUNCHER = (ECHUIM_IMMERSIVE + 1),
}
