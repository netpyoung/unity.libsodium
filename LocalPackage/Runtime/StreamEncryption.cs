using System;
using System.Text;

namespace unity.libsodium
{
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

        unsafe public static byte[] EncryptChaCha20(byte[] message, byte[] nonce, byte[] key)
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

            byte[] buffer = new byte[message.Length];
            fixed (byte* bufferPtr = buffer)
            {
                int ret = NativeLibsodium.crypto_stream_chacha20_xor(bufferPtr, message, (ulong)message.Length, nonce, key);
                if (ret != 0)
                    throw new Exception("Error encrypting message.");
            }
            return buffer;
        }

        public static byte[] DecryptChaCha20(string cipherText, byte[] nonce, byte[] key)
        {
            return DecryptChaCha20(HexToBinary(cipherText), nonce, key);
        }

        unsafe public static byte[] DecryptChaCha20(byte[] cipherText, byte[] nonce, byte[] key)
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

            byte[] buffer = new byte[cipherText.Length];
            fixed (byte* bufferPtr = buffer)
            {
                int ret = NativeLibsodium.crypto_stream_chacha20_xor(bufferPtr, cipherText, (ulong)cipherText.Length, nonce, key);
                if (ret != 0)
                    throw new Exception("Error derypting message.");
            }
            return buffer;
        }


        public static unsafe byte[] GetRandomBytes(int count)
        {
            byte[] buffer = new byte[count];
            fixed (byte* bufferPtr = buffer)
            {
                NativeLibsodium.randombytes_buf(bufferPtr, (uint)count);
            }
            return buffer;
        }


        unsafe public static byte[] HexToBinary(string hex)
        {
            const string IGNORED_CHARS = ":- ";

            byte[] arr = new byte[hex.Length >> 1];
            byte[] hexBytes = Encoding.ASCII.GetBytes(hex);
            int binLength;

            fixed (byte* arrPtr = arr)
            {
                //we call sodium_hex2bin with some chars to be ignored
                int ret = NativeLibsodium.sodium_hex2bin(
                    arrPtr, (uint)arr.Length,
                    hex, (uint)hexBytes.Length,
                    IGNORED_CHARS,
                    out binLength,
                    null
                );

                if (ret != 0)
                    throw new Exception("Internal error, decoding failed.");
            }
            //remove the trailing nulls from the array, if there were some format characters in the hex string before
            if (arr.Length != binLength)
            {
                byte[] tmp = new byte[binLength];
                Array.Copy(arr, 0, tmp, 0, binLength);
                return tmp;
            }

            return arr;
        }
    }
}