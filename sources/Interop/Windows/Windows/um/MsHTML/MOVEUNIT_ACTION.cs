// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum MOVEUNIT_ACTION
{
    MOVEUNIT_PREVCHAR = 0,
    MOVEUNIT_NEXTCHAR = 1,
    MOVEUNIT_PREVCLUSTERBEGIN = 2,
    MOVEUNIT_NEXTCLUSTERBEGIN = 3,
    MOVEUNIT_PREVCLUSTEREND = 4,
    MOVEUNIT_NEXTCLUSTEREND = 5,
    MOVEUNIT_PREVWORDBEGIN = 6,
    MOVEUNIT_NEXTWORDBEGIN = 7,
    MOVEUNIT_PREVWORDEND = 8,
    MOVEUNIT_NEXTWORDEND = 9,
    MOVEUNIT_PREVPROOFWORD = 10,
    MOVEUNIT_NEXTPROOFWORD = 11,
    MOVEUNIT_NEXTURLBEGIN = 12,
    MOVEUNIT_PREVURLBEGIN = 13,
    MOVEUNIT_NEXTURLEND = 14,
    MOVEUNIT_PREVURLEND = 15,
    MOVEUNIT_PREVSENTENCE = 16,
    MOVEUNIT_NEXTSENTENCE = 17,
    MOVEUNIT_PREVBLOCK = 18,
    MOVEUNIT_NEXTBLOCK = 19,
    MOVEUNIT_ACTION_Max = 2147483647,
}
