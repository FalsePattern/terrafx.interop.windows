// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3050F842-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHostBehaviorInit : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHostBehaviorInit : IHostBehaviorInit.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHostBehaviorInit*, Guid*, void**, int>)(lpVtbl[0]))((IHostBehaviorInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHostBehaviorInit*, uint>)(lpVtbl[1]))((IHostBehaviorInit*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHostBehaviorInit*, uint>)(lpVtbl[2]))((IHostBehaviorInit*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PopulateNamespaceTable()
    {
        return ((delegate* unmanaged<IHostBehaviorInit*, int>)(lpVtbl[3]))((IHostBehaviorInit*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PopulateNamespaceTable();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHostBehaviorInit*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHostBehaviorInit*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHostBehaviorInit*, uint> Release;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IHostBehaviorInit*, int> PopulateNamespaceTable;
    }
}
