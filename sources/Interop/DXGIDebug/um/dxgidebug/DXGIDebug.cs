// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class DXGIDebug
    {
        private const string LibraryPath = "DXGIDebug";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "DXGIGetDebugInterface", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXGIGetDebugInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDebug);
    }
}
