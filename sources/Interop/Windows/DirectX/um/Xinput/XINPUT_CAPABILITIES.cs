// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public partial struct XINPUT_CAPABILITIES
{
    public byte Type;

    public byte SubType;

    [NativeTypeName("WORD")]
    public ushort Flags;

    public XINPUT_GAMEPAD Gamepad;

    public XINPUT_VIBRATION Vibration;
}
