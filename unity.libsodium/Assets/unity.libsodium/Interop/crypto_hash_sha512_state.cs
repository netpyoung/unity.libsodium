namespace unity.libsodium.Interop
{
    public unsafe partial struct crypto_hash_sha512_state
    {
        [NativeTypeName("uint64_t [8]")]
        public fixed ulong state[8];

        [NativeTypeName("uint64_t [2]")]
        public fixed ulong count[2];

        [NativeTypeName("uint8_t [128]")]
        public fixed byte buf[128];
    }
}
