namespace unity.libsodium.Interop
{
    public unsafe partial struct crypto_onetimeauth_poly1305_state
    {
        [NativeTypeName("unsigned char[256]")]
        public fixed byte opaque[256];
    }
}
