// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct TVITEMA
{
    public uint mask;

    public HTREEITEM hItem;

    public uint state;

    public uint stateMask;

    [NativeTypeName("LPSTR")]
    public sbyte* pszText;

    public int cchTextMax;

    public int iImage;

    public int iSelectedImage;

    public int cChildren;

    public LPARAM lParam;
}
