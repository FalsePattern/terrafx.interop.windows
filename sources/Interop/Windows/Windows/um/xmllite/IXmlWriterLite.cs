// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("862494C6-1310-4AAD-B3CD-2DBEEBF670D3")]
[NativeTypeName("struct IXmlWriterLite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXmlWriterLite : IXmlWriterLite.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, Guid*, void**, int>)(lpVtbl[0]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXmlWriterLite*, uint>)(lpVtbl[1]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlWriterLite*, uint>)(lpVtbl[2]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOutput(IUnknown* pOutput)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, IUnknown*, int>)(lpVtbl[3]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pOutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, uint, nint*, int>)(lpVtbl[4]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), nProperty, ppValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, uint, nint, int>)(lpVtbl[5]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), nProperty, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteAttributes(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int>)(lpVtbl[6]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WriteAttributeString([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName, [NativeTypeName("const WCHAR *")] ushort* pwszValue, uint cwszValue)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, ushort*, uint, int>)(lpVtbl[7]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName, pwszValue, cwszValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteCData([NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[8]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteCharEntity([NativeTypeName("WCHAR")] ushort wch)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort, int>)(lpVtbl[9]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), wch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WriteChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[10]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwch, cwch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteComment([NativeTypeName("LPCWSTR")] ushort* pwszComment)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[11]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszComment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteDocType([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszPublicId, [NativeTypeName("LPCWSTR")] ushort* pwszSystemId, [NativeTypeName("LPCWSTR")] ushort* pwszSubset)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, ushort*, ushort*, ushort*, int>)(lpVtbl[12]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName, pwszPublicId, pwszSystemId, pwszSubset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT WriteElementString([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName, [NativeTypeName("LPCWSTR")] ushort* pwszValue)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, ushort*, int>)(lpVtbl[13]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName, pwszValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteEndDocument()
    {
        return ((delegate* unmanaged<IXmlWriterLite*, int>)(lpVtbl[14]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[15]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT WriteEntityRef([NativeTypeName("LPCWSTR")] ushort* pwszName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[16]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT WriteFullEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[17]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT WriteName([NativeTypeName("LPCWSTR")] ushort* pwszName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[18]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteNmToken([NativeTypeName("LPCWSTR")] ushort* pwszNmToken)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[19]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszNmToken);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteNode(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int>)(lpVtbl[20]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT WriteNodeShallow(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int>)(lpVtbl[21]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT WriteProcessingInstruction([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, ushort*, int>)(lpVtbl[22]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName, pwszText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT WriteRaw([NativeTypeName("LPCWSTR")] ushort* pwszData)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[23]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT WriteRawChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[24]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwch, cwch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT WriteStartDocument(XmlStandalone standalone)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, XmlStandalone, int>)(lpVtbl[25]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), standalone);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT WriteStartElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int>)(lpVtbl[26]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT WriteString([NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[27]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT WriteSurrogateCharEntity([NativeTypeName("WCHAR")] ushort wchLow, [NativeTypeName("WCHAR")] ushort wchHigh)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort, ushort, int>)(lpVtbl[28]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), wchLow, wchHigh);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT WriteWhitespace([NativeTypeName("LPCWSTR")] ushort* pwszWhitespace)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int>)(lpVtbl[29]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszWhitespace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IXmlWriterLite*, int>)(lpVtbl[30]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetOutput(IUnknown* pOutput);

        [VtblIndex(4)]
        HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue);

        [VtblIndex(5)]
        HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue);

        [VtblIndex(6)]
        HRESULT WriteAttributes(IXmlReader* pReader, BOOL fWriteDefaultAttributes);

        [VtblIndex(7)]
        HRESULT WriteAttributeString([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName, [NativeTypeName("const WCHAR *")] ushort* pwszValue, uint cwszValue);

        [VtblIndex(8)]
        HRESULT WriteCData([NativeTypeName("LPCWSTR")] ushort* pwszText);

        [VtblIndex(9)]
        HRESULT WriteCharEntity([NativeTypeName("WCHAR")] ushort wch);

        [VtblIndex(10)]
        HRESULT WriteChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch);

        [VtblIndex(11)]
        HRESULT WriteComment([NativeTypeName("LPCWSTR")] ushort* pwszComment);

        [VtblIndex(12)]
        HRESULT WriteDocType([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszPublicId, [NativeTypeName("LPCWSTR")] ushort* pwszSystemId, [NativeTypeName("LPCWSTR")] ushort* pwszSubset);

        [VtblIndex(13)]
        HRESULT WriteElementString([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName, [NativeTypeName("LPCWSTR")] ushort* pwszValue);

        [VtblIndex(14)]
        HRESULT WriteEndDocument();

        [VtblIndex(15)]
        HRESULT WriteEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName);

        [VtblIndex(16)]
        HRESULT WriteEntityRef([NativeTypeName("LPCWSTR")] ushort* pwszName);

        [VtblIndex(17)]
        HRESULT WriteFullEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName);

        [VtblIndex(18)]
        HRESULT WriteName([NativeTypeName("LPCWSTR")] ushort* pwszName);

        [VtblIndex(19)]
        HRESULT WriteNmToken([NativeTypeName("LPCWSTR")] ushort* pwszNmToken);

        [VtblIndex(20)]
        HRESULT WriteNode(IXmlReader* pReader, BOOL fWriteDefaultAttributes);

        [VtblIndex(21)]
        HRESULT WriteNodeShallow(IXmlReader* pReader, BOOL fWriteDefaultAttributes);

        [VtblIndex(22)]
        HRESULT WriteProcessingInstruction([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszText);

        [VtblIndex(23)]
        HRESULT WriteRaw([NativeTypeName("LPCWSTR")] ushort* pwszData);

        [VtblIndex(24)]
        HRESULT WriteRawChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch);

        [VtblIndex(25)]
        HRESULT WriteStartDocument(XmlStandalone standalone);

        [VtblIndex(26)]
        HRESULT WriteStartElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName);

        [VtblIndex(27)]
        HRESULT WriteString([NativeTypeName("LPCWSTR")] ushort* pwszText);

        [VtblIndex(28)]
        HRESULT WriteSurrogateCharEntity([NativeTypeName("WCHAR")] ushort wchLow, [NativeTypeName("WCHAR")] ushort wchHigh);

        [VtblIndex(29)]
        HRESULT WriteWhitespace([NativeTypeName("LPCWSTR")] ushort* pwszWhitespace);

        [VtblIndex(30)]
        HRESULT Flush();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, IUnknown*, int> SetOutput;

        [NativeTypeName("HRESULT (UINT, LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, uint, nint*, int> GetProperty;

        [NativeTypeName("HRESULT (UINT, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, uint, nint, int> SetProperty;

        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int> WriteAttributes;

        [NativeTypeName("HRESULT (const WCHAR *, UINT, const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, uint, ushort*, uint, int> WriteAttributeString;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, int> WriteCData;

        [NativeTypeName("HRESULT (WCHAR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort, int> WriteCharEntity;

        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> WriteChars;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, int> WriteComment;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, ushort*, ushort*, ushort*, int> WriteDocType;

        [NativeTypeName("HRESULT (const WCHAR *, UINT, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, uint, ushort*, int> WriteElementString;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, int> WriteEndDocument;

        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> WriteEndElement;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, int> WriteEntityRef;

        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> WriteFullEndElement;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, int> WriteName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, int> WriteNmToken;

        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int> WriteNode;

        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int> WriteNodeShallow;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, ushort*, int> WriteProcessingInstruction;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, int> WriteRaw;

        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> WriteRawChars;

        [NativeTypeName("HRESULT (XmlStandalone) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, XmlStandalone, int> WriteStartDocument;

        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> WriteStartElement;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, int> WriteString;

        [NativeTypeName("HRESULT (WCHAR, WCHAR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort, ushort, int> WriteSurrogateCharEntity;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, ushort*, int> WriteWhitespace;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IXmlWriterLite*, int> Flush;
    }
}
