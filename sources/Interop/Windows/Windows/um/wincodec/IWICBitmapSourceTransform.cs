// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3B16811B-6A43-4EC9-B713-3D5A0C13B940")]
[NativeTypeName("struct IWICBitmapSourceTransform : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapSourceTransform : IWICBitmapSourceTransform.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform*, uint>)(lpVtbl[1]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform*, uint>)(lpVtbl[2]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint uiWidth, uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, uint, uint, byte*, int>)(lpVtbl[3]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetClosestSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform*, uint*, uint*, int>)(lpVtbl[4]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat)
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform*, Guid*, int>)(lpVtbl[5]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), pguidDstFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DoesSupportTransform(WICBitmapTransformOptions dstTransform, BOOL* pfIsSupported)
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform*, WICBitmapTransformOptions, BOOL*, int>)(lpVtbl[6]))((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), dstTransform, pfIsSupported);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint uiWidth, uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer);

        [VtblIndex(4)]
        HRESULT GetClosestSize(uint* puiWidth, uint* puiHeight);

        [VtblIndex(5)]
        HRESULT GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat);

        [VtblIndex(6)]
        HRESULT DoesSupportTransform(WICBitmapTransformOptions dstTransform, BOOL* pfIsSupported);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmapSourceTransform*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmapSourceTransform*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmapSourceTransform*, uint> Release;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, WICPixelFormatGUID *, WICBitmapTransformOptions, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmapSourceTransform*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, uint, uint, byte*, int> CopyPixels;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmapSourceTransform*, uint*, uint*, int> GetClosestSize;

        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmapSourceTransform*, Guid*, int> GetClosestPixelFormat;

        [NativeTypeName("HRESULT (WICBitmapTransformOptions, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmapSourceTransform*, WICBitmapTransformOptions, BOOL*, int> DoesSupportTransform;
    }
}
