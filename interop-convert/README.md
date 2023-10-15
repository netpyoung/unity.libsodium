# interop convert

- Instead of manually write interop code, there are some interop generator like [java's panama](https://openjdk.java.net/projects/panama/).
  - <https://github.com/microsoft/ClangSharp>
  - <https://github.com/mono/CppSharp>

``` cmd
> dotnet tool install --global ClangSharpPInvokeGenerator --version 12.0.0-beta2
> cp ClangShap_libsodium.rsp libsodium/src/libsodium/ClangShap_libsodium.rsp
> ClangSharpPInvokeGenerator @ClangShap_libsodium.rsp
```

## Do Change

- Generator itself is not perfect so It needs to manually modify some codes.

### Methods.cs

``` txt
/// comment out
// [NativeTypeName("#define randombytes_salsa20_implementation randombytes_internal_implementation")]
// public static readonly randombytes_implementation randombytes_salsa20_implementation = randombytes_internal_implementation;


/// Change
| before                                          | after                                            |
| ----------------------------------------------- | ------------------------------------------------ |
| [NativeTypeName("const unsigned char *")] byte* | [NativeTypeName("const unsigned char *")] byte[] |
| [NativeTypeName("const char *const")] sbyte*    | [NativeTypeName("const char *const")] string     |
| [NativeTypeName("const size_t")] UIntPtr        | [NativeTypeName("const size_t")] uint             |
| [NativeTypeName("size_t *const")] UIntPtr*      | [NativeTypeName("size_t *const")] out uint        |

```

## Ref

- [Versioning?](https://github.com/jedisct1/libsodium/issues/643)
