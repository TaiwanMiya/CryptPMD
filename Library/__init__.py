from Library.AesForm import AES
from Library.DesForm import DES
from Library.Des3Form import DES3
from Library.RsaForm import RSA
from Library.UuidForm import UUID
from Library.HashForm import HASH
from Library.QrForm import QR
from Crypt.CryptoApi import (
    CryptoBase64,
    CryptoConvert,
    File
)

__all__ = ['AesForm']

def DealWithEncryptionMethod(encryption):
    if encryption == 'Base16':
        encryption = CryptoBase64.Base16
    elif encryption == 'Base32':
        encryption = CryptoBase64.Base32
    elif encryption == 'Base64':
        encryption = CryptoBase64.Base64
    elif encryption == 'Base85':
        encryption = CryptoBase64.Base85
    elif encryption == 'ConvertHex':
        encryption = CryptoConvert.HEX
    elif encryption == 'ConvertBase64':
        encryption = CryptoConvert.BASE64
    elif encryption == 'ConvertQP':
        encryption = CryptoConvert.QP
    elif encryption == 'ConvertUU':
        encryption = CryptoConvert.UU
    return encryption