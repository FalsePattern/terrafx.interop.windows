// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("F1DF64B6-57FD-49CD-8807-C0EB88B45C8F")]
[NativeTypeName("struct ID3D12SwapChainAssistant : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SwapChainAssistant : ID3D12SwapChainAssistant.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, uint>)(lpVtbl[1]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, uint>)(lpVtbl[2]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public LUID GetLUID()
    {
        LUID result;
        return *((delegate* unmanaged<ID3D12SwapChainAssistant*, LUID*, LUID*>)(lpVtbl[3]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)(lpVtbl[4]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, void** ppvQueue)
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(lpVtbl[5]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riidResource, ppvResource, riidQueue, ppvQueue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertImplicitSync()
    {
        return ((delegate* unmanaged<ID3D12SwapChainAssistant*, int>)(lpVtbl[6]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        LUID GetLUID();

        [VtblIndex(4)]
        HRESULT GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(5)]
        HRESULT GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, void** ppvQueue);

        [VtblIndex(6)]
        HRESULT InsertImplicitSync();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12SwapChainAssistant*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12SwapChainAssistant*, uint> Release;

        [NativeTypeName("LUID () __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12SwapChainAssistant*, LUID*, LUID*> GetLUID;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int> GetSwapChainObject;

        [NativeTypeName("HRESULT (const IID &, void **, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int> GetCurrentResourceAndCommandQueue;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12SwapChainAssistant*, int> InsertImplicitSync;
    }
}
