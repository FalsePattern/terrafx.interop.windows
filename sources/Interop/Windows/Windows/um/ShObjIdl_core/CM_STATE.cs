// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

[Flags]
public enum CM_STATE
{
    CM_STATE_NONE = 0,
    CM_STATE_VISIBLE = 0x1,
    CM_STATE_FIXEDWIDTH = 0x2,
    CM_STATE_NOSORTBYFOLDERNESS = 0x4,
    CM_STATE_ALWAYSVISIBLE = 0x8,
}
