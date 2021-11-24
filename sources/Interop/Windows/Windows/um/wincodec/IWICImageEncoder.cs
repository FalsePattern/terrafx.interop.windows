// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
[Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999")]
[NativeTypeName("struct IWICImageEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICImageEncoder : IWICImageEncoder.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICImageEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICImageEncoder*, uint>)(lpVtbl[1]))((IWICImageEncoder*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICImageEncoder*, uint>)(lpVtbl[2]))((IWICImageEncoder*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT WriteFrame(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
    {
        return ((delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int>)(lpVtbl[3]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteFrameThumbnail(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
    {
        return ((delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int>)(lpVtbl[4]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT WriteThumbnail(ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
    {
        return ((delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapEncoder*, WICImageParameters*, int>)(lpVtbl[5]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pEncoder, pImageParameters);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT WriteFrame(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

        [VtblIndex(4)]
        HRESULT WriteFrameThumbnail(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

        [VtblIndex(5)]
        HRESULT WriteThumbnail(ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICImageEncoder*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICImageEncoder*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICImageEncoder*, uint> Release;

        [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int> WriteFrame;

        [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int> WriteFrameThumbnail;

        [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapEncoder *, const WICImageParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapEncoder*, WICImageParameters*, int> WriteThumbnail;
    }
}
