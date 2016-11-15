#!/usr/bin/env bash

# [brew]
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


# [environment]
export ANDROID_NDK_HOME=/opt/android-ndk
export PATH=${ANDROID_NDK_HOME}:${DIST}
DIR_DEST=./
DIR_TEMP=./temp_libsodium

# [sdk] Android NDK
mkdir $DIR_TEMP && cd $DIR_TEMP
wget -q https://dl.google.com/android/repository/android-ndk-r13b-linux-x86_64.zip
unzip -q android-ndk-r13b-linux-x86_64.zip
mv $DIR_TEMP/android-ndk-r13b ${ANDROID_NDK_HOME}


# [src] libsodium
git clone https://github.com/jedisct1/libsodium.git $DIR_LIBSODIUM
cd $DIR_LIBSODIUM
./autogen.sh
./dist-build/ios.sh
./dist-build/osx.sh


# [bin] copy to dest
mkdir -p $DIR_DEST/Plugins/iOs
mkdir -p $DIR_DEST/Plugins/x64
cp $DIR_LIBSODIUM/libsodium-ios/lib/libsodium.a $DIR_DEST/Plugins/iOS/libsodium.a
cp $DIR_LIBSODIUM/libsodium-osx/lib/libsodium.*.dylib $DIR_DEST/Plugins/x64/sodium.bundle
