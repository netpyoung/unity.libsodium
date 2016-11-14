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
dist-build/ios.sh
dist-build/osx.sh


libsodium/libsodium-ios/lib/libsodium.a /iOS/libsodium.a
libsodium/libsodium-osx/lib/libsodium.*.dylib /Plugins/x64/sodium.bundle
