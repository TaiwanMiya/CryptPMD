from Crypt.CryptoApi import (
    CryptoUid,
    File
)

class UUID:

    def Guid1(filename=None):
        uid = CryptoUid.Get().date()
        if not filename:
            path = f'Data/UUID/UUID1/{str(uid)}'
        else:
            path = f'File/{filename}'
        File(path,str(uid)).write()
        print(str(uid))
        return path

    def Guid3(data,content,filename=None):
        content = ' '.join([i for i in content.split('+')])
        uid = CryptoUid.Get(data,content).md5()
        if not filename:
            path = f'Data/UUID/UUID3/{str(uid)}'
        else:
            path = f'File/{filename}'
        File(path,str(uid)).write()
        print(str(uid))
        return path

    def Guid4(filename=None):
        uid = CryptoUid.Get().random()
        if not filename:
            path = f'Data/UUID/UUID4/{str(uid)}'
        else:
            path = f'File/{filename}'
        File(path,str(uid)).write()
        print(str(uid))
        return path

    def Guid5(data,content,filename=None):
        content = ' '.join([i for i in content.split('+')])
        uid = CryptoUid.Get(data,content).sha1()
        if not filename:
            path = f'Data/UUID/UUID5/{str(uid)}'
        else:
            path = f'File/{filename}'
        File(path,str(uid)).write()
        print(str(uid))
        return path
