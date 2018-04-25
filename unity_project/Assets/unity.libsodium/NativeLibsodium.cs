using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;


// ref: https://github.com/jedisct1/libsodium/tree/master/src/libsodium/include/sodium/
// ref: https://github.com/joshjdevl/libsodium-jni/blob/master/src/main/java/org/libsodium/jni/SodiumJNI.java
// ref: https://github.com/adamcaudill/libsodium-net/blob/master/libsodium-net/SodiumLibrary.cs
using System.Text;


namespace unity.libsodium
{

	/// <summary>
	/// Native libsodium wrapper for unity
	/// Functions are documented at https://download.libsodium.org/doc/
	/// </summary>
	public static class NativeLibsodium
	{
		#if UNITY_IOS && !UNITY_EDITOR
		const string DLL_NAME = "__Internal";
		#else
		const string DLL_NAME = "sodium";
		#endif

		// crypto_generichash_state
		[StructLayout(LayoutKind.Sequential, Size = 384)]
		internal struct _HashState
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public ulong[] h;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public ulong[] t;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public ulong[] f;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
			public byte[] buf;

			public uint buflen;

			public byte last_node;
		}

		[DllImport(DLL_NAME)] public static extern int sodium_init();
		[DllImport(DLL_NAME)] public static extern void randombytes_buf(byte[] buffer, int size);
		[DllImport(DLL_NAME)] public static extern int randombytes_uniform(int upperBound);
		[DllImport(DLL_NAME)] public static extern void sodium_increment(byte[] buffer, UIntPtr length);
		[DllImport(DLL_NAME)] public static extern int sodium_compare(byte[] a, byte[] b, UIntPtr length);
		[DllImport(DLL_NAME)] public static extern IntPtr sodium_version_string();
		[DllImport(DLL_NAME)] public static extern int crypto_hash(byte[] buffer, byte[] message, UIntPtr length);
		[DllImport(DLL_NAME)] public static extern int crypto_hash_sha512(byte[] buffer, byte[] message, UIntPtr length);
		[DllImport(DLL_NAME)] public static extern int crypto_hash_sha256(byte[] buffer, byte[] message, UIntPtr length);
		[DllImport(DLL_NAME)] public static extern int crypto_generichash(byte[] buffer, int bufferLength, byte[] message, long messageLength, byte[] key, int keyLength);
		[DllImport(DLL_NAME)] public static extern int crypto_generichash_blake2b_salt_personal(byte[] buffer, int bufferLength, byte[] message, long messageLength, byte[] key, int keyLength, byte[] salt, byte[] personal);
		[DllImport(DLL_NAME)] public static extern int crypto_onetimeauth(byte[] buffer, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_onetimeauth_verify(byte[] signature, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_pwhash_str(byte[] buffer, byte[] password, long passwordLen, long opsLimit, int memLimit);
		[DllImport(DLL_NAME)] public static extern int crypto_pwhash_str_verify(byte[] buffer, byte[] password, long passLength);
		[DllImport(DLL_NAME)] public static extern int crypto_pwhash(byte[] buffer, long bufferLen, byte[] password, long passwordLen, byte[] salt, long opsLimit, int memLimit, int alg);
		[DllImport(DLL_NAME)] public static extern int crypto_pwhash_scryptsalsa208sha256_str(byte[] buffer, byte[] password, long passwordLen, long opsLimit, int memLimit);
		[DllImport(DLL_NAME)] public static extern int crypto_pwhash_scryptsalsa208sha256(byte[] buffer, long bufferLen, byte[] password, long passwordLen, byte[] salt, long opsLimit, int memLimit);
		[DllImport(DLL_NAME)] public static extern int crypto_pwhash_scryptsalsa208sha256_str_verify(byte[] buffer, byte[] password, long passLength);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_keypair(byte[] publicKey, byte[] secretKey);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_seed_keypair(byte[] publicKey, byte[] secretKey, byte[] seed);
		[DllImport(DLL_NAME)] public static extern int crypto_sign(byte[] buffer, ref long bufferLength, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_open(byte[] buffer, ref long bufferLength, byte[] signedMessage, long signedMessageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_detached(byte[] signature, ref long signatureLength, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_verify_detached(byte[] signature, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_ed25519_sk_to_seed(byte[] seed, byte[] secretKey);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_ed25519_sk_to_pk(byte[] publicKey, byte[] secretKey);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_ed25519_pk_to_curve25519(byte[] curve25519Pk, byte[] ed25519Pk);
		[DllImport(DLL_NAME)] public static extern int crypto_sign_ed25519_sk_to_curve25519(byte[] curve25519Sk, byte[] ed25519Sk);
		[DllImport(DLL_NAME)] public static extern int crypto_box_keypair(byte[] publicKey, byte[] secretKey);
		[DllImport(DLL_NAME)] public static extern int crypto_box_easy(byte[] buffer, byte[] message, long messageLength, byte[] nonce, byte[] publicKey, byte[] secretKey);
		[DllImport(DLL_NAME)] public static extern int crypto_box_open_easy(byte[] buffer, byte[] cipherText, long cipherTextLength, byte[] nonce, byte[] publicKey, byte[] secretKey);
		[DllImport(DLL_NAME)] public static extern int crypto_box_detached(byte[] cipher, byte[] mac, byte[] message, long messageLength, byte[] nonce, byte[] pk, byte[] sk);
		[DllImport(DLL_NAME)] public static extern int crypto_box_open_detached(byte[] buffer, byte[] cipherText, byte[] mac, long cipherTextLength, byte[] nonce, byte[] pk, byte[] sk);
		[DllImport(DLL_NAME)] public static extern int crypto_scalarmult_bytes();
		[DllImport(DLL_NAME)] public static extern int crypto_scalarmult_scalarbytes();
		[DllImport(DLL_NAME)] public static extern byte crypto_scalarmult_primitive();
		[DllImport(DLL_NAME)] public static extern int crypto_scalarmult_base(byte[] q, byte[] n);
		[DllImport(DLL_NAME)] public static extern int crypto_scalarmult(byte[] q, byte[] n, byte[] p);
		[DllImport(DLL_NAME)] public static extern int crypto_box_seal(byte[] buffer, byte[] message, long messageLength, byte[] pk);
		[DllImport(DLL_NAME)] public static extern int crypto_box_seal_open(byte[] buffer, byte[] cipherText, long cipherTextLength, byte[] pk, byte[] sk);
		[DllImport(DLL_NAME)] public static extern int crypto_secretbox_easy(byte[] buffer, byte[] message, long messageLength, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_secretbox_open_easy(byte[] buffer, byte[] cipherText, long cipherTextLength, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_secretbox_detached(byte[] cipher, byte[] mac, byte[] message, long messageLength, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_secretbox_open_detached(byte[] buffer, byte[] cipherText, byte[] mac, long cipherTextLength, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_auth(byte[] buffer, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_auth_verify(byte[] signature, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_auth_hmacsha256(byte[] buffer, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_auth_hmacsha256_verify(byte[] signature, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_auth_hmacsha512(byte[] signature, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_auth_hmacsha512_verify(byte[] signature, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_shorthash(byte[] buffer, byte[] message, long messageLength, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_stream_xor(byte[] buffer, byte[] message, long messageLength, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_stream_chacha20_xor(byte[] buffer, byte[] message, long messageLength, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)] public static extern IntPtr sodium_bin2hex(byte[] hex, int hexMaxlen, byte[] bin, int binLen);
		[DllImport(DLL_NAME)] public static extern int sodium_hex2bin(IntPtr bin, int binMaxlen, string hex, int hexLen, string ignore, out int binLen, string hexEnd);
		[DllImport(DLL_NAME)]
		public static extern int crypto_aead_chacha20poly1305_encrypt(
			IntPtr cipher, out long cipherLength, byte[] message, long messageLength, byte[] additionalData,
			long additionalDataLength, byte[] nsec, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)]
		public static extern int crypto_aead_chacha20poly1305_decrypt(
			IntPtr message, out long messageLength, byte[] nsec, byte[] cipher, long cipherLength, byte[] additionalData,
			long additionalDataLength, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_aead_aes256gcm_is_available();
		[DllImport(DLL_NAME)]
		public static extern int crypto_aead_aes256gcm_encrypt(
			IntPtr cipher, out long cipherLength, byte[] message, long messageLength, byte[] additionalData,
			long additionalDataLength, byte[] nsec, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)]
		public static extern int crypto_aead_aes256gcm_decrypt(
			IntPtr message, out long messageLength, byte[] nsec, byte[] cipher, long cipherLength, byte[] additionalData,
			long additionalDataLength, byte[] nonce, byte[] key);
		[DllImport(DLL_NAME)] public static extern int crypto_generichash_init(IntPtr state, byte[] key, int keySize, int hashSize);
		[DllImport(DLL_NAME)] public static extern int crypto_generichash_update(IntPtr state, byte[] message, long messageLength);
		[DllImport(DLL_NAME)] public static extern int crypto_generichash_final(IntPtr state, byte[] buffer, int bufferLength);
		[DllImport(DLL_NAME)] public static extern int crypto_stream_chacha20_xor_ic(byte[] c, byte[] m, ulong mlen, byte[] n, ulong ic, byte[] k);
		[DllImport(DLL_NAME)] public static extern int crypto_stream_chacha20_xor_ic_offset(byte[] c, ulong c_offset, byte[] m, ulong m_offset, ulong mlen, byte[] n, ulong ic, byte[] k);
		[DllImport(DLL_NAME)] public static extern int crypto_stream_aes128ctr_xor(byte[] c, byte[] m, ulong inlen, byte[] n, byte[] k);
		[DllImport(DLL_NAME)] public static extern int crypto_stream_aes128ctr_beforenm(byte[] tbl, byte[] k);
		[DllImport(DLL_NAME)] public static extern int crypto_stream_aes128ctr_xor_afternm(byte[] c, byte[] m, ulong len, byte[] nonce, byte[] tbl);
		[DllImport(DLL_NAME)] public static extern int crypto_stream_aes128ctr_xor_afternm_offset(byte[] c, ulong c_offset, byte[] m, ulong m_offset, ulong len, byte[] nonce, byte[] tbl);

		[DllImport(DLL_NAME)] public static extern int crypto_kx_seed_keypair(byte[] publicKey, byte[] secretKey, byte[] seed);
		[DllImport(DLL_NAME)] public static extern int crypto_kx_keypair(byte[] publicKey, byte[] secretKey);
		[DllImport(DLL_NAME)] public static extern int crypto_kx_client_session_keys(byte[] rx, byte[] tx, byte[] client_pk, byte[] client_sk, byte[] server_pk);
		[DllImport(DLL_NAME)] public static extern int crypto_kx_server_session_keys(byte[] rx, byte[] tx, byte[] server_pk, byte[] server_sk, byte[] client_pk);



	}

	public static class StreamEncryption
	{
		private const int XSALSA20_KEY_BYTES = 32;
		private const int XSALSA20_NONCE_BYTES = 24;
		private const int CHACHA20_KEY_BYTES = 32;
		private const int CHACHA20_NONCEBYTES = 8;


		public static byte[] GenerateNonceChaCha20()
		{
			return GetRandomBytes(CHACHA20_NONCEBYTES);
		}
		public static byte[] GenerateKey()
		{
			return GetRandomBytes(XSALSA20_KEY_BYTES);
		}

		public static byte[] EncryptChaCha20(string message, byte[] nonce, byte[] key)
		{
			return EncryptChaCha20(Encoding.UTF8.GetBytes(message), nonce, key);
		}

		public static byte[] EncryptChaCha20(byte[] message, byte[] nonce, byte[] key)
		{
			//validate the length of the key
			if (key == null || key.Length != CHACHA20_KEY_BYTES)
				throw new Exception();
			//throw new Exception("key", (key == null) ? 0 : key.Length,
			//	string.Format("key must be {0} bytes in length.", CHACHA20_KEY_BYTES));

			//validate the length of the nonce
			if (nonce == null || nonce.Length != CHACHA20_NONCEBYTES)
				throw new Exception();
			//throw new Exception("nonce", (nonce == null) ? 0 : nonce.Length,
			//	string.Format("nonce must be {0} bytes in length.", CHACHA20_NONCEBYTES));

			var buffer = new byte[message.Length];
			var ret = NativeLibsodium.crypto_stream_chacha20_xor(buffer, message, message.Length, nonce, key);

			if (ret != 0)
				throw new Exception("Error encrypting message.");

			return buffer;
		}

		public static byte[] DecryptChaCha20(string cipherText, byte[] nonce, byte[] key)
		{
			return DecryptChaCha20(HexToBinary(cipherText), nonce, key);
		}

		public static byte[] DecryptChaCha20(byte[] cipherText, byte[] nonce, byte[] key)
		{
			//validate the length of the key
			if (key == null || key.Length != CHACHA20_KEY_BYTES)
				throw new Exception();
			//throw new Exception("key", (key == null) ? 0 : key.Length,
			//	string.Format("key must be {0} bytes in length.", CHACHA20_KEY_BYTES));

			//validate the length of the nonce
			if (nonce == null || nonce.Length != CHACHA20_NONCEBYTES)
				throw new Exception();
			//throw new Exception("nonce", (nonce == null) ? 0 : nonce.Length,
			//	string.Format("nonce must be {0} bytes in length.", CHACHA20_NONCEBYTES));

			var buffer = new byte[cipherText.Length];
			var ret = NativeLibsodium.crypto_stream_chacha20_xor(buffer, cipherText, cipherText.Length, nonce, key);

			if (ret != 0)
				throw new Exception("Error derypting message.");

			return buffer;
		}




		public static byte[] GetRandomBytes(int count)
		{
			var buffer = new byte[count];
			NativeLibsodium.randombytes_buf(buffer, count);
			return buffer;
		}


		public static byte[] HexToBinary(string hex)
		{
			const string IGNORED_CHARS = ":- ";

			var arr = new byte[hex.Length >> 1];
			var bin = Marshal.AllocHGlobal(arr.Length);
			int binLength;

			//we call sodium_hex2bin with some chars to be ignored
			var ret = NativeLibsodium.sodium_hex2bin(bin, arr.Length, hex, hex.Length, IGNORED_CHARS, out binLength, null);

			Marshal.Copy(bin, arr, 0, binLength);
			Marshal.FreeHGlobal(bin);

			if (ret != 0)
			{
				throw new Exception("Internal error, decoding failed.");
			}

			//remove the trailing nulls from the array, if there were some format characters in the hex string before
			if (arr.Length != binLength)
			{
				var tmp = new byte[binLength];
				Array.Copy(arr, 0, tmp, 0, binLength);
				return tmp;
			}

			return arr;
		}

	}
}