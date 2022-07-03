from Crypt.CryptoApi import (
    CryptoDES,
    CryptoBase64,
    CryptoConvert,
    File,
    Encoding,
    Errors
)

class DES3:

    def new(size:int,filename,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name):
        if not encrytion:
            key = CryptoDES.DES3NEW(int(size)).newkey()
            iv = CryptoDES.DES3NEW('iv').newkey()
        else:
            key = CryptoDES.DES3NEW(int(size)).newkey()
            iv = CryptoDES.DES3NEW('iv').newkey()
            key = encrytion(key,encoding,errors).encrypt()
            iv = encrytion(iv,encoding,errors).encrypt()
        File(f'Data/DES3/Keys/{filename}_des3.key',key).write()
        File(f'Data/DES3/IV/{filename}_iv.key',iv).write()
        print(key)
        print(iv)
        return [f'Data/DES3/Keys/{filename}_des3.key',f'Data/DES3/IV/{filename}_iv.key']

    def create(key,iv,filename,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name):
        if not encrytion:
            key = key.encode()
            iv = iv.encode()
        else:
            key = encrytion(key,encoding,errors).encrypt()
            iv = encrytion(iv,encoding,errors).encrypt()
        File(f'Data/DES3/Keys/{filename}_des3.key',key).write()
        File(f'Data/DES3/IV/{filename}_iv.key',iv).write()
        print(key)
        print(iv)
        return [f'Data/DES3/Keys/{filename}_des3.key',f'Data/DES3/IV/{filename}_iv.key']

    class Encrypt:

        def DES3CBC(key,iv,filename,content,data,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoDES.DES3CBC(msg,key,iv,True if data == 'padding' else False).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoDES.DES3CBC(line,key,iv,True if data == 'padding' else False).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/DES3_CBC/{filename}_cbc',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/DES3_CBC/{filename}_cbc'

        def DES3ECB(key,filename,content,data,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoDES.DES3ECB(msg,key,True if data == 'padding' else False).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoDES.DES3ECB(line,key,True if data == 'padding' else False).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/DES3_ECB/{filename}_ecb',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/DES3_ECB/{filename}_ecb'

    class Decrypt:

        def DES3CBC(key,iv,filename,content,data,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoDES.DES3CBC(msg,key,iv,True if data == 'padding' else False).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoDES.DES3CBC(line,key,iv,True if data == 'padding' else False).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'

        def DES3ECB(key,filename,content,data,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoDES.DES3ECB(msg,key,True if data == 'padding' else False).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoDES.DES3ECB(line,key,True if data == 'padding' else False).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'
