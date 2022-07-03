from Crypt.CryptoApi import (
    CryptoAES,
    CryptoBase64,
    CryptoConvert,
    File,
    Encoding,
    Errors
)

class AES:

    def new(size:int,filename,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name):
        if not encrytion:
            key = CryptoAES.AESNEW(int(size)).newkey()
            iv = CryptoAES.AESNEW(16).newkey()
        else:
            key = CryptoAES.AESNEW(int(size)).newkey()
            iv = CryptoAES.AESNEW(16).newkey()
            key = encrytion(key,encoding,errors).encrypt()
            iv = encrytion(iv,encoding,errors).encrypt()
        File(f'Data/AES/Keys/{filename}_aes.key',key).write()
        File(f'Data/AES/IV/{filename}_iv.key',iv).write()
        print(key)
        print(iv)
        return [f'Data/AES/Keys/{filename}_aes.key',f'Data/AES/IV/{filename}_iv.key']

    def create(key,iv,filename,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name):
        if not encrytion:
            key = key.encode()
            iv = iv.encode()
        else:
            key = encrytion(key,encoding,errors).encrypt()
            iv = encrytion(iv,encoding,errors).encrypt()
        File(f'Data/AES/Keys/{filename}_aes.key',key).write()
        File(f'Data/AES/IV/{filename}_iv.key',iv).write()
        print(key)
        print(iv)
        return [f'Data/AES/Keys/{filename}_aes.key',f'Data/AES/IV/{filename}_iv.key']

    class Encrypt:

        def AESCTR(key,filename,content,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoAES.CTR(msg,key).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoAES.CTR(line,key).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/AES_CTR/{filename}_ctr',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/AES_CTR/{filename}_ctr'

        def AESCBC(key,iv,filename,content,data,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoAES.CBC(msg,key,iv,True if data == 'padding' else False).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoAES.CBC(line,key,iv,True if data == 'padding' else False).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/AES_CBC/{filename}_cbc',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/AES_CBC/{filename}_cbc'

        def AESCFB(key,iv,filename,content,data,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoAES.CFB(msg,key,iv,int(data)).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoAES.CFB(line,key,iv,int(data)).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/AES_CFB/{filename}_cfb',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/AES_CFB/{filename}_cfb'

        def AESOFB(key,iv,filename,content,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoAES.OFB(msg,key,iv).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoAES.OFB(line,key,iv).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/AES_OFB/{filename}_ofb',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/AES_OFB/{filename}_ofb'

        def AESECB(key,filename,content,data,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            msg = File(content).read()
            if special == 0:
                ciphertext = CryptoAES.ECB(msg,key,True if data == 'padding' else False).encrypt()
            elif special == 1:
                ciphertext = b'\r\n'.join([CryptoAES.ECB(line,key,True if data == 'padding' else False).encrypt() for line in msg.split(b'\r\n')])
            if encrytion:
                ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
            File(f'Data/DataBase/AES_ECB/{filename}_ecb',ciphertext).write()
            print(ciphertext)
            return f'Data/DataBase/AES_ECB/{filename}_ecb'

    class Decrypt:

        def AESCTR(key,filename,content,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoAES.CTR(msg,key).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoAES.CTR(line,key).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'

        def AESCBC(key,iv,filename,content,data,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoAES.CBC(msg,key,iv,True if data == 'padding' else False).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoAES.CBC(line,key,iv,True if data == 'padding' else False).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'

        def AESCFB(key,iv,filename,content,data,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoAES.CFB(msg,key,iv,int(data)).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoAES.CFB(line,key,iv,int(data)).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'

        def AESOFB(key,iv,filename,content,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            iv = File(iv).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoAES.OFB(msg,key,iv).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoAES.OFB(line,key,iv).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'

        def AESECB(key,filename,content,data,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
            key = File(key).read()
            msg = File(content).read()
            if decrytion:
                msg = decrytion(msg,encoding,errors).decrypt()
            if special == 0:
                plaintext = CryptoAES.ECB(msg,key,True if data == 'padding' else False).decrypt()
            elif special == 1:
                plaintext = b'\r\n'.join([CryptoAES.ECB(line,key,True if data == 'padding' else False).decrypt() for line in msg.split(b'\r\n')])
            File(f'File/{filename}',plaintext).write()
            print(plaintext)
            return f'File/{filename}'
