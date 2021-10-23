using System;
using System.Runtime.InteropServices;
using unity.libsodium.Interop;

namespace unity.libsodium
{
    public class NativeTypeNameAttribute : Attribute
    {
        public NativeTypeNameAttribute(string str) { }
    }

    public static unsafe partial class NativeLibsodium
    {
#if UNITY_IOS && !UNITY_EDITOR
		const string DLL_NAME = "__Internal";
#else
        private const string DLL_NAME = "sodium";
#endif

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_init();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_set_misuse_handler([NativeTypeName("void (*)()")] IntPtr handler);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sodium_misuse();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis128l_is_available();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis128l_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis128l_nsecbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis128l_npubbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis128l_abytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis128l_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis128l_encrypt([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long *")] ulong* clen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis128l_decrypt([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis128l_encrypt_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long *")] ulong* maclen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis128l_decrypt_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_aead_aegis128l_keygen([NativeTypeName("unsigned char [16]")] byte* k);

        [NativeTypeName("#define crypto_aead_aegis128l_KEYBYTES 16U")]
        public const uint crypto_aead_aegis128l_KEYBYTES = 16U;

        [NativeTypeName("#define crypto_aead_aegis128l_NSECBYTES 0U")]
        public const uint crypto_aead_aegis128l_NSECBYTES = 0U;

        [NativeTypeName("#define crypto_aead_aegis128l_NPUBBYTES 16U")]
        public const uint crypto_aead_aegis128l_NPUBBYTES = 16U;

        [NativeTypeName("#define crypto_aead_aegis128l_ABYTES 16U")]
        public const uint crypto_aead_aegis128l_ABYTES = 16U;

