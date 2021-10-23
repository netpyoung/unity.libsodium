namespace unity.libsodium.Interop
{
    public unsafe partial struct crypto_secretstream_xchacha20poly1305_state
    {
        [NativeTypeName("unsigned char [32]")]
        public fixed byte k[32];

        [NativeTypeName("unsigned char [12]")]
        public fixed byte nonce[12];

        [NativeTypeName("unsigned char [8]")]
        public fixed byte _pad[8];
    }
}
