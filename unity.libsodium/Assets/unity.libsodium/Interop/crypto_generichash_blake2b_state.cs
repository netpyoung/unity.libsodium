namespace unity.libsodium.Interop
{
    public unsafe partial struct crypto_generichash_blake2b_state
    {
        [NativeTypeName("unsigned char[384]")]
        public fixed byte opaque[384];
    }
}
