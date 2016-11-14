#!/usr/bin/env bash

# [environment]
export ANDROID_NDK_HOME=/opt/android-ndk
export PATH=${ANDROID_NDK_HOME}:${PATH}

# [sdk] Android NDK
mkdir /opt/android-ndk-tmp
cd /opt/android-ndk-tmp
wget -q https://dl.google.com/android/repository/android-ndk-r13b-linux-x86_64.zip
unzip -q android-ndk-r13b-linux-x86_64.zip
mv ./android-ndk-r13b ${ANDROID_NDK_HOME}
rm -rf /opt/android-ndk-tmp

# [src] libsodium
cd /root
git clone https://github.com/jedisct1/libsodium.git
cd /root/libsodium
./autogen.sh
./dist-build/android-armv7-a.sh
./dist-build/android-x86.sh


# [bin] copy to dist
mkdir -p /root/Android/libs/armeabi-v7a
mv /root/libsodium/libsodium-android-armv7-a/lib/libsodium.a /root/libsodium/libsodium-android-armv7-a/lib/libsodium.so /root/Android/libs/armeabi-v7a

mkdir -p /root/Android/libs/x86
mv /root/libsodium/libsodium-android-i686/lib/libsodium.a /root/libsodium/libsodium-android-i686/lib/libsodium.so /root/Android/libs/x86
