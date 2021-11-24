// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("00000121-A8F2-4877-BA0A-FD2B6645FB94")]
[NativeTypeName("struct IWICBitmap : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICBitmap : IWICBitmap.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmap*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmap*, uint>)(lpVtbl[1]))((IWICBitmap*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmap*, uint>)(lpVtbl[2]))((IWICBitmap*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICBitmap*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmap*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged<IWICBitmap*, Guid*, int>)(lpVtbl[4]))((IWICBitmap*)Unsafe.AsPointer(ref this), pPixelFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResolution(double* pDpiX, double* pDpiY)
    {
        return ((delegate* unmanaged<IWICBitmap*, double*, double*, int>)(lpVtbl[5]))((IWICBitmap*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmap*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged<IWICBitmap*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmap*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Lock([NativeTypeName("const WICRect *")] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, IWICBitmapLock** ppILock)
    {
        return ((delegate* unmanaged<IWICBitmap*, WICRect*, uint, IWICBitmapLock**, int>)(lpVtbl[8]))((IWICBitmap*)Unsafe.AsPointer(ref this), prcLock, flags, ppILock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmap*, IWICPalette*, int>)(lpVtbl[9]))((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetResolution(double dpiX, double dpiY)
    {
        return ((delegate* unmanaged<IWICBitmap*, double, double, int>)(lpVtbl[10]))((IWICBitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
    }

    public interface Interface : IWICBitmapSource.Interface
    {
        [VtblIndex(8)]
        HRESULT Lock([NativeTypeName("const WICRect *")] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, IWICBitmapLock** ppILock);

        [VtblIndex(9)]
        HRESULT SetPalette(IWICPalette* pIPalette);

        [VtblIndex(10)]
        HRESULT SetResolution(double dpiX, double dpiY);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, uint> Release;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, uint*, uint*, int> GetSize;

        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, Guid*, int> GetPixelFormat;

        [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, double*, double*, int> GetResolution;

        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, IWICPalette*, int> CopyPalette;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, WICRect*, uint, uint, byte*, int> CopyPixels;

        [NativeTypeName("HRESULT (const WICRect *, DWORD, IWICBitmapLock **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, WICRect*, uint, IWICBitmapLock**, int> Lock;

        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, IWICPalette*, int> SetPalette;

        [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICBitmap*, double, double, int> SetResolution;
    }
}
