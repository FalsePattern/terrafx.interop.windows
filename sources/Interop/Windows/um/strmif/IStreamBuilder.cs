// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868BF-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IStreamBuilder : IUnknown")]
    public unsafe partial struct IStreamBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IStreamBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamBuilder*, uint>)(lpVtbl[1]))((IStreamBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamBuilder*, uint>)(lpVtbl[2]))((IStreamBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Render(IPin* ppinOut, IGraphBuilder* pGraph)
        {
            return ((delegate* unmanaged<IStreamBuilder*, IPin*, IGraphBuilder*, int>)(lpVtbl[3]))((IStreamBuilder*)Unsafe.AsPointer(ref this), ppinOut, pGraph);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Backout(IPin* ppinOut, IGraphBuilder* pGraph)
        {
            return ((delegate* unmanaged<IStreamBuilder*, IPin*, IGraphBuilder*, int>)(lpVtbl[4]))((IStreamBuilder*)Unsafe.AsPointer(ref this), ppinOut, pGraph);
        }
    }
}
