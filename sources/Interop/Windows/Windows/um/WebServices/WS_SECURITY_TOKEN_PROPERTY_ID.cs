// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum WS_SECURITY_TOKEN_PROPERTY_ID
{
    WS_SECURITY_TOKEN_PROPERTY_KEY_TYPE = 1,
    WS_SECURITY_TOKEN_PROPERTY_VALID_FROM_TIME = 2,
    WS_SECURITY_TOKEN_PROPERTY_VALID_TILL_TIME = 3,
    WS_SECURITY_TOKEN_PROPERTY_SERIALIZED_XML = 4,
    WS_SECURITY_TOKEN_PROPERTY_ATTACHED_REFERENCE_XML = 5,
    WS_SECURITY_TOKEN_PROPERTY_UNATTACHED_REFERENCE_XML = 6,
    WS_SECURITY_TOKEN_PROPERTY_SYMMETRIC_KEY = 7,
}
