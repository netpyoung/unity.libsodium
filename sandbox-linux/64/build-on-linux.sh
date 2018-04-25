#!/usr/bin/env bash

# [variable]
ROOT=$(pwd)
DIR_DEST=${ROOT}/output
DIR_LIBWEBP=${ROOT}/libsodium


# [src] libsodium
git clone https://github.com/jedisct1/libsodium.git
cd libsodium
git checkout tags/1.0.16

# configure
# ref: https://askubuntu.com/questions/27677/cannot-find-install-sh-install-sh-or-shtool-in-ac-aux
libtoolize --force
aclocal
autoheader
automake --force-missing --add-missing
autoconf
chmod +x ./configure

# compile
mkdir .libs/
./configure --prefix=`pwd`/.libs/ && make && make install

mkdir -p ${DIR_DEST}

cp -r .libs/* ${DIR_DEST}