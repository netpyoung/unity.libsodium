namespace unity.libsodium.Interop
{
    public unsafe partial struct crypto_aead_aes256gcm_state_
    {
        [NativeTypeName("unsigned char[512]")]
        public fixed byte opaque[512];
    }
}
