// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum msidbSumInfoSourceType
{
    msidbSumInfoSourceTypeSFN = 0x00000001,
    msidbSumInfoSourceTypeCompressed = 0x00000002,
    msidbSumInfoSourceTypeAdminImage = 0x00000004,
    msidbSumInfoSourceTypeLUAPackage = 0x00000008,
}
