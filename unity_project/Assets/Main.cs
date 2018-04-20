using UnityEngine;
using System.Text;
using unity.libsodium;

public class Main : MonoBehaviour
{
    void Start()
    {
        var x = NativeLibsodium.sodium_init();
        Debug.Log(x);


        const string MESSAGE = "Test message to encrypt";
        var nonce = StreamEncryption.GenerateNonceChaCha20();
        var key = StreamEncryption.GenerateKey();

        //encrypt it
        var encrypted = StreamEncryption.EncryptChaCha20(MESSAGE, nonce, key);


        //decrypt it
        var decrypted = StreamEncryption.DecryptChaCha20(encrypted, nonce, key);

        Debug.Log(MESSAGE);
        Debug.Log(Encoding.UTF8.GetString(encrypted));
        Debug.Log(Encoding.UTF8.GetString(decrypted));
    }
}