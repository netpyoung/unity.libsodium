#!/usr/bin/env bash


# [brew] install dependencies
packages='libtool autoconf automake'
brew update
for pkg in ${packages}; do
    if brew list -1 | grep -q "^${pkg}\$"; then
        echo "Package '$pkg' is installed"
        #brew upgrade $pkg
    else
        echo "Package '$pkg' is not installed"
        brew install $pkg
    fi
done
brew upgrade ${packages} || true


# [variable]
ROOT=$(pwd)
DIR_DEST=${ROOT}/output
DIR_LIBSODIUM=${ROOT}/libsodium


# [src] libsodium
git clone https://github.com/jedisct1/libsodium.git $DIR_LIBSODIUM && cd $DIR_LIBSODIUM
./autogen.sh


# [generate]
cd $DIR_LIBSODIUM
./dist-build/ios.sh
./dist-build/osx.sh

mkdir -p $DIR_DEST/Plugins/iOs
mkdir -p $DIR_DEST/Plugins/x64
cp $DIR_LIBSODIUM/libsodium-ios/lib/libsodium.a $DIR_DEST/Plugins/iOS/libsodium.a
cp $DIR_LIBSODIUM/libsodium-osx/lib/libsodium.*.dylib $DIR_DEST/Plugins/x64/sodium.bundle



# ===========================
# Android
# ===========================
# [environment]
export ANDROID_NDK_HOME=${ROOT}/android-ndk
DIR_TEMP=${ROOT}/temp_dir


# [sdk] Android NDK
mkdir $DIR_TEMP && cd $DIR_TEMP
wget -q https://dl.google.com/android/repository/android-ndk-r13b-darwin-x86_64.zip
unzip -o -q android-ndk-r13b-darwin-x86_64.zip
mv $DIR_TEMP/android-ndk-r13b ${ANDROID_NDK_HOME}


# [generate]
cd $DIR_LIBSODIUM
./dist-build/android-armv7-a.sh
./dist-build/android-x86.sh

mkdir -p $DIR_DEST/Plugins/Android/libs/armeabi-v7a
mv $DIR_LIBSODIUM/libsodium-android-armv7-a/lib/libsodium.a $DIR_LIBSODIUM/libsodium-android-armv7-a/lib/libsodium.so $DIR_DEST/Plugins/Android/libs/armeabi-v7a

mkdir -p $DIR_DEST/Plugins/Android/libs/x86
mv $DIR_LIBSODIUM/libsodium-android-i686/lib/libsodium.a $DIR_LIBSODIUM/libsodium-android-i686/lib/libsodium.so $DIR_DEST/Plugins/Android/libs/x86
