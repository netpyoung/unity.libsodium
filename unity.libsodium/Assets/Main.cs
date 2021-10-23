using System.Text;
using unity.libsodium;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Text txt_origin;
    public Text txt_encrypted;
    public Text txt_decrypted;

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

        string str_origin = MESSAGE;
        string str_encrypted = Encoding.UTF8.GetString(encrypted);
        string str_decrypted = Encoding.UTF8.GetString(decrypted);

        Debug.Log(str_origin);
        Debug.Log(str_encrypted);
        Debug.Log(str_decrypted);

        txt_origin.text = str_origin;
        txt_encrypted.text = str_encrypted;
        txt_decrypted.text = str_decrypted;
    }
}