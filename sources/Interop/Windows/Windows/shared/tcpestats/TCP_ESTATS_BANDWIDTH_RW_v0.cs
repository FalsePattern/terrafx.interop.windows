// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct TCP_ESTATS_BANDWIDTH_RW_v0
{
    public TCP_BOOLEAN_OPTIONAL EnableCollectionOutbound;

    public TCP_BOOLEAN_OPTIONAL EnableCollectionInbound;
}
