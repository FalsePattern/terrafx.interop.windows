// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("26A0ADC3-CE26-4672-9304-69552EDD3FAF")]
[NativeTypeName("struct IMFAudioMediaType : IMFMediaType")]
[NativeInheritance("IMFMediaType")]
public unsafe partial struct IMFAudioMediaType : IMFAudioMediaType.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, void**, int>)(lpVtbl[0]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, uint>)(lpVtbl[1]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, uint>)(lpVtbl[2]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, uint*, int>)(lpVtbl[7]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, punValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, punValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, double*, int>)(lpVtbl[9]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pfValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, uint*, int>)(lpVtbl[11]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, uint*, int>)(lpVtbl[14]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, int>)(lpVtbl[19]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DeleteAllItems()
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, int>)(lpVtbl[20]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, uint, int>)(lpVtbl[21]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, unValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, ulong, int>)(lpVtbl[22]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, unValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, double, int>)(lpVtbl[23]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, fValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, guidValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, wszValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT LockStore()
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, int>)(lpVtbl[28]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT UnlockStore()
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, int>)(lpVtbl[29]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, uint*, int>)(lpVtbl[30]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pcItems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CopyAllItems(IMFAttributes* pDest)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, IMFAttributes*, int>)(lpVtbl[32]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pDest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetMajorType(Guid* pguidMajorType)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid*, int>)(lpVtbl[33]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pguidMajorType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT IsCompressedFormat(BOOL* pfCompressed)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, BOOL*, int>)(lpVtbl[34]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pfCompressed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT IsEqual(IMFMediaType* pIMediaType, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, IMFMediaType*, uint*, int>)(lpVtbl[35]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pIMediaType, pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetRepresentation(Guid guidRepresentation, [NativeTypeName("LPVOID *")] void** ppvRepresentation)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid, void**, int>)(lpVtbl[36]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, ppvRepresentation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT FreeRepresentation(Guid guidRepresentation, [NativeTypeName("LPVOID")] void* pvRepresentation)
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, Guid, void*, int>)(lpVtbl[37]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, pvRepresentation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [return: NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* GetAudioFormat()
    {
        return ((delegate* unmanaged<IMFAudioMediaType*, WAVEFORMATEX*>)(lpVtbl[38]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFMediaType.Interface
    {
        [VtblIndex(38)]
        [return: NativeTypeName("const WAVEFORMATEX *")]
        WAVEFORMATEX* GetAudioFormat();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, PROPVARIANT*, int> GetItem;

        [NativeTypeName("HRESULT (const GUID &, MF_ATTRIBUTE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, MF_ATTRIBUTE_TYPE*, int> GetItemType;

        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, PROPVARIANT*, BOOL*, int> CompareItem;

        [NativeTypeName("HRESULT (IMFAttributes *, MF_ATTRIBUTES_MATCH_TYPE, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int> Compare;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, uint*, int> GetUINT32;

        [NativeTypeName("HRESULT (const GUID &, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, ulong*, int> GetUINT64;

        [NativeTypeName("HRESULT (const GUID &, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, double*, int> GetDouble;

        [NativeTypeName("HRESULT (const GUID &, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, uint*, int> GetStringLength;

        [NativeTypeName("HRESULT (const GUID &, LPWSTR, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, ushort*, uint, uint*, int> GetString;

        [NativeTypeName("HRESULT (const GUID &, LPWSTR *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, ushort**, uint*, int> GetAllocatedString;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, uint*, int> GetBlobSize;

        [NativeTypeName("HRESULT (const GUID &, UINT8 *, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, byte*, uint, uint*, int> GetBlob;

        [NativeTypeName("HRESULT (const GUID &, UINT8 **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, byte**, uint*, int> GetAllocatedBlob;

        [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, Guid*, void**, int> GetUnknown;

        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, PROPVARIANT*, int> SetItem;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, int> DeleteItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, int> DeleteAllItems;

        [NativeTypeName("HRESULT (const GUID &, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, uint, int> SetUINT32;

        [NativeTypeName("HRESULT (const GUID &, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, ulong, int> SetUINT64;

        [NativeTypeName("HRESULT (const GUID &, double) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, double, int> SetDouble;

        [NativeTypeName("HRESULT (const GUID &, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, Guid*, int> SetGUID;

        [NativeTypeName("HRESULT (const GUID &, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, ushort*, int> SetString;

        [NativeTypeName("HRESULT (const GUID &, const UINT8 *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, byte*, uint, int> SetBlob;

        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, IUnknown*, int> SetUnknown;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, int> LockStore;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, int> UnlockStore;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT32, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, uint, Guid*, PROPVARIANT*, int> GetItemByIndex;

        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, IMFAttributes*, int> CopyAllItems;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid*, int> GetMajorType;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, BOOL*, int> IsCompressedFormat;

        [NativeTypeName("HRESULT (IMFMediaType *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, IMFMediaType*, uint*, int> IsEqual;

        [NativeTypeName("HRESULT (GUID, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid, void**, int> GetRepresentation;

        [NativeTypeName("HRESULT (GUID, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, Guid, void*, int> FreeRepresentation;

        [NativeTypeName("const WAVEFORMATEX *() __attribute__((stdcall))")]
        public delegate* unmanaged<IMFAudioMediaType*, WAVEFORMATEX*> GetAudioFormat;
    }
}
