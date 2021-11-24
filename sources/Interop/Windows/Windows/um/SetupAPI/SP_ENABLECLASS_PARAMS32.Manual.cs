// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SP_ENABLECLASS_PARAMS32
{
    public SP_CLASSINSTALL_HEADER32 ClassInstallHeader;

    public Guid ClassGuid;

    [NativeTypeName("DWORD")]
    public uint EnableMessage;
}
