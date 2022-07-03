from Crypt.CryptoApi import (
    CryptoHash,
    File
)

class HASH:
    
    def md5(salt,filename):
        NewHash = CryptoHash.Hash(salt if salt != None else '')
        NewHash.MD5()
        if not filename:
            bytespath = f'Data/HASH/MD5/bytes/{NewHash.hexdigest}'
            hexpath = f'Data/HASH/MD5/hex/{NewHash.hexdigest}'
            File(bytespath,NewHash.digest).write()
            File(hexpath,NewHash.hexdigest).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return [bytespath,hexpath]
        else:
            path = f'File/{filename}'
            value = NewHash.hexdigest.encode() + b'\n\n' + NewHash.digest
            File(path,value).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return path

    def sha1(salt,filename):
        NewHash = CryptoHash.Hash(salt if salt != None else '')
        NewHash.SHA1()
        if not filename:
            bytespath = f'Data/HASH/SHA1/bytes/{NewHash.hexdigest}'
            hexpath = f'Data/HASH/SHA1/hex/{NewHash.hexdigest}'
            File(bytespath,NewHash.digest).write()
            File(hexpath,NewHash.hexdigest).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return [bytespath,hexpath]
        else:
            path = f'File/{filename}'
            value = NewHash.hexdigest.encode() + b'\n\n' + NewHash.digest
            File(path,value).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return path

    def sha224(salt,filename):
        NewHash = CryptoHash.Hash(salt if salt != None else '')
        NewHash.SHA224()
        if not filename:
            bytespath = f'Data/HASH/SHA224/bytes/{NewHash.hexdigest}'
            hexpath = f'Data/HASH/SHA224/hex/{NewHash.hexdigest}'
            File(bytespath,NewHash.digest).write()
            File(hexpath,NewHash.hexdigest).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return [bytespath,hexpath]
        else:
            path = f'File/{filename}'
            value = NewHash.hexdigest.encode() + b'\n\n' + NewHash.digest
            File(path,value).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return path

    def sha256(salt,filename):
        NewHash = CryptoHash.Hash(salt if salt != None else '')
        NewHash.SHA256()
        if not filename:
            bytespath = f'Data/HASH/SHA256/bytes/{NewHash.hexdigest}'
            hexpath = f'Data/HASH/SHA256/hex/{NewHash.hexdigest}'
            File(bytespath,NewHash.digest).write()
            File(hexpath,NewHash.hexdigest).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return [bytespath,hexpath]
        else:
            path = f'File/{filename}'
            value = NewHash.hexdigest.encode() + b'\n\n' + NewHash.digest
            File(path,value).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return path

    def sha384(salt,filename):
        NewHash = CryptoHash.Hash(salt if salt != None else '')
        NewHash.SHA384()
        if not filename:
            bytespath = f'Data/HASH/SHA384/bytes/{NewHash.hexdigest}'
            hexpath = f'Data/HASH/SHA384/hex/{NewHash.hexdigest}'
            File(bytespath,NewHash.digest).write()
            File(hexpath,NewHash.hexdigest).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return [bytespath,hexpath]
        else:
            path = f'File/{filename}'
            value = NewHash.hexdigest.encode() + b'\n\n' + NewHash.digest
            File(path,value).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return path

    def sha512(salt,filename):
        NewHash = CryptoHash.Hash(salt if salt != None else '')
        NewHash.SHA512()
        if not filename:
            bytespath = f'Data/HASH/SHA512/bytes/{NewHash.hexdigest}'
            hexpath = f'Data/HASH/SHA512/hex/{NewHash.hexdigest}'
            File(bytespath,NewHash.digest).write()
            File(hexpath,NewHash.hexdigest).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return [bytespath,hexpath]
        else:
            path = f'File/{filename}'
            value = NewHash.hexdigest.encode() + b'\n\n' + NewHash.digest
            File(path,value).write()
            print(NewHash.hexdigest)
            print(NewHash.digest)
            return path