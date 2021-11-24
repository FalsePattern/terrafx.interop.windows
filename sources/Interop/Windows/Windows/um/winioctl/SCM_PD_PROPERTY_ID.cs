// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum SCM_PD_PROPERTY_ID
{
    ScmPhysicalDeviceProperty_DeviceInfo = 0,
    ScmPhysicalDeviceProperty_ManagementStatus,
    ScmPhysicalDeviceProperty_FirmwareInfo,
    ScmPhysicalDeviceProperty_LocationString,
    ScmPhysicalDeviceProperty_DeviceSpecificInfo,
    ScmPhysicalDeviceProperty_DeviceHandle,
    ScmPhysicalDeviceProperty_FruIdString,
    ScmPhysicalDeviceProperty_RuntimeFwActivationInfo,
    ScmPhysicalDeviceProperty_RuntimeFwActivationArmState,
    ScmPhysicalDeviceProperty_Max,
}
