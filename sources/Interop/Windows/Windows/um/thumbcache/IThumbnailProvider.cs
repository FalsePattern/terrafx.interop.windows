// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("E357FCCD-A995-4576-B01F-234630154E96")]
[NativeTypeName("struct IThumbnailProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IThumbnailProvider : IThumbnailProvider.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailProvider*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IThumbnailProvider*, uint>)(lpVtbl[1]))((IThumbnailProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailProvider*, uint>)(lpVtbl[2]))((IThumbnailProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetThumbnail(uint cx, HBITMAP* phbmp, WTS_ALPHATYPE* pdwAlpha)
    {
        return ((delegate* unmanaged<IThumbnailProvider*, uint, HBITMAP*, WTS_ALPHATYPE*, int>)(lpVtbl[3]))((IThumbnailProvider*)Unsafe.AsPointer(ref this), cx, phbmp, pdwAlpha);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetThumbnail(uint cx, HBITMAP* phbmp, WTS_ALPHATYPE* pdwAlpha);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IThumbnailProvider*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IThumbnailProvider*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IThumbnailProvider*, uint> Release;

        [NativeTypeName("HRESULT (UINT, HBITMAP *, WTS_ALPHATYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IThumbnailProvider*, uint, HBITMAP*, WTS_ALPHATYPE*, int> GetThumbnail;
    }
}
