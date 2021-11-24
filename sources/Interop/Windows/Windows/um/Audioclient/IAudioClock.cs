// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("CD63314F-3FBA-4A1B-812C-EF96358728E7")]
[NativeTypeName("struct IAudioClock : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioClock : IAudioClock.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioClock*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClock*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioClock*, uint>)(lpVtbl[1]))((IAudioClock*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioClock*, uint>)(lpVtbl[2]))((IAudioClock*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFrequency([NativeTypeName("UINT64 *")] ulong* pu64Frequency)
    {
        return ((delegate* unmanaged<IAudioClock*, ulong*, int>)(lpVtbl[3]))((IAudioClock*)Unsafe.AsPointer(ref this), pu64Frequency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPosition([NativeTypeName("UINT64 *")] ulong* pu64Position, [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition)
    {
        return ((delegate* unmanaged<IAudioClock*, ulong*, ulong*, int>)(lpVtbl[4]))((IAudioClock*)Unsafe.AsPointer(ref this), pu64Position, pu64QPCPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IAudioClock*, uint*, int>)(lpVtbl[5]))((IAudioClock*)Unsafe.AsPointer(ref this), pdwCharacteristics);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFrequency([NativeTypeName("UINT64 *")] ulong* pu64Frequency);

        [VtblIndex(4)]
        HRESULT GetPosition([NativeTypeName("UINT64 *")] ulong* pu64Position, [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition);

        [VtblIndex(5)]
        HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioClock*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioClock*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioClock*, uint> Release;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioClock*, ulong*, int> GetFrequency;

        [NativeTypeName("HRESULT (UINT64 *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioClock*, ulong*, ulong*, int> GetPosition;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioClock*, uint*, int> GetCharacteristics;
    }
}
