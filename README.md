# unity.libsodium

## What's this?

 I decided that there should be a simpler way and I created **unity.libsodium**, a plugin that helps you to use [libsodium](https://github.com/jedisct1/libsodium/) in your Unity3d projects in a clear and easy way and works in **iOS, Android, OSX, Windows, Android** projects.

## prebuilt library

- prebuilt library are maintained by [prebuilt-libsodium](https://github.com/netpyoung/prebuilt-libsodium)
  - libsodium 1.0.18

## installation

- [Download this .unitypackage from Release Page](https://github.com/netpyoung/unity.libsodium/releases)

## Example

``` csharp
var x = NativeLibsodium.sodium_init();
Debug.Log (x);


const string MESSAGE = "Test message to encrypt";
var nonce = StreamEncryption.GenerateNonceChaCha20();
var key = StreamEncryption.GenerateKey();

//encrypt it
var encrypted = StreamEncryption.EncryptChaCha20(MESSAGE, nonce, key);


//decrypt it
var decrypted = StreamEncryption.DecryptChaCha20(encrypted, nonce, key);

Debug.Log (MESSAGE);
Debug.Log (Encoding.UTF8.GetString(encrypted));
Debug.Log (Encoding.UTF8.GetString(decrypted));
```

## License

### [libsodium](https://github.com/jedisct1/libsodium/)

``` license
/*
 * ISC License
 *
 * Copyright (c) 2013-2018
 * Frank Denis <j at pureftpd dot org>
 *
 * Permission to use, copy, modify, and/or distribute this software for any
 * purpose with or without fee is hereby granted, provided that the above
 * copyright notice and this permission notice appear in all copies.
 *
 * THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
 * WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
 * MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
 * ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
 * WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
 * ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
 * OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
*/
```

## contributor

- [@netpyoung](https://github.com/netpyoung)
- [@Ekwav](https://github.com/Ekwav)

## Ref

- <https://github.com/jedisct1/libsodium/tree/master/src/libsodium/include/sodium/>
- <https://github.com/joshjdevl/libsodium-jni/blob/master/src/main/java/org/libsodium/jni/SodiumJNI.java>
- <https://github.com/terl/lazysodium-android>
- <https://github.com/adamcaudill/libsodium-net/blob/master/libsodium-net/SodiumLibrary.cs>
- <https://github.com/microsoft/ClangSharp>
