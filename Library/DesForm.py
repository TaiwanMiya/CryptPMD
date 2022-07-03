from Crypt.CryptoApi import (
    CryptoDES,
    CryptoBase64,
    CryptoConvert,
    File,
    Encoding,
    Errors
)

class DES:

    def new(filename,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name):
        if not encrytion:
            key = CryptoDES.DESNEW().newkey()
            iv = CryptoDES.DESNEW().newkey()
        else:
            key = CryptoDES.DESNEW().newkey()
            iv = CryptoDES.DESNEW().newkey()
            key = encrytion(key,encoding,errors).encrypt()
            iv = encrytion(iv,encoding,errors).encrypt()
        File(f'Data/DES/Keys/{filename}_des.key',key).write()
        File(f'Data/DES/IV/{filename}_iv.key',iv).write()
        print(key)
        print(iv)
        return [f'Data/DES/Keys/{filename}_des.key',f'Data/DES/IV/{filename}_iv.key']

    def create(key,iv,filename,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name):
        if not encrytion:
            key = key.encode()
            iv = iv.encode()
        else:
            key = encrytion(key,encoding,errors).encrypt()
            iv = encrytion(iv,encoding,errors).encrypt()
        File(f'Data/DES/Keys/{filename}_des.key',key).write()
        File(f'Data/DES/IV/{filename}_iv.key',iv).write()
        print(key)
        print(iv)
        return [f'Data/DES/Keys/{filename}_des.key',f'Data/DES/IV/{filename}_iv.key']

    class Encrypt:

        def DESCBC(key,iv,filename,content,data,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoDES.CBC(msg,key,iv,True if data == 'padding' else False).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoDES.CBC(line,key,iv,True if data == 'padding' else False).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/DES_CBC/{filename}_cbc',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/DES_CBC/{filename}_cbc'

        def DESECB(key,filename,content,data,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoDES.ECB(msg,key,True if data == 'padding' else False).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoDES.ECB(line,key,True if data == 'padding' else False).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/DES_ECB/{filename}_ecb',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/DES_ECB/{filename}_ecb'

    class Decrypt:

        def DESCBC(key,iv,filename,content,data,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoDES.CBC(msg,key,iv,True if data == 'padding' else False).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoDES.CBC(line,key,iv,True if data == 'padding' else False).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'

        def DESECB(key,filename,content,data,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoDES.ECB(msg,key,True if data == 'padding' else False).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoDES.ECB(line,key,True if data == 'padding' else False).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'
