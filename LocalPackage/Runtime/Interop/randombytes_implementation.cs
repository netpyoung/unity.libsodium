using System;

namespace unity.libsodium.Interop
{
    public partial struct randombytes_implementation
    {
        [NativeTypeName("const char *(*)()")]
        public IntPtr implementation_name;

        [NativeTypeName("uint32_t (*)()")]
        public IntPtr random;

        [NativeTypeName("void (*)()")]
        public IntPtr stir;

        [NativeTypeName("uint32_t (*)(const uint32_t)")]
        public IntPtr uniform;

        [NativeTypeName("void (*)(void *const, const size_t)")]
        public IntPtr buf;

        [NativeTypeName("int (*)()")]
        public IntPtr close;
    }
}
