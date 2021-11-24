// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows10.0")]
[Guid("9A178793-F97E-46AC-AACA-DD5BA4C177C8")]
[NativeTypeName("struct IAppxBundleManifestOptionalBundleInfoEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxBundleManifestOptionalBundleInfoEnumerator : IAppxBundleManifestOptionalBundleInfoEnumerator.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, uint>)(lpVtbl[1]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, uint>)(lpVtbl[2]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxBundleManifestOptionalBundleInfo** optionalBundle)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, IAppxBundleManifestOptionalBundleInfo**, int>)(lpVtbl[3]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this), optionalBundle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxBundleManifestOptionalBundleInfoEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxBundleManifestOptionalBundleInfo** optionalBundle);

        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);

        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasNext);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, uint> Release;

        [NativeTypeName("HRESULT (IAppxBundleManifestOptionalBundleInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, IAppxBundleManifestOptionalBundleInfo**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator*, BOOL*, int> MoveNext;
    }
}
