// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("ED79BA56-5294-4250-8D46-F9AECEE23459")]
[NativeTypeName("struct IFsiNamedStreams : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IFsiNamedStreams : IFsiNamedStreams.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, Guid*, void**, int>)(lpVtbl[0]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, uint>)(lpVtbl[1]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, uint>)(lpVtbl[2]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, uint*, int>)(lpVtbl[3]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get__NewEnum(IEnumVARIANT** NewEnum)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, IEnumVARIANT**, int>)(lpVtbl[7]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), NewEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Item([NativeTypeName("LONG")] int index, IFsiFileItem2** item)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, int, IFsiFileItem2**, int>)(lpVtbl[8]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), index, item);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* count)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, int*, int>)(lpVtbl[9]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_EnumNamedStreams(IEnumFsiItems** NewEnum)
    {
        return ((delegate* unmanaged<IFsiNamedStreams*, IEnumFsiItems**, int>)(lpVtbl[10]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), NewEnum);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get__NewEnum(IEnumVARIANT** NewEnum);

        [VtblIndex(8)]
        HRESULT get_Item([NativeTypeName("LONG")] int index, IFsiFileItem2** item);

        [VtblIndex(9)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* count);

        [VtblIndex(10)]
        HRESULT get_EnumNamedStreams(IEnumFsiItems** NewEnum);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (IEnumVARIANT **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, IEnumVARIANT**, int> get__NewEnum;

        [NativeTypeName("HRESULT (LONG, IFsiFileItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, int, IFsiFileItem2**, int> get_Item;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, int*, int> get_Count;

        [NativeTypeName("HRESULT (IEnumFsiItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFsiNamedStreams*, IEnumFsiItems**, int> get_EnumNamedStreams;
    }
}
