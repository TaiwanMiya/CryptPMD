import sys
import traceback
import Library
import os

AES = Library.AES
DES = Library.DES
DES3 = Library.DES3
RSA = Library.RSA
UUID = Library.UUID
FILE = Library.File
HASH = Library.HASH
QR = Library.QR

class Main:

    def __init__(self,args:sys.argv) -> None:
        # 加密類型
        self.cryption       = args[0] if args[0] != 'None' else None

        # 方法
        self.method         = args[1] if args[1] != 'None' else None

        # 檔案名稱
        self.filename       = args[2] if args[2] != 'None' else None

        # 編碼
        self.encoding       = args[3] if args[3] != 'None' else ''

        # 特殊編碼
        self.encryption     = args[4] if args[4] != 'None' else None

        # 鑰匙
        self.key            = args[5] if args[5] != 'None' else None

        # 初始化變量
        self.iv             = args[6] if args[6] != 'None' else None

        # 公鑰
        self.pub            = args[7] if args[7] != 'None' else None

        # 私鑰
        self.priv           = args[8] if args[8] != 'None' else None

        # 數據
        self.data           = args[9] if args[9] != 'None' else None

        # 內容
        self.content        = args[10] if args[10] != 'None' else None

        # 錯誤
        self.errors         = args[11] if args[11] != 'None' else ''

        # 特殊方法(檔案 or 行)
        self.special        = int(args[12]) if args[12] != 'None' else 0

    def ReadArgv(self):
        try:

            self.encryption = Library.DealWithEncryptionMethod(self.encryption)
            if self.method == 'reader':
                print('<FILE>\n'+self.filename.split('\\')[-1:][0])
                print(FILE(self.filename).read())
                path = self.filename.split('\\')[-2:][0] + '\\' + self.filename.split('\\')[-2:][1]

            # AES 創建/生成 鑰匙與初始化變量
            elif (self.cryption,self.method) == ('aes','new'):
                path = AES.new(int(self.content), self.filename, self.encoding, self.encryption, self.errors)
            elif (self.cryption,self.method) == ('aes','create'):
                path = AES.create(self.key, self.iv, self.filename, self.encoding, self.encryption, self.errors)
            
            # AES 加密模式
            elif (self.cryption,self.method) == ('aes','CTR_encrypt'):
                path = AES.Encrypt.AESCTR(self.key, self.filename, self.content, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('aes','CBC_encrypt'):
                path = AES.Encrypt.AESCBC(self.key, self.iv, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('aes','CFB_encrypt'):
                path = AES.Encrypt.AESCFB(self.key, self.iv, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('aes','OFB_encrypt'):
                path = AES.Encrypt.AESOFB(self.key, self.iv, self.filename, self.content, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('aes','ECB_encrypt'):
                path = AES.Encrypt.AESECB(self.key, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)

            # AES 解密模式
            elif (self.cryption,self.method) == ('aes','CTR_decrypt'):
                path = AES.Decrypt.AESCTR(self.key, self.filename, self.content, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('aes','CBC_decrypt'):
                path = AES.Decrypt.AESCBC(self.key, self.iv, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('aes','CFB_decrypt'):
                path = AES.Decrypt.AESCFB(self.key, self.iv, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('aes','OFB_decrypt'):
                path = AES.Decrypt.AESOFB(self.key, self.iv, self.filename, self.content, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('aes','ECB_decrypt'):
                path = AES.Decrypt.AESECB(self.key, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)

            # DES 創建/生成 鑰匙與初始化變量
            elif (self.cryption,self.method) == ('des','new'):
                path = DES.new(self.filename, self.encoding, self.encryption, self.errors)
            elif (self.cryption,self.method) == ('des','create'):
                path = DES.create(self.key, self.iv, self.filename, self.encoding, self.encryption, self.errors)

            # DES 加密模式
            elif (self.cryption,self.method) == ('des','CBC_encrypt'):
                path = DES.Encrypt.DESCBC(self.key, self.iv, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('des','ECB_encrypt'):
                path = DES.Encrypt.DESECB(self.key, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)

            # DES 解密模式
            elif (self.cryption,self.method) == ('des','CBC_decrypt'):
                path = DES.Decrypt.DESCBC(self.key, self.iv, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('des','ECB_decrypt'):
                path = DES.Decrypt.DESECB(self.key, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)

            # DES3 創建/生成 鑰匙與初始化變量
            elif (self.cryption,self.method) == ('des3','new'):
                path = DES3.new(int(self.content), self.filename, self.encoding, self.encryption, self.errors)
            elif (self.cryption,self.method) == ('des3','create'):
                path = DES3.create(self.key, self.iv, self.filename, self.encoding, self.encryption, self.errors)

            # DES3 加密模式
            elif (self.cryption,self.method) == ('des3','CBC_encrypt'):
                path = DES3.Encrypt.DES3CBC(self.key, self.iv, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('des3','ECB_encrypt'):
                path = DES3.Encrypt.DES3ECB(self.key, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)

            # DES3 解密模式
            elif (self.cryption,self.method) == ('des3','CBC_decrypt'):
                path = DES3.Decrypt.DES3CBC(self.key, self.iv, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)
            elif (self.cryption,self.method) == ('des3','ECB_decrypt'):
                path = DES3.Decrypt.DES3ECB(self.key, self.filename, self.content, self.data, self.encoding, self.encryption, self.errors, self.special)

            # RSA 生成 公鑰與私鑰
            elif (self.cryption,self.method) == ('rsa','new'):
                path = RSA.new(int(self.content), self.filename)

            # RSA 加密
            elif (self.cryption,self.method) == ('rsa','RSA_encrypt'):
                path = RSA.encrypt(self.pub, self.filename, self.content, self.encoding, self.encryption, self.errors, self.special)

            # RSA 解密
            elif (self.cryption,self.method) == ('rsa','RSA_decrypt'):
                path = RSA.decrypt(self.priv, self.filename, self.content, self.encoding, self.encryption, self.errors, self.special)

            # UUID 創建/生成
            elif (self.cryption,self.method) == ('uuid','date' or 'uuid1'):
                path = UUID.Guid1(self.filename)
            elif (self.cryption,self.method) == ('uuid','md5' or 'uuid3'):
                path = UUID.Guid3(self.data, self.content, self.filename)
            elif (self.cryption,self.method) == ('uuid','random' or 'uuid4'):
                path = UUID.Guid4(self.filename)
            elif (self.cryption,self.method) == ('uuid','sha1' or 'uuid5'):
                path = UUID.Guid5(self.data, self.content, self.filename)

            # HASH 加密/創建/生成
            elif (self.cryption,self.method) == ('hash','md5'):
                path = HASH.md5(self.content, self.filename)
            elif (self.cryption,self.method) == ('hash','sha1'):
                path = HASH.sha1(self.content, self.filename)
            elif (self.cryption,self.method) == ('hash','sha224'):
                path = HASH.sha224(self.content, self.filename)
            elif (self.cryption,self.method) == ('hash','sha256'):
                path = HASH.sha256(self.content, self.filename)
            elif (self.cryption,self.method) == ('hash','sha384'):
                path = HASH.sha384(self.content, self.filename)
            elif (self.cryption,self.method) == ('hash','sha512'):
                path = HASH.sha512(self.content, self.filename)

            # QR 創建/生成
            elif (self.cryption,self.method) == ('qr','show'):
                path = QR.show(self.content, self.data, self.encoding, self.special)
            elif (self.cryption,self.method) == ('qr','png'):
                path = QR.png(self.filename, self.content, self.data, self.encoding, self.special)
            elif (self.cryption,self.method) == ('qr','svg'):
                path = QR.svg(self.filename, self.content, self.data, self.encoding, self.special)
            elif (self.cryption,self.method) == ('qr','eps'):
                path = QR.eps(self.filename, self.content, self.data, self.encoding, self.special)
            elif (self.cryption,self.method) == ('qr','txt'):
                path = QR.txt(self.filename, self.content, self.encoding, self.special)
            elif (self.cryption,self.method) == ('qr','xbm'):
                path = QR.xbm(self.filename, self.content, self.data, self.encoding, self.special)

        except Exception:                
            print('<FAILED>\n%s' % traceback.format_exc())
        else:
            print('<SUCCESS>')
            if not path:...
            else:
                route = os.getcwd()
                if isinstance(path,str):
                    print(route+'\\'+path.replace('/','\\'))
                elif isinstance(path,list):
                    print(route+'\\'+path[0].replace('/','\\'))
                    print(route+'\\'+path[1].replace('/','\\'))

if __name__ == '__main__':
    if len(sys.argv) < 2:
        raise AttributeError('Wrong format')
    else:
        Main(sys.argv[1:]).ReadArgv()
