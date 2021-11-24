// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("DBB84C27-36CE-4FC9-B801-F048C46AC570")]
[NativeTypeName("struct ID3D12MetaCommand : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12MetaCommand : ID3D12MetaCommand.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, uint>)(lpVtbl[1]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, uint>)(lpVtbl[2]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), guid, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, ushort*, int>)(lpVtbl[6]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetRequiredParameterResourceSize(D3D12_META_COMMAND_PARAMETER_STAGE Stage, uint ParameterIndex)
    {
        return ((delegate* unmanaged<ID3D12MetaCommand*, D3D12_META_COMMAND_PARAMETER_STAGE, uint, ulong>)(lpVtbl[8]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), Stage, ParameterIndex);
    }

    public interface Interface : ID3D12Pageable.Interface
    {
        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        ulong GetRequiredParameterResourceSize(D3D12_META_COMMAND_PARAMETER_STAGE Stage, uint ParameterIndex);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, ushort*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, Guid*, void**, int> GetDevice;

        [NativeTypeName("UINT64 (D3D12_META_COMMAND_PARAMETER_STAGE, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12MetaCommand*, D3D12_META_COMMAND_PARAMETER_STAGE, uint, ulong> GetRequiredParameterResourceSize;
    }
}
