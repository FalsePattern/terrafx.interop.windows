// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct WS_XML_WRITER_BINARY_ENCODING
{
    public WS_XML_WRITER_ENCODING encoding;

    public WS_XML_DICTIONARY* staticDictionary;

    [NativeTypeName("WS_DYNAMIC_STRING_CALLBACK")]
    public delegate* unmanaged<void*, WS_XML_STRING*, BOOL*, uint*, IntPtr, HRESULT> dynamicStringCallback;

    public void* dynamicStringCallbackState;
}
