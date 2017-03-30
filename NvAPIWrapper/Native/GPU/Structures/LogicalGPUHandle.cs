using System;
using System.Runtime.InteropServices;
using NvAPIWrapper.Native.Interfaces;

namespace NvAPIWrapper.Native.GPU.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LogicalGPUHandle : IHandle
    {
        public const int MaxLogicalGPUs = 64;

        internal IntPtr _MemoryAddress;

        public IntPtr MemoryAddress => _MemoryAddress;
        public bool IsNull => _MemoryAddress == IntPtr.Zero;
    }
}