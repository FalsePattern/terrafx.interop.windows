// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum SYNCMGRITEMFLAGS
{
    SYNCMGRITEM_HASPROPERTIES = 0x1,
    SYNCMGRITEM_TEMPORARY = 0x2,
    SYNCMGRITEM_ROAMINGUSER = 0x4,
    SYNCMGRITEM_LASTUPDATETIME = 0x8,
    SYNCMGRITEM_MAYDELETEITEM = 0x10,
    SYNCMGRITEM_HIDDEN = 0x20,
}
