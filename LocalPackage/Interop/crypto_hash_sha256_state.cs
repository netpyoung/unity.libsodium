namespace unity.libsodium.Interop
{
    public unsafe partial struct crypto_hash_sha256_state
    {
        [NativeTypeName("uint32_t[8]")]
        public fixed uint state[8];

        [NativeTypeName("uint64_t")]
        public ulong count;

        [NativeTypeName("uint8_t[64]")]
        public fixed byte buf[64];
    }
}
