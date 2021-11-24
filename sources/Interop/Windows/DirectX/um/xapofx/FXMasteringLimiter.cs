// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

[Guid("C4137916-2BE1-46FD-8599-441536F49856")]
public partial struct FXMasteringLimiter
{
    [NativeTypeName("#define FXMASTERINGLIMITER_MIN_RELEASE 1")]
    public const int FXMASTERINGLIMITER_MIN_RELEASE = 1;

    [NativeTypeName("#define FXMASTERINGLIMITER_MAX_RELEASE 20")]
    public const int FXMASTERINGLIMITER_MAX_RELEASE = 20;

    [NativeTypeName("#define FXMASTERINGLIMITER_DEFAULT_RELEASE 6")]
    public const int FXMASTERINGLIMITER_DEFAULT_RELEASE = 6;

    [NativeTypeName("#define FXMASTERINGLIMITER_MIN_LOUDNESS 1")]
    public const int FXMASTERINGLIMITER_MIN_LOUDNESS = 1;

    [NativeTypeName("#define FXMASTERINGLIMITER_MAX_LOUDNESS 1800")]
    public const int FXMASTERINGLIMITER_MAX_LOUDNESS = 1800;

    [NativeTypeName("#define FXMASTERINGLIMITER_DEFAULT_LOUDNESS 1000")]
    public const int FXMASTERINGLIMITER_DEFAULT_LOUDNESS = 1000;
}
