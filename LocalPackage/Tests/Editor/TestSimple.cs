using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace unity.libsodium.EditorTests
{
    public class TestSimple
    {
        [Test]
        public void TestChaCha20()
        {
            int x = NativeLibsodium.sodium_init();
            Assert.True(x == 0 || x == 1);

            const string MESSAGE = "Test message to encrypt";
            byte[] nonce = StreamEncryption.GenerateNonceChaCha20();
            byte[] key = StreamEncryption.GenerateKey();

            //encrypt it
            byte[] encrypted = StreamEncryption.EncryptChaCha20(MESSAGE, nonce, key);


            //decrypt it
            byte[] decrypted = StreamEncryption.DecryptChaCha20(encrypted, nonce, key);

            Assert.AreEqual(MESSAGE, decrypted);
        }

        unsafe bool TryEncryptedBytesFromAES256GCM(byte[] messageBytes, byte[] adBytes, byte[] key, byte[] nonce, out byte[] outEncrypted, out ulong outClen)
        {
            byte[] buffer = new byte[messageBytes.Length + NativeLibsodium.crypto_aead_aes256gcm_ABYTES];
            ulong clen = 0;
            fixed (byte* bufferPtr = buffer)
            {
                if (NativeLibsodium.crypto_aead_aes256gcm_encrypt(bufferPtr, &clen,
                        messageBytes, (ulong)messageBytes.Length,
                        adBytes, (ulong)adBytes.Length,
                        null,
                        nonce, key) != 0)
                {
                    outEncrypted = null;
                    outClen = 0;
                    return false;
                }
            }
            
            outEncrypted = buffer;
            outClen = clen;
            return true;
        }

        unsafe bool TryDecryptedBytesFromAES256GCM(byte[] encryptedBytes, byte[] adBytes, byte[] key, byte[] nonce, ulong clen, out byte[]  outDecryptedBytes)
        {
            byte[] buffer = new byte[clen - NativeLibsodium.crypto_aead_aes256gcm_ABYTES];
            
            ulong mlen = 0;
            fixed (byte* bufferPtr = buffer)
            {
                if (NativeLibsodium.crypto_aead_aes256gcm_decrypt(bufferPtr, &mlen,
                        null,
                        encryptedBytes, clen,
                        adBytes, (ulong)adBytes.Length,
                        nonce, key) != 0)
                {
                    outDecryptedBytes = null;
                    return false;
                }
            }

            Span<byte> s = new Span<byte>(buffer);
            outDecryptedBytes = s.Slice(0, (int)mlen).ToArray();
            return true;
        }

        [Test]
        public unsafe void TestAes256gcm()
        {
            int x = NativeLibsodium.sodium_init();
            Assert.True(x == 0 || x == 1);
            
            string messageStr = "Hello, AES‑256‑GCM with .NET!";
            string adStr = "Additional authenticated data";

            byte[] messageBytes = Encoding.UTF8.GetBytes(messageStr);
            byte[] adBytes = Encoding.UTF8.GetBytes(adStr);

            byte[] key = new byte[NativeLibsodium.crypto_aead_aes256gcm_KEYBYTES];
            byte[] nonce = new byte[NativeLibsodium.crypto_aead_aes256gcm_NPUBBYTES];

            fixed (byte* keyPtr = key)
            {
                NativeLibsodium.randombytes_buf(keyPtr, NativeLibsodium.crypto_aead_aes256gcm_KEYBYTES);
            }

            fixed (byte* noncePtr = nonce)
            {
                NativeLibsodium.randombytes_buf(noncePtr, NativeLibsodium.crypto_aead_aes256gcm_NPUBBYTES);
            }

            Debug.Log("=========================================");
            if (!TryEncryptedBytesFromAES256GCM(messageBytes, adBytes, key, nonce, out byte[] encryptedBytes, out ulong clen))
            {
                Assert.Fail("fail to encrypt");
                return;
            }
            string encryptedStr = Encoding.UTF8.GetString(encryptedBytes);
            Debug.Log($"encryptedStr= {encryptedStr}");
            Debug.Log(encryptedStr);

            Debug.Log("=========================================");
            if (!TryDecryptedBytesFromAES256GCM(encryptedBytes, adBytes, key, nonce, clen, out byte[] decryptedBytes))
            {
                Assert.Fail("fail to decrypt");
                return;
            }
            string decryptedStr = Encoding.UTF8.GetString(decryptedBytes);
            Debug.Log($"decryptedStr= {decryptedStr}");

            Assert.AreEqual(expected: messageStr, actual: decryptedStr);
        }
    }
}