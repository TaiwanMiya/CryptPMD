from Crypt.CryptoApi import (
    CryptoRSA,
    CryptoBase64,
    CryptoConvert,
    File,
    Encoding,
    Errors
)

class RSA:

    def new(size:int,filename):
        (public, private) = CryptoRSA.RSANEW(int(size)).newkey()
        rsa = CryptoRSA.File()
        rsa.PublicPath = f'Data/RSA/PublicKey/{filename}_pub.pem'
        rsa.PrivatePath = f'Data/RSA/PrivateKey/{filename}_priv.pem'
        rsa.PublicKey = public
        rsa.PrivateKey = private
        rsa.write()
        print(public)
        print(private)
        return [rsa.PublicPath,rsa.PrivatePath]

    def encrypt(public,filename,content,encoding=Encoding.ASCII.name,encrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
        public,private = CryptoRSA.File(PublicPath=public).read()
        msg = File(content).read()
        if special == 0:
            ciphertext = CryptoRSA.Encrypt(msg,public).encrypt()
        elif special == 1:
            ciphertext = b'\r\n'.join([CryptoRSA.Encrypt(line,public).encrypt() for line in msg.split(b'\r\n')])
        if encrytion:
            ciphertext = encrytion(ciphertext,encoding,errors).encrypt()
        File(f'Data/DataBase/RSA/{filename}_rsa',ciphertext).write()
        print(ciphertext)
        return f'Data/DataBase/RSA/{filename}_rsa'

    def decrypt(private,filename,content,encoding=Encoding.ASCII.name,decrytion=CryptoConvert.HEX,errors=Errors.backslashreplace.name,special=0):
        public,private = CryptoRSA.File(PrivatePath=private).read()
        msg = File(content).read()
        if decrytion:
            msg = decrytion(msg,encoding,errors).decrypt()
        if special == 0:
            plaintext = CryptoRSA.Decrypt(msg,private).decrypt()
        elif special == 1:
            # plaintext = b''.join([CryptoRSA.Decrypt(line,private).decrypt() for line in msg.split(b'\r\n')])
            def LineDecrypt(line,key):
                CryptoRSA.Decrypt(line,key).decrypt()
            plaintext = b''
            for line in msg.split(b'\r\n'):
                try:
                    plaintext += b'\r\n' + CryptoRSA.Decrypt(line,private).decrypt()
                except:...
            plaintext = plaintext.lstrip(b'\r\n')
        File(f'File/{filename}',plaintext).write()
        print(plaintext)
        return f'File/{filename}'
