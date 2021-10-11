// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/NotificationActivationCallback.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53E31837-6600-4A81-9395-75CFFE746F94")]
    [NativeTypeName("struct INotificationActivationCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INotificationActivationCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INotificationActivationCallback*, Guid*, void**, int>)(lpVtbl[0]))((INotificationActivationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INotificationActivationCallback*, uint>)(lpVtbl[1]))((INotificationActivationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INotificationActivationCallback*, uint>)(lpVtbl[2]))((INotificationActivationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("LPCWSTR")] ushort* appUserModelId, [NativeTypeName("LPCWSTR")] ushort* invokedArgs, [NativeTypeName("const NOTIFICATION_USER_INPUT_DATA *")] NOTIFICATION_USER_INPUT_DATA* data, [NativeTypeName("ULONG")] uint count)
        {
            return ((delegate* unmanaged<INotificationActivationCallback*, ushort*, ushort*, NOTIFICATION_USER_INPUT_DATA*, uint, int>)(lpVtbl[3]))((INotificationActivationCallback*)Unsafe.AsPointer(ref this), appUserModelId, invokedArgs, data, count);
        }
    }
}
