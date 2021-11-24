// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct RSOP_TARGET
{
    [NativeTypeName("WCHAR *")]
    public ushort* pwszAccountName;

    [NativeTypeName("WCHAR *")]
    public ushort* pwszNewSOM;

    public SAFEARRAY* psaSecurityGroups;

    [NativeTypeName("PRSOPTOKEN")]
    public void* pRsopToken;

    [NativeTypeName("PGROUP_POLICY_OBJECT")]
    public GROUP_POLICY_OBJECTW* pGPOList;

    public IWbemServices* pWbemServices;
}
