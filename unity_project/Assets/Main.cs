using System.Text;
using unity.libsodium;
using UnityEngine;

public class Main : MonoBehaviour
{
    private void Start()
    {
        int x = NativeLibsodium.sodium_init();
        Debug.Log(x);


        const string MESSAGE = "Test message to encrypt";
        byte[] nonce = StreamEncryption.GenerateNonceChaCha20();
        byte[] key = StreamEncryption.GenerateKey();

        //encrypt it
        byte[] encrypted = StreamEncryption.EncryptChaCha20(MESSAGE, nonce, key);


        //decrypt it
        byte[] decrypted = StreamEncryption.DecryptChaCha20(encrypted, nonce, key);

        Debug.Log(MESSAGE);
        Debug.Log(Encoding.UTF8.GetString(encrypted));
        Debug.Log(Encoding.UTF8.GetString(decrypted));
    }
}