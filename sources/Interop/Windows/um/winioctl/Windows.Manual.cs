// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid GUID_DEVINTERFACE_DISK = new Guid(0x53F56307, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_CDROM = new Guid(0x53F56308, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_PARTITION = new Guid(0x53F5630A, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_TAPE = new Guid(0x53F5630B, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_WRITEONCEDISK = new Guid(0x53F5630C, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_VOLUME = new Guid(0x53F5630D, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_MEDIUMCHANGER = new Guid(0x53F56310, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_FLOPPY = new Guid(0x53F56311, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_CDCHANGER = new Guid(0x53F56312, 0xB6BF, 0x11D0, 0x94, 0xF2, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_STORAGEPORT = new Guid(0x2ACCFE60, 0xC130, 0x11D2, 0xB0, 0x82, 0x00, 0xA0, 0xC9, 0x1E, 0xFB, 0x8B);

        public static readonly Guid GUID_DEVINTERFACE_VMLUN = new Guid(0x6F416619, 0x9F29, 0x42A5, 0xB2, 0x0B, 0x37, 0xE2, 0x19, 0xCA, 0x02, 0xB0);

        public static readonly Guid GUID_DEVINTERFACE_SES = new Guid(0x1790C9EC, 0x47D5, 0x4DF3, 0xB5, 0xAF, 0x9A, 0xDF, 0x3C, 0xF2, 0x3E, 0x48);

        public static readonly Guid GUID_DEVINTERFACE_SERVICE_VOLUME = new Guid(0x6EAD3D82, 0x25EC, 0x46BC, 0xB7, 0xFD, 0xC1, 0xF0, 0xDF, 0x8F, 0x50, 0x37);

        public static readonly Guid GUID_DEVINTERFACE_HIDDEN_VOLUME = new Guid(0x7F108A28, 0x9833, 0x4B3B, 0xB7, 0x80, 0x2C, 0x6B, 0x5F, 0xA5, 0xC0, 0x62);

        public static readonly Guid GUID_DEVINTERFACE_UNIFIED_ACCESS_RPMB = new Guid(0x27447C21, 0xBCC3, 0x4D07, 0xA0, 0x5B, 0xA3, 0x39, 0x5B, 0xB4, 0xEE, 0xE7);

        public static readonly Guid GUID_DEVINTERFACE_SCM_PHYSICAL_DEVICE = new Guid(0x4283609D, 0x4DC2, 0x43BE, 0xBB, 0xB4, 0x4F, 0x15, 0xDF, 0xCE, 0x2C, 0x61);

        public static readonly Guid GUID_SCM_PD_HEALTH_NOTIFICATION = new Guid(0x9DA2D386, 0x72F5, 0x4EE3, 0x81, 0x55, 0xEC, 0xA0, 0x67, 0x8E, 0x3B, 0x6);

        public static readonly Guid GUID_SCM_PD_PASSTHROUGH_INVDIMM = new Guid(0x4309AC30, 0x0D11, 0x11E4, 0x91, 0x91, 0x08, 0x00, 0x20, 0x0C, 0x9A, 0x66);

        public static readonly Guid GUID_DEVINTERFACE_COMPORT = new Guid(0x86E0D1E0, 0x8089, 0x11D0, 0x9C, 0xE4, 0x08, 0x00, 0x3E, 0x30, 0x1F, 0x73);

        public static readonly Guid GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR = new Guid(0x4D36E978, 0xE325, 0x11CE, 0xBF, 0xC1, 0x08, 0x00, 0x2B, 0xE1, 0x03, 0x18);

        public static readonly Guid FILE_TYPE_NOTIFICATION_GUID_PAGE_FILE = new Guid(0x0D0A64A1, 0x38FC, 0x4DB8, 0x9F, 0xE7, 0x3F, 0x43, 0x52, 0xCD, 0x7C, 0x5C);

        public static readonly Guid FILE_TYPE_NOTIFICATION_GUID_HIBERNATION_FILE = new Guid(0xB7624D64, 0xB9A3, 0x4CF8, 0x80, 0x11, 0x5B, 0x86, 0xC9, 0x40, 0xE7, 0xB7);

        public static readonly Guid FILE_TYPE_NOTIFICATION_GUID_CRASHDUMP_FILE = new Guid(0x9D453EB7, 0xD2A6, 0x4DBD, 0xA2, 0xE3, 0xFB, 0xD0, 0xED, 0x91, 0x09, 0xA9);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CTL_CODE(int DeviceType, int Function, int Method, int Access) => (DeviceType << 16) | (Access << 14) | (Function << 2) | Method;
    }
}
