// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public enum D2D1_GAMMATRANSFER_PROP : uint
{
    D2D1_GAMMATRANSFER_PROP_RED_AMPLITUDE = 0,
    D2D1_GAMMATRANSFER_PROP_RED_EXPONENT = 1,
    D2D1_GAMMATRANSFER_PROP_RED_OFFSET = 2,
    D2D1_GAMMATRANSFER_PROP_RED_DISABLE = 3,
    D2D1_GAMMATRANSFER_PROP_GREEN_AMPLITUDE = 4,
    D2D1_GAMMATRANSFER_PROP_GREEN_EXPONENT = 5,
    D2D1_GAMMATRANSFER_PROP_GREEN_OFFSET = 6,
    D2D1_GAMMATRANSFER_PROP_GREEN_DISABLE = 7,
    D2D1_GAMMATRANSFER_PROP_BLUE_AMPLITUDE = 8,
    D2D1_GAMMATRANSFER_PROP_BLUE_EXPONENT = 9,
    D2D1_GAMMATRANSFER_PROP_BLUE_OFFSET = 10,
    D2D1_GAMMATRANSFER_PROP_BLUE_DISABLE = 11,
    D2D1_GAMMATRANSFER_PROP_ALPHA_AMPLITUDE = 12,
    D2D1_GAMMATRANSFER_PROP_ALPHA_EXPONENT = 13,
    D2D1_GAMMATRANSFER_PROP_ALPHA_OFFSET = 14,
    D2D1_GAMMATRANSFER_PROP_ALPHA_DISABLE = 15,
    D2D1_GAMMATRANSFER_PROP_CLAMP_OUTPUT = 16,
    D2D1_GAMMATRANSFER_PROP_FORCE_DWORD = 0xffffffff,
}
