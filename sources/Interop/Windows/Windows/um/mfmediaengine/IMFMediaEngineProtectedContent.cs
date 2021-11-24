// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
[Guid("9F8021E8-9C8C-487E-BB5C-79AA4779938C")]
[NativeTypeName("struct IMFMediaEngineProtectedContent : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineProtectedContent : IMFMediaEngineProtectedContent.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, uint>)(lpVtbl[1]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, uint>)(lpVtbl[2]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShareResources(IUnknown* pUnkDeviceContext)
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, IUnknown*, int>)(lpVtbl[3]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pUnkDeviceContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRequiredProtections([NativeTypeName("DWORD *")] uint* pFrameProtectionFlags)
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, uint*, int>)(lpVtbl[4]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pFrameProtectionFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOPMWindow(HWND hwnd)
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, HWND, int>)(lpVtbl[5]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TransferVideoFrame(IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr, [NativeTypeName("DWORD *")] uint* pFrameProtectionFlags)
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, uint*, int>)(lpVtbl[6]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr, pFrameProtectionFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetContentProtectionManager(IMFContentProtectionManager* pCPM)
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, IMFContentProtectionManager*, int>)(lpVtbl[7]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pCPM);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetApplicationCertificate([NativeTypeName("const BYTE *")] byte* pbBlob, [NativeTypeName("DWORD")] uint cbBlob)
    {
        return ((delegate* unmanaged<IMFMediaEngineProtectedContent*, byte*, uint, int>)(lpVtbl[8]))((IMFMediaEngineProtectedContent*)Unsafe.AsPointer(ref this), pbBlob, cbBlob);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShareResources(IUnknown* pUnkDeviceContext);

        [VtblIndex(4)]
        HRESULT GetRequiredProtections([NativeTypeName("DWORD *")] uint* pFrameProtectionFlags);

        [VtblIndex(5)]
        HRESULT SetOPMWindow(HWND hwnd);

        [VtblIndex(6)]
        HRESULT TransferVideoFrame(IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr, [NativeTypeName("DWORD *")] uint* pFrameProtectionFlags);

        [VtblIndex(7)]
        HRESULT SetContentProtectionManager(IMFContentProtectionManager* pCPM);

        [VtblIndex(8)]
        HRESULT SetApplicationCertificate([NativeTypeName("const BYTE *")] byte* pbBlob, [NativeTypeName("DWORD")] uint cbBlob);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, IUnknown*, int> ShareResources;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, uint*, int> GetRequiredProtections;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, HWND, int> SetOPMWindow;

        [NativeTypeName("HRESULT (IUnknown *, const MFVideoNormalizedRect *, const RECT *, const MFARGB *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, uint*, int> TransferVideoFrame;

        [NativeTypeName("HRESULT (IMFContentProtectionManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, IMFContentProtectionManager*, int> SetContentProtectionManager;

        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineProtectedContent*, byte*, uint, int> SetApplicationCertificate;
    }
}
