using System.Collections;
using System.Collections.Generic;
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

    }
}
