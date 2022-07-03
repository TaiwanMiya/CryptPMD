using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Method
{
    public enum EncodingItems
    {
        None    = 0x00,
        ASCII   = 0x01,
        UTF8    = 0x02,
        UTF16   = 0x04,
        UTF32   = 0x08
    }

    public enum EncryptionCodings
    {
        None            = 0x00,
        Base16          = 0x01,
        Base32          = 0x02,
        Base64          = 0x04,
        Base85          = 0x08,
        ConvertHex      = 0x10,
        ConvertBase64   = 0x20,
        ConvertQP       = 0x40,
        ConvertUU       = 0x80
    }

    public enum ErrorType
    {
        None                = 0x00,
        strict              = 0x01,
        ignore              = 0x02,
        replace             = 0x04,
        backslashreplace    = 0x08,
        surrogateescape     = 0x10
    }

    public enum CryptItemsValue
    {
        cryption,
        method,
        filename,
        encoding,
        encryption,
        key,
        iv,
        pub,
        priv,
        text,
        message,
        errors,
    }

    public enum AESname
    {
        CTR = 0x01,
        CBC = 0X02,
        CFB = 0X04,
        OFB = 0X08,
        ECB = 0x10
    }

    public enum DESname
    {
        CBC = 0x01,
        ECB = 0x02
    }

    public enum RSAname
    {
        RSA = 0x01
    }

    public enum UUIDname
    {
        date    = 0x01,
        md5     = 0x02,
        random  = 0x04,
        sha1    = 0x08,
    }

    public enum HASHname
    {
        md5     = 0x01,
        sha1    = 0x02,
        sha224  = 0x04,
        sha256  = 0x08,
        sha384  = 0x10,
        sha512  = 0x20,
    }

    public enum QRname
    {
        show    = 0x01,
        png     = 0x02,
        svg     = 0x04,
        eps     = 0x08,
        txt     = 0x10,
        xbm     = 0x20,
    }

    public class Format
    {
        public static string[] CryptoStringType = new string[]
        {
            "File / 檔案",
            "String / 字串"
        };

        /// <summary>
        /// 指令前綴
        /// </summary>
        public static string Command
        {
            get
            {
                string setting = $"set PATH={Terminal.GetRouteResult("python")};%PATH%";
                return $"{setting}\ncd " + ReadWrite.MainPath + "\n" + Terminal.py + " ";
            }
        }

        /// <summary>
        /// 傳入參數
        /// </summary>
        public static string[] CryptItems{ get; set; } = new string[13];

        /// <summary>
        /// 執行Form.py,且傳入參數
        /// </summary>
        public static string CryptStart
        {
            get
            {
                string results = string.Empty;
                for (int i = 0;i < CryptItems.Length; i++)
                {
                    if (CryptItems[i] != null)
                    {
                        results += CryptItems[i];
                    }
                    else
                    {
                        results += "None";
                    }
                    results += " ";
                }
                CryptItems = new string[13];
                return Command + results.Trim();
            }
        }
    }

    public class AES_Format
    {
        public static string[] Items { get;} = new string[]
        {
            "Keys",
            "IV",
            "CTR",
            "CBC",
            "CFB",
            "OFB",
            "ECB"
        };

        public static string[] Path { get;} = new string[]
        {
            ReadWrite.GetAesRoute[0],
            ReadWrite.GetAesRoute[1],
            ReadWrite.GetAesEnCryptRoute[0],
            ReadWrite.GetAesEnCryptRoute[1],
            ReadWrite.GetAesEnCryptRoute[2],
            ReadWrite.GetAesEnCryptRoute[3],
            ReadWrite.GetAesEnCryptRoute[4],
        };
    }

    public class DES_Format
    {
        public static string[] Items { get;} = new string[]
        {
            "Keys",
            "IV",
            "CBC",
            "ECB"
        };

        public static string[] Path { get; } = new string[]
        {
            ReadWrite.GetDesRoute[0],
            ReadWrite.GetDesRoute[1],
            ReadWrite.GetDesEnCryptRoute[0],
            ReadWrite.GetDesEnCryptRoute[1]
        };
    }

    public class DES3_Format
    {
        public static string[] Items { get; } = new string[]
        {
            "Keys",
            "IV",
            "CBC",
            "ECB"
        };

        public static string[] Path { get; } = new string[]
        {
            ReadWrite.GetDes3Route[0],
            ReadWrite.GetDes3Route[1],
            ReadWrite.GetDes3EnCryptRoute[0],
            ReadWrite.GetDes3EnCryptRoute[1]
        };
    }

    public class RSA_Format
    {
        public static string[] Items { get; } = new string[]
        {
            "PublicKeys",
            "PrivateKeys",
            "RSA"
        };

        public static string[] Path { get; } = new string[]
        {
            ReadWrite.GetRsaRoute[0],
            ReadWrite.GetRsaRoute[1],
            ReadWrite.GetRsaEnCryptRoute
        };
    }

    public class UUID_Format
    {
        public static string[] Items { get; } = new string[]
        {
            "DATE - UUID1",
            "MD5 - UUID3",
            "RANDOM - UUID4",
            "SHA1 - UUID5"
        };

        public static string[] Path { get; } = new string[]
        {
            ReadWrite.GetUuidRoute[0],
            ReadWrite.GetUuidRoute[1],
            ReadWrite.GetUuidRoute[2],
            ReadWrite.GetUuidRoute[3],
        };
    }

    public class HASH_Format
    {

        public static string[] Items { get; } = new string[]
        {
            "MD5 - bytes",
            "MD5 - hex",
            "SHA1 - bytes",
            "SHA1 - hex",
            "SHA224 - bytes",
            "SHA224 - hex",
            "SHA256 - bytes",
            "SHA256 - hex",
            "SHA384 - bytes",
            "SHA384 - hex",
            "SHA512 - bytes",
            "SHA512 - hex"
        };

        public static string[] Path { get; } = new string[]
        {
            ReadWrite.GetHashRoute[0],
            ReadWrite.GetHashRoute[1],
            ReadWrite.GetHashRoute[2],
            ReadWrite.GetHashRoute[3],
            ReadWrite.GetHashRoute[4],
            ReadWrite.GetHashRoute[5],
            ReadWrite.GetHashRoute[6],
            ReadWrite.GetHashRoute[7],
            ReadWrite.GetHashRoute[8],
            ReadWrite.GetHashRoute[9],
            ReadWrite.GetHashRoute[10],
            ReadWrite.GetHashRoute[11],
        };
    }

    public class QR_Format
    {
        public static string[] Items { get; } = new string[]
        {
            "PNG",
            "SVG",
            "EPS",
            "TXT",
            "XBM",
        };

        public static string[] Path { get; } = new string[]
        {
            ReadWrite.GetQrRoute[0],
            ReadWrite.GetQrRoute[1],
            ReadWrite.GetQrRoute[2],
            ReadWrite.GetQrRoute[3],
            ReadWrite.GetQrRoute[4],
        };
    }
}
