// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3050F606-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHighlightRenderingServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHighlightRenderingServices : IHighlightRenderingServices.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHighlightRenderingServices*, Guid*, void**, int>)(lpVtbl[0]))((IHighlightRenderingServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHighlightRenderingServices*, uint>)(lpVtbl[1]))((IHighlightRenderingServices*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHighlightRenderingServices*, uint>)(lpVtbl[2]))((IHighlightRenderingServices*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddSegment(IDisplayPointer* pDispPointerStart, IDisplayPointer* pDispPointerEnd, IHTMLRenderStyle* pIRenderStyle, IHighlightSegment** ppISegment)
    {
        return ((delegate* unmanaged<IHighlightRenderingServices*, IDisplayPointer*, IDisplayPointer*, IHTMLRenderStyle*, IHighlightSegment**, int>)(lpVtbl[3]))((IHighlightRenderingServices*)Unsafe.AsPointer(ref this), pDispPointerStart, pDispPointerEnd, pIRenderStyle, ppISegment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MoveSegmentToPointers(IHighlightSegment* pISegment, IDisplayPointer* pDispPointerStart, IDisplayPointer* pDispPointerEnd)
    {
        return ((delegate* unmanaged<IHighlightRenderingServices*, IHighlightSegment*, IDisplayPointer*, IDisplayPointer*, int>)(lpVtbl[4]))((IHighlightRenderingServices*)Unsafe.AsPointer(ref this), pISegment, pDispPointerStart, pDispPointerEnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveSegment(IHighlightSegment* pISegment)
    {
        return ((delegate* unmanaged<IHighlightRenderingServices*, IHighlightSegment*, int>)(lpVtbl[5]))((IHighlightRenderingServices*)Unsafe.AsPointer(ref this), pISegment);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddSegment(IDisplayPointer* pDispPointerStart, IDisplayPointer* pDispPointerEnd, IHTMLRenderStyle* pIRenderStyle, IHighlightSegment** ppISegment);

        [VtblIndex(4)]
        HRESULT MoveSegmentToPointers(IHighlightSegment* pISegment, IDisplayPointer* pDispPointerStart, IDisplayPointer* pDispPointerEnd);

        [VtblIndex(5)]
        HRESULT RemoveSegment(IHighlightSegment* pISegment);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHighlightRenderingServices*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHighlightRenderingServices*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHighlightRenderingServices*, uint> Release;

        [NativeTypeName("HRESULT (IDisplayPointer *, IDisplayPointer *, IHTMLRenderStyle *, IHighlightSegment **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHighlightRenderingServices*, IDisplayPointer*, IDisplayPointer*, IHTMLRenderStyle*, IHighlightSegment**, int> AddSegment;

        [NativeTypeName("HRESULT (IHighlightSegment *, IDisplayPointer *, IDisplayPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHighlightRenderingServices*, IHighlightSegment*, IDisplayPointer*, IDisplayPointer*, int> MoveSegmentToPointers;

        [NativeTypeName("HRESULT (IHighlightSegment *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHighlightRenderingServices*, IHighlightSegment*, int> RemoveSegment;
    }
}
