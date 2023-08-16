
# AES IGE (Infinite Garble Extension)

[![](http://img.shields.io/nuget/v/AesIge.svg)](http://www.nuget.org/packages/AesIge)

## General 

Infinite Garble Extension (IGE) is a block cipher mode. It has the property that errors are propagated forward indefinitely. 
Bi-directional IGE (biIGE) propogates errors in both directions: that is, any change to the ciphertext will cause all of the plaintext to be corrupted.
IGE and biIGE have some leeway in their definitions admitting several possible implementations. 
This paper documents the way I chose to implement them in OpenSSL, and also provides test vectors.
It also points out some implementation details that may not be obvious from the original papers. [More info](http://www.links.org/files/openssl-ige.pdf)