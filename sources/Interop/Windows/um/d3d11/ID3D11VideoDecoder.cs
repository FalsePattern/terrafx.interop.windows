// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C9C5B51-995D-48D1-9B8D-FA5CAEDED65C")]
    [NativeTypeName("struct ID3D11VideoDecoder : ID3D11DeviceChild")]
    public unsafe partial struct ID3D11VideoDecoder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoDecoder*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoDecoder*, uint>)(lpVtbl[1]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoDecoder*, uint>)(lpVtbl[2]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoDecoder*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoDecoder*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoDecoder*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoDecoder*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCreationParameters(D3D11_VIDEO_DECODER_DESC* pVideoDesc, D3D11_VIDEO_DECODER_CONFIG* pConfig)
        {
            return ((delegate* unmanaged<ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_DESC*, D3D11_VIDEO_DECODER_CONFIG*, int>)(lpVtbl[7]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDriverHandle([NativeTypeName("HANDLE *")] IntPtr* pDriverHandle)
        {
            return ((delegate* unmanaged<ID3D11VideoDecoder*, IntPtr*, int>)(lpVtbl[8]))((ID3D11VideoDecoder*)Unsafe.AsPointer(ref this), pDriverHandle);
        }
    }
}
