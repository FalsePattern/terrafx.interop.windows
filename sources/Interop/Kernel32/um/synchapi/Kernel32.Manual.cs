// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/synchapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        public const uint INIT_ONCE_CHECK_ONLY = RTL_RUN_ONCE_CHECK_ONLY;

        public const uint INIT_ONCE_ASYNC = RTL_RUN_ONCE_ASYNC;

        public const uint INIT_ONCE_INIT_FAILED = RTL_RUN_ONCE_INIT_FAILED;

        public const uint INIT_ONCE_CTX_RESERVED_BITS = RTL_RUN_ONCE_CTX_RESERVED_BITS;

        // #define CONDITION_VARIABLE_INIT RTL_CONDITION_VARIABLE_INIT
        // #define CONDITION_VARIABLE_LOCKMODE_SHARED RTL_CONDITION_VARIABLE_LOCKMODE_SHARED
        // #define MUTEX_MODIFY_STATE  MUTANT_QUERY_STATE
        // #define MUTEX_ALL_ACCESS    MUTANT_ALL_ACCESS
        // #define CREATE_MUTEX_INITIAL_OWNER  0x00000001
        // #define CREATE_EVENT_MANUAL_RESET   0x00000001
        // #define CREATE_EVENT_INITIAL_SET    0x00000002
        // #define CREATE_WAITABLE_TIMER_MANUAL_RESET  0x00000001
        // #define CREATE_WAITABLE_TIMER_HIGH_RESOLUTION 0x00000002
        // #define SYNCHRONIZATION_BARRIER_FLAGS_SPIN_ONLY  0x01
        // #define SYNCHRONIZATION_BARRIER_FLAGS_BLOCK_ONLY 0x02
	    // #define SYNCHRONIZATION_BARRIER_FLAGS_NO_DELETE  0x04
    }
}
