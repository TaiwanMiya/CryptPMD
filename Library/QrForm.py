from Crypt.QR import QRCode
from Crypt.CryptoApi import (
    Encoding,
    File
)

class QR:

    def show(content:str,data:str,encoding=Encoding.UTF8.name,zone=4):
        qr = QRCode(content.replace('(+)',' ').rstrip(),encoding=encoding)
        data = data.split(':')
        mg = [int(i) for i in data[0].split(',')]
        bg = [int(i) for i in data[1].split(',')]
        scale = int(data[2])
        zone = int(zone) if zone != None else 4
        qr.show(wait=0.1,scale=scale,module_color=(mg[0],mg[1],mg[2]),background=(bg[0],bg[1],bg[2]),quiet_zone=zone)
        return

    def png(filename,content:str,data:str,encoding=Encoding.UTF8.name,zone=4):
        qr = QRCode(content.replace('(+)',' ').rstrip(),encoding=encoding)
        data = data.split(':')
        mg = [int(i) for i in data[0].split(',')]
        bg = [int(i) for i in data[1].split(',')]
        scale = int(data[2])
        zone = int(zone) if zone != None else 4
        path = f'Data\\QR\\PNG\\{filename}.png'
        qr.png(file=path,scale=scale,module_color=(mg[0],mg[1],mg[2]),background=(bg[0],bg[1],bg[2]),quiet_zone=zone)
        return path

    def svg(filename,content:str,data:str,encoding=Encoding.UTF8.name,zone=4):
        qr = QRCode(content.replace('(+)',' ').rstrip(),encoding=encoding)
        data = data.split(':')
        mg = [int(i) for i in data[0].split(',')]
        bg = [int(i) for i in data[1].split(',')]
        scale = int(data[2])
        zone = int(zone) if zone != None else 4
        path = f'Data\\QR\\SVG\\{filename}.svg'
        mg = '#' + ''.join(['%x' % i for i in mg])
        bg = '#' + ''.join(['%x' % i for i in bg])
        qr.svg(file=path,scale=scale,module_color=mg,background=bg,quiet_zone=zone)
        return path

    def eps(filename,content:str,data:str,encoding=Encoding.UTF8.name,zone=4):
        qr = QRCode(content.replace('(+)',' ').rstrip(),encoding=encoding)
        data = data.split(':')
        mg = [int(i) for i in data[0].split(',')]
        bg = [int(i) for i in data[1].split(',')]
        scale = int(data[2])
        zone = int(zone) if zone != None else 4
        path = f'Data\\QR\\EPS\\{filename}.eps'
        qr.eps(file=path,scale=scale,module_color=(mg[0],mg[1],mg[2]),background=(bg[0],bg[1],bg[2]),quiet_zone=zone)
        return path

    def txt(filename,content:str,encoding=Encoding.UTF8.name,zone=4):
        qr = QRCode(content.replace('(+)',' ').rstrip(),encoding=encoding)
        zone = int(zone) if zone != None else 4
        path = f'Data\\QR\\TXT\\{filename}.txt'
        string = qr.text(zone)
        File(path,string).write()
        print(string)
        return path

    def xbm(filename,content:str,data:str,encoding=Encoding.UTF8.name,zone=4):
        qr = QRCode(content.replace('(+)',' ').rstrip(),encoding=encoding)
        data = int(data)
        zone = int(zone) if zone != None else 4
        path = f'Data\\QR\\XBM\\{filename}.xbm'
        string = qr.xbm(scale=data,quiet_zone=zone)
        File(path,string).write()
        print(string)
        return path