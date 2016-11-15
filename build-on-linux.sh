#!/usr/bin/env bash

# [environment]
export ANDROID_NDK_HOME=/opt/android-ndk
export PATH=${ANDROID_NDK_HOME}:${PATH}
DIR_LIBSODIUM=/root/libsodium
DIR_DEST=/root

# [sdk] Android NDK
mkdir /opt/android-ndk-tmp
cd /opt/android-ndk-tmp
wget -q https://dl.google.com/android/repository/android-ndk-r13b-linux-x86_64.zip
unzip -q android-ndk-r13b-linux-x86_64.zip
mv ./android-ndk-r13b ${ANDROID_NDK_HOME}
rm -rf /opt/android-ndk-tmp

# [src] libsodium
git clone https://github.com/jedisct1/libsodium.git $DIR_LIBSODIUM
cd $DIR_LIBSODIUM
./autogen.sh
./dist-build/android-armv7-a.sh
./dist-build/android-x86.sh


# [bin] copy to dest
mkdir -p $DIR_DEST/Plugins/Android/libs/armeabi-v7a
mv $DIR_LIBSODIUM/libsodium-android-armv7-a/lib/libsodium.a $DIR_LIBSODIUM/libsodium-android-armv7-a/lib/libsodium.so $DIR_DEST/Plugins/Android/libs/armeabi-v7a

mkdir -p $DIR_DEST/Plugins/Android/libs/x86
mv $DIR_LIBSODIUM/libsodium-android-i686/lib/libsodium.a $DIR_LIBSODIUM/libsodium-android-i686/lib/libsodium.so $DIR_DEST/Plugins/Android/libs/x86