        [NativeTypeName("#define crypto_aead_aegis128l_MESSAGEBYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX - crypto_aead_aegis128l_ABYTES, \\\r\n               (1ULL << 61) - 1)")]
        public const ulong crypto_aead_aegis128l_MESSAGEBYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) < ((1UL << 61) - 1) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) : ((1UL << 61) - 1));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis256_is_available();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis256_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis256_nsecbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis256_npubbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis256_abytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aegis256_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis256_encrypt([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long *")] ulong* clen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis256_decrypt([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis256_encrypt_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long *")] ulong* maclen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aegis256_decrypt_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_aead_aegis256_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_aead_aegis256_KEYBYTES 32U")]
        public const uint crypto_aead_aegis256_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_aead_aegis256_NSECBYTES 0U")]
        public const uint crypto_aead_aegis256_NSECBYTES = 0U;

        [NativeTypeName("#define crypto_aead_aegis256_NPUBBYTES 32U")]
        public const uint crypto_aead_aegis256_NPUBBYTES = 32U;

        [NativeTypeName("#define crypto_aead_aegis256_ABYTES 16U")]
        public const uint crypto_aead_aegis256_ABYTES = 16U;

        [NativeTypeName("#define crypto_aead_aegis256_MESSAGEBYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX - crypto_aead_aegis256_ABYTES, \\\r\n               (1ULL << 61) - 1)")]
        public const ulong crypto_aead_aegis256_MESSAGEBYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) < ((1UL << 61) - 1) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) : ((1UL << 61) - 1));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_is_available();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aes256gcm_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aes256gcm_nsecbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aes256gcm_npubbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aes256gcm_abytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aes256gcm_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_aes256gcm_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_encrypt([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long *")] ulong* clen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_decrypt([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_encrypt_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long *")] ulong* maclen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_decrypt_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_beforenm([NativeTypeName("crypto_aead_aes256gcm_state *")] crypto_aead_aes256gcm_state_* ctx_, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_encrypt_afternm([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long *")] ulong* clen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const crypto_aead_aes256gcm_state *")] crypto_aead_aes256gcm_state_* ctx_);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_decrypt_afternm([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const crypto_aead_aes256gcm_state *")] crypto_aead_aes256gcm_state_* ctx_);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_encrypt_detached_afternm([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long *")] ulong* maclen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const crypto_aead_aes256gcm_state *")] crypto_aead_aes256gcm_state_* ctx_);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_aes256gcm_decrypt_detached_afternm([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const crypto_aead_aes256gcm_state *")] crypto_aead_aes256gcm_state_* ctx_);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_aead_aes256gcm_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_aead_aes256gcm_KEYBYTES 32U")]
        public const uint crypto_aead_aes256gcm_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_aead_aes256gcm_NSECBYTES 0U")]
        public const uint crypto_aead_aes256gcm_NSECBYTES = 0U;

        [NativeTypeName("#define crypto_aead_aes256gcm_NPUBBYTES 12U")]
        public const uint crypto_aead_aes256gcm_NPUBBYTES = 12U;

        [NativeTypeName("#define crypto_aead_aes256gcm_ABYTES 16U")]
        public const uint crypto_aead_aes256gcm_ABYTES = 16U;

        [NativeTypeName("#define crypto_aead_aes256gcm_MESSAGEBYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX - crypto_aead_aes256gcm_ABYTES, \\\r\n               (16ULL * ((1ULL << 32) - 2ULL)))")]
        public const ulong crypto_aead_aes256gcm_MESSAGEBYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) < ((16UL * ((1UL << 32) - 2UL))) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) : ((16UL * ((1UL << 32) - 2UL))));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_ietf_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_ietf_nsecbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_ietf_npubbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_ietf_abytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_ietf_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_chacha20poly1305_ietf_encrypt([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long *")] ulong* clen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_chacha20poly1305_ietf_decrypt([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_chacha20poly1305_ietf_encrypt_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long *")] ulong* maclen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_chacha20poly1305_ietf_decrypt_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_aead_chacha20poly1305_ietf_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_nsecbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_npubbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_abytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_chacha20poly1305_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_chacha20poly1305_encrypt([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long *")] ulong* clen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_chacha20poly1305_decrypt([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_chacha20poly1305_encrypt_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long *")] ulong* maclen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_chacha20poly1305_decrypt_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_aead_chacha20poly1305_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_aead_chacha20poly1305_ietf_KEYBYTES 32U")]
        public const uint crypto_aead_chacha20poly1305_ietf_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_ietf_NSECBYTES 0U")]
        public const uint crypto_aead_chacha20poly1305_ietf_NSECBYTES = 0U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_ietf_NPUBBYTES 12U")]
        public const uint crypto_aead_chacha20poly1305_ietf_NPUBBYTES = 12U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_ietf_ABYTES 16U")]
        public const uint crypto_aead_chacha20poly1305_ietf_ABYTES = 16U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_ietf_MESSAGEBYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX - crypto_aead_chacha20poly1305_ietf_ABYTES, \\\r\n               (64ULL * ((1ULL << 32) - 1ULL)))")]
        public const ulong crypto_aead_chacha20poly1305_ietf_MESSAGEBYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) < ((64UL * ((1UL << 32) - 1UL))) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) : ((64UL * ((1UL << 32) - 1UL))));

        [NativeTypeName("#define crypto_aead_chacha20poly1305_KEYBYTES 32U")]
        public const uint crypto_aead_chacha20poly1305_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_NSECBYTES 0U")]
        public const uint crypto_aead_chacha20poly1305_NSECBYTES = 0U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_NPUBBYTES 8U")]
        public const uint crypto_aead_chacha20poly1305_NPUBBYTES = 8U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_ABYTES 16U")]
        public const uint crypto_aead_chacha20poly1305_ABYTES = 16U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_MESSAGEBYTES_MAX (SODIUM_SIZE_MAX - crypto_aead_chacha20poly1305_ABYTES)")]
        public const ulong crypto_aead_chacha20poly1305_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [NativeTypeName("#define crypto_aead_chacha20poly1305_IETF_KEYBYTES crypto_aead_chacha20poly1305_ietf_KEYBYTES")]
        public const uint crypto_aead_chacha20poly1305_IETF_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_IETF_NSECBYTES crypto_aead_chacha20poly1305_ietf_NSECBYTES")]
        public const uint crypto_aead_chacha20poly1305_IETF_NSECBYTES = 0U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_IETF_NPUBBYTES crypto_aead_chacha20poly1305_ietf_NPUBBYTES")]
        public const uint crypto_aead_chacha20poly1305_IETF_NPUBBYTES = 12U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_IETF_ABYTES crypto_aead_chacha20poly1305_ietf_ABYTES")]
        public const uint crypto_aead_chacha20poly1305_IETF_ABYTES = 16U;

        [NativeTypeName("#define crypto_aead_chacha20poly1305_IETF_MESSAGEBYTES_MAX crypto_aead_chacha20poly1305_ietf_MESSAGEBYTES_MAX")]
        public const ulong crypto_aead_chacha20poly1305_IETF_MESSAGEBYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) < ((64UL * ((1UL << 32) - 1UL))) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U) : ((64UL * ((1UL << 32) - 1UL))));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_xchacha20poly1305_ietf_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_xchacha20poly1305_ietf_nsecbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_xchacha20poly1305_ietf_npubbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_xchacha20poly1305_ietf_abytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_aead_xchacha20poly1305_ietf_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_xchacha20poly1305_ietf_encrypt([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long *")] ulong* clen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_xchacha20poly1305_ietf_decrypt([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_xchacha20poly1305_ietf_encrypt_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long *")] ulong* maclen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_aead_xchacha20poly1305_ietf_decrypt_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned char *")] byte[] nsec, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("const unsigned char *")] byte[] npub, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_aead_xchacha20poly1305_ietf_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_ietf_KEYBYTES 32U")]
        public const uint crypto_aead_xchacha20poly1305_ietf_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_ietf_NSECBYTES 0U")]
        public const uint crypto_aead_xchacha20poly1305_ietf_NSECBYTES = 0U;

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_ietf_NPUBBYTES 24U")]
        public const uint crypto_aead_xchacha20poly1305_ietf_NPUBBYTES = 24U;

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_ietf_ABYTES 16U")]
        public const uint crypto_aead_xchacha20poly1305_ietf_ABYTES = 16U;

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_ietf_MESSAGEBYTES_MAX (SODIUM_SIZE_MAX - crypto_aead_xchacha20poly1305_ietf_ABYTES)")]
        public const ulong crypto_aead_xchacha20poly1305_ietf_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_IETF_KEYBYTES crypto_aead_xchacha20poly1305_ietf_KEYBYTES")]
        public const uint crypto_aead_xchacha20poly1305_IETF_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_IETF_NSECBYTES crypto_aead_xchacha20poly1305_ietf_NSECBYTES")]
        public const uint crypto_aead_xchacha20poly1305_IETF_NSECBYTES = 0U;

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_IETF_NPUBBYTES crypto_aead_xchacha20poly1305_ietf_NPUBBYTES")]
        public const uint crypto_aead_xchacha20poly1305_IETF_NPUBBYTES = 24U;

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_IETF_ABYTES crypto_aead_xchacha20poly1305_ietf_ABYTES")]
        public const uint crypto_aead_xchacha20poly1305_IETF_ABYTES = 16U;

        [NativeTypeName("#define crypto_aead_xchacha20poly1305_IETF_MESSAGEBYTES_MAX crypto_aead_xchacha20poly1305_ietf_MESSAGEBYTES_MAX")]
        public const ulong crypto_aead_xchacha20poly1305_IETF_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_auth_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_verify([NativeTypeName("const unsigned char *")] byte[] h, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_auth_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_auth_BYTES crypto_auth_hmacsha512256_BYTES")]
        public const uint crypto_auth_BYTES = 32U;

        [NativeTypeName("#define crypto_auth_KEYBYTES crypto_auth_hmacsha512256_KEYBYTES")]
        public const uint crypto_auth_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_auth_PRIMITIVE \"hmacsha512256\"")]
        public static byte[] crypto_auth_PRIMITIVE => new byte[] { 0x68, 0x6D, 0x61, 0x63, 0x73, 0x68, 0x61, 0x35, 0x31, 0x32, 0x32, 0x35, 0x36, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha256_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha256_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha256([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha256_verify([NativeTypeName("const unsigned char *")] byte[] h, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha256_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha256_init(crypto_auth_hmacsha256_state* state, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("size_t")] UIntPtr keylen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha256_update(crypto_auth_hmacsha256_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha256_final(crypto_auth_hmacsha256_state* state, [NativeTypeName("unsigned char *")] byte* @out);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_auth_hmacsha256_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_auth_hmacsha256_BYTES 32U")]
        public const uint crypto_auth_hmacsha256_BYTES = 32U;

        [NativeTypeName("#define crypto_auth_hmacsha256_KEYBYTES 32U")]
        public const uint crypto_auth_hmacsha256_KEYBYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha512_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha512_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512_verify([NativeTypeName("const unsigned char *")] byte[] h, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha512_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512_init(crypto_auth_hmacsha512_state* state, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("size_t")] UIntPtr keylen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512_update(crypto_auth_hmacsha512_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512_final(crypto_auth_hmacsha512_state* state, [NativeTypeName("unsigned char *")] byte* @out);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_auth_hmacsha512_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_auth_hmacsha512_BYTES 64U")]
        public const uint crypto_auth_hmacsha512_BYTES = 64U;

        [NativeTypeName("#define crypto_auth_hmacsha512_KEYBYTES 32U")]
        public const uint crypto_auth_hmacsha512_KEYBYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha512256_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha512256_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512256([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512256_verify([NativeTypeName("const unsigned char *")] byte[] h, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_auth_hmacsha512256_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512256_init([NativeTypeName("crypto_auth_hmacsha512256_state *")] crypto_auth_hmacsha512_state* state, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("size_t")] UIntPtr keylen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512256_update([NativeTypeName("crypto_auth_hmacsha512256_state *")] crypto_auth_hmacsha512_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_auth_hmacsha512256_final([NativeTypeName("crypto_auth_hmacsha512256_state *")] crypto_auth_hmacsha512_state* state, [NativeTypeName("unsigned char *")] byte* @out);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_auth_hmacsha512256_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_auth_hmacsha512256_BYTES 32U")]
        public const uint crypto_auth_hmacsha512256_BYTES = 32U;

        [NativeTypeName("#define crypto_auth_hmacsha512256_KEYBYTES 32U")]
        public const uint crypto_auth_hmacsha512256_KEYBYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_seedbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_publickeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_secretkeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_macbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_box_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_seed_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk, [NativeTypeName("const unsigned char *")] byte[] seed);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_easy([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_open_easy([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_open_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_beforenmbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_beforenm([NativeTypeName("unsigned char *")] byte[] k, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_easy_afternm([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_open_easy_afternm([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_detached_afternm([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_open_detached_afternm([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_sealbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_seal([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] pk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_seal_open([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_zerobytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_boxzerobytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_open([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_afternm([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_open_afternm([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [NativeTypeName("#define crypto_box_SEEDBYTES crypto_box_curve25519xsalsa20poly1305_SEEDBYTES")]
        public const uint crypto_box_SEEDBYTES = 32U;

        [NativeTypeName("#define crypto_box_PUBLICKEYBYTES crypto_box_curve25519xsalsa20poly1305_PUBLICKEYBYTES")]
        public const uint crypto_box_PUBLICKEYBYTES = 32U;

        [NativeTypeName("#define crypto_box_SECRETKEYBYTES crypto_box_curve25519xsalsa20poly1305_SECRETKEYBYTES")]
        public const uint crypto_box_SECRETKEYBYTES = 32U;

        [NativeTypeName("#define crypto_box_NONCEBYTES crypto_box_curve25519xsalsa20poly1305_NONCEBYTES")]
        public const uint crypto_box_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_box_MACBYTES crypto_box_curve25519xsalsa20poly1305_MACBYTES")]
        public const uint crypto_box_MACBYTES = 16U;

        [NativeTypeName("#define crypto_box_MESSAGEBYTES_MAX crypto_box_curve25519xsalsa20poly1305_MESSAGEBYTES_MAX")]
        public const ulong crypto_box_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [NativeTypeName("#define crypto_box_PRIMITIVE \"curve25519xsalsa20poly1305\"")]
        public static byte[] crypto_box_PRIMITIVE => new byte[] { 0x63, 0x75, 0x72, 0x76, 0x65, 0x32, 0x35, 0x35, 0x31, 0x39, 0x78, 0x73, 0x61, 0x6C, 0x73, 0x61, 0x32, 0x30, 0x70, 0x6F, 0x6C, 0x79, 0x31, 0x33, 0x30, 0x35, 0x00 };

        [NativeTypeName("#define crypto_box_BEFORENMBYTES crypto_box_curve25519xsalsa20poly1305_BEFORENMBYTES")]
        public const uint crypto_box_BEFORENMBYTES = 32U;

        [NativeTypeName("#define crypto_box_SEALBYTES (crypto_box_PUBLICKEYBYTES + crypto_box_MACBYTES)")]
        public const uint crypto_box_SEALBYTES = (32U + 16U);

        [NativeTypeName("#define crypto_box_ZEROBYTES crypto_box_curve25519xsalsa20poly1305_ZEROBYTES")]
        public const uint crypto_box_ZEROBYTES = (16U + 16U);

        [NativeTypeName("#define crypto_box_BOXZEROBYTES crypto_box_curve25519xsalsa20poly1305_BOXZEROBYTES")]
        public const uint crypto_box_BOXZEROBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xchacha20poly1305_seedbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xchacha20poly1305_publickeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xchacha20poly1305_secretkeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xchacha20poly1305_beforenmbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xchacha20poly1305_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xchacha20poly1305_macbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xchacha20poly1305_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_seed_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk, [NativeTypeName("const unsigned char *")] byte[] seed);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_easy([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_open_easy([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_open_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_beforenm([NativeTypeName("unsigned char *")] byte[] k, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_easy_afternm([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_open_easy_afternm([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_detached_afternm([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_open_detached_afternm([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xchacha20poly1305_sealbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_seal([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] pk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xchacha20poly1305_seal_open([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [NativeTypeName("#define crypto_box_curve25519xchacha20poly1305_SEEDBYTES 32U")]
        public const uint crypto_box_curve25519xchacha20poly1305_SEEDBYTES = 32U;

        [NativeTypeName("#define crypto_box_curve25519xchacha20poly1305_PUBLICKEYBYTES 32U")]
        public const uint crypto_box_curve25519xchacha20poly1305_PUBLICKEYBYTES = 32U;

        [NativeTypeName("#define crypto_box_curve25519xchacha20poly1305_SECRETKEYBYTES 32U")]
        public const uint crypto_box_curve25519xchacha20poly1305_SECRETKEYBYTES = 32U;

        [NativeTypeName("#define crypto_box_curve25519xchacha20poly1305_BEFORENMBYTES 32U")]
        public const uint crypto_box_curve25519xchacha20poly1305_BEFORENMBYTES = 32U;

        [NativeTypeName("#define crypto_box_curve25519xchacha20poly1305_NONCEBYTES 24U")]
        public const uint crypto_box_curve25519xchacha20poly1305_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_box_curve25519xchacha20poly1305_MACBYTES 16U")]
        public const uint crypto_box_curve25519xchacha20poly1305_MACBYTES = 16U;

        [NativeTypeName("#define crypto_box_curve25519xchacha20poly1305_MESSAGEBYTES_MAX (crypto_stream_xchacha20_MESSAGEBYTES_MAX - crypto_box_curve25519xchacha20poly1305_MACBYTES)")]
        public const ulong crypto_box_curve25519xchacha20poly1305_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [NativeTypeName("#define crypto_box_curve25519xchacha20poly1305_SEALBYTES (crypto_box_curve25519xchacha20poly1305_PUBLICKEYBYTES + \\\r\n     crypto_box_curve25519xchacha20poly1305_MACBYTES)")]
        public const uint crypto_box_curve25519xchacha20poly1305_SEALBYTES = (32U + 16U);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_seedbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_publickeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_secretkeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_beforenmbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_macbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xsalsa20poly1305_seed_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk, [NativeTypeName("const unsigned char *")] byte[] seed);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xsalsa20poly1305_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xsalsa20poly1305_beforenm([NativeTypeName("unsigned char *")] byte[] k, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_boxzerobytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_box_curve25519xsalsa20poly1305_zerobytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xsalsa20poly1305([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xsalsa20poly1305_open([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xsalsa20poly1305_afternm([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_box_curve25519xsalsa20poly1305_open_afternm([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_SEEDBYTES 32U")]
        public const uint crypto_box_curve25519xsalsa20poly1305_SEEDBYTES = 32U;

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_PUBLICKEYBYTES 32U")]
        public const uint crypto_box_curve25519xsalsa20poly1305_PUBLICKEYBYTES = 32U;

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_SECRETKEYBYTES 32U")]
        public const uint crypto_box_curve25519xsalsa20poly1305_SECRETKEYBYTES = 32U;

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_BEFORENMBYTES 32U")]
        public const uint crypto_box_curve25519xsalsa20poly1305_BEFORENMBYTES = 32U;

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_NONCEBYTES 24U")]
        public const uint crypto_box_curve25519xsalsa20poly1305_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_MACBYTES 16U")]
        public const uint crypto_box_curve25519xsalsa20poly1305_MACBYTES = 16U;

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_MESSAGEBYTES_MAX (crypto_stream_xsalsa20_MESSAGEBYTES_MAX - crypto_box_curve25519xsalsa20poly1305_MACBYTES)")]
        public const ulong crypto_box_curve25519xsalsa20poly1305_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_BOXZEROBYTES 16U")]
        public const uint crypto_box_curve25519xsalsa20poly1305_BOXZEROBYTES = 16U;

        [NativeTypeName("#define crypto_box_curve25519xsalsa20poly1305_ZEROBYTES (crypto_box_curve25519xsalsa20poly1305_BOXZEROBYTES + \\\r\n     crypto_box_curve25519xsalsa20poly1305_MACBYTES)")]
        public const uint crypto_box_curve25519xsalsa20poly1305_ZEROBYTES = (16U + 16U);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ed25519_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ed25519_uniformbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ed25519_hashbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ed25519_scalarbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ed25519_nonreducedscalarbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ed25519_is_valid_point([NativeTypeName("const unsigned char *")] byte[] p);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ed25519_add([NativeTypeName("unsigned char *")] byte[] r, [NativeTypeName("const unsigned char *")] byte[] p, [NativeTypeName("const unsigned char *")] byte[] q);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ed25519_sub([NativeTypeName("unsigned char *")] byte[] r, [NativeTypeName("const unsigned char *")] byte[] p, [NativeTypeName("const unsigned char *")] byte[] q);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ed25519_from_uniform([NativeTypeName("unsigned char *")] byte[] p, [NativeTypeName("const unsigned char *")] byte[] r);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ed25519_from_string([NativeTypeName("unsigned char [32]")] byte* p, [NativeTypeName("const char *")] sbyte* ctx, [NativeTypeName("const unsigned char *")] byte[] msg, [NativeTypeName("size_t")] UIntPtr msg_len, int hash_alg);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ed25519_from_string_ro([NativeTypeName("unsigned char [32]")] byte* p, [NativeTypeName("const char *")] sbyte* ctx, [NativeTypeName("const unsigned char *")] byte[] msg, [NativeTypeName("size_t")] UIntPtr msg_len, int hash_alg);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ed25519_random([NativeTypeName("unsigned char *")] byte[] p);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ed25519_scalar_random([NativeTypeName("unsigned char *")] byte[] r);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ed25519_scalar_invert([NativeTypeName("unsigned char *")] byte[] recip, [NativeTypeName("const unsigned char *")] byte[] s);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ed25519_scalar_negate([NativeTypeName("unsigned char *")] byte[] neg, [NativeTypeName("const unsigned char *")] byte[] s);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ed25519_scalar_complement([NativeTypeName("unsigned char *")] byte[] comp, [NativeTypeName("const unsigned char *")] byte[] s);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ed25519_scalar_add([NativeTypeName("unsigned char *")] byte[] z, [NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ed25519_scalar_sub([NativeTypeName("unsigned char *")] byte[] z, [NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ed25519_scalar_mul([NativeTypeName("unsigned char *")] byte[] z, [NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ed25519_scalar_reduce([NativeTypeName("unsigned char *")] byte[] r, [NativeTypeName("const unsigned char *")] byte[] s);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ed25519_scalar_is_canonical([NativeTypeName("const unsigned char *")] byte[] s);

        [NativeTypeName("#define crypto_core_ed25519_BYTES 32")]
        public const int crypto_core_ed25519_BYTES = 32;

        [NativeTypeName("#define crypto_core_ed25519_UNIFORMBYTES 32")]
        public const int crypto_core_ed25519_UNIFORMBYTES = 32;

        [NativeTypeName("#define crypto_core_ed25519_HASHBYTES 64")]
        public const int crypto_core_ed25519_HASHBYTES = 64;

        [NativeTypeName("#define crypto_core_ed25519_SCALARBYTES 32")]
        public const int crypto_core_ed25519_SCALARBYTES = 32;

        [NativeTypeName("#define crypto_core_ed25519_NONREDUCEDSCALARBYTES 64")]
        public const int crypto_core_ed25519_NONREDUCEDSCALARBYTES = 64;

        [NativeTypeName("#define crypto_core_ed25519_H2CSHA256 1")]
        public const int crypto_core_ed25519_H2CSHA256 = 1;

        [NativeTypeName("#define crypto_core_ed25519_H2CSHA512 2")]
        public const int crypto_core_ed25519_H2CSHA512 = 2;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_hchacha20_outputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_hchacha20_inputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_hchacha20_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_hchacha20_constbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_hchacha20([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("const unsigned char *")] byte[] k, [NativeTypeName("const unsigned char *")] byte[] c);

        [NativeTypeName("#define crypto_core_hchacha20_OUTPUTBYTES 32U")]
        public const uint crypto_core_hchacha20_OUTPUTBYTES = 32U;

        [NativeTypeName("#define crypto_core_hchacha20_INPUTBYTES 16U")]
        public const uint crypto_core_hchacha20_INPUTBYTES = 16U;

        [NativeTypeName("#define crypto_core_hchacha20_KEYBYTES 32U")]
        public const uint crypto_core_hchacha20_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_core_hchacha20_CONSTBYTES 16U")]
        public const uint crypto_core_hchacha20_CONSTBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_hsalsa20_outputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_hsalsa20_inputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_hsalsa20_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_hsalsa20_constbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_hsalsa20([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("const unsigned char *")] byte[] k, [NativeTypeName("const unsigned char *")] byte[] c);

        [NativeTypeName("#define crypto_core_hsalsa20_OUTPUTBYTES 32U")]
        public const uint crypto_core_hsalsa20_OUTPUTBYTES = 32U;

        [NativeTypeName("#define crypto_core_hsalsa20_INPUTBYTES 16U")]
        public const uint crypto_core_hsalsa20_INPUTBYTES = 16U;

        [NativeTypeName("#define crypto_core_hsalsa20_KEYBYTES 32U")]
        public const uint crypto_core_hsalsa20_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_core_hsalsa20_CONSTBYTES 16U")]
        public const uint crypto_core_hsalsa20_CONSTBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ristretto255_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ristretto255_hashbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ristretto255_scalarbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_ristretto255_nonreducedscalarbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ristretto255_is_valid_point([NativeTypeName("const unsigned char *")] byte[] p);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ristretto255_add([NativeTypeName("unsigned char *")] byte[] r, [NativeTypeName("const unsigned char *")] byte[] p, [NativeTypeName("const unsigned char *")] byte[] q);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ristretto255_sub([NativeTypeName("unsigned char *")] byte[] r, [NativeTypeName("const unsigned char *")] byte[] p, [NativeTypeName("const unsigned char *")] byte[] q);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ristretto255_from_hash([NativeTypeName("unsigned char *")] byte[] p, [NativeTypeName("const unsigned char *")] byte[] r);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ristretto255_from_string([NativeTypeName("unsigned char [32]")] byte* p, [NativeTypeName("const char *")] sbyte* ctx, [NativeTypeName("const unsigned char *")] byte[] msg, [NativeTypeName("size_t")] UIntPtr msg_len, int hash_alg);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ristretto255_from_string_ro([NativeTypeName("unsigned char [32]")] byte* p, [NativeTypeName("const char *")] sbyte* ctx, [NativeTypeName("const unsigned char *")] byte[] msg, [NativeTypeName("size_t")] UIntPtr msg_len, int hash_alg);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ristretto255_random([NativeTypeName("unsigned char *")] byte[] p);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ristretto255_scalar_random([NativeTypeName("unsigned char *")] byte[] r);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ristretto255_scalar_invert([NativeTypeName("unsigned char *")] byte[] recip, [NativeTypeName("const unsigned char *")] byte[] s);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ristretto255_scalar_negate([NativeTypeName("unsigned char *")] byte[] neg, [NativeTypeName("const unsigned char *")] byte[] s);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ristretto255_scalar_complement([NativeTypeName("unsigned char *")] byte[] comp, [NativeTypeName("const unsigned char *")] byte[] s);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ristretto255_scalar_add([NativeTypeName("unsigned char *")] byte[] z, [NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ristretto255_scalar_sub([NativeTypeName("unsigned char *")] byte[] z, [NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ristretto255_scalar_mul([NativeTypeName("unsigned char *")] byte[] z, [NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_core_ristretto255_scalar_reduce([NativeTypeName("unsigned char *")] byte[] r, [NativeTypeName("const unsigned char *")] byte[] s);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_ristretto255_scalar_is_canonical([NativeTypeName("const unsigned char *")] byte[] s);

        [NativeTypeName("#define crypto_core_ristretto255_BYTES 32")]
        public const int crypto_core_ristretto255_BYTES = 32;

        [NativeTypeName("#define crypto_core_ristretto255_HASHBYTES 64")]
        public const int crypto_core_ristretto255_HASHBYTES = 64;

        [NativeTypeName("#define crypto_core_ristretto255_SCALARBYTES 32")]
        public const int crypto_core_ristretto255_SCALARBYTES = 32;

        [NativeTypeName("#define crypto_core_ristretto255_NONREDUCEDSCALARBYTES 64")]
        public const int crypto_core_ristretto255_NONREDUCEDSCALARBYTES = 64;

        [NativeTypeName("#define crypto_core_ristretto255_H2CSHA256 1")]
        public const int crypto_core_ristretto255_H2CSHA256 = 1;

        [NativeTypeName("#define crypto_core_ristretto255_H2CSHA512 2")]
        public const int crypto_core_ristretto255_H2CSHA512 = 2;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa20_outputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa20_inputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa20_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa20_constbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_salsa20([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("const unsigned char *")] byte[] k, [NativeTypeName("const unsigned char *")] byte[] c);

        [NativeTypeName("#define crypto_core_salsa20_OUTPUTBYTES 64U")]
        public const uint crypto_core_salsa20_OUTPUTBYTES = 64U;

        [NativeTypeName("#define crypto_core_salsa20_INPUTBYTES 16U")]
        public const uint crypto_core_salsa20_INPUTBYTES = 16U;

        [NativeTypeName("#define crypto_core_salsa20_KEYBYTES 32U")]
        public const uint crypto_core_salsa20_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_core_salsa20_CONSTBYTES 16U")]
        public const uint crypto_core_salsa20_CONSTBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa2012_outputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa2012_inputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa2012_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa2012_constbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_salsa2012([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("const unsigned char *")] byte[] k, [NativeTypeName("const unsigned char *")] byte[] c);

        [NativeTypeName("#define crypto_core_salsa2012_OUTPUTBYTES 64U")]
        public const uint crypto_core_salsa2012_OUTPUTBYTES = 64U;

        [NativeTypeName("#define crypto_core_salsa2012_INPUTBYTES 16U")]
        public const uint crypto_core_salsa2012_INPUTBYTES = 16U;

        [NativeTypeName("#define crypto_core_salsa2012_KEYBYTES 32U")]
        public const uint crypto_core_salsa2012_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_core_salsa2012_CONSTBYTES 16U")]
        public const uint crypto_core_salsa2012_CONSTBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa208_outputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa208_inputbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa208_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_core_salsa208_constbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_core_salsa208([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("const unsigned char *")] byte[] k, [NativeTypeName("const unsigned char *")] byte[] c);

        [NativeTypeName("#define crypto_core_salsa208_OUTPUTBYTES 64U")]
        public const uint crypto_core_salsa208_OUTPUTBYTES = 64U;

        [NativeTypeName("#define crypto_core_salsa208_INPUTBYTES 16U")]
        public const uint crypto_core_salsa208_INPUTBYTES = 16U;

        [NativeTypeName("#define crypto_core_salsa208_KEYBYTES 32U")]
        public const uint crypto_core_salsa208_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_core_salsa208_CONSTBYTES 16U")]
        public const uint crypto_core_salsa208_CONSTBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_keybytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_keybytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_generichash_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("size_t")] UIntPtr outlen, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("size_t")] UIntPtr keylen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_init([NativeTypeName("crypto_generichash_state *")] crypto_generichash_blake2b_state* state, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("const size_t")] UIntPtr keylen, [NativeTypeName("const size_t")] UIntPtr outlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_update([NativeTypeName("crypto_generichash_state *")] crypto_generichash_blake2b_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_final([NativeTypeName("crypto_generichash_state *")] crypto_generichash_blake2b_state* state, [NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const size_t")] UIntPtr outlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_generichash_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_generichash_BYTES_MIN crypto_generichash_blake2b_BYTES_MIN")]
        public const uint crypto_generichash_BYTES_MIN = 16U;

        [NativeTypeName("#define crypto_generichash_BYTES_MAX crypto_generichash_blake2b_BYTES_MAX")]
        public const uint crypto_generichash_BYTES_MAX = 64U;

        [NativeTypeName("#define crypto_generichash_BYTES crypto_generichash_blake2b_BYTES")]
        public const uint crypto_generichash_BYTES = 32U;

        [NativeTypeName("#define crypto_generichash_KEYBYTES_MIN crypto_generichash_blake2b_KEYBYTES_MIN")]
        public const uint crypto_generichash_KEYBYTES_MIN = 16U;

        [NativeTypeName("#define crypto_generichash_KEYBYTES_MAX crypto_generichash_blake2b_KEYBYTES_MAX")]
        public const uint crypto_generichash_KEYBYTES_MAX = 64U;

        [NativeTypeName("#define crypto_generichash_KEYBYTES crypto_generichash_blake2b_KEYBYTES")]
        public const uint crypto_generichash_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_generichash_PRIMITIVE \"blake2b\"")]
        public static byte[] crypto_generichash_PRIMITIVE => new byte[] { 0x62, 0x6C, 0x61, 0x6B, 0x65, 0x32, 0x62, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_keybytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_keybytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_saltbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_personalbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_generichash_blake2b_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_blake2b([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("size_t")] UIntPtr outlen, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("size_t")] UIntPtr keylen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_blake2b_salt_personal([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("size_t")] UIntPtr outlen, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("size_t")] UIntPtr keylen, [NativeTypeName("const unsigned char *")] byte[] salt, [NativeTypeName("const unsigned char *")] byte[] personal);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_blake2b_init(crypto_generichash_blake2b_state* state, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("const size_t")] UIntPtr keylen, [NativeTypeName("const size_t")] UIntPtr outlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_blake2b_init_salt_personal(crypto_generichash_blake2b_state* state, [NativeTypeName("const unsigned char *")] byte[] key, [NativeTypeName("const size_t")] UIntPtr keylen, [NativeTypeName("const size_t")] UIntPtr outlen, [NativeTypeName("const unsigned char *")] byte[] salt, [NativeTypeName("const unsigned char *")] byte[] personal);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_blake2b_update(crypto_generichash_blake2b_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_generichash_blake2b_final(crypto_generichash_blake2b_state* state, [NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const size_t")] UIntPtr outlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_generichash_blake2b_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_generichash_blake2b_BYTES_MIN 16U")]
        public const uint crypto_generichash_blake2b_BYTES_MIN = 16U;

        [NativeTypeName("#define crypto_generichash_blake2b_BYTES_MAX 64U")]
        public const uint crypto_generichash_blake2b_BYTES_MAX = 64U;

        [NativeTypeName("#define crypto_generichash_blake2b_BYTES 32U")]
        public const uint crypto_generichash_blake2b_BYTES = 32U;

        [NativeTypeName("#define crypto_generichash_blake2b_KEYBYTES_MIN 16U")]
        public const uint crypto_generichash_blake2b_KEYBYTES_MIN = 16U;

        [NativeTypeName("#define crypto_generichash_blake2b_KEYBYTES_MAX 64U")]
        public const uint crypto_generichash_blake2b_KEYBYTES_MAX = 64U;

        [NativeTypeName("#define crypto_generichash_blake2b_KEYBYTES 32U")]
        public const uint crypto_generichash_blake2b_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_generichash_blake2b_SALTBYTES 16U")]
        public const uint crypto_generichash_blake2b_SALTBYTES = 16U;

        [NativeTypeName("#define crypto_generichash_blake2b_PERSONALBYTES 16U")]
        public const uint crypto_generichash_blake2b_PERSONALBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_hash_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_hash_primitive();

        [NativeTypeName("#define crypto_hash_BYTES crypto_hash_sha512_BYTES")]
        public const uint crypto_hash_BYTES = 64U;

        [NativeTypeName("#define crypto_hash_PRIMITIVE \"sha512\"")]
        public static byte[] crypto_hash_PRIMITIVE => new byte[] { 0x73, 0x68, 0x61, 0x35, 0x31, 0x32, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_hash_sha256_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_hash_sha256_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash_sha256([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash_sha256_init(crypto_hash_sha256_state* state);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash_sha256_update(crypto_hash_sha256_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash_sha256_final(crypto_hash_sha256_state* state, [NativeTypeName("unsigned char *")] byte* @out);

        [NativeTypeName("#define crypto_hash_sha256_BYTES 32U")]
        public const uint crypto_hash_sha256_BYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_hash_sha512_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_hash_sha512_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash_sha512([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash_sha512_init(crypto_hash_sha512_state* state);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash_sha512_update(crypto_hash_sha512_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_hash_sha512_final(crypto_hash_sha512_state* state, [NativeTypeName("unsigned char *")] byte* @out);

        [NativeTypeName("#define crypto_hash_sha512_BYTES 64U")]
        public const uint crypto_hash_sha512_BYTES = 64U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_contextbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_kdf_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kdf_derive_from_key([NativeTypeName("unsigned char *")] byte[] subkey, [NativeTypeName("size_t")] UIntPtr subkey_len, [NativeTypeName("uint64_t")] ulong subkey_id, [NativeTypeName("const char [8]")] sbyte* ctx, [NativeTypeName("const unsigned char [32]")] byte[] key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_kdf_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_kdf_BYTES_MIN crypto_kdf_blake2b_BYTES_MIN")]
        public const int crypto_kdf_BYTES_MIN = 16;

        [NativeTypeName("#define crypto_kdf_BYTES_MAX crypto_kdf_blake2b_BYTES_MAX")]
        public const int crypto_kdf_BYTES_MAX = 64;

        [NativeTypeName("#define crypto_kdf_CONTEXTBYTES crypto_kdf_blake2b_CONTEXTBYTES")]
        public const int crypto_kdf_CONTEXTBYTES = 8;

        [NativeTypeName("#define crypto_kdf_KEYBYTES crypto_kdf_blake2b_KEYBYTES")]
        public const int crypto_kdf_KEYBYTES = 32;

        [NativeTypeName("#define crypto_kdf_PRIMITIVE \"blake2b\"")]
        public static byte[] crypto_kdf_PRIMITIVE => new byte[] { 0x62, 0x6C, 0x61, 0x6B, 0x65, 0x32, 0x62, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_blake2b_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_blake2b_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_blake2b_contextbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_blake2b_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kdf_blake2b_derive_from_key([NativeTypeName("unsigned char *")] byte[] subkey, [NativeTypeName("size_t")] UIntPtr subkey_len, [NativeTypeName("uint64_t")] ulong subkey_id, [NativeTypeName("const char [8]")] sbyte* ctx, [NativeTypeName("const unsigned char [32]")] byte[] key);

        [NativeTypeName("#define crypto_kdf_blake2b_BYTES_MIN 16")]
        public const int crypto_kdf_blake2b_BYTES_MIN = 16;

        [NativeTypeName("#define crypto_kdf_blake2b_BYTES_MAX 64")]
        public const int crypto_kdf_blake2b_BYTES_MAX = 64;

        [NativeTypeName("#define crypto_kdf_blake2b_CONTEXTBYTES 8")]
        public const int crypto_kdf_blake2b_CONTEXTBYTES = 8;

        [NativeTypeName("#define crypto_kdf_blake2b_KEYBYTES 32")]
        public const int crypto_kdf_blake2b_KEYBYTES = 32;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_hkdf_sha256_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_hkdf_sha256_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_hkdf_sha256_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kdf_hkdf_sha256_extract([NativeTypeName("unsigned char [32]")] byte* prk, [NativeTypeName("const unsigned char *")] byte[] salt, [NativeTypeName("size_t")] UIntPtr salt_len, [NativeTypeName("const unsigned char *")] byte[] ikm, [NativeTypeName("size_t")] UIntPtr ikm_len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_kdf_hkdf_sha256_keygen([NativeTypeName("unsigned char [32]")] byte* prk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kdf_hkdf_sha256_expand([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("size_t")] UIntPtr out_len, [NativeTypeName("const char *")] sbyte* ctx, [NativeTypeName("size_t")] UIntPtr ctx_len, [NativeTypeName("const unsigned char [32]")] byte[] prk);

        [NativeTypeName("#define crypto_kdf_hkdf_sha256_KEYBYTES crypto_auth_hmacsha256_BYTES")]
        public const uint crypto_kdf_hkdf_sha256_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_kdf_hkdf_sha256_BYTES_MIN 0U")]
        public const uint crypto_kdf_hkdf_sha256_BYTES_MIN = 0U;

        [NativeTypeName("#define crypto_kdf_hkdf_sha256_BYTES_MAX (0xff * crypto_auth_hmacsha256_BYTES)")]
        public const uint crypto_kdf_hkdf_sha256_BYTES_MAX = (0xff * 32U);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_hkdf_sha512_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_hkdf_sha512_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kdf_hkdf_sha512_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kdf_hkdf_sha512_extract([NativeTypeName("unsigned char [64]")] byte* prk, [NativeTypeName("const unsigned char *")] byte[] salt, [NativeTypeName("size_t")] UIntPtr salt_len, [NativeTypeName("const unsigned char *")] byte[] ikm, [NativeTypeName("size_t")] UIntPtr ikm_len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_kdf_hkdf_sha512_keygen([NativeTypeName("unsigned char [64]")] byte* prk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kdf_hkdf_sha512_expand([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("size_t")] UIntPtr out_len, [NativeTypeName("const char *")] sbyte* ctx, [NativeTypeName("size_t")] UIntPtr ctx_len, [NativeTypeName("const unsigned char [64]")] byte* prk);

        [NativeTypeName("#define crypto_kdf_hkdf_sha512_KEYBYTES crypto_auth_hmacsha512_BYTES")]
        public const uint crypto_kdf_hkdf_sha512_KEYBYTES = 64U;

        [NativeTypeName("#define crypto_kdf_hkdf_sha512_BYTES_MIN 0U")]
        public const uint crypto_kdf_hkdf_sha512_BYTES_MIN = 0U;

        [NativeTypeName("#define crypto_kdf_hkdf_sha512_BYTES_MAX (0xff * crypto_auth_hmacsha512_BYTES)")]
        public const uint crypto_kdf_hkdf_sha512_BYTES_MAX = (0xff * 64U);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kx_publickeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kx_secretkeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kx_seedbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_kx_sessionkeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_kx_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kx_seed_keypair([NativeTypeName("unsigned char [32]")] byte* pk, [NativeTypeName("unsigned char [32]")] byte* sk, [NativeTypeName("const unsigned char [32]")] byte[] seed);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kx_keypair([NativeTypeName("unsigned char [32]")] byte* pk, [NativeTypeName("unsigned char [32]")] byte* sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kx_client_session_keys([NativeTypeName("unsigned char [32]")] byte* rx, [NativeTypeName("unsigned char [32]")] byte* tx, [NativeTypeName("const unsigned char [32]")] byte[] client_pk, [NativeTypeName("const unsigned char [32]")] byte[] client_sk, [NativeTypeName("const unsigned char [32]")] byte[] server_pk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_kx_server_session_keys([NativeTypeName("unsigned char [32]")] byte* rx, [NativeTypeName("unsigned char [32]")] byte* tx, [NativeTypeName("const unsigned char [32]")] byte[] server_pk, [NativeTypeName("const unsigned char [32]")] byte[] server_sk, [NativeTypeName("const unsigned char [32]")] byte[] client_pk);

        [NativeTypeName("#define crypto_kx_PUBLICKEYBYTES 32")]
        public const int crypto_kx_PUBLICKEYBYTES = 32;

        [NativeTypeName("#define crypto_kx_SECRETKEYBYTES 32")]
        public const int crypto_kx_SECRETKEYBYTES = 32;

        [NativeTypeName("#define crypto_kx_SEEDBYTES 32")]
        public const int crypto_kx_SEEDBYTES = 32;

        [NativeTypeName("#define crypto_kx_SESSIONKEYBYTES 32")]
        public const int crypto_kx_SESSIONKEYBYTES = 32;

        [NativeTypeName("#define crypto_kx_PRIMITIVE \"x25519blake2b\"")]
        public static byte[] crypto_kx_PRIMITIVE => new byte[] { 0x78, 0x32, 0x35, 0x35, 0x31, 0x39, 0x62, 0x6C, 0x61, 0x6B, 0x65, 0x32, 0x62, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_onetimeauth_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_onetimeauth_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_onetimeauth_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_onetimeauth_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_verify([NativeTypeName("const unsigned char *")] byte[] h, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_init([NativeTypeName("crypto_onetimeauth_state *")] crypto_onetimeauth_poly1305_state* state, [NativeTypeName("const unsigned char *")] byte[] key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_update([NativeTypeName("crypto_onetimeauth_state *")] crypto_onetimeauth_poly1305_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_final([NativeTypeName("crypto_onetimeauth_state *")] crypto_onetimeauth_poly1305_state* state, [NativeTypeName("unsigned char *")] byte* @out);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_onetimeauth_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_onetimeauth_BYTES crypto_onetimeauth_poly1305_BYTES")]
        public const uint crypto_onetimeauth_BYTES = 16U;

        [NativeTypeName("#define crypto_onetimeauth_KEYBYTES crypto_onetimeauth_poly1305_KEYBYTES")]
        public const uint crypto_onetimeauth_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_onetimeauth_PRIMITIVE \"poly1305\"")]
        public static byte[] crypto_onetimeauth_PRIMITIVE => new byte[] { 0x70, 0x6F, 0x6C, 0x79, 0x31, 0x33, 0x30, 0x35, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_onetimeauth_poly1305_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_onetimeauth_poly1305_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_onetimeauth_poly1305_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_poly1305([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_poly1305_verify([NativeTypeName("const unsigned char *")] byte[] h, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_poly1305_init(crypto_onetimeauth_poly1305_state* state, [NativeTypeName("const unsigned char *")] byte[] key);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_poly1305_update(crypto_onetimeauth_poly1305_state* state, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_onetimeauth_poly1305_final(crypto_onetimeauth_poly1305_state* state, [NativeTypeName("unsigned char *")] byte* @out);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_onetimeauth_poly1305_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_onetimeauth_poly1305_BYTES 16U")]
        public const uint crypto_onetimeauth_poly1305_BYTES = 16U;

        [NativeTypeName("#define crypto_onetimeauth_poly1305_KEYBYTES 32U")]
        public const uint crypto_onetimeauth_poly1305_KEYBYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_alg_argon2i13();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_alg_argon2id13();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_alg_default();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_passwd_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_passwd_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_saltbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_strbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_pwhash_strprefix();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_opslimit_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_opslimit_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_memlimit_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_memlimit_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_opslimit_interactive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_memlimit_interactive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_opslimit_moderate();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_memlimit_moderate();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_opslimit_sensitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_memlimit_sensitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash([NativeTypeName("unsigned char *const")] byte* @out, [NativeTypeName("unsigned long long")] ulong outlen, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("const unsigned char *const")] byte* salt, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit, int alg);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_str([NativeTypeName("char [128]")] sbyte* @out, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_str_alg([NativeTypeName("char [128]")] sbyte* @out, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit, int alg);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_str_verify([NativeTypeName("const char [128]")] sbyte* str, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_str_needs_rehash([NativeTypeName("const char [128]")] sbyte* str, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_pwhash_primitive();

        [NativeTypeName("#define crypto_pwhash_ALG_ARGON2I13 crypto_pwhash_argon2i_ALG_ARGON2I13")]
        public const int crypto_pwhash_ALG_ARGON2I13 = 1;

        [NativeTypeName("#define crypto_pwhash_ALG_ARGON2ID13 crypto_pwhash_argon2id_ALG_ARGON2ID13")]
        public const int crypto_pwhash_ALG_ARGON2ID13 = 2;

        [NativeTypeName("#define crypto_pwhash_ALG_DEFAULT crypto_pwhash_ALG_ARGON2ID13")]
        public const int crypto_pwhash_ALG_DEFAULT = 2;

        [NativeTypeName("#define crypto_pwhash_BYTES_MIN crypto_pwhash_argon2id_BYTES_MIN")]
        public const uint crypto_pwhash_BYTES_MIN = 16U;

        [NativeTypeName("#define crypto_pwhash_BYTES_MAX crypto_pwhash_argon2id_BYTES_MAX")]
        public const ulong crypto_pwhash_BYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) < (4294967295U) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) : (4294967295U));

        [NativeTypeName("#define crypto_pwhash_PASSWD_MIN crypto_pwhash_argon2id_PASSWD_MIN")]
        public const uint crypto_pwhash_PASSWD_MIN = 0U;

        [NativeTypeName("#define crypto_pwhash_PASSWD_MAX crypto_pwhash_argon2id_PASSWD_MAX")]
        public const uint crypto_pwhash_PASSWD_MAX = 4294967295U;

        [NativeTypeName("#define crypto_pwhash_SALTBYTES crypto_pwhash_argon2id_SALTBYTES")]
        public const uint crypto_pwhash_SALTBYTES = 16U;

        [NativeTypeName("#define crypto_pwhash_STRBYTES crypto_pwhash_argon2id_STRBYTES")]
        public const uint crypto_pwhash_STRBYTES = 128U;

        [NativeTypeName("#define crypto_pwhash_STRPREFIX crypto_pwhash_argon2id_STRPREFIX")]
        public static byte[] crypto_pwhash_STRPREFIX => new byte[] { 0x24, 0x61, 0x72, 0x67, 0x6F, 0x6E, 0x32, 0x69, 0x64, 0x24, 0x00 };

        [NativeTypeName("#define crypto_pwhash_OPSLIMIT_MIN crypto_pwhash_argon2id_OPSLIMIT_MIN")]
        public const uint crypto_pwhash_OPSLIMIT_MIN = 1U;

        [NativeTypeName("#define crypto_pwhash_OPSLIMIT_MAX crypto_pwhash_argon2id_OPSLIMIT_MAX")]
        public const uint crypto_pwhash_OPSLIMIT_MAX = 4294967295U;

        [NativeTypeName("#define crypto_pwhash_MEMLIMIT_MIN crypto_pwhash_argon2id_MEMLIMIT_MIN")]
        public const uint crypto_pwhash_MEMLIMIT_MIN = 8192U;

        [NativeTypeName("#define crypto_pwhash_MEMLIMIT_MAX crypto_pwhash_argon2id_MEMLIMIT_MAX")]
        public const ulong crypto_pwhash_MEMLIMIT_MAX = ((0xffffffffffffffffUL >= 4398046510080U) ? 4398046510080U : (0xffffffffffffffffUL >= 2147483648U) ? 2147483648U : 32768U);

        [NativeTypeName("#define crypto_pwhash_OPSLIMIT_INTERACTIVE crypto_pwhash_argon2id_OPSLIMIT_INTERACTIVE")]
        public const uint crypto_pwhash_OPSLIMIT_INTERACTIVE = 2U;

        [NativeTypeName("#define crypto_pwhash_MEMLIMIT_INTERACTIVE crypto_pwhash_argon2id_MEMLIMIT_INTERACTIVE")]
        public const uint crypto_pwhash_MEMLIMIT_INTERACTIVE = 67108864U;

        [NativeTypeName("#define crypto_pwhash_OPSLIMIT_MODERATE crypto_pwhash_argon2id_OPSLIMIT_MODERATE")]
        public const uint crypto_pwhash_OPSLIMIT_MODERATE = 3U;

        [NativeTypeName("#define crypto_pwhash_MEMLIMIT_MODERATE crypto_pwhash_argon2id_MEMLIMIT_MODERATE")]
        public const uint crypto_pwhash_MEMLIMIT_MODERATE = 268435456U;

        [NativeTypeName("#define crypto_pwhash_OPSLIMIT_SENSITIVE crypto_pwhash_argon2id_OPSLIMIT_SENSITIVE")]
        public const uint crypto_pwhash_OPSLIMIT_SENSITIVE = 4U;

        [NativeTypeName("#define crypto_pwhash_MEMLIMIT_SENSITIVE crypto_pwhash_argon2id_MEMLIMIT_SENSITIVE")]
        public const uint crypto_pwhash_MEMLIMIT_SENSITIVE = 1073741824U;

        [NativeTypeName("#define crypto_pwhash_PRIMITIVE \"argon2i\"")]
        public static byte[] crypto_pwhash_PRIMITIVE => new byte[] { 0x61, 0x72, 0x67, 0x6F, 0x6E, 0x32, 0x69, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2i_alg_argon2i13();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_passwd_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_passwd_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_saltbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_strbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_pwhash_argon2i_strprefix();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2i_opslimit_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2i_opslimit_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_memlimit_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_memlimit_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2i_opslimit_interactive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_memlimit_interactive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2i_opslimit_moderate();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_memlimit_moderate();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2i_opslimit_sensitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2i_memlimit_sensitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2i([NativeTypeName("unsigned char *const")] byte* @out, [NativeTypeName("unsigned long long")] ulong outlen, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("const unsigned char *const")] byte* salt, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit, int alg);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2i_str([NativeTypeName("char [128]")] sbyte* @out, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2i_str_verify([NativeTypeName("const char [128]")] sbyte* str, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2i_str_needs_rehash([NativeTypeName("const char [128]")] sbyte* str, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [NativeTypeName("#define crypto_pwhash_argon2i_ALG_ARGON2I13 1")]
        public const int crypto_pwhash_argon2i_ALG_ARGON2I13 = 1;

        [NativeTypeName("#define crypto_pwhash_argon2i_BYTES_MIN 16U")]
        public const uint crypto_pwhash_argon2i_BYTES_MIN = 16U;

        [NativeTypeName("#define crypto_pwhash_argon2i_BYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX, 4294967295U)")]
        public const ulong crypto_pwhash_argon2i_BYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) < (4294967295U) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) : (4294967295U));

        [NativeTypeName("#define crypto_pwhash_argon2i_PASSWD_MIN 0U")]
        public const uint crypto_pwhash_argon2i_PASSWD_MIN = 0U;

        [NativeTypeName("#define crypto_pwhash_argon2i_PASSWD_MAX 4294967295U")]
        public const uint crypto_pwhash_argon2i_PASSWD_MAX = 4294967295U;

        [NativeTypeName("#define crypto_pwhash_argon2i_SALTBYTES 16U")]
        public const uint crypto_pwhash_argon2i_SALTBYTES = 16U;

        [NativeTypeName("#define crypto_pwhash_argon2i_STRBYTES 128U")]
        public const uint crypto_pwhash_argon2i_STRBYTES = 128U;

        [NativeTypeName("#define crypto_pwhash_argon2i_STRPREFIX \"$argon2i$\"")]
        public static byte[] crypto_pwhash_argon2i_STRPREFIX => new byte[] { 0x24, 0x61, 0x72, 0x67, 0x6F, 0x6E, 0x32, 0x69, 0x24, 0x00 };

        [NativeTypeName("#define crypto_pwhash_argon2i_OPSLIMIT_MIN 3U")]
        public const uint crypto_pwhash_argon2i_OPSLIMIT_MIN = 3U;

        [NativeTypeName("#define crypto_pwhash_argon2i_OPSLIMIT_MAX 4294967295U")]
        public const uint crypto_pwhash_argon2i_OPSLIMIT_MAX = 4294967295U;

        [NativeTypeName("#define crypto_pwhash_argon2i_MEMLIMIT_MIN 8192U")]
        public const uint crypto_pwhash_argon2i_MEMLIMIT_MIN = 8192U;

        [NativeTypeName("#define crypto_pwhash_argon2i_MEMLIMIT_MAX ((SIZE_MAX >= 4398046510080U) ? 4398046510080U : (SIZE_MAX >= 2147483648U) ? 2147483648U : 32768U)")]
        public const ulong crypto_pwhash_argon2i_MEMLIMIT_MAX = ((0xffffffffffffffffUL >= 4398046510080U) ? 4398046510080U : (0xffffffffffffffffUL >= 2147483648U) ? 2147483648U : 32768U);

        [NativeTypeName("#define crypto_pwhash_argon2i_OPSLIMIT_INTERACTIVE 4U")]
        public const uint crypto_pwhash_argon2i_OPSLIMIT_INTERACTIVE = 4U;

        [NativeTypeName("#define crypto_pwhash_argon2i_MEMLIMIT_INTERACTIVE 33554432U")]
        public const uint crypto_pwhash_argon2i_MEMLIMIT_INTERACTIVE = 33554432U;

        [NativeTypeName("#define crypto_pwhash_argon2i_OPSLIMIT_MODERATE 6U")]
        public const uint crypto_pwhash_argon2i_OPSLIMIT_MODERATE = 6U;

        [NativeTypeName("#define crypto_pwhash_argon2i_MEMLIMIT_MODERATE 134217728U")]
        public const uint crypto_pwhash_argon2i_MEMLIMIT_MODERATE = 134217728U;

        [NativeTypeName("#define crypto_pwhash_argon2i_OPSLIMIT_SENSITIVE 8U")]
        public const uint crypto_pwhash_argon2i_OPSLIMIT_SENSITIVE = 8U;

        [NativeTypeName("#define crypto_pwhash_argon2i_MEMLIMIT_SENSITIVE 536870912U")]
        public const uint crypto_pwhash_argon2i_MEMLIMIT_SENSITIVE = 536870912U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2id_alg_argon2id13();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_passwd_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_passwd_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_saltbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_strbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_pwhash_argon2id_strprefix();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2id_opslimit_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2id_opslimit_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_memlimit_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_memlimit_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2id_opslimit_interactive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_memlimit_interactive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2id_opslimit_moderate();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_memlimit_moderate();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_argon2id_opslimit_sensitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_argon2id_memlimit_sensitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2id([NativeTypeName("unsigned char *const")] byte* @out, [NativeTypeName("unsigned long long")] ulong outlen, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("const unsigned char *const")] byte* salt, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit, int alg);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2id_str([NativeTypeName("char [128]")] sbyte* @out, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2id_str_verify([NativeTypeName("const char [128]")] sbyte* str, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_argon2id_str_needs_rehash([NativeTypeName("const char [128]")] sbyte* str, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [NativeTypeName("#define crypto_pwhash_argon2id_ALG_ARGON2ID13 2")]
        public const int crypto_pwhash_argon2id_ALG_ARGON2ID13 = 2;

        [NativeTypeName("#define crypto_pwhash_argon2id_BYTES_MIN 16U")]
        public const uint crypto_pwhash_argon2id_BYTES_MIN = 16U;

        [NativeTypeName("#define crypto_pwhash_argon2id_BYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX, 4294967295U)")]
        public const ulong crypto_pwhash_argon2id_BYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) < (4294967295U) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) : (4294967295U));

        [NativeTypeName("#define crypto_pwhash_argon2id_PASSWD_MIN 0U")]
        public const uint crypto_pwhash_argon2id_PASSWD_MIN = 0U;

        [NativeTypeName("#define crypto_pwhash_argon2id_PASSWD_MAX 4294967295U")]
        public const uint crypto_pwhash_argon2id_PASSWD_MAX = 4294967295U;

        [NativeTypeName("#define crypto_pwhash_argon2id_SALTBYTES 16U")]
        public const uint crypto_pwhash_argon2id_SALTBYTES = 16U;

        [NativeTypeName("#define crypto_pwhash_argon2id_STRBYTES 128U")]
        public const uint crypto_pwhash_argon2id_STRBYTES = 128U;

        [NativeTypeName("#define crypto_pwhash_argon2id_STRPREFIX \"$argon2id$\"")]
        public static byte[] crypto_pwhash_argon2id_STRPREFIX => new byte[] { 0x24, 0x61, 0x72, 0x67, 0x6F, 0x6E, 0x32, 0x69, 0x64, 0x24, 0x00 };

        [NativeTypeName("#define crypto_pwhash_argon2id_OPSLIMIT_MIN 1U")]
        public const uint crypto_pwhash_argon2id_OPSLIMIT_MIN = 1U;

        [NativeTypeName("#define crypto_pwhash_argon2id_OPSLIMIT_MAX 4294967295U")]
        public const uint crypto_pwhash_argon2id_OPSLIMIT_MAX = 4294967295U;

        [NativeTypeName("#define crypto_pwhash_argon2id_MEMLIMIT_MIN 8192U")]
        public const uint crypto_pwhash_argon2id_MEMLIMIT_MIN = 8192U;

        [NativeTypeName("#define crypto_pwhash_argon2id_MEMLIMIT_MAX ((SIZE_MAX >= 4398046510080U) ? 4398046510080U : (SIZE_MAX >= 2147483648U) ? 2147483648U : 32768U)")]
        public const ulong crypto_pwhash_argon2id_MEMLIMIT_MAX = ((0xffffffffffffffffUL >= 4398046510080U) ? 4398046510080U : (0xffffffffffffffffUL >= 2147483648U) ? 2147483648U : 32768U);

        [NativeTypeName("#define crypto_pwhash_argon2id_OPSLIMIT_INTERACTIVE 2U")]
        public const uint crypto_pwhash_argon2id_OPSLIMIT_INTERACTIVE = 2U;

        [NativeTypeName("#define crypto_pwhash_argon2id_MEMLIMIT_INTERACTIVE 67108864U")]
        public const uint crypto_pwhash_argon2id_MEMLIMIT_INTERACTIVE = 67108864U;

        [NativeTypeName("#define crypto_pwhash_argon2id_OPSLIMIT_MODERATE 3U")]
        public const uint crypto_pwhash_argon2id_OPSLIMIT_MODERATE = 3U;

        [NativeTypeName("#define crypto_pwhash_argon2id_MEMLIMIT_MODERATE 268435456U")]
        public const uint crypto_pwhash_argon2id_MEMLIMIT_MODERATE = 268435456U;

        [NativeTypeName("#define crypto_pwhash_argon2id_OPSLIMIT_SENSITIVE 4U")]
        public const uint crypto_pwhash_argon2id_OPSLIMIT_SENSITIVE = 4U;

        [NativeTypeName("#define crypto_pwhash_argon2id_MEMLIMIT_SENSITIVE 1073741824U")]
        public const uint crypto_pwhash_argon2id_MEMLIMIT_SENSITIVE = 1073741824U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_bytes_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_bytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_passwd_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_passwd_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_saltbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_strbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_pwhash_scryptsalsa208sha256_strprefix();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_scryptsalsa208sha256_opslimit_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_scryptsalsa208sha256_opslimit_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_memlimit_min();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_memlimit_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_scryptsalsa208sha256_opslimit_interactive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_memlimit_interactive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong crypto_pwhash_scryptsalsa208sha256_opslimit_sensitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_pwhash_scryptsalsa208sha256_memlimit_sensitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_scryptsalsa208sha256([NativeTypeName("unsigned char *const")] byte* @out, [NativeTypeName("unsigned long long")] ulong outlen, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("const unsigned char *const")] byte* salt, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_scryptsalsa208sha256_str([NativeTypeName("char [102]")] sbyte* @out, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_scryptsalsa208sha256_str_verify([NativeTypeName("const char [102]")] sbyte* str, [NativeTypeName("const char *const")] string passwd, [NativeTypeName("unsigned long long")] ulong passwdlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_scryptsalsa208sha256_ll([NativeTypeName("const uint8_t *")] byte* passwd, [NativeTypeName("size_t")] UIntPtr passwdlen, [NativeTypeName("const uint8_t *")] byte* salt, [NativeTypeName("size_t")] UIntPtr saltlen, [NativeTypeName("uint64_t")] ulong N, [NativeTypeName("uint32_t")] uint r, [NativeTypeName("uint32_t")] uint p, [NativeTypeName("uint8_t *")] byte* buf, [NativeTypeName("size_t")] UIntPtr buflen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_pwhash_scryptsalsa208sha256_str_needs_rehash([NativeTypeName("const char [102]")] sbyte* str, [NativeTypeName("unsigned long long")] ulong opslimit, [NativeTypeName("size_t")] UIntPtr memlimit);

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_BYTES_MIN 16U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_BYTES_MIN = 16U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_BYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX, 0x1fffffffe0ULL)")]
        public const ulong crypto_pwhash_scryptsalsa208sha256_BYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) < (0x1fffffffe0UL) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) : (0x1fffffffe0UL));

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_PASSWD_MIN 0U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_PASSWD_MIN = 0U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_PASSWD_MAX SODIUM_SIZE_MAX")]
        public const ulong crypto_pwhash_scryptsalsa208sha256_PASSWD_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_SALTBYTES 32U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_SALTBYTES = 32U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_STRBYTES 102U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_STRBYTES = 102U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_STRPREFIX \"$7$\"")]
        public static byte[] crypto_pwhash_scryptsalsa208sha256_STRPREFIX => new byte[] { 0x24, 0x37, 0x24, 0x00 };

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_OPSLIMIT_MIN 32768U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_OPSLIMIT_MIN = 32768U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_OPSLIMIT_MAX 4294967295U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_OPSLIMIT_MAX = 4294967295U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_MEMLIMIT_MIN 16777216U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_MEMLIMIT_MIN = 16777216U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_MEMLIMIT_MAX SODIUM_MIN(SIZE_MAX, 68719476736ULL)")]
        public const ulong crypto_pwhash_scryptsalsa208sha256_MEMLIMIT_MAX = ((0xffffffffffffffffUL) < (68719476736UL) ? (0xffffffffffffffffUL) : (68719476736UL));

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_OPSLIMIT_INTERACTIVE 524288U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_OPSLIMIT_INTERACTIVE = 524288U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_MEMLIMIT_INTERACTIVE 16777216U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_MEMLIMIT_INTERACTIVE = 16777216U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_OPSLIMIT_SENSITIVE 33554432U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_OPSLIMIT_SENSITIVE = 33554432U;

        [NativeTypeName("#define crypto_pwhash_scryptsalsa208sha256_MEMLIMIT_SENSITIVE 1073741824U")]
        public const uint crypto_pwhash_scryptsalsa208sha256_MEMLIMIT_SENSITIVE = 1073741824U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_scalarmult_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_scalarmult_scalarbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_scalarmult_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_base([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] p);

        [NativeTypeName("#define crypto_scalarmult_BYTES crypto_scalarmult_curve25519_BYTES")]
        public const uint crypto_scalarmult_BYTES = 32U;

        [NativeTypeName("#define crypto_scalarmult_SCALARBYTES crypto_scalarmult_curve25519_SCALARBYTES")]
        public const uint crypto_scalarmult_SCALARBYTES = 32U;

        [NativeTypeName("#define crypto_scalarmult_PRIMITIVE \"curve25519\"")]
        public static byte[] crypto_scalarmult_PRIMITIVE => new byte[] { 0x63, 0x75, 0x72, 0x76, 0x65, 0x32, 0x35, 0x35, 0x31, 0x39, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_scalarmult_curve25519_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_scalarmult_curve25519_scalarbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_curve25519([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] p);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_curve25519_base([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n);

        [NativeTypeName("#define crypto_scalarmult_curve25519_BYTES 32U")]
        public const uint crypto_scalarmult_curve25519_BYTES = 32U;

        [NativeTypeName("#define crypto_scalarmult_curve25519_SCALARBYTES 32U")]
        public const uint crypto_scalarmult_curve25519_SCALARBYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_scalarmult_ed25519_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_scalarmult_ed25519_scalarbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_ed25519([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] p);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_ed25519_noclamp([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] p);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_ed25519_base([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_ed25519_base_noclamp([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n);

        [NativeTypeName("#define crypto_scalarmult_ed25519_BYTES 32U")]
        public const uint crypto_scalarmult_ed25519_BYTES = 32U;

        [NativeTypeName("#define crypto_scalarmult_ed25519_SCALARBYTES 32U")]
        public const uint crypto_scalarmult_ed25519_SCALARBYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_scalarmult_ristretto255_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_scalarmult_ristretto255_scalarbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_ristretto255([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] p);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_scalarmult_ristretto255_base([NativeTypeName("unsigned char *")] byte[] q, [NativeTypeName("const unsigned char *")] byte[] n);

        [NativeTypeName("#define crypto_scalarmult_ristretto255_BYTES 32U")]
        public const uint crypto_scalarmult_ristretto255_BYTES = 32U;

        [NativeTypeName("#define crypto_scalarmult_ristretto255_SCALARBYTES 32U")]
        public const uint crypto_scalarmult_ristretto255_SCALARBYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_macbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_secretbox_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_easy([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_open_easy([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_open_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_secretbox_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_zerobytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_boxzerobytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_open([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [NativeTypeName("#define crypto_secretbox_KEYBYTES crypto_secretbox_xsalsa20poly1305_KEYBYTES")]
        public const uint crypto_secretbox_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_secretbox_NONCEBYTES crypto_secretbox_xsalsa20poly1305_NONCEBYTES")]
        public const uint crypto_secretbox_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_secretbox_MACBYTES crypto_secretbox_xsalsa20poly1305_MACBYTES")]
        public const uint crypto_secretbox_MACBYTES = 16U;

        [NativeTypeName("#define crypto_secretbox_PRIMITIVE \"xsalsa20poly1305\"")]
        public static byte[] crypto_secretbox_PRIMITIVE => new byte[] { 0x78, 0x73, 0x61, 0x6C, 0x73, 0x61, 0x32, 0x30, 0x70, 0x6F, 0x6C, 0x79, 0x31, 0x33, 0x30, 0x35, 0x00 };

        [NativeTypeName("#define crypto_secretbox_MESSAGEBYTES_MAX crypto_secretbox_xsalsa20poly1305_MESSAGEBYTES_MAX")]
        public const ulong crypto_secretbox_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [NativeTypeName("#define crypto_secretbox_ZEROBYTES crypto_secretbox_xsalsa20poly1305_ZEROBYTES")]
        public const uint crypto_secretbox_ZEROBYTES = (16U + 16U);

        [NativeTypeName("#define crypto_secretbox_BOXZEROBYTES crypto_secretbox_xsalsa20poly1305_BOXZEROBYTES")]
        public const uint crypto_secretbox_BOXZEROBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xchacha20poly1305_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xchacha20poly1305_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xchacha20poly1305_macbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xchacha20poly1305_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_xchacha20poly1305_easy([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_xchacha20poly1305_open_easy([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_xchacha20poly1305_detached([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned char *")] byte[] mac, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_xchacha20poly1305_open_detached([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] mac, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [NativeTypeName("#define crypto_secretbox_xchacha20poly1305_KEYBYTES 32U")]
        public const uint crypto_secretbox_xchacha20poly1305_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_secretbox_xchacha20poly1305_NONCEBYTES 24U")]
        public const uint crypto_secretbox_xchacha20poly1305_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_secretbox_xchacha20poly1305_MACBYTES 16U")]
        public const uint crypto_secretbox_xchacha20poly1305_MACBYTES = 16U;

        [NativeTypeName("#define crypto_secretbox_xchacha20poly1305_MESSAGEBYTES_MAX (crypto_stream_xchacha20_MESSAGEBYTES_MAX - crypto_secretbox_xchacha20poly1305_MACBYTES)")]
        public const ulong crypto_secretbox_xchacha20poly1305_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xsalsa20poly1305_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xsalsa20poly1305_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xsalsa20poly1305_macbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xsalsa20poly1305_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_secretbox_xsalsa20poly1305_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xsalsa20poly1305_boxzerobytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretbox_xsalsa20poly1305_zerobytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_xsalsa20poly1305([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretbox_xsalsa20poly1305_open([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [NativeTypeName("#define crypto_secretbox_xsalsa20poly1305_KEYBYTES 32U")]
        public const uint crypto_secretbox_xsalsa20poly1305_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_secretbox_xsalsa20poly1305_NONCEBYTES 24U")]
        public const uint crypto_secretbox_xsalsa20poly1305_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_secretbox_xsalsa20poly1305_MACBYTES 16U")]
        public const uint crypto_secretbox_xsalsa20poly1305_MACBYTES = 16U;

        [NativeTypeName("#define crypto_secretbox_xsalsa20poly1305_MESSAGEBYTES_MAX (crypto_stream_xsalsa20_MESSAGEBYTES_MAX - crypto_secretbox_xsalsa20poly1305_MACBYTES)")]
        public const ulong crypto_secretbox_xsalsa20poly1305_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 16U);

        [NativeTypeName("#define crypto_secretbox_xsalsa20poly1305_BOXZEROBYTES 16U")]
        public const uint crypto_secretbox_xsalsa20poly1305_BOXZEROBYTES = 16U;

        [NativeTypeName("#define crypto_secretbox_xsalsa20poly1305_ZEROBYTES (crypto_secretbox_xsalsa20poly1305_BOXZEROBYTES + \\\r\n     crypto_secretbox_xsalsa20poly1305_MACBYTES)")]
        public const uint crypto_secretbox_xsalsa20poly1305_ZEROBYTES = (16U + 16U);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretstream_xchacha20poly1305_abytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretstream_xchacha20poly1305_headerbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretstream_xchacha20poly1305_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretstream_xchacha20poly1305_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned char")]
        public static extern byte crypto_secretstream_xchacha20poly1305_tag_message();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned char")]
        public static extern byte crypto_secretstream_xchacha20poly1305_tag_push();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned char")]
        public static extern byte crypto_secretstream_xchacha20poly1305_tag_rekey();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned char")]
        public static extern byte crypto_secretstream_xchacha20poly1305_tag_final();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_secretstream_xchacha20poly1305_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_secretstream_xchacha20poly1305_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretstream_xchacha20poly1305_init_push(crypto_secretstream_xchacha20poly1305_state* state, [NativeTypeName("unsigned char [24]")] byte* header, [NativeTypeName("const unsigned char [32]")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretstream_xchacha20poly1305_push(crypto_secretstream_xchacha20poly1305_state* state, [NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long *")] ulong* clen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen, [NativeTypeName("unsigned char")] byte tag);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretstream_xchacha20poly1305_init_pull(crypto_secretstream_xchacha20poly1305_state* state, [NativeTypeName("const unsigned char [24]")] byte* header, [NativeTypeName("const unsigned char [32]")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_secretstream_xchacha20poly1305_pull(crypto_secretstream_xchacha20poly1305_state* state, [NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("unsigned char *")] byte[] tag_p, [NativeTypeName("const unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] ad, [NativeTypeName("unsigned long long")] ulong adlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_secretstream_xchacha20poly1305_rekey(crypto_secretstream_xchacha20poly1305_state* state);

        [NativeTypeName("#define crypto_secretstream_xchacha20poly1305_ABYTES (1U + crypto_aead_xchacha20poly1305_ietf_ABYTES)")]
        public const uint crypto_secretstream_xchacha20poly1305_ABYTES = (1U + 16U);

        [NativeTypeName("#define crypto_secretstream_xchacha20poly1305_HEADERBYTES crypto_aead_xchacha20poly1305_ietf_NPUBBYTES")]
        public const uint crypto_secretstream_xchacha20poly1305_HEADERBYTES = 24U;

        [NativeTypeName("#define crypto_secretstream_xchacha20poly1305_KEYBYTES crypto_aead_xchacha20poly1305_ietf_KEYBYTES")]
        public const uint crypto_secretstream_xchacha20poly1305_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_secretstream_xchacha20poly1305_MESSAGEBYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX - crypto_secretstream_xchacha20poly1305_ABYTES, \\\r\n              (64ULL * ((1ULL << 32) - 2ULL)))")]
        public const ulong crypto_secretstream_xchacha20poly1305_MESSAGEBYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - (1U + 16U)) < ((64UL * ((1UL << 32) - 2UL))) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - (1U + 16U)) : ((64UL * ((1UL << 32) - 2UL))));

        [NativeTypeName("#define crypto_secretstream_xchacha20poly1305_TAG_MESSAGE 0x00")]
        public const int crypto_secretstream_xchacha20poly1305_TAG_MESSAGE = 0x00;

        [NativeTypeName("#define crypto_secretstream_xchacha20poly1305_TAG_PUSH 0x01")]
        public const int crypto_secretstream_xchacha20poly1305_TAG_PUSH = 0x01;

        [NativeTypeName("#define crypto_secretstream_xchacha20poly1305_TAG_REKEY 0x02")]
        public const int crypto_secretstream_xchacha20poly1305_TAG_REKEY = 0x02;

        [NativeTypeName("#define crypto_secretstream_xchacha20poly1305_TAG_FINAL (crypto_secretstream_xchacha20poly1305_TAG_PUSH | \\\r\n     crypto_secretstream_xchacha20poly1305_TAG_REKEY)")]
        public const int crypto_secretstream_xchacha20poly1305_TAG_FINAL = (0x01 | 0x02);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_shorthash_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_shorthash_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_shorthash_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_shorthash([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_shorthash_keygen([NativeTypeName("unsigned char [16]")] byte* k);

        [NativeTypeName("#define crypto_shorthash_BYTES crypto_shorthash_siphash24_BYTES")]
        public const uint crypto_shorthash_BYTES = 8U;

        [NativeTypeName("#define crypto_shorthash_KEYBYTES crypto_shorthash_siphash24_KEYBYTES")]
        public const uint crypto_shorthash_KEYBYTES = 16U;

        [NativeTypeName("#define crypto_shorthash_PRIMITIVE \"siphash24\"")]
        public static byte[] crypto_shorthash_PRIMITIVE => new byte[] { 0x73, 0x69, 0x70, 0x68, 0x61, 0x73, 0x68, 0x32, 0x34, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_shorthash_siphash24_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_shorthash_siphash24_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_shorthash_siphash24([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_shorthash_siphashx24_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_shorthash_siphashx24_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_shorthash_siphashx24([NativeTypeName("unsigned char *")] byte* @out, [NativeTypeName("const unsigned char *")] byte[] @in, [NativeTypeName("unsigned long long")] ulong inlen, [NativeTypeName("const unsigned char *")] byte[] k);

        [NativeTypeName("#define crypto_shorthash_siphash24_BYTES 8U")]
        public const uint crypto_shorthash_siphash24_BYTES = 8U;

        [NativeTypeName("#define crypto_shorthash_siphash24_KEYBYTES 16U")]
        public const uint crypto_shorthash_siphash24_KEYBYTES = 16U;

        [NativeTypeName("#define crypto_shorthash_siphashx24_BYTES 16U")]
        public const uint crypto_shorthash_siphashx24_BYTES = 16U;

        [NativeTypeName("#define crypto_shorthash_siphashx24_KEYBYTES 16U")]
        public const uint crypto_shorthash_siphashx24_KEYBYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_seedbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_publickeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_secretkeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_sign_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_seed_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk, [NativeTypeName("const unsigned char *")] byte[] seed);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign([NativeTypeName("unsigned char *")] byte[] sm, [NativeTypeName("unsigned long long *")] ulong* smlen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_open([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("const unsigned char *")] byte[] sm, [NativeTypeName("unsigned long long")] ulong smlen, [NativeTypeName("const unsigned char *")] byte[] pk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_detached([NativeTypeName("unsigned char *")] byte[] sig, [NativeTypeName("unsigned long long *")] ulong* siglen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_verify_detached([NativeTypeName("const unsigned char *")] byte[] sig, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] pk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_init([NativeTypeName("crypto_sign_state *")] crypto_sign_ed25519ph_state* state);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_update([NativeTypeName("crypto_sign_state *")] crypto_sign_ed25519ph_state* state, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_final_create([NativeTypeName("crypto_sign_state *")] crypto_sign_ed25519ph_state* state, [NativeTypeName("unsigned char *")] byte[] sig, [NativeTypeName("unsigned long long *")] ulong* siglen_p, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_final_verify([NativeTypeName("crypto_sign_state *")] crypto_sign_ed25519ph_state* state, [NativeTypeName("const unsigned char *")] byte[] sig, [NativeTypeName("const unsigned char *")] byte[] pk);

        [NativeTypeName("#define crypto_sign_BYTES crypto_sign_ed25519_BYTES")]
        public const uint crypto_sign_BYTES = 64U;

        [NativeTypeName("#define crypto_sign_SEEDBYTES crypto_sign_ed25519_SEEDBYTES")]
        public const uint crypto_sign_SEEDBYTES = 32U;

        [NativeTypeName("#define crypto_sign_PUBLICKEYBYTES crypto_sign_ed25519_PUBLICKEYBYTES")]
        public const uint crypto_sign_PUBLICKEYBYTES = 32U;

        [NativeTypeName("#define crypto_sign_SECRETKEYBYTES crypto_sign_ed25519_SECRETKEYBYTES")]
        public const uint crypto_sign_SECRETKEYBYTES = (32U + 32U);

        [NativeTypeName("#define crypto_sign_MESSAGEBYTES_MAX crypto_sign_ed25519_MESSAGEBYTES_MAX")]
        public const ulong crypto_sign_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 64U);

        [NativeTypeName("#define crypto_sign_PRIMITIVE \"ed25519\"")]
        public static byte[] crypto_sign_PRIMITIVE => new byte[] { 0x65, 0x64, 0x32, 0x35, 0x35, 0x31, 0x39, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_ed25519ph_statebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_ed25519_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_ed25519_seedbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_ed25519_publickeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_ed25519_secretkeybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_sign_ed25519_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519([NativeTypeName("unsigned char *")] byte[] sm, [NativeTypeName("unsigned long long *")] ulong* smlen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_open([NativeTypeName("unsigned char *")] byte[] m, [NativeTypeName("unsigned long long *")] ulong* mlen_p, [NativeTypeName("const unsigned char *")] byte[] sm, [NativeTypeName("unsigned long long")] ulong smlen, [NativeTypeName("const unsigned char *")] byte[] pk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_detached([NativeTypeName("unsigned char *")] byte[] sig, [NativeTypeName("unsigned long long *")] ulong* siglen_p, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_verify_detached([NativeTypeName("const unsigned char *")] byte[] sig, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] pk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_seed_keypair([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("unsigned char *")] byte[] sk, [NativeTypeName("const unsigned char *")] byte[] seed);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_pk_to_curve25519([NativeTypeName("unsigned char *")] byte[] curve25519_pk, [NativeTypeName("const unsigned char *")] byte[] ed25519_pk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_sk_to_curve25519([NativeTypeName("unsigned char *")] byte[] curve25519_sk, [NativeTypeName("const unsigned char *")] byte[] ed25519_sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_sk_to_seed([NativeTypeName("unsigned char *")] byte[] seed, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519_sk_to_pk([NativeTypeName("unsigned char *")] byte[] pk, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519ph_init(crypto_sign_ed25519ph_state* state);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519ph_update(crypto_sign_ed25519ph_state* state, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519ph_final_create(crypto_sign_ed25519ph_state* state, [NativeTypeName("unsigned char *")] byte[] sig, [NativeTypeName("unsigned long long *")] ulong* siglen_p, [NativeTypeName("const unsigned char *")] byte[] sk);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_sign_ed25519ph_final_verify(crypto_sign_ed25519ph_state* state, [NativeTypeName("const unsigned char *")] byte[] sig, [NativeTypeName("const unsigned char *")] byte[] pk);

        [NativeTypeName("#define crypto_sign_ed25519_BYTES 64U")]
        public const uint crypto_sign_ed25519_BYTES = 64U;

        [NativeTypeName("#define crypto_sign_ed25519_SEEDBYTES 32U")]
        public const uint crypto_sign_ed25519_SEEDBYTES = 32U;

        [NativeTypeName("#define crypto_sign_ed25519_PUBLICKEYBYTES 32U")]
        public const uint crypto_sign_ed25519_PUBLICKEYBYTES = 32U;

        [NativeTypeName("#define crypto_sign_ed25519_SECRETKEYBYTES (32U + 32U)")]
        public const uint crypto_sign_ed25519_SECRETKEYBYTES = (32U + 32U);

        [NativeTypeName("#define crypto_sign_ed25519_MESSAGEBYTES_MAX (SODIUM_SIZE_MAX - crypto_sign_ed25519_BYTES)")]
        public const ulong crypto_sign_ed25519_MESSAGEBYTES_MAX = (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL)) - 64U);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* crypto_stream_primitive();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_xor([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_stream_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_stream_KEYBYTES crypto_stream_xsalsa20_KEYBYTES")]
        public const uint crypto_stream_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_NONCEBYTES crypto_stream_xsalsa20_NONCEBYTES")]
        public const uint crypto_stream_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_stream_MESSAGEBYTES_MAX crypto_stream_xsalsa20_MESSAGEBYTES_MAX")]
        public const ulong crypto_stream_MESSAGEBYTES_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [NativeTypeName("#define crypto_stream_PRIMITIVE \"xsalsa20\"")]
        public static byte[] crypto_stream_PRIMITIVE => new byte[] { 0x78, 0x73, 0x61, 0x6C, 0x73, 0x61, 0x32, 0x30, 0x00 };

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_chacha20_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_chacha20_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_chacha20_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_chacha20([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_chacha20_xor([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_chacha20_xor_ic([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("uint64_t")] ulong ic, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_stream_chacha20_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_chacha20_ietf_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_chacha20_ietf_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_chacha20_ietf_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_chacha20_ietf([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_chacha20_ietf_xor([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_chacha20_ietf_xor_ic([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("uint32_t")] uint ic, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_stream_chacha20_ietf_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_stream_chacha20_KEYBYTES 32U")]
        public const uint crypto_stream_chacha20_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_chacha20_NONCEBYTES 8U")]
        public const uint crypto_stream_chacha20_NONCEBYTES = 8U;

        [NativeTypeName("#define crypto_stream_chacha20_MESSAGEBYTES_MAX SODIUM_SIZE_MAX")]
        public const ulong crypto_stream_chacha20_MESSAGEBYTES_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [NativeTypeName("#define crypto_stream_chacha20_ietf_KEYBYTES 32U")]
        public const uint crypto_stream_chacha20_ietf_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_chacha20_ietf_NONCEBYTES 12U")]
        public const uint crypto_stream_chacha20_ietf_NONCEBYTES = 12U;

        [NativeTypeName("#define crypto_stream_chacha20_ietf_MESSAGEBYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX, 64ULL * (1ULL << 32))")]
        public const ulong crypto_stream_chacha20_ietf_MESSAGEBYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) < (64UL * (1UL << 32)) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) : (64UL * (1UL << 32)));

        [NativeTypeName("#define crypto_stream_chacha20_IETF_KEYBYTES crypto_stream_chacha20_ietf_KEYBYTES")]
        public const uint crypto_stream_chacha20_IETF_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_chacha20_IETF_NONCEBYTES crypto_stream_chacha20_ietf_NONCEBYTES")]
        public const uint crypto_stream_chacha20_IETF_NONCEBYTES = 12U;

        [NativeTypeName("#define crypto_stream_chacha20_IETF_MESSAGEBYTES_MAX crypto_stream_chacha20_ietf_MESSAGEBYTES_MAX")]
        public const ulong crypto_stream_chacha20_IETF_MESSAGEBYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) < (64UL * (1UL << 32)) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) : (64UL * (1UL << 32)));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa20_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa20_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa20_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_salsa20([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_salsa20_xor([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_salsa20_xor_ic([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("uint64_t")] ulong ic, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_stream_salsa20_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_stream_salsa20_KEYBYTES 32U")]
        public const uint crypto_stream_salsa20_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_salsa20_NONCEBYTES 8U")]
        public const uint crypto_stream_salsa20_NONCEBYTES = 8U;

        [NativeTypeName("#define crypto_stream_salsa20_MESSAGEBYTES_MAX SODIUM_SIZE_MAX")]
        public const ulong crypto_stream_salsa20_MESSAGEBYTES_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa2012_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa2012_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa2012_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_salsa2012([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_salsa2012_xor([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_stream_salsa2012_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_stream_salsa2012_KEYBYTES 32U")]
        public const uint crypto_stream_salsa2012_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_salsa2012_NONCEBYTES 8U")]
        public const uint crypto_stream_salsa2012_NONCEBYTES = 8U;

        [NativeTypeName("#define crypto_stream_salsa2012_MESSAGEBYTES_MAX SODIUM_SIZE_MAX")]
        public const ulong crypto_stream_salsa2012_MESSAGEBYTES_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa208_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa208_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_salsa208_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_salsa208([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_salsa208_xor([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_stream_salsa208_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_stream_salsa208_KEYBYTES 32U")]
        public const uint crypto_stream_salsa208_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_salsa208_NONCEBYTES 8U")]
        public const uint crypto_stream_salsa208_NONCEBYTES = 8U;

        [NativeTypeName("#define crypto_stream_salsa208_MESSAGEBYTES_MAX SODIUM_SIZE_MAX")]
        public const ulong crypto_stream_salsa208_MESSAGEBYTES_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_xchacha20_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_xchacha20_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_xchacha20_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_xchacha20([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_xchacha20_xor([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_xchacha20_xor_ic([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("uint64_t")] ulong ic, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_stream_xchacha20_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_stream_xchacha20_KEYBYTES 32U")]
        public const uint crypto_stream_xchacha20_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_xchacha20_NONCEBYTES 24U")]
        public const uint crypto_stream_xchacha20_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_stream_xchacha20_MESSAGEBYTES_MAX SODIUM_SIZE_MAX")]
        public const ulong crypto_stream_xchacha20_MESSAGEBYTES_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_xsalsa20_keybytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_xsalsa20_noncebytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_stream_xsalsa20_messagebytes_max();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_xsalsa20([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("unsigned long long")] ulong clen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_xsalsa20_xor([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_stream_xsalsa20_xor_ic([NativeTypeName("unsigned char *")] byte[] c, [NativeTypeName("const unsigned char *")] byte[] m, [NativeTypeName("unsigned long long")] ulong mlen, [NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("uint64_t")] ulong ic, [NativeTypeName("const unsigned char *")] byte[] k);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void crypto_stream_xsalsa20_keygen([NativeTypeName("unsigned char [32]")] byte* k);

        [NativeTypeName("#define crypto_stream_xsalsa20_KEYBYTES 32U")]
        public const uint crypto_stream_xsalsa20_KEYBYTES = 32U;

        [NativeTypeName("#define crypto_stream_xsalsa20_NONCEBYTES 24U")]
        public const uint crypto_stream_xsalsa20_NONCEBYTES = 24U;

        [NativeTypeName("#define crypto_stream_xsalsa20_MESSAGEBYTES_MAX SODIUM_SIZE_MAX")]
        public const ulong crypto_stream_xsalsa20_MESSAGEBYTES_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_verify_16_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_verify_16([NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [NativeTypeName("#define crypto_verify_16_BYTES 16U")]
        public const uint crypto_verify_16_BYTES = 16U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_verify_32_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_verify_32([NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [NativeTypeName("#define crypto_verify_32_BYTES 32U")]
        public const uint crypto_verify_32_BYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr crypto_verify_64_bytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int crypto_verify_64([NativeTypeName("const unsigned char *")] byte[] x, [NativeTypeName("const unsigned char *")] byte[] y);

        [NativeTypeName("#define crypto_verify_64_BYTES 64U")]
        public const uint crypto_verify_64_BYTES = 64U;

        [NativeTypeName("#define SODIUM_SIZE_MAX SODIUM_MIN(UINT64_MAX, SIZE_MAX)")]
        public const ulong SODIUM_SIZE_MAX = ((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL));

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr randombytes_seedbytes();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void randombytes_buf([NativeTypeName("void *const")] void* buf, [NativeTypeName("const size_t")] UIntPtr size);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void randombytes_buf_deterministic([NativeTypeName("void *const")] void* buf, [NativeTypeName("const size_t")] UIntPtr size, [NativeTypeName("const unsigned char [32]")] byte[] seed);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint randombytes_random();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint randombytes_uniform([NativeTypeName("const uint32_t")] uint upper_bound);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void randombytes_stir();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int randombytes_close();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int randombytes_set_implementation([NativeTypeName("const randombytes_implementation *")] randombytes_implementation* impl);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* randombytes_implementation_name();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void randombytes([NativeTypeName("unsigned char *const")] byte* buf, [NativeTypeName("const unsigned long long")] ulong buf_len);

        [NativeTypeName("#define randombytes_BYTES_MAX SODIUM_MIN(SODIUM_SIZE_MAX, 0xffffffffUL)")]
        public const ulong randombytes_BYTES_MAX = ((((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) < (0xffffffffU) ? (((0xffffffffffffffffUL) < (0xffffffffffffffffUL) ? (0xffffffffffffffffUL) : (0xffffffffffffffffUL))) : (0xffffffffU));

        [NativeTypeName("#define randombytes_SEEDBYTES 32U")]
        public const uint randombytes_SEEDBYTES = 32U;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_neon();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_armcrypto();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_sse2();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_sse3();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_ssse3();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_sse41();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_avx();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_avx2();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_avx512f();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_pclmul();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_aesni();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_runtime_has_rdrand();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int _sodium_runtime_get_cpu_features();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sodium_memzero([NativeTypeName("void *const")] void* pnt, [NativeTypeName("const size_t")] UIntPtr len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sodium_stackzero([NativeTypeName("const size_t")] UIntPtr len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_memcmp([NativeTypeName("const void *const")] void* b1_, [NativeTypeName("const void *const")] void* b2_, [NativeTypeName("size_t")] UIntPtr len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_compare([NativeTypeName("const unsigned char *")] byte[] b1_, [NativeTypeName("const unsigned char *")] byte[] b2_, [NativeTypeName("size_t")] UIntPtr len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_is_zero([NativeTypeName("const unsigned char *")] byte[] n, [NativeTypeName("const size_t")] UIntPtr nlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sodium_increment([NativeTypeName("unsigned char *")] byte[] n, [NativeTypeName("const size_t")] UIntPtr nlen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sodium_add([NativeTypeName("unsigned char *")] byte[] a, [NativeTypeName("const unsigned char *")] byte[] b, [NativeTypeName("const size_t")] UIntPtr len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sodium_sub([NativeTypeName("unsigned char *")] byte[] a, [NativeTypeName("const unsigned char *")] byte[] b, [NativeTypeName("const size_t")] UIntPtr len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* sodium_bin2hex([NativeTypeName("char *const")] string hex, [NativeTypeName("const size_t")] UIntPtr hex_maxlen, [NativeTypeName("const unsigned char *const")] byte* bin, [NativeTypeName("const size_t")] UIntPtr bin_len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_hex2bin([NativeTypeName("unsigned char *const")] byte* bin, [NativeTypeName("const size_t")] UIntPtr bin_maxlen, [NativeTypeName("const char *const")] string hex, [NativeTypeName("const size_t")] UIntPtr hex_len, [NativeTypeName("const char *const")] string ignore, [NativeTypeName("size_t *const")] out int bin_len, [NativeTypeName("const char **const")] sbyte** hex_end);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr sodium_base64_encoded_len([NativeTypeName("const size_t")] UIntPtr bin_len, [NativeTypeName("const int")] int variant);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* sodium_bin2base64([NativeTypeName("char *const")] string b64, [NativeTypeName("const size_t")] UIntPtr b64_maxlen, [NativeTypeName("const unsigned char *const")] byte* bin, [NativeTypeName("const size_t")] UIntPtr bin_len, [NativeTypeName("const int")] int variant);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_base642bin([NativeTypeName("unsigned char *const")] byte* bin, [NativeTypeName("const size_t")] UIntPtr bin_maxlen, [NativeTypeName("const char *const")] string b64, [NativeTypeName("const size_t")] UIntPtr b64_len, [NativeTypeName("const char *const")] string ignore, [NativeTypeName("size_t *const")] UIntPtr* bin_len, [NativeTypeName("const char **const")] sbyte** b64_end, [NativeTypeName("const int")] int variant);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_mlock([NativeTypeName("void *const")] void* addr, [NativeTypeName("const size_t")] UIntPtr len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_munlock([NativeTypeName("void *const")] void* addr, [NativeTypeName("const size_t")] UIntPtr len);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* sodium_malloc([NativeTypeName("const size_t")] UIntPtr size);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* sodium_allocarray([NativeTypeName("size_t")] UIntPtr count, [NativeTypeName("size_t")] UIntPtr size);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sodium_free(void* ptr);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_mprotect_noaccess(void* ptr);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_mprotect_readonly(void* ptr);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_mprotect_readwrite(void* ptr);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_pad([NativeTypeName("size_t *")] UIntPtr* padded_buflen_p, [NativeTypeName("unsigned char *")] byte[] buf, [NativeTypeName("size_t")] UIntPtr unpadded_buflen, [NativeTypeName("size_t")] UIntPtr blocksize, [NativeTypeName("size_t")] UIntPtr max_buflen);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_unpad([NativeTypeName("size_t *")] UIntPtr* unpadded_buflen_p, [NativeTypeName("const unsigned char *")] byte[] buf, [NativeTypeName("size_t")] UIntPtr padded_buflen, [NativeTypeName("size_t")] UIntPtr blocksize);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int _sodium_alloc_init();

        [NativeTypeName("#define sodium_base64_VARIANT_ORIGINAL 1")]
        public const int sodium_base64_VARIANT_ORIGINAL = 1;

        [NativeTypeName("#define sodium_base64_VARIANT_ORIGINAL_NO_PADDING 3")]
        public const int sodium_base64_VARIANT_ORIGINAL_NO_PADDING = 3;

        [NativeTypeName("#define sodium_base64_VARIANT_URLSAFE 5")]
        public const int sodium_base64_VARIANT_URLSAFE = 5;

        [NativeTypeName("#define sodium_base64_VARIANT_URLSAFE_NO_PADDING 7")]
        public const int sodium_base64_VARIANT_URLSAFE_NO_PADDING = 7;

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* sodium_version_string();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_library_version_major();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_library_version_minor();

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sodium_library_minimal();

        [NativeTypeName("#define SODIUM_VERSION_STRING \"1.0.18\"")]
        public static byte[] SODIUM_VERSION_STRING => new byte[] { 0x31, 0x2E, 0x30, 0x2E, 0x31, 0x38, 0x00 };

        [NativeTypeName("#define SODIUM_LIBRARY_VERSION_MAJOR 11")]
        public const int SODIUM_LIBRARY_VERSION_MAJOR = 11;

        [NativeTypeName("#define SODIUM_LIBRARY_VERSION_MINOR 0")]
        public const int SODIUM_LIBRARY_VERSION_MINOR = 0;
    }
}
