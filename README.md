unity.libsodium
===============


based version : `1.0.10`

# What's this?

 I decided that there should be a simpler way and I created **unity.libsodium**, a plugin that helps you to use [libsodium](https://github.com/jedisct1/libsodium/) in your Unity3d projects in a clear and easy way and works in **iOS, Android, Windows** projects.


# The fast track
 All you have to do to start using it in your project:

1. [Download this .unitypackage](https://github.com/netpyoung/unity.libsodium/raw/master/libsodium-0.0.1.unitypackage), extract its content on your Unity3D Project. It contains the dlls that Unity3d will need to access libsodium.
4. **You’re done!**

# Example

``` csharp
		var x = NativeLibsodium.sodium_init ();
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


# build native library

## on macOs
* available iOS/macOs/Android/Windows

```
sh build-on-mac.sh
```

## on docker
* available Android

```
docker-compose up
```

## on Windows
* available Windows

```
libsodium/builds/msvc/build/buildall.bat
```

## etc
`ag '^[a-z].*\(.*' *.h --no-numbers > a.txt`


# License
* this repo what i written, under MIT License.

##  [libsodium](https://github.com/jedisct1/libsodium/)

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
