// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("90F732E2-5092-4606-A819-8651970BACCD")]
[NativeTypeName("struct ID2D1BoundsAdjustmentTransform : ID2D1TransformNode")]
[NativeInheritance("ID2D1TransformNode")]
public unsafe partial struct ID2D1BoundsAdjustmentTransform : ID2D1BoundsAdjustmentTransform.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, uint>)(lpVtbl[1]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, uint>)(lpVtbl[2]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, uint>)(lpVtbl[3]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetOutputBounds([NativeTypeName("const D2D1_RECT_L *")] RECT* outputBounds)
    {
        ((delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, RECT*, void>)(lpVtbl[4]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), outputBounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void GetOutputBounds([NativeTypeName("D2D1_RECT_L *")] RECT* outputBounds)
    {
        ((delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, RECT*, void>)(lpVtbl[5]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), outputBounds);
    }

    public interface Interface : ID2D1TransformNode.Interface
    {
        [VtblIndex(4)]
        void SetOutputBounds([NativeTypeName("const D2D1_RECT_L *")] RECT* outputBounds);

        [VtblIndex(5)]
        void GetOutputBounds([NativeTypeName("D2D1_RECT_L *")] RECT* outputBounds);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, uint> Release;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, uint> GetInputCount;

        [NativeTypeName("void (const D2D1_RECT_L *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, RECT*, void> SetOutputBounds;

        [NativeTypeName("void (D2D1_RECT_L *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1BoundsAdjustmentTransform*, RECT*, void> GetOutputBounds;
    }
}
