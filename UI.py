import Crypt
import os
import time
import sys
import shutil

CryptoAES = Crypt.CryptoAES
CryptoDES = Crypt.CryptoDES
CryptoRSA = Crypt.CryptoRSA
CryptoCanvas = Crypt.CryptoCanvas
CryptoBase64 = Crypt.CryptoBase64
CryptoCarry = Crypt.CryptoCarry
CryptoConvert = Crypt.CryptoConvert

def EnColor(CryptoType=False) -> str:
    if CryptoType == False:
        print('Enter the encoding type you want\n輸入你要的編碼類型')
        print(CryptoCanvas.Print.red()+'1.ASCII'+CryptoCanvas.Print.attr(0))
        print(CryptoCanvas.Print.orange()+'2.UTF-8'+CryptoCanvas.Print.attr(0))
        print(CryptoCanvas.Print.grey()+'>>>'+CryptoCanvas.Print.attr(0),end='')
        try:
            entype = int(input())
        except ValueError:return True
        if entype == 1:return 'ASCII'
        elif entype == 2:return 'UTF8'
        else:return EnColor()
    if CryptoType:
        all = [
            CryptoCanvas.Print.white()+'0.None'+CryptoCanvas.Print.attr(0),
            CryptoCanvas.Print.red()+'1.Base16'+CryptoCanvas.Print.attr(0),
            CryptoCanvas.Print.orange()+'2.Base32'+CryptoCanvas.Print.attr(0),
            CryptoCanvas.Print.yellow()+'3.Base64'+CryptoCanvas.Print.attr(0),
            CryptoCanvas.Print.green()+'4.Base85'+CryptoCanvas.Print.attr(0),
            CryptoCanvas.Print.cyan()+'5.Convert Hex'+CryptoCanvas.Print.attr(0),
            CryptoCanvas.Print.blue()+'6.Convert Base64'+CryptoCanvas.Print.attr(0),
            CryptoCanvas.Print.purple()+'7.Convert QP'+CryptoCanvas.Print.attr(0),
            CryptoCanvas.Print.white()+'8.Convert UU'+CryptoCanvas.Print.attr(0),
        ]
        print('Enter the encoding type you want\n輸入你要的編碼類型')
        for i in all:
            print(i)
        print(CryptoCanvas.Print.grey()+'>>>'+CryptoCanvas.Print.attr(0),end='')
        try:
            entype = int(input())
        except ValueError:return True
        if entype == 0:return ''
        elif entype == 1:return 'Base16'
        elif entype == 2:return 'Base32'
        elif entype == 3:return 'Base64'
        elif entype == 4:return 'Base85'
        elif entype == 5:return 'Convert Hex'
        elif entype == 6:return 'Convert Base64'
        elif entype == 7:return 'Convert QP'
        elif entype == 8:return 'Convert UU'
        else:return EnColor(True)

