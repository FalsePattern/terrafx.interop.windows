// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public enum WCM_CONNECTION_COST_SOURCE
{
    WCM_CONNECTION_COST_SOURCE_DEFAULT = 0,
    WCM_CONNECTION_COST_SOURCE_GP = 1,
    WCM_CONNECTION_COST_SOURCE_USER = 2,
    WCM_CONNECTION_COST_SOURCE_OPERATOR = 3,
}
