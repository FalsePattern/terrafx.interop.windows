// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class E
{
    [NativeTypeName("#define E_FLAGS MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x1000)")]
    public const int E_FLAGS = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x1000))));
}
