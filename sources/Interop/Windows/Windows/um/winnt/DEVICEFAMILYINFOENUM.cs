// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class DEVICEFAMILYINFOENUM
    {
        [NativeTypeName("#define DEVICEFAMILYINFOENUM_UAP 0x00000000")]
        public const int DEVICEFAMILYINFOENUM_UAP = 0x00000000;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_8X 0x00000001")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_8X = 0x00000001;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_PHONE_8X 0x00000002")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_PHONE_8X = 0x00000002;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_DESKTOP 0x00000003")]
        public const int DEVICEFAMILYINFOENUM_DESKTOP = 0x00000003;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_MOBILE 0x00000004")]
        public const int DEVICEFAMILYINFOENUM_MOBILE = 0x00000004;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOX 0x00000005")]
        public const int DEVICEFAMILYINFOENUM_XBOX = 0x00000005;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_TEAM 0x00000006")]
        public const int DEVICEFAMILYINFOENUM_TEAM = 0x00000006;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_IOT 0x00000007")]
        public const int DEVICEFAMILYINFOENUM_IOT = 0x00000007;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_IOT_HEADLESS 0x00000008")]
        public const int DEVICEFAMILYINFOENUM_IOT_HEADLESS = 0x00000008;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_SERVER 0x00000009")]
        public const int DEVICEFAMILYINFOENUM_SERVER = 0x00000009;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_HOLOGRAPHIC 0x0000000A")]
        public const int DEVICEFAMILYINFOENUM_HOLOGRAPHIC = 0x0000000A;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOXSRA 0x0000000B")]
        public const int DEVICEFAMILYINFOENUM_XBOXSRA = 0x0000000B;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOXERA 0x0000000C")]
        public const int DEVICEFAMILYINFOENUM_XBOXERA = 0x0000000C;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_SERVER_NANO 0x0000000D")]
        public const int DEVICEFAMILYINFOENUM_SERVER_NANO = 0x0000000D;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_8828080 0x0000000E")]
        public const int DEVICEFAMILYINFOENUM_8828080 = 0x0000000E;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_7067329 0x0000000F")]
        public const int DEVICEFAMILYINFOENUM_7067329 = 0x0000000F;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_CORE 0x00000010")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_CORE = 0x00000010;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_CORE_HEADLESS 0x00000011")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_CORE_HEADLESS = 0x00000011;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_MAX 0x00000011")]
        public const int DEVICEFAMILYINFOENUM_MAX = 0x00000011;
    }
}
