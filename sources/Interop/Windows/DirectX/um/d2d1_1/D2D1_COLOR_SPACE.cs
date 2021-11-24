// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public enum D2D1_COLOR_SPACE : uint
{
    D2D1_COLOR_SPACE_CUSTOM = 0,
    D2D1_COLOR_SPACE_SRGB = 1,
    D2D1_COLOR_SPACE_SCRGB = 2,
    D2D1_COLOR_SPACE_FORCE_DWORD = 0xffffffff,
}
