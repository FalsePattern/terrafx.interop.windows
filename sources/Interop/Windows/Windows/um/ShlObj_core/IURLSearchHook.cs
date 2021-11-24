// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("AC60F6A0-0FD9-11D0-99CB-00C04FD64497")]
[NativeTypeName("struct IURLSearchHook : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IURLSearchHook : IURLSearchHook.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IURLSearchHook*, Guid*, void**, int>)(lpVtbl[0]))((IURLSearchHook*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IURLSearchHook*, uint>)(lpVtbl[1]))((IURLSearchHook*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IURLSearchHook*, uint>)(lpVtbl[2]))((IURLSearchHook*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Translate([NativeTypeName("PWSTR")] ushort* pwszSearchURL, [NativeTypeName("DWORD")] uint cchBufferSize)
    {
        return ((delegate* unmanaged<IURLSearchHook*, ushort*, uint, int>)(lpVtbl[3]))((IURLSearchHook*)Unsafe.AsPointer(ref this), pwszSearchURL, cchBufferSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Translate([NativeTypeName("PWSTR")] ushort* pwszSearchURL, [NativeTypeName("DWORD")] uint cchBufferSize);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IURLSearchHook*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IURLSearchHook*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IURLSearchHook*, uint> Release;

        [NativeTypeName("HRESULT (PWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IURLSearchHook*, ushort*, uint, int> Translate;
    }
}
