namespace unity.libsodium.Interop
{
    public partial struct crypto_auth_hmacsha512_state
    {
        public crypto_hash_sha512_state ictx;

        public crypto_hash_sha512_state octx;
    }
}
