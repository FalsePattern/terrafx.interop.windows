// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum BEHAVIOR_RENDER_INFO
{
    BEHAVIORRENDERINFO_BEFOREBACKGROUND = 0x1,
    BEHAVIORRENDERINFO_AFTERBACKGROUND = 0x2,
    BEHAVIORRENDERINFO_BEFORECONTENT = 0x4,
    BEHAVIORRENDERINFO_AFTERCONTENT = 0x8,
    BEHAVIORRENDERINFO_AFTERFOREGROUND = 0x20,
    BEHAVIORRENDERINFO_ABOVECONTENT = 0x28,
    BEHAVIORRENDERINFO_ALLLAYERS = 0xff,
    BEHAVIORRENDERINFO_DISABLEBACKGROUND = 0x100,
    BEHAVIORRENDERINFO_DISABLENEGATIVEZ = 0x200,
    BEHAVIORRENDERINFO_DISABLECONTENT = 0x400,
    BEHAVIORRENDERINFO_DISABLEPOSITIVEZ = 0x800,
    BEHAVIORRENDERINFO_DISABLEALLLAYERS = 0xf00,
    BEHAVIORRENDERINFO_HITTESTING = 0x1000,
    BEHAVIORRENDERINFO_SURFACE = 0x100000,
    BEHAVIORRENDERINFO_3DSURFACE = 0x200000,
    BEHAVIOR_RENDER_INFO_Max = 2147483647,
}
