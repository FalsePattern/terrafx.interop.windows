// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("576616C0-A231-494D-A38D-00FD5EC4DB46")]
    [NativeTypeName("struct IDCompositionCompositeEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionCompositeEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionCompositeEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionCompositeEffect*, uint>)(lpVtbl[1]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionCompositeEffect*, uint>)(lpVtbl[2]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged<IDCompositionCompositeEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMode(D2D1_COMPOSITE_MODE mode)
        {
            return ((delegate* unmanaged<IDCompositionCompositeEffect*, D2D1_COMPOSITE_MODE, int>)(lpVtbl[4]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), mode);
        }
    }
}