class RunCrypt(object):

    def __init__(self) -> None:
        self.red = CryptoCanvas.Print.red()
        self.orange = CryptoCanvas.Print.orange()
        self.yellow = CryptoCanvas.Print.yellow()
        self.green = CryptoCanvas.Print.green()
        self.cyan = CryptoCanvas.Print.cyan()
        self.blue = CryptoCanvas.Print.blue()
        self.purple = CryptoCanvas.Print.purple()
        self.black = CryptoCanvas.Print.black()
        self.grey = CryptoCanvas.Print.grey()
        self.white = CryptoCanvas.Print.white()
        self.reset = CryptoCanvas.Print.attr(0)

        self.key = None
        self.aesiv = None
        self.public = None
        self.private = None
        self.size = None
        self.padding = False
        self.pt = CryptoCanvas.Print
        self.name = self.TimeNow()
        self.set_print = [
            '0.Execute/Cancel : 執行/取消',
            '0.Execute : 執行',
            '0.Cancel : 取消',
        ]
        self.path = {
            'key': '',
            'iv': '',
            'public': '',
            'private': '',
            'file': 'File',
            'aeskey': 'Data/AES',
            'deskey': 'Data/DES',
            'des3key': 'Data/DES3',
            'rsakey': 'Data/RSA',
            'aes_ctr': 'Data/DataBase/AES_CTR',
            'aes_cbc': 'Data/DataBase/AES_CBC',
            'aes_cfb': 'Data/DataBase/AES_CFB',
            'aes_ofb': 'Data/DataBase/AES_OFB',
            'aes_ecb': 'Data/DataBase/AES_ECB',
            'des_cbc': 'Data/DataBase/DES_CBC',
            'des_ecb': 'Data/DataBase/DES_ECB',
            'des3_cbc': 'Data/DataBase/DES3_CBC',
            'des3_ecb': 'Data/DataBase/DES3_ECB',
            'rsa': 'Data/DataBase/RSA',
            'b16': 'Data/DataBase/Base/Base16',
            'b32': 'Data/DataBase/Base/Base32',
            'b64': 'Data/DataBase/Base/Base64',
            'b85': 'Data/DataBase/Base/Base85',
            'hex': 'Data/DataBase/Convert/Hex',
            'base64': 'Data/DataBase/Convert/Base64',
            'qp': 'Data/DataBase/Convert/QP',
            'uu': 'Data/DataBase/Convert/UU',
        }
        self.document = [
            [ None,         None       ],
            [ '_aes.key',   'Data/AES/Keys' ],
            [ '_iv.key',    'Data/AES/IV' ],
            [ '_des.key',   'Data/DES/Keys' ],
            [ '_iv.key',    'Data/DES/IV' ],
            [ '_des3.key',  'Data/DES3/Keys' ],
            [ '_iv.key',    'Data/DES3/IV' ],
            [ '_pub.pem',   'Data/RSA/PublicKey' ],
            [ '_priv.pem',  'Data/RSA/PrivateKey' ],
            [ '_ctr',       'Data/DataBase/AES_CTR' ],
            [ '_cbc',       'Data/DataBase/AES_CBC' ],
            [ '_cfb',       'Data/DataBase/AES_CFB' ],
            [ '_ofb',       'Data/DataBase/AES_OFB' ],
            [ '_ecb',       'Data/DataBase/AES_ECB' ],
            [ '_cbc',       'Data/DataBase/DES_CBC' ],
            [ '_ecb',       'Data/DataBase/DES_ECB' ],
            [ '_cbc',       'Data/DataBase/DES3_CBC' ],
            [ '_ecb',       'Data/DataBase/DES3_ECB' ],
            [ '_rsa',       'Data/DataBase/RSA' ],
            [ '_b16.bin',   'Data/DataBase/Base/Base16' ],
            [ '_b32.bin',   'Data/DataBase/Base/Base32' ],
            [ '_b64.bin',   'Data/DataBase/Base/Base64' ],
            [ '_b85.bin',   'Data/DataBase/Base/Base85' ],
            [ '_hex.bin',   'Data/DataBase/Convert/Hex' ],
            [ '_base.bin',  'Data/DataBase/Convert/Base64' ],
            [ '_qp.bin',    'Data/DataBase/Convert/QP' ],
            [ '_uu.bin',    'Data/DataBase/Convert/UU' ],
            [ '',           'File' ],
        ]
        self.filedata = [
            None,
            '1.AES key : AES 密鑰',
            '2.AES iv : AES 初始化變量',
            '3.DES key : DES 密鑰',
            '4.DES iv : DES 初始化變量',
            '5.DES3 key : DES3 密鑰',
            '6.DES3 iv : DES3 初始化變量',
            '7.RSA public key : RSA 公鑰',
            '8.RSA private key : RSA 私鑰',
            '9.AES CTR encrypted data : AES CTR 加密數據',
            '10.AES CBC encrypted data : AES CBC 加密數據',
            '11.AES CFB encrypted data : AES CFB 加密數據',
            '12.AES OFB encrypted data : AES OFB 加密數據',
            '13.AES ECB encrypted data : AES ECB 加密數據',
            '14.DES CBC encrypted data : DES CBC 加密數據',
            '15.DES ECB encrypted data : DES ECB 加密數據',
            '16.DES3 CBC encrypted data : DES3 CBC 加密數據',
            '17.DES3 ECB encrypted data : DES3 ECB 加密數據',
            '18.RSA encrypted data : RSA 加密數據',
            '19.Base16 data : Base16 數據',
            '20.Base32 data : Base32 數據',
            '21.Base64 data : Base64 數據',
            '22.Base85 data : Base85 數據',
            '23.Convert Hex data : Hex 編碼數據',
            '24.Convert Base64 data : Base64 編碼數據',
            '25.Convert QP data : QP 編碼數據',
            '26.Convert UU data : UU 編碼數據',
            '27.File data : 數據庫',
            '>>>'
        ]
        self.dellist = []

    def TimeNow(self):
        return time.strftime('%Y-%m-%d__%H_%M_%S',time.localtime())

    def AEScreate(self):
        while 1:
            print('Enter your AES key size\n輸入您的 AES 密鑰大小')
            print(self.white+'0.Cancel'+self.reset)
            print(self.red+'1.16 or 128'+self.reset)
            print(self.yellow+'2.24 or 192'+self.reset)
            print(self.green+'3.32 or 256'+self.reset)
            print(self.grey+'>>>'+self.reset,end='')
            size = input()
            if size.isdecimal():
                size = int(size)
                sizelist = [16,24,32,128,192,256]
                if size == 0:break
                if size in [1,2,3]:
                    size = sizelist[size-1]
                if size in sizelist:
                    self.key = CryptoAES.AESNEW(size).newkey()
                    self.iv = CryptoAES.AESNEW('iv').newkey()
                    self.path['key'] = 'Data/AES/Keys/'+self.name+'_aes.key'
                    self.path['iv'] = 'Data/AES/IV/'+self.name+'_iv.key'
                    CryptoAES.File(self.path['key'],self.key).write()
                    CryptoAES.File(self.path['iv'],self.iv).write()
                    print(''.center(50,'-'))
                    print(f'AESkey:{self.key}\npath:{self.path["key"]}')
                    print(f'AESiv:{self.iv}\npath:{self.path["iv"]}')
                    break

    def DEScreate(self):
        self.key = CryptoDES.DESNEW().newkey()
        self.iv = CryptoDES.DESNEW().newkey()
        self.path['key'] = 'Data/DES/Keys/'+self.name+'_des.key'
        self.path['iv'] = 'Data/DES/IV/'+self.name+'_iv.key'
        CryptoDES.File(self.path['key'],self.key).write()
        CryptoDES.File(self.path['iv'],self.iv).write()
        print(''.center(50,'-'))
        print(f'DESkey:{self.key}\npath:{self.path["key"]}')
        print(f'DESiv:{self.iv}\npath:{self.path["iv"]}')

    def DES3create(self):
        while 1:
            print('Enter your DES3 key size\n輸入您的 DES3 密鑰大小')
            print(self.white+'0.Cancel'+self.reset)
            print(self.red+'1.16 or 128'+self.reset)
            print(self.yellow+'2.24 or 192'+self.reset)
            print(self.grey+'>>>'+self.reset,end='')
            size = input()
            if size.isdecimal():
                size = int(size)
                sizelist = [16,24,128,192]
                if size == 0:break
                if size in [1,2]:
                    size = sizelist[size-1]
                if size in sizelist:
                    self.key = CryptoDES.DES3NEW(size).newkey()
                    self.iv = CryptoDES.DES3NEW('iv').newkey()
                    self.path['key'] = 'Data/DES3/Keys/'+self.name+'_des3.key'
                    self.path['iv'] = 'Data/DES3/IV/'+self.name+'_iv.key'
                    CryptoDES.File(self.path['key'],self.key).write()
                    CryptoDES.File(self.path['iv'],self.iv).write()
                    print(''.center(50,'-'))
                    print(f'DES3key:{self.key}\npath:{self.path["key"]}')
                    print(f'DES3iv:{self.iv}\npath:{self.path["iv"]}')
                    break

    def RSAcreate(self):
        while 1:
            'Enter your RSA key size\n輸入您的 RSA 密鑰大小'
            print(self.white+'0.Cancel'+self.reset)
            print(self.red+'1.128'+self.reset)
            print(self.orange+'2.256'+self.reset)
            print(self.yellow+'3.512'+self.reset)
            print(self.green+'4.1024'+self.reset)
            print(self.cyan+'5.2048'+self.reset)
            print(self.purple+'6.4096'+self.reset)
            print(self.grey+'>>>'+self.reset,end='')
            size = input()
            if size.isdecimal():
                size = int(size)
                sizelist = [128,256,512,1024,2048,4096]
                if size == 0:break
                if size in [1,2,3,4,5,6]:
                    size = sizelist[size-1]
                if size in sizelist:
                    self.public,self.private = CryptoRSA.RSANEW(size).newkey()
                    self.path['public'] = 'Data/RSA/PublicKey/'+self.name+'_pub.pem'
                    self.path['private'] = 'Data/RSA/PrivateKey/'+self.name+'_priv.pem'
                    CryptoRSA.File(self.path["public"],self.path["private"],self.public,self.private).write()
                    print(''.center(50,'-'))
                    print(f'{self.public}\npath:{self.path["public"]}')
                    print(f'{self.private}\npath:{self.path["private"]}')
                    break

    def Encrypto_Data_Input(self):
        while 1:
            print(self.white+'Enter the type to encrypt\n輸入要加密的類型\n0.Cancel(取消)'+self.reset)
            print(self.red+'1.String(字串)'+self.reset)
            print(self.orange+'2.File(檔案)'+self.reset)
            print(self.grey+'>>>'+self.reset,end='')
            try:
                types = int(input())
            except ValueError:return self.Encrypto_Data_Input()
            if types == 0:return
            elif types == 1:
                TextArray : list = []
                while 1:
                    text = input('Enter your string to encrypt(Press Enter directly to end the input)\n輸入要加密的字串(直接按下Enter結束輸入)\n>>>')
                    if text == '' or text == None:
                        return '\n'.join([i for i in TextArray])
                    else:
                        TextArray.append(text)
            elif types == 2:
                path = os.listdir(self.path['file'])
                print('0.Restart(重新選擇)')
                for i in range(len(path)):
                    print(f'{i+1}.{path[i]}')
                while 1:
                    try:
                        print(self.grey+'>>>'+self.reset,end='')
                        filenum = int(input())
                    except ValueError:continue
                    if filenum == 0:break
                    elif filenum > len(path):continue
                    else:
                        return Crypt.File(self.path['file'] + '/' + path[filenum-1]).read()

    def Encode_format(self,entext,type='encode'):
        entype = EnColor(True)
        if entype == True:return self.Encode_format(entext)
        encodes = EnColor()
        if encodes == True:return self.Encode_format(entext)
        elif isinstance(entype,str):
            if entype == 'Base16':
                if type == 'encode':
                    return CryptoBase64.Base16(entext,encodes).encrypt()
                elif type == 'decode':
                    return CryptoBase64.Base16(entext,encodes).decrypt()
            elif entype == 'Base32':
                if type == 'encode':
                    return CryptoBase64.Base32(entext,encodes).encrypt()
                elif type == 'decode':
                    return CryptoBase64.Base32(entext,encodes).decrypt()
            elif entype == 'Base64':
                if type == 'encode':
                    return CryptoBase64.Base64(entext,encodes).encrypt()
                elif type == 'decode':
                    return CryptoBase64.Base64(entext,encodes).decrypt()
            elif entype == 'Base85':
                if type == 'encode':
                    return CryptoBase64.Base85(entext,encodes).encrypt()
                elif type == 'decode':
                    return CryptoBase64.Base85(entext,encodes).decrypt()
            elif entype == 'Convert Hex':
                if type == 'encode':
                    return CryptoConvert.HEX(entext,encodes).encrypt()
                elif type == 'decode':
                    return CryptoConvert.HEX(entext,encodes).decrypt()
            elif entype == 'Convert Base64':
                if type == 'encode':
                    return CryptoConvert.BASE64(entext,encodes).encrypt()
                elif type == 'decode':
                    return CryptoConvert.BASE64(entext,encodes).decrypt()
            elif entype == 'Convert QP':
                if type == 'encode':
                    return CryptoConvert.QP(entext,encodes).encrypt()
                elif type == 'decode':
                    return CryptoConvert.QP(entext,encodes).decrypt()
            elif entype == 'Convert UU':
                if type == 'encode':
                    return CryptoConvert.UU(entext,encodes).encrypt()
                elif type == 'decode':
                    return CryptoConvert.UU(entext,encodes).decrypt()
            if entype == '':
                if type == 'encode':
                    if isinstance(entext,str):
                        return entext.encode(encodes)
                    elif isinstance(entext,bytes):
                        return entext
                elif type == 'decode':
                    try:
                        return entext.decode(encodes)
                    except UnicodeDecodeError:
                        return entext

    def Transfer_File(self,datatype,end):
        old = self.path[datatype] + '/' + self.name + end
        new = self.path['file'] + '/' + self.name + end
        while 1:
            print(f'Whether to copy files to the data folder to be encrypted\n是否複製一份檔案至待加密數據資料夾\n{new}')
            print(self.red+'1.y'+self.reset)
            print(self.cyan+'2.n'+self.reset)
            print(self.grey+'>>>'+self.reset,end='')
            move = input()
            if move.casefold() in ['y','1']:
                shutil.copyfile(old,new)
                break
            elif move.casefold() in ['n','2']:
                break

    def AESload(self):
        key_path = os.listdir('Data/AES/Keys')
        iv_path = os.listdir('Data/AES/IV')
        aespath : list = []
        ivpath : list = []
        for i in key_path:
            if '_aes.key' in i:aespath.append(i)
        for i in iv_path:
            if '_iv.key' in i:ivpath.append(i)
        assert len(aespath) > 0,'No aes key archive\n沒有 aes 密鑰存檔'
        assert len(ivpath) > 0,'No aes iv archive\n沒有 aes iv 存檔'
        print('Enter the key number (enter the numbers in order)\n輸入密鑰編號（按順序輸入數字）')
        for i in range(len(aespath)):
            print(f'{i+1}.{aespath[i]}')
        try:
            keynum = int(input('>>>'))
            if keynum > len(aespath):return self.AESload()
        except ValueError:return self.AESload()
        self.path['key'] = f'Data/AES/Keys/{aespath[keynum-1]}'
        print('Enter the iv number (enter the numbers in order)\n輸入iv編號（按順序輸入數字）')
        for i in range(len(ivpath)):
            print(f'{i+1}.{ivpath[i]}')
        try:
            ivnum = int(input('>>>'))
            if ivnum > len(ivpath):return self.AESload()
        except ValueError:return self.AESload()
        self.path['iv'] = f'Data/AES/IV/{ivpath[ivnum-1]}'
        self.key,self.iv = CryptoAES.File(self.path['key']).read(),CryptoAES.File(self.path['iv']).read()
        print(''.center(50,'-'))
        print(self.red+'AESkey:'+self.reset)
        print(self.red+f'{self.key}'+self.reset)
        print(self.green+'AESiv:'+self.reset)
        print(self.green+f'{self.iv}'+self.reset)

    def DESload(self):
        key_path = os.listdir('Data/DES/Keys')
        iv_path = os.listdir('Data/DES/IV')
        despath : list = []
        ivpath : list = []
        for i in key_path:
            if '_des.key' in i:despath.append(i)
        for i in iv_path:
            if '_iv.key' in i:ivpath.append(i)
        assert len(despath) > 0,'No des key archive\n沒有 des 密鑰存檔'
        assert len(ivpath) > 0,'No des iv archive\n沒有 des iv 存檔'
        print('Enter the key number (enter the numbers in order)\n輸入密鑰編號（按順序輸入數字）')
        for i in range(len(despath)):
            print(f'{i+1}.{despath[i]}')
        try:
            keynum = int(input('>>>'))
            if keynum > len(despath):return self.DESload()
        except ValueError:return self.DESload()
        self.path['key'] = f'Data/DES/Keys/{despath[keynum-1]}'
        print('Enter the iv number (enter the numbers in order)\n輸入iv編號（按順序輸入數字）')
        for i in range(len(ivpath)):
            print(f'{i+1}.{ivpath[i]}')
        try:
            ivnum = int(input('>>>'))
            if ivnum > len(ivpath):return self.DESload()
        except ValueError:return self.DESload()
        self.path['iv'] = f'Data/DES/IV/{ivpath[ivnum-1]}'
        self.key,self.iv = CryptoDES.File(self.path['key']).read(),CryptoDES.File(self.path['iv']).read()
        print(''.center(50,'-'))
        print(self.red+'DESkey:'+self.reset)
        print(self.red+f'{self.key}'+self.reset)
        print(self.green+'DESiv:'+self.reset)
        print(self.green+f'{self.iv}'+self.reset)

    def DES3load(self):
        key_path = os.listdir('Data/DES3/Keys')
        iv_path = os.listdir('Data/DES3/IV')
        despath : list = []
        ivpath : list = []
        for i in key_path:
            if '_des3.key' in i:despath.append(i)
        for i in iv_path:
            if '_iv.key' in i:ivpath.append(i)
        assert len(despath) > 0,'No des3 key archive\n沒有 des3 密鑰存檔'
        assert len(ivpath) > 0,'No des3 iv archive\n沒有 des3 iv 存檔'
        print('Enter the key number (enter the numbers in order)\n輸入密鑰編號（按順序輸入數字）')
        for i in range(len(despath)):
            print(f'{i+1}.{despath[i]}')
        try:
            keynum = int(input('>>>'))
            if keynum > len(despath):return self.DES3load()
        except ValueError:return self.DES3load()
        self.path['key'] = f'Data/DES3/Keys/{despath[keynum-1]}'
        print('Enter the iv number (enter the numbers in order)\n輸入iv編號（按順序輸入數字）')
        for i in range(len(ivpath)):
            print(f'{i+1}.{ivpath[i]}')
        try:
            ivnum = int(input('>>>'))
            if ivnum > len(ivpath):return self.DES3load()
        except ValueError:return self.DES3load()
        self.path['iv'] = f'Data/DES3/IV/{ivpath[ivnum-1]}'
        self.key,self.iv = CryptoDES.File(self.path['key']).read(),CryptoDES.File(self.path['iv']).read()
        print(''.center(50,'-'))
        print(self.red+'DES3key:'+self.reset)
        print(self.red+f'{self.key}'+self.reset)
        print(self.green+'DES3iv:'+self.reset)
        print(self.green+f'{self.iv}'+self.reset)

    def RSAload(self):
        pubpath = os.listdir('Data/RSA/PublicKey')
        privpath = os.listdir('Data/RSA/PrivateKey')
        pubs : list = []
        privs : list = []
        for i in pubpath:
            if '_pub.pem' in i:pubs.append(i)
        for i in privpath:
            if '_priv.pem' in i:privs.append(i)
        assert len(pubs) > 0,'No rsa public key archive\n沒有 rsa 公鑰存檔'
        assert len(privs) > 0,'No rsa private key archive\n沒有 rsa 私鑰存檔'
        print('Enter the PublicKey number (enter the numbers in order)\n輸入公鑰編號（按順序輸入數字）')
        for i in range(len(pubs)):
            print(f'{i+1}.{pubs[i]}')
        try:
            public = int(input('>>>'))
            if public > len(pubs):return self.RSAload()
        except ValueError:return self.RSAload()
        self.path['public'] = f'Data/RSA/PublicKey/{pubs[public-1]}'
        print('Enter the PrivateKey number (enter the numbers in order)\n輸入私鑰編號（按順序輸入數字）')
        for i in range(len(privs)):
            print(f'{i+1}.{privs[i]}')
        try:
            private = int(input('>>>'))
            if private > len(privs):return self.RSAload()
        except ValueError:return self.RSAload()
        self.path['private'] = f'Data/RSA/PrivateKey/{privs[private-1]}'
        self.public,self.private = CryptoRSA.File(self.path['public'],self.path['private']).read()
        print(''.center(50,'-'))
        print(self.cyan+'Publickey:'+self.reset)
        print(self.cyan+f'{self.public}'+self.reset)
        print(self.red+'Privatekey:'+self.reset)
        print(self.red+f'{self.private}'+self.reset)

    def AES_CTR_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoAES.CTR(entext,self.key).encrypt()
        msgpath = self.path['aes_ctr']+'/'+self.name+'_ctr'
        CryptoAES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('aes_ctr','_ctr')

    def AES_CBC_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoAES.CBC(entext,self.key,self.iv,self.padding).encrypt()
        msgpath = self.path['aes_cbc']+'/'+self.name+'_cbc'
        CryptoAES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('aes_cbc','_cbc')

    def AES_CFB_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoAES.CFB(entext,self.key,self.iv,self.size).encrypt()
        msgpath = self.path['aes_cfb']+'/'+self.name+'_cfb'
        CryptoAES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('aes_cfb','_cfb')

    def AES_OFB_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoAES.OFB(entext,self.key,self.iv).encrypt()
        msgpath = self.path['aes_ofb']+'/'+self.name+'_ofb'
        CryptoAES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('aes_ofb','_ofb')

    def AES_ECB_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoAES.ECB(entext,self.key,self.padding).encrypt()
        msgpath = self.path['aes_ecb']+'/'+self.name+'_ecb'
        CryptoAES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('aes_ecb','_ecb')

    def DES_CBC_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoDES.CBC(entext,self.key,self.iv,self.padding).encrypt()
        msgpath = self.path['des_cbc']+'/'+self.name+'_cbc'
        CryptoDES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('des_cbc','_cbc')

    def DES_ECB_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoDES.ECB(entext,self.key,self.padding).encrypt()
        msgpath = self.path['des_ecb']+'/'+self.name+'_ecb'
        CryptoDES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('des_ecb','_ecb')

    def DES3_CBC_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoDES.DES3CBC(entext,self.key,self.iv,self.padding).encrypt()
        msgpath = self.path['des3_cbc']+'/'+self.name+'_cbc'
        CryptoDES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('des3_cbc','_cbc')

    def DES3_ECB_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoDES.DES3ECB(entext,self.key,self.padding).encrypt()
        msgpath = self.path['des3_ecb']+'/'+self.name+'_ecb'
        CryptoDES.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('des3_ecb','_ecb')

    def RSA_encrypt(self,entext):
        enformat = self.Encode_format(entext)
        entext = enformat if enformat is not None else entext
        enmsg = CryptoRSA.Encrypt(entext,self.public).encrypt()
        msgpath = self.path['rsa']+'/'+self.name+'_rsa'
        CryptoRSA.TextFile(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('rsa','_rsa')

    def Base16_encrypt(self,entext):
        entype = EnColor()
        if entype == True:return self.Base16_encrypt(entext)
        enmsg = CryptoBase64.Base16(entext,entype).encrypt()
        msgpath = self.path['b16']+'/'+self.name+'_b16.bin'
        Crypt.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('b16','_b16.bin')

    def Base32_encrypt(self,entext):
        entype = EnColor()
        if entype == True:return self.Base32_encrypt(entext)
        enmsg = CryptoBase64.Base32(entext,entype).encrypt()
        msgpath = self.path['b32']+'/'+self.name+'_b32.bin'
        Crypt.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('b32','_b32.bin')

    def Base64_encrypt(self,entext):
        entype = EnColor()
        if entype == True:return self.Base64_encrypt(entext)
        enmsg = CryptoBase64.Base64(entext,entype).encrypt()
        msgpath = self.path['b64']+'/'+self.name+'_b64.bin'
        Crypt.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('b64','_b64.bin')

    def Base85_encrypt(self,entext):
        entype = EnColor()
        if entype == True:return self.Base85_encrypt(entext)
        enmsg = CryptoBase64.Base85(entext,entype).encrypt()
        msgpath = self.path['b85']+'/'+self.name+'_b85.bin'
        Crypt.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('b85','_b85.bin')

    def Convert_Hex_encrypt(self,entext):
        entype = EnColor()
        if entype == True:return self.Convert_Hex_encrypt(entext)
        enmsg = CryptoConvert.HEX(entext,entype).encrypt()
        msgpath = self.path['hex']+'/'+self.name+'_hex.bin'
        Crypt.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('hex','_hex.bin')

    def Convert_Base64_encrypt(self,entext):
        entype = EnColor()
        if entype == True:return self.Convert_Base64_encrypt(entext)
        enmsg = CryptoConvert.BASE64(entext,entype).encrypt()
        msgpath = self.path['base64']+'/'+self.name+'_base.bin'
        Crypt.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('base64','_base.bin')

    def Convert_QP_encrypt(self,entext):
        entype = EnColor()
        if entype == True:return self.Convert_QP_encrypt(entext)
        enmsg = CryptoConvert.QP(entext,entype).encrypt()
        msgpath = self.path['qp']+'/'+self.name+'_qp.bin'
        Crypt.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('qp','_qp.bin')

    def Convert_UU_encrypt(self,entext):
        entype = EnColor()
        if entype == True:return self.Convert_UU_encrypt(entext)
        enmsg = CryptoConvert.UU(entext,entype).encrypt()
        msgpath = self.path['uu']+'/'+self.name+'_uu.bin'
        Crypt.File(msgpath,enmsg).write()
        print(''.center(50,'-'))
        print(self.red+'encrypt:'+self.reset)
        print(self.red+f'{enmsg}'+self.reset)
        print(self.blue+'path:'+self.reset)
        print(self.blue+f'{msgpath}'+self.reset)
        self.Transfer_File('uu','_uu.bin')

    def AES_CTR_decrypt(self):
        paths = os.listdir(self.path['aes_ctr'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.AES_CTR_decrypt()
        except ValueError:return self.AES_CTR_decrypt()
        depath = self.path['aes_ctr'] + '/' + paths[num-1]
        detext = CryptoAES.File(depath).read()
        demsg = CryptoAES.CTR(detext,self.key).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def AES_CBC_decrypt(self):
        paths = os.listdir(self.path['aes_cbc'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.AES_CBC_decrypt()
        except ValueError:return self.AES_CBC_decrypt()
        depath = self.path['aes_cbc'] + '/' + paths[num-1]
        detext = CryptoAES.File(depath).read()
        demsg = CryptoAES.CBC(detext,self.key,self.iv,self.padding).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def AES_CFB_decrypt(self):
        paths = os.listdir(self.path['aes_cfb'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.AES_CFB_decrypt()
        except ValueError:return self.AES_CFB_decrypt()
        depath = self.path['aes_cfb'] + '/' + paths[num-1]
        detext = CryptoAES.File(depath).read()
        demsg = CryptoAES.CFB(detext,self.key,self.iv,self.size).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def AES_OFB_decrypt(self):
        paths = os.listdir(self.path['aes_ofb'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.AES_OFB_decrypt()
        except ValueError:return self.AES_OFB_decrypt()
        depath = self.path['aes_ofb'] + '/' + paths[num-1]
        detext = CryptoAES.File(depath).read()
        demsg = CryptoAES.OFB(detext,self.key,self.iv).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def AES_ECB_decrypt(self):
        paths = os.listdir(self.path['aes_ecb'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.AES_ECB_decrypt()
        except ValueError:return self.AES_ECB_decrypt()
        depath = self.path['aes_ecb'] + '/' + paths[num-1]
        detext = CryptoAES.File(depath).read()
        demsg = CryptoAES.ECB(detext,self.key,self.padding).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def DES_CBC_decrypt(self):
        paths = os.listdir(self.path['des_cbc'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.DES_CBC_decrypt()
        except ValueError:return self.DES_CBC_decrypt()
        depath = self.path['des_cbc'] + '/' + paths[num-1]
        detext = CryptoDES.File(depath).read()
        demsg = CryptoDES.CBC(detext,self.key,self.iv,self.padding).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def DES_ECB_decrypt(self):
        paths = os.listdir(self.path['des_ecb'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.DES_ECB_decrypt()
        except ValueError:return self.DES_ECB_decrypt()
        depath = self.path['des_ecb'] + '/' + paths[num-1]
        detext = CryptoDES.File(depath).read()
        demsg = CryptoDES.ECB(detext,self.key,self.padding).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def DES3_CBC_decrypt(self):
        paths = os.listdir(self.path['des3_cbc'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.DES3_CBC_decrypt()
        except ValueError:return self.DES3_CBC_decrypt()
        depath = self.path['des3_cbc'] + '/' + paths[num-1]
        detext = CryptoDES.File(depath).read()
        demsg = CryptoDES.DES3CBC(detext,self.key,self.iv,self.padding).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def DES3_ECB_decrypt(self):
        paths = os.listdir(self.path['des3_ecb'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.DES3_ECB_decrypt()
        except ValueError:return self.DES3_ECB_decrypt()
        depath = self.path['des3_ecb'] + '/' + paths[num-1]
        detext = CryptoDES.File(depath).read()
        demsg = CryptoDES.DES3ECB(detext,self.key,self.padding).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def RSA_decrypt(self):
        paths = os.listdir(self.path['rsa'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.RSA_decrypt()
        except ValueError:return self.RSA_decrypt()
        depath = self.path['rsa'] + '/' + paths[num-1]
        detext = CryptoRSA.TextFile(depath).read()
        demsg = CryptoRSA.Decrypt(detext,self.private).decrypt()
        deformat = self.Encode_format(demsg,type='decode')
        demsg = deformat if deformat is not None else demsg
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def Base16_decrypt(self):
        paths = os.listdir(self.path['b16'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.Base16_decrypt()
        except ValueError:return self.Base16_decrypt()
        depath = self.path['b16'] + '/' + paths[num-1]
        detext = Crypt.File(depath).read()
        detype = EnColor()
        if detype == True:return self.Base16_decrypt()
        demsg = CryptoBase64.Base16(detext,detype).decrypt()
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def Base32_decrypt(self):
        paths = os.listdir(self.path['b32'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.Base32_decrypt()
        except ValueError:return self.Base32_decrypt()
        depath = self.path['b32'] + '/' + paths[num-1]
        detext = Crypt.File(depath).read()
        detype = EnColor()
        if detype == True:return self.Base32_decrypt()
        demsg = CryptoBase64.Base32(detext,detype).decrypt()
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def Base64_decrypt(self):
        paths = os.listdir(self.path['b64'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.Base64_decrypt()
        except ValueError:return self.Base64_decrypt()
        depath = self.path['b64'] + '/' + paths[num-1]
        detext = Crypt.File(depath).read()
        detype = EnColor()
        if detype == True:return self.Base64_decrypt()
        demsg = CryptoBase64.Base64(detext,detype).decrypt()
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def Base85_decrypt(self):
        paths = os.listdir(self.path['b85'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.Base85_decrypt()
        except ValueError:return self.Base85_decrypt()
        depath = self.path['b85'] + '/' + paths[num-1]
        detext = Crypt.File(depath).read()
        detype = EnColor()
        if detype == True:return self.Base85_decrypt()
        demsg = CryptoBase64.Base85(detext,detype).decrypt()
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def Convert_Hex_decrypt(self):
        paths = os.listdir(self.path['hex'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.Convert_Hex_decrypt()
        except ValueError:return self.Convert_Hex_decrypt()
        depath = self.path['hex'] + '/' + paths[num-1]
        detext = Crypt.File(depath).read()
        detype = EnColor()
        if detype == True:return self.Convert_Hex_decrypt()
        demsg = CryptoConvert.HEX(detext,detype).decrypt()
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def Convert_Base64_decrypt(self):
        paths = os.listdir(self.path['base64'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.Convert_Base64_decrypt()
        except ValueError:return self.Convert_Base64_decrypt()
        depath = self.path['base64'] + '/' + paths[num-1]
        detext = Crypt.File(depath).read()
        detype = EnColor()
        if detype == True:return self.Convert_Base64_decrypt()
        demsg = CryptoConvert.BASE64(detext,detype).decrypt()
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def Convert_QP_decrypt(self):
        paths = os.listdir(self.path['qp'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.Convert_QP_decrypt()
        except ValueError:return self.Convert_QP_decrypt()
        depath = self.path['qp'] + '/' + paths[num-1]
        detext = Crypt.File(depath).read()
        detype = EnColor()
        if detype == True:return self.Convert_QP_decrypt()
        demsg = CryptoConvert.QP(detext,detype).decrypt()
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def Convert_UU_decrypt(self):
        paths = os.listdir(self.path['uu'])
        assert len(paths) > 0,'No decrypted text\n沒有解密文本'
        print('Enter the path number to decrypt\n輸入要解密的路徑編號')
        for i in range(len(paths)):
            print(f'{i+1}.{paths[i]}')
        try:
            num = int(input('>>>'))
            if num > len(paths):return self.Convert_UU_decrypt()
        except ValueError:return self.Convert_UU_decrypt()
        depath = self.path['uu'] + '/' + paths[num-1]
        detext = Crypt.File(depath).read()
        detype = EnColor()
        if detype == True:return self.Convert_UU_decrypt()
        demsg = CryptoConvert.UU(detext,detype).decrypt()
        print(self.orange+'decrypt:'+self.reset)
        if isinstance(demsg,str):
            print(self.orange+f'{demsg}'+self.reset)
        elif isinstance(demsg,bytes):
            try:
                print(self.orange+f'{demsg.decode()}'+self.reset)
            except UnicodeDecodeError:
                print(self.orange+f'{demsg}'+self.reset)

    def DEL_aes_key(self):
        path = os.listdir(self.path['aeskey']+'/Keys')
        aespath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        count = 0
        for i in path:
            if '_aes.key' in i:
                aespath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(aespath):return self.DEL_aes_key()
        except ValueError:return self.DEL_aes_key()
        if num == 0:return
        if self.path['aeskey']+'/Keys/'+aespath[num-1] not in self.dellist:
            self.dellist.append(self.path['aeskey']+'/Keys/'+aespath[num-1])

    def DEL_aes_iv(self):
        path = os.listdir(self.path['aeskey']+'/IV')
        ivpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        count = 0
        for i in path:
            if '_iv.key' in i:
                ivpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(ivpath):return self.DEL_aes_iv()
        except ValueError:return self.DEL_aes_iv()
        if num == 0:return
        if self.path['aeskey']+'/IV/'+ivpath[num-1] not in self.dellist:
            self.dellist.append(self.path['aeskey']+'/IV/'+ivpath[num-1])

    def DEL_des_key(self):
        path = os.listdir(self.path['deskey']+'/Keys')
        despath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        count = 0
        for i in path:
            if '_des.key' in i:
                despath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(despath):return self.DEL_des_key()
        except ValueError:return self.DEL_des_key()
        if num == 0:return
        if self.path['deskey']+'/Keys/'+despath[num-1] not in self.dellist:
            self.dellist.append(self.path['deskey']+'/Keys/'+despath[num-1])

    def DEL_des_iv(self):
        path = os.listdir(self.path['deskey']+'/IV')
        ivpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        count = 0
        for i in path:
            if '_iv.key' in i:
                ivpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(ivpath):return self.DEL_des_iv()
        except ValueError:return self.DEL_des_iv()
        if num == 0:return
        if self.path['deskey']+'/IV/'+ivpath[num-1] not in self.dellist:
            self.dellist.append(self.path['deskey']+'/IV/'+ivpath[num-1])

    def DEL_des3_key(self):
        path = os.listdir(self.path['des3key']+'/Keys')
        despath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        count = 0
        for i in path:
            if '_des3.key' in i:
                despath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(despath):return self.DEL_des3_key()
        except ValueError:return self.DEL_des3_key()
        if num == 0:return
        if self.path['des3key']+'/Keys/'+despath[num-1] not in self.dellist:
            self.dellist.append(self.path['des3key']+'/Keys/'+despath[num-1])

    def DEL_des3_iv(self):
        path = os.listdir(self.path['des3key']+'/IV')
        ivpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        count = 0
        for i in path:
            if '_iv.key' in i:
                ivpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(ivpath):return self.DEL_des3_iv()
        except ValueError:return self.DEL_des3_iv()
        if num == 0:return
        if self.path['des3key']+'/IV/'+ivpath[num-1] not in self.dellist:
            self.dellist.append(self.path['des3key']+'/IV/'+ivpath[num-1])

    def DEL_rsa_public(self):
        path = os.listdir(self.path['rsakey']+'/PublicKey')
        pubpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        count = 0
        for i in path:
            if '_pub.pem' in i:
                pubpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(pubpath):return self.DEL_rsa_public()
        except ValueError:return self.DEL_rsa_public()
        if num == 0:return
        if self.path['rsakey']+'/PublicKey/'+pubpath[num-1] not in self.dellist:
            self.dellist.append(self.path['rsakey']+'/PublicKey/'+pubpath[num-1])

    def DEL_rsa_private(self):
        path = os.listdir(self.path['rsakey']+'/PrivateKey')
        privpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        count = 0
        for i in path:
            if '_priv.pem' in i:
                privpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(privpath):return self.DEL_rsa_private()
        except ValueError:return self.DEL_rsa_private()
        if num == 0:return
        if self.path['rsakey']+'/PrivateKey/'+privpath[num-1] not in self.dellist:
            self.dellist.append(self.path['rsakey']+'/PrivateKey/'+privpath[num-1])

    def DEL_aes_ctr(self):
        path = os.listdir(self.path['aes_ctr'])
        ctrpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_ctr' in path[i]:
                ctrpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(ctrpath):return self.DEL_aes_ctr()
        except ValueError:return self.DEL_aes_ctr()
        if num == 0:return
        if self.path['aes_ctr']+'/'+ctrpath[num-1] not in self.dellist:
            self.dellist.append(self.path['aes_ctr']+'/'+ctrpath[num-1])

    def DEL_aes_cbc(self):
        path = os.listdir(self.path['aes_cbc'])
        cbcpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_cbc' in path[i]:
                cbcpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(cbcpath):return self.DEL_aes_cbc()
        except ValueError:return self.DEL_aes_cbc()
        if num == 0:return
        if self.path['aes_cbc']+'/'+cbcpath[num-1] not in self.dellist:
            self.dellist.append(self.path['aes_cbc']+'/'+cbcpath[num-1])

    def DEL_aes_cfb(self):
        path = os.listdir(self.path['aes_cfb'])
        cfbpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_cfb' in path[i]:
                cfbpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(cfbpath):return self.DEL_aes_cfb()
        except ValueError:return self.DEL_aes_cfb()
        if num == 0:return
        if self.path['aes_cfb']+'/'+cfbpath[num-1] not in self.dellist:
            self.dellist.append(self.path['aes_cfb']+'/'+cfbpath[num-1])

    def DEL_aes_ofb(self):
        path = os.listdir(self.path['aes_ofb'])
        ofbpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_ofb' in path[i]:
                ofbpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(ofbpath):return self.DEL_aes_ofb()
        except ValueError:return self.DEL_aes_ofb()
        if num == 0:return
        if self.path['aes_ofb']+'/'+ofbpath[num-1] not in self.dellist:
            self.dellist.append(self.path['aes_ofb']+'/'+ofbpath[num-1])

    def DEL_aes_ecb(self):
        path = os.listdir(self.path['aes_ecb'])
        ecbpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_ecb' in path[i]:
                ecbpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(ecbpath):return self.DEL_aes_ecb()
        except ValueError:return self.DEL_aes_ecb()
        if num == 0:return
        if self.path['aes_ecb']+'/'+ecbpath[num-1] not in self.dellist:
            self.dellist.append(self.path['aes_ecb']+'/'+ecbpath[num-1])

    def DEL_des_cbc(self):
        path = os.listdir(self.path['des_cbc'])
        cbcpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_cbc' in path[i]:
                cbcpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(cbcpath):return self.DEL_des_cbc()
        except ValueError:return self.DEL_des_cbc()
        if num == 0:return
        if self.path['des_cbc']+'/'+cbcpath[num-1] not in self.dellist:
            self.dellist.append(self.path['des_cbc']+'/'+cbcpath[num-1])

    def DEL_des_ecb(self):
        path = os.listdir(self.path['des_ecb'])
        ecbpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_ecb' in path[i]:
                ecbpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(ecbpath):return self.DEL_des_ecb()
        except ValueError:return self.DEL_des_ecb()
        if num == 0:return
        if self.path['des_ecb']+'/'+ecbpath[num-1] not in self.dellist:
            self.dellist.append(self.path['des_ecb']+'/'+ecbpath[num-1])

    def DEL_des3_cbc(self):
        path = os.listdir(self.path['des3_cbc'])
        cbcpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_cbc' in path[i]:
                cbcpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(cbcpath):return self.DEL_des3_cbc()
        except ValueError:return self.DEL_des3_cbc()
        if num == 0:return
        if self.path['des3_cbc']+'/'+cbcpath[num-1] not in self.dellist:
            self.dellist.append(self.path['des3_cbc']+'/'+cbcpath[num-1])

    def DEL_des3_ecb(self):
        path = os.listdir(self.path['des3_ecb'])
        ecbpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_ecb' in path[i]:
                ecbpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(ecbpath):return self.DEL_des3_ecb()
        except ValueError:return self.DEL_des3_ecb()
        if num == 0:return
        if self.path['des3_ecb']+'/'+ecbpath[num-1] not in self.dellist:
            self.dellist.append(self.path['des3_ecb']+'/'+ecbpath[num-1])

    def DEL_rsa_data(self):
        path = os.listdir(self.path['rsa'])
        rsapath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_rsa' in path[i]:
                rsapath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(rsapath):return self.DEL_rsa_data()
        except ValueError:return self.DEL_rsa_data()
        if num == 0:return
        if self.path['rsa']+'/'+rsapath[num-1] not in self.dellist:
            self.dellist.append(self.path['rsa']+'/'+rsapath[num-1])

    def DEL_base16(self):
        path = os.listdir(self.path['b16'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_b16.bin' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_base16()
        except ValueError:return self.DEL_base16()
        if num == 0:return
        if self.path['b16']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['b16']+'/'+newpath[num-1])

    def DEL_base32(self):
        path = os.listdir(self.path['b32'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_b32.bin' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_base32()
        except ValueError:return self.DEL_base32()
        if num == 0:return
        if self.path['b32']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['b32']+'/'+newpath[num-1])

    def DEL_base64(self):
        path = os.listdir(self.path['b64'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_b64.bin' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_base64()
        except ValueError:return self.DEL_base64()
        if num == 0:return
        if self.path['b64']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['b64']+'/'+newpath[num-1])

    def DEL_base85(self):
        path = os.listdir(self.path['b85'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_b85.bin' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_base85()
        except ValueError:return self.DEL_base85()
        if num == 0:return
        if self.path['b85']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['b85']+'/'+newpath[num-1])

    def DEL_Convert_Hex(self):
        path = os.listdir(self.path['hex'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_hex.bin' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_Convert_Hex()
        except ValueError:return self.DEL_Convert_Hex()
        if num == 0:return
        if self.path['hex']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['hex']+'/'+newpath[num-1])

    def DEL_Convert_Base64(self):
        path = os.listdir(self.path['base64'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_base.bin' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_Convert_Base64()
        except ValueError:return self.DEL_Convert_Base64()
        if num == 0:return
        if self.path['base64']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['base64']+'/'+newpath[num-1])

    def DEL_Convert_QP(self):
        path = os.listdir(self.path['qp'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_qp.bin' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_Convert_QP()
        except ValueError:return self.DEL_Convert_QP()
        if num == 0:return
        if self.path['qp']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['qp']+'/'+newpath[num-1])

    def DEL_Convert_UU(self):
        path = os.listdir(self.path['uu'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            if '_uu.bin' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_Convert_UU()
        except ValueError:return self.DEL_Convert_UU()
        if num == 0:return
        if self.path['uu']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['uu']+'/'+newpath[num-1])

    def DEL_File_Data(self):
        path = os.listdir(self.path['file'])
        newpath = []
        print('which data do you want to delete\n你要刪除哪個數據?\n0.Cancel')
        for i in range(len(path)):
            newpath.append(path[i])
            print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.DEL_File_Data()
        except ValueError:return self.DEL_File_Data()
        if num == 0:return
        if self.path['file']+'/'+newpath[num-1] not in self.dellist:
            self.dellist.append(self.path['file']+'/'+newpath[num-1])

    def DEL_execute(self):
        while 1:
            print('Are you sure you want to delete the following data?\n確認刪除以下數據?\n1.y\n2.n\n')
            for i in self.dellist:
                print(i)
            swit = input('>>>')
            if swit.casefold() in ['y','1']:
                for i in self.dellist:
                    print(f'Deleting file -> {i}')
                    os.remove(i)
                return True
            elif swit.casefold() in ['n','2']:
                self.dellist.clear()
                return False

    def DEL_data(self):
        self.filedata[0] = self.set_print[0]
        while 1:
            listdata = '\n'.join([i for i in self.filedata])
            try:
                data = int(input('What kind of data do you want to delete?\n你想要刪除哪種數據?\n'+listdata))
            except ValueError:return self.DEL_data()
            if data == 1:
                self.DEL_aes_key()
            elif data == 2:
                self.DEL_aes_iv()
            elif data == 3:
                self.DEL_des_key()
            elif data == 4:
                self.DEL_des_iv()
            elif data == 5:
                self.DEL_des3_key()
            elif data == 6:
                self.DEL_des3_iv()
            elif data == 7:
                self.DEL_rsa_public()
            elif data == 8:
                self.DEL_rsa_private()
            elif data == 9:
                self.DEL_aes_ctr()
            elif data == 10:
                self.DEL_aes_cbc()
            elif data == 11:
                self.DEL_aes_cfb()
            elif data == 12:
                self.DEL_aes_ofb()
            elif data == 13:
                self.DEL_aes_ecb()
            elif data == 14:
                self.DEL_des_cbc()
            elif data == 15:
                self.DEL_des_ecb()
            elif data == 16:
                self.DEL_des3_cbc()
            elif data == 17:
                self.DEL_des3_ecb()
            elif data == 18:
                self.DEL_rsa_data()
            elif data == 19:
                self.DEL_base16()
            elif data == 20:
                self.DEL_base32()
            elif data == 21:
                self.DEL_base64()
            elif data == 22:
                self.DEL_base85()
            elif data == 23:
                self.DEL_Convert_Hex()
            elif data == 24:
                self.DEL_Convert_Base64()
            elif data == 25:
                self.DEL_Convert_QP()
            elif data == 26:
                self.DEL_Convert_UU()
            elif data == 27:
                self.DEL_File_Data()
            elif data == 0:
                if self.DEL_execute():
                    break

    def READ_aes_key(self):
        path = os.listdir(self.path['aeskey']+'/Keys')
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        count = 0
        for i in path:
            if '_aes.key' in i:
                newpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_aes_key()
        except ValueError:return self.READ_aes_key()
        if num == 0:return
        return CryptoAES.File(self.path['aeskey']+'/Keys/'+newpath[num-1]).read()

    def READ_aes_iv(self):
        path = os.listdir(self.path['aeskey']+'/IV')
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        count = 0
        for i in path:
            if '_iv.key' in i:
                newpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_aes_iv()
        except ValueError:return self.READ_aes_iv()
        if num == 0:return
        return CryptoAES.File(self.path['aeskey']+'/IV/'+newpath[num-1]).read()

    def READ_des_key(self):
        path = os.listdir(self.path['deskey']+'/Keys')
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        count = 0
        for i in path:
            if '_des.key' in i:
                newpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_des_key()
        except ValueError:return self.READ_des_key()
        if num == 0:return
        return CryptoDES.File(self.path['deskey']+'/Keys/'+newpath[num-1]).read()

    def READ_des_iv(self):
        path = os.listdir(self.path['deskey']+'/IV')
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        count = 0
        for i in path:
            if '_iv.key' in i:
                newpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_des_iv()
        except ValueError:return self.READ_des_iv()
        if num == 0:return
        return CryptoDES.File(self.path['deskey']+'/IV/'+newpath[num-1]).read()

    def READ_des3_key(self):
        path = os.listdir(self.path['des3key']+'/Keys')
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        count = 0
        for i in path:
            if '_des3.key' in i:
                newpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_des3_key()
        except ValueError:return self.READ_des3_key()
        if num == 0:return
        return CryptoDES.File(self.path['des3key']+'/Keys/'+newpath[num-1]).read()

    def READ_des3_iv(self):
        path = os.listdir(self.path['des3key']+'/IV')
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        count = 0
        for i in path:
            if '_iv.key' in i:
                newpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_des3_iv()
        except ValueError:return self.READ_des3_iv()
        if num == 0:return
        return CryptoDES.File(self.path['des3key']+'/IV/'+newpath[num-1]).read()

    def READ_rsa_public(self):
        path = os.listdir(self.path['rsakey']+'/PublicKey')
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        count = 0
        for i in path:
            if '_pub.pem' in i:
                newpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_rsa_public()
        except ValueError:return self.READ_rsa_public()
        if num == 0:return
        pub,_ = CryptoRSA.File(PublicPath=self.path['rsakey']+'/PublicKey/'+newpath[num-1]).read()
        return pub

    def READ_rsa_private(self):
        path = os.listdir(self.path['rsakey']+'/PrivateKey')
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        count = 0
        for i in path:
            if '_priv.pem' in i:
                newpath.append(i)
                print(f'{count+1}.{i}')
                count += 1
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_rsa_private()
        except ValueError:return self.READ_rsa_private()
        if num == 0:return
        _,priv = CryptoRSA.File(PrivatePath=self.path['rsakey']+'/PrivateKey/'+newpath[num-1]).read()
        return priv

    def READ_aes_ctr(self):
        path = os.listdir(self.path['aes_ctr'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_ctr' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_aes_ctr()
        except ValueError:return self.READ_aes_ctr()
        if num == 0:return
        return CryptoAES.File(self.path['aes_ctr']+'/'+newpath[num-1]).read()

    def READ_aes_cbc(self):
        path = os.listdir(self.path['aes_cbc'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_cbc' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_aes_cbc()
        except ValueError:return self.READ_aes_cbc()
        if num == 0:return
        return CryptoAES.File(self.path['aes_cbc']+'/'+newpath[num-1]).read()

    def READ_aes_cfb(self):
        path = os.listdir(self.path['aes_cfb'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_cfb' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_aes_cfb()
        except ValueError:return self.READ_aes_cfb()
        if num == 0:return
        return CryptoAES.File(self.path['aes_cfb']+'/'+newpath[num-1]).read()

    def READ_aes_ofb(self):
        path = os.listdir(self.path['aes_ofb'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_ofb' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_aes_ofb()
        except ValueError:return self.READ_aes_ofb()
        if num == 0:return
        return CryptoAES.File(self.path['aes_ofb']+'/'+newpath[num-1]).read()

    def READ_aes_ecb(self):
        path = os.listdir(self.path['aes_ecb'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_ecb' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_aes_ecb()
        except ValueError:return self.READ_aes_ecb()
        if num == 0:return
        return CryptoAES.File(self.path['aes_ecb']+'/'+newpath[num-1]).read()

    def READ_des_cbc(self):
        path = os.listdir(self.path['des_cbc'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_cbc' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_des_cbc()
        except ValueError:return self.READ_des_cbc()
        if num == 0:return
        return CryptoDES.File(self.path['des_cbc']+'/'+newpath[num-1]).read()

    def READ_des_ecb(self):
        path = os.listdir(self.path['des_ecb'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_ecb' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_des_ecb()
        except ValueError:return self.READ_des_ecb()
        if num == 0:return
        return CryptoDES.File(self.path['des_ecb']+'/'+newpath[num-1]).read()

    def READ_des3_cbc(self):
        path = os.listdir(self.path['des3_cbc'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_cbc' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_des3_cbc()
        except ValueError:return self.READ_des3_cbc()
        if num == 0:return
        return CryptoDES.File(self.path['des3_cbc']+'/'+newpath[num-1]).read()

    def READ_des3_ecb(self):
        path = os.listdir(self.path['des3_ecb'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_ecb' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_des3_ecb()
        except ValueError:return self.READ_des3_ecb()
        if num == 0:return
        return CryptoDES.File(self.path['des3_ecb']+'/'+newpath[num-1]).read()

    def READ_rsa_data(self):
        path = os.listdir(self.path['rsa'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_rsa' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_rsa_data()
        except ValueError:return self.READ_rsa_data()
        if num == 0:return
        return CryptoRSA.TextFile(self.path['rsa']+'/'+newpath[num-1]).read()

    def READ_base16(self):
        path = os.listdir(self.path['b16'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_b16' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_base16()
        except ValueError:return self.READ_base16()
        if num == 0:return
        return Crypt.File(self.path['b16']+'/'+newpath[num-1]).read()

    def READ_base32(self):
        path = os.listdir(self.path['b32'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_b32' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_base32()
        except ValueError:return self.READ_base32()
        if num == 0:return
        return Crypt.File(self.path['b32']+'/'+newpath[num-1]).read()

    def READ_base64(self):
        path = os.listdir(self.path['b64'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_b64' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_base64()
        except ValueError:return self.READ_base64()
        if num == 0:return
        return Crypt.File(self.path['b64']+'/'+newpath[num-1]).read()

    def READ_base85(self):
        path = os.listdir(self.path['b85'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_b85' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_base85()
        except ValueError:return self.READ_base85()
        if num == 0:return
        return Crypt.File(self.path['b85']+'/'+newpath[num-1]).read()

    def READ_Convert_Hex(self):
        path = os.listdir(self.path['hex'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_hex' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_Convert_Hex()
        except ValueError:return self.READ_Convert_Hex()
        if num == 0:return
        return Crypt.File(self.path['hex']+'/'+newpath[num-1]).read()

    def READ_Convert_Base64(self):
        path = os.listdir(self.path['base64'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_base' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_Convert_Base64()
        except ValueError:return self.READ_Convert_Base64()
        if num == 0:return
        return Crypt.File(self.path['base64']+'/'+newpath[num-1]).read()

    def READ_Convert_QP(self):
        path = os.listdir(self.path['qp'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_qp' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_Convert_QP()
        except ValueError:return self.READ_Convert_QP()
        if num == 0:return
        return Crypt.File(self.path['qp']+'/'+newpath[num-1]).read()

    def READ_Convert_UU(self):
        path = os.listdir(self.path['uu'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            if '_uu' in path[i]:
                newpath.append(path[i])
                print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_Convert_UU()
        except ValueError:return self.READ_Convert_UU()
        if num == 0:return
        return Crypt.File(self.path['uu']+'/'+newpath[num-1]).read()

    def READ_File_Data(self):
        path = os.listdir(self.path['file'])
        newpath = []
        print('which data do you want to read\n你要讀取哪個數據\n0.Cancel')
        for i in range(len(path)):
            newpath.append(path[i])
            print(f'{i+1}.{path[i]}')
        try:
            num = int(input('>>>'))
            if num > len(newpath):return self.READ_File_Data()
        except ValueError:return self.READ_File_Data()
        if num == 0:return
        return Crypt.File(self.path['file']+'/'+newpath[num-1]).read()

    def READ_data(self):
        self.filedata[0] = self.set_print[2]
        while 1:
            listdata = '\n'.join([i for i in self.filedata])
            try:
                data = int(input('What kind of data do you want to delete?\n你想要讀取哪種數據?\n'+listdata))
            except ValueError:return self.READ_data()
            if data == 1:
                print(f'\n{self.READ_aes_key()}\n')
            elif data == 2:
                print(f'\n{self.READ_aes_iv()}\n')
            elif data == 3:
                print(f'\n{self.READ_des_key()}\n')
            elif data == 4:
                print(f'\n{self.READ_des_iv()}\n')
            elif data == 5:
                print(f'\n{self.READ_des3_key()}\n')
            elif data == 6:
                print(f'\n{self.READ_des3_iv()}\n')
            elif data == 7:
                print(f'\n{self.READ_rsa_public()}\n')
            elif data == 8:
                print(f'\n{self.READ_rsa_private()}\n')
            elif data == 9:
                print(f'\n{self.READ_aes_ctr()}\n')
            elif data == 10:
                print(f'\n{self.READ_aes_cbc()}\n')
            elif data == 11:
                print(f'\n{self.READ_aes_cfb()}\n')
            elif data == 12:
                print(f'\n{self.READ_aes_ofb()}\n')
            elif data == 13:
                print(f'\n{self.READ_aes_ecb()}\n')
            elif data == 14:
                print(f'\n{self.READ_des_cbc()}\n')
            elif data == 15:
                print(f'\n{self.READ_des_ecb()}\n')
            elif data == 16:
                print(f'\n{self.READ_des3_cbc()}\n')
            elif data == 17:
                print(f'\n{self.READ_des3_ecb()}\n')
            elif data == 18:
                print(f'\n{self.READ_rsa_data()}\n')
            elif data == 19:
                print(f'\n{self.READ_base16()}\n')
            elif data == 20:
                print(f'\n{self.READ_base32()}\n')
            elif data == 21:
                print(f'\n{self.READ_base64()}\n')
            elif data == 22:
                print(f'\n{self.READ_base85()}\n')
            elif data == 23:
                print(f'\n{self.READ_Convert_Hex()}\n')
            elif data == 24:
                print(f'\n{self.READ_Convert_Base64()}\n')
            elif data == 25:
                print(f'\n{self.READ_Convert_QP()}\n')
            elif data == 26:
                print(f'\n{self.READ_Convert_UU()}\n')
            elif data == 27:
                print(f'\n{self.READ_File_Data()}\n')
            elif data == 0:
                break
    
    def EDIT_data(self):
        self.filedata[0] = self.set_print[2]
        while 1:
            listdata = '\n'.join([i for i in self.filedata])
            try:
                data = int(input('What kind of data do you want to edit?\n你想要修改哪種數據?\n'+listdata))
            except ValueError:return self.EDIT_data()
            if data == 0:return
            paths = os.listdir(self.document[data][1])
            newpath = []
            count = 1
            print('which filename do you want to change\n你要更改哪個檔名?\n0.Cancel')
            for i in range(len(paths)):
                if paths[i].endswith(self.document[data][0]):
                    newpath.append(paths[i])
                    print(f'{count}.{paths[i]}')
                    count += 1
            break
        while 1:
            try:
                num = int(input('>>>'))
                if num > len(newpath):continue
                if num == 0:return self.EDIT_data()
            except ValueError:continue
            else:break
        newname = input('Enter your new filename\n輸入你的新檔名\n>>>')
        newname = newname.rstrip(self.document[data][0])
        oldfile = self.document[data][1]+'/'+newpath[num-1]
        newfile = self.document[data][1]+'/'+newname+self.document[data][0]
        while 1:
            rename = input(f'Old name:{oldfile}\nNew name:{newfile}\nAre you sure you want to change?\n確定更改嗎?\n1.y\n2.n\n>>>')
            if rename.casefold() in ['y','1']:
                os.rename(oldfile,newfile)
                return self.EDIT_data()
            elif rename.casefold() in ['n','2']:
                return self.EDIT_data()

def Initial():
    news = RunCrypt()
    typ = str()
    isnew = False
    isfirst = True
    swit = int()
    METHOD = 0

    while 1:
        print('Enter key type,delete data or read data')
        print('輸入密鑰類型,刪除資料或者讀取資料')
        print(news.white+'0.EXIT'+news.reset)
        print(news.red+'1.AES'+news.reset)
        print(news.orange+'2.DES'+news.reset)
        print(news.yellow+'3.DES3'+news.reset)
        print(news.green+'4.RSA'+news.reset)
        print(news.cyan+'5.BASE64'+news.reset)
        print(news.blue+'6.CONVERT'+news.reset)
        print(news.purple+'7.READ'+news.reset)
        print(news.white+'8.DEL'+news.reset)
        print(news.grey+'9.EDIT'+news.reset)
        print(news.grey+'>>>',end=''+news.reset)
        keytype = input()
        if keytype.casefold().strip() in ['exit','0']:
            os._exit(0)
        elif keytype.casefold().strip() in ['aes','1']:
            typ = 'AES'
            break
        elif keytype.casefold().strip() in ['des','2']:
            typ = 'DES'
            break
        elif keytype.casefold().strip() in ['des','3']:
            typ = 'DES3'
            break
        elif keytype.casefold().strip() in ['rsa','4']:
            typ = 'RSA'
            break
        elif keytype.casefold().strip() in ['base64','5']:
            typ = 'BASE64'
            break
        elif keytype.casefold().strip() in ['convert','6']:
            typ = 'CONVERT'
            break
        elif keytype.casefold().strip() in ['read','7']:
            typ = 'READ'
            break
        elif keytype.casefold().strip() in ['del','8']:
            typ = 'DEL'
            break
        elif keytype.casefold().strip() in ['edit','9']:
            typ = 'EDIT'
            break

    if typ == 'DEL':
        news.DEL_data()
    elif typ == 'READ':
        news.READ_data()
    elif typ == 'EDIT':
        news.EDIT_data()
    else:
        while 1:
            if typ in ['AES','DES','DES3','RSA']:
                print(news.white+'Do you need to create a key?\n您需要創建密鑰嗎?'+news.reset)
                print(news.cyan+'1.y'+news.reset)
                print(news.red+'2.n'+news.reset)
                print(news.grey+'>>>'+news.reset,end='')
                create = input()
                if create.casefold() in ['y','1']:
                    if typ == 'AES':
                        news.AEScreate()
                        isnew = True
                        break
                    elif typ == 'DES':
                        news.DEScreate()
                        isnew = True
                        break
                    elif typ == 'DES3':
                        news.DES3create()
                        isnew = True
                        break
                    elif typ == 'RSA':
                        news.RSAcreate()
                        isnew = True
                        break
                elif create.casefold() in ['n','2']:
                    if typ == 'AES':
                        news.AESload()
                        break
                    elif typ == 'DES':
                        news.DESload()
                        break
                    elif typ == 'DES3':
                        news.DES3load()
                        break
                    elif typ == 'RSA':
                        news.RSAload()
                        break
            else:
                break

        while 1:
            if typ == 'AES' and isnew:
                try:
                    print('Enter yout encrypt type')
                    print('輸入您的加密類型')
                    print(news.red+'1.CTR'+news.reset)
                    print(news.orange+'2.CBC'+news.reset)
                    print(news.yellow+'3.CFB'+news.reset)
                    print(news.green+'4.OFB'+news.reset)
                    print(news.cyan+'5.ECB'+news.reset)
                    print(news.grey+'>>>'+news.reset,end='')
                    entype = int(input())
                except ValueError:continue
                if entype in [1,2,3,4,5]:
                    METHOD = entype
                    swit = 1
                    break

            elif typ == 'DES' and isnew or typ == 'DES3' and isnew:
                try:
                    entype = int(input('Enter yout encrypt type\n輸入您的加密類型\n1.CBC\n2.ECB\n>>>'))
                except ValueError:continue
                if entype in [1,2]:
                    METHOD = entype
                    swit = 1
                    break

            elif typ == 'RSA' and isnew:
                swit = 1
                METHOD = 1
                break

            elif isnew == False and isfirst == True:
                try:
                    print('Encrypt or Decrypt?\n加密還是解密?')
                    print(news.red+'1.encrypt 加密'+news.reset)
                    print(news.cyan+'2.decrypt 解密'+news.reset)
                    print(news.grey+'>>>'+news.reset,end='')
                    _swit = int(input())
                except ValueError:continue
                if _swit in [1,2]:
                    swit = _swit
                    isfirst = False

            elif METHOD == 0:
                if typ == 'AES':
                    try:
                        print(f'Enter your {"encrypt" if swit == 1 else "decrypt"} type\n輸入您的 {"加密" if swit == 1 else "解密"} 類型')
                        print(news.red+'1.CTR'+news.reset)
                        print(news.orange+'2.CBC'+news.reset)
                        print(news.yellow+'3.CFB'+news.reset)
                        print(news.green+'4.OFB'+news.reset)
                        print(news.cyan+'5.ECB'+news.reset)
                        print(news.grey+'>>>'+news.reset,end='')
                        method = int(input())
                    except ValueError:continue
                    if method in [1,2,3,4,5]:
                        METHOD = method
                        break
                elif typ == 'DES' or typ == 'DES3':
                    try:
                        print(f'Enter your {"encrypt" if swit == 1 else "decrypt"} type\n輸入您的 {"加密" if swit == 1 else "解密"} 類型')
                        print(news.red+'1.CBC'+news.reset)
                        print(news.orange+'2.ECB'+news.reset)
                        print(news.grey+'>>>'+news.reset,end='')
                        method = int(input())
                    except ValueError:continue
                    if method in [1,2]:
                        METHOD = method
                        break
                elif typ == 'RSA':
                    break
                elif typ == 'BASE64':
                    try:
                        print(f'Enter your {"encrypt" if swit == 1 else "decrypt"} type\n輸入您的 {"加密" if swit == 1 else "解密"} 類型')
                        print(news.red+'1.Base16'+news.reset)
                        print(news.orange+'2.Base32'+news.reset)
                        print(news.yellow+'3.Base64'+news.reset)
                        print(news.green+'4.Base85'+news.reset)
                        print(news.grey+'>>>'+news.reset,end='')
                        method = int(input())
                    except ValueError:continue
                    if method in [1,2,3,4]:
                        METHOD = method
                        break
                elif typ == 'CONVERT':
                    try:
                        print(f'Enter your {"encrypt" if swit == 1 else "decrypt"} type\n輸入您的 {"加密" if swit == 1 else "解密"} 類型')
                        print(news.red+'1.Hex'+news.reset)
                        print(news.orange+'2.Base64'+news.reset)
                        print(news.yellow+'3.QP'+news.reset)
                        print(news.green+'4.UU'+news.reset)
                        print(news.grey+'>>>'+news.reset,end='')
                        method = int(input())
                    except ValueError:continue
                    if method in [1,2,3,4]:
                        METHOD = method
                        break

        if typ == 'AES' and swit == 1:
            entext = news.Encrypto_Data_Input()
            if METHOD == 1:
                news.AES_CTR_encrypt(entext)
            elif METHOD == 2:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.AES_CBC_encrypt(entext)
            elif METHOD == 3:
                while 1:
                    try:
                        size = int(input('Enter your CFB segment size(Must not be greater than 16,The segment size must be divisible by the string)\n輸入您的 CFB 段大小（不得大於 16，段大小必須能被字符串整除）\n>>>'))
                    except ValueError:continue
                    if len(entext) % size == 0 and size <= 16:
                        news.size = size
                        break
                news.AES_CFB_encrypt(entext)
            elif METHOD == 4:
                news.AES_OFB_encrypt(entext)
            elif METHOD == 5:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.AES_ECB_encrypt(entext)
        elif typ == 'AES' and swit == 2:
            if METHOD == 1:
                news.AES_CTR_decrypt()
            elif METHOD == 2:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.AES_CBC_decrypt()
            elif METHOD == 3:
                while 1:
                    try:
                        size = int(input('Enter your CFB segment size(Must not be greater than 16,The segment size must be divisible by the string)\n輸入您的 CFB 段大小（不得大於 16，段大小必須能被字符串整除）\n>>>'))
                    except ValueError:continue
                    if size <= 16:
                        news.size = int(size)
                        break
                news.AES_CFB_decrypt()
            elif METHOD == 4:
                news.AES_OFB_decrypt()
            elif METHOD == 5:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.AES_ECB_decrypt()

        elif typ == 'DES' and swit == 1:
            entext = news.Encrypto_Data_Input()
            if METHOD == 1:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.DES_CBC_encrypt(entext)
            elif METHOD == 2:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.DES_ECB_encrypt(entext)
        elif typ == 'DES' and swit == 2:
            if METHOD == 1:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.DES_CBC_decrypt()
            elif METHOD == 2:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.DES_ECB_decrypt()

        elif typ == 'DES3' and swit == 1:
            entext = news.Encrypto_Data_Input()
            if METHOD == 1:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.DES3_CBC_encrypt(entext)
            elif METHOD == 2:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.DES3_ECB_encrypt(entext)
        elif typ == 'DES3' and swit == 2:
            if METHOD == 1:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.DES3_CBC_decrypt()
            elif METHOD == 2:
                while 1:
                    pad = input('Do you need to add padding?\n你需要加入填充嗎?\n1.y\n2.n\n>>>')
                    if pad.casefold() in ['y','1']:
                        news.padding = True
                        break
                    elif pad.casefold() in ['n','2']:
                        break
                news.DES3_ECB_decrypt()

        elif typ == 'RSA' and swit == 1:
            entext = news.Encrypto_Data_Input()
            news.RSA_encrypt(entext)
        elif typ == 'RSA' and swit == 2:
            news.RSA_decrypt()

        elif typ == 'BASE64' and swit == 1:
            entext = news.Encrypto_Data_Input()
            if METHOD == 1:
                news.Base16_encrypt(entext)
            elif METHOD == 2:
                news.Base32_encrypt(entext)
            elif METHOD == 3:
                news.Base64_encrypt(entext)
            elif METHOD == 4:
                news.Base85_encrypt(entext)
        elif typ == 'BASE64' and swit == 2:
            if METHOD == 1:
                news.Base16_decrypt()
            elif METHOD == 2:
                news.Base32_decrypt()
            elif METHOD == 3:
                news.Base64_decrypt()
            elif METHOD == 4:
                news.Base85_decrypt()
        elif typ == 'CONVERT' and swit == 1:
            entext = news.Encrypto_Data_Input()
            if METHOD == 1:
                news.Convert_Hex_encrypt(entext)
            elif METHOD == 2:
                news.Convert_Base64_encrypt(entext)
            elif METHOD == 3:
                news.Convert_QP_encrypt(entext)
            elif METHOD == 4:
                news.Convert_UU_encrypt(entext)
        elif typ == 'CONVERT' and swit == 2:
            if METHOD == 1:
                news.Convert_Hex_decrypt()
            elif METHOD == 2:
                news.Convert_Base64_decrypt()
            elif METHOD == 3:
                news.Convert_QP_decrypt()
            elif METHOD == 4:
                news.Convert_UU_decrypt()

    print(news.yellow+f'\nReturn to the initial state after 3 seconds...\n3秒後回到初始狀態...'+news.reset)
    for _ in range(30):
        print(news.cyan+'▉'+news.reset,end='',flush=True)
        time.sleep(0.1)
    print('\n')
    return Initial()

if __name__ == '__main__':
    if len(sys.argv) > 1:
        if sys.argv[1].casefold() == 'aes':
            RunCrypt().AEScreate()
        elif sys.argv[1].casefold() == 'des':
            RunCrypt().DEScreate()
        elif sys.argv[1].casefold() == 'des3':
            RunCrypt().DES3create()
        elif sys.argv[1].casefold() == 'rsa':
            RunCrypt().RSAcreate()
        elif sys.argv[1].casefold() == 'del':
            RunCrypt().DEL_data()
        elif sys.argv[1].casefold() == 'read':
            RunCrypt().READ_data()
        elif sys.argv[1].casefold() == 'edit':
            RunCrypt().EDIT_data()
        else:
            pt = CryptoCanvas.Print
            print(pt.red()+'Linux   -> python3 UI.py aes'+pt.attr('reset'))
            print(pt.orange()+'Linux   -> python3 UI.py des'+pt.attr('reset'))
            print(pt.yellow()+'Linux   -> python3 UI.py des3'+pt.attr('reset'))
            print(pt.green()+'Linux   -> python3 UI.py rsa'+pt.attr('reset'))
            print(pt.cyan()+'Linux   -> python3 UI.py del'+pt.attr('reset'))
            print(pt.blue()+'Linux   -> python3 UI.py read'+pt.attr('reset'))
            print(pt.purple()+'Linux   -> python3 UI.py edit'+pt.attr('reset'))
            print(pt.grey()+''.center(50,'-')+pt.attr('reset'))
            print(pt.red()+'Windows -> py UI.py aes'+pt.attr('reset'))
            print(pt.orange()+'Windows -> py UI.py des'+pt.attr('reset'))
            print(pt.yellow()+'Windows -> py UI.py des3'+pt.attr('reset'))
            print(pt.green()+'Windows -> py UI.py rsa'+pt.attr('reset'))
            print(pt.cyan()+'Windows -> py UI.py del'+pt.attr('reset'))
            print(pt.blue()+'Windows -> py UI.py read'+pt.attr('reset'))
            print(pt.purple()+'Windows -> py UI.py edit'+pt.attr('reset'))
            print(pt.fg(11)+f'\nReturn to the initial state after 3 seconds...\n3秒後回到初始狀態...'+pt.attr('reset'))
            for _ in range(30):
                print(pt.fg(6)+'▉'+pt.attr(0),end='',flush=True)
                time.sleep(0.1)
            print('\n')
    else:
        Initial()