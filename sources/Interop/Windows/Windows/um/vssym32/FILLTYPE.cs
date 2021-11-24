// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum FILLTYPE
{
    FT_SOLID = 0,
    FT_VERTGRADIENT = 1,
    FT_HORZGRADIENT = 2,
    FT_RADIALGRADIENT = 3,
    FT_TILEIMAGE = 4,
}
