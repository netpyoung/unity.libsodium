FROM debian:jessie

RUN apt-get update && \
    apt-get -y install \
    git \
    curl \
    wget \
    python \
    build-essential \
    autotools-dev \
    autoconf \
    automake \
    autogen \
    gettext-base \
    gettext \
    binutils \
    libtool \
    unzip && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

WORKDIR /root
ADD build-on-android.sh .
RUN chmod +x build-on-android.sh
ENTRYPOINT ["./build-on-android.sh"]
