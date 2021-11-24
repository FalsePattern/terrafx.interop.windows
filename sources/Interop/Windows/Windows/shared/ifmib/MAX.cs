// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_INTERFACE_NAME_LEN 256")]
    public const int MAX_INTERFACE_NAME_LEN = 256;
}
