namespace unity.libsodium.Interop
{
    public partial struct crypto_auth_hmacsha256_state
    {
        public crypto_hash_sha256_state ictx;

        public crypto_hash_sha256_state octx;
    }
}
