using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Crypto.Method
{
    public class ReadWrite
    {
        public static string MainPath
        {
            get
            {
                return CheakPathRoute();
            }
        }

        public static string GetFileRoute
        {
            get { return MainPath + "\\File"; }
        }

        public static string[] GetAesRoute { get; } = new string[]
        {
            MainPath + "\\Data\\AES\\Keys",
            MainPath + "\\Data\\AES\\IV"
        };

        public static string[] GetDesRoute { get; } = new string[]
        {
            MainPath + "\\Data\\DES\\Keys",
            MainPath + "\\Data\\DES\\IV"
        };

        public static string[] GetDes3Route { get; } = new string[]
        {
            MainPath + "\\Data\\DES3\\Keys",
            MainPath + "\\Data\\DES3\\IV"
        };

        public static string[] GetRsaRoute { get; } = new string[]
        {
            MainPath + "\\Data\\RSA\\PublicKey",
            MainPath + "\\Data\\RSA\\PrivateKey"
        };

        public static string[] GetUuidRoute { get; } = new string[]
        {
            MainPath + "\\Data\\UUID\\UUID1",
            MainPath + "\\Data\\UUID\\UUID3",
            MainPath + "\\Data\\UUID\\UUID4",
            MainPath + "\\Data\\UUID\\UUID5",
        };

        public static string[] GetHashRoute { get; } = new string[]
        {
            MainPath + "\\Data\\HASH\\MD5\\bytes",
            MainPath + "\\Data\\HASH\\MD5\\hex",
            MainPath + "\\Data\\HASH\\SHA1\\bytes",
            MainPath + "\\Data\\HASH\\SHA1\\hex",
            MainPath + "\\Data\\HASH\\SHA224\\bytes",
            MainPath + "\\Data\\HASH\\SHA224\\hex",
            MainPath + "\\Data\\HASH\\SHA256\\bytes",
            MainPath + "\\Data\\HASH\\SHA256\\hex",
            MainPath + "\\Data\\HASH\\SHA384\\bytes",
            MainPath + "\\Data\\HASH\\SHA384\\hex",
            MainPath + "\\Data\\HASH\\SHA512\\bytes",
            MainPath + "\\Data\\HASH\\SHA512\\hex",
        };

        public static string[] GetQrRoute { get; } = new string[]
        {
            MainPath + "\\Data\\QR\\PNG",
            MainPath + "\\Data\\QR\\SVG",
            MainPath + "\\Data\\QR\\EPS",
            MainPath + "\\Data\\QR\\TXT",
            MainPath + "\\Data\\QR\\XBM",
        };

        public static string[] GetAesEnCryptRoute { get;} = new string[]
        {
            MainPath + "\\Data\\DataBase\\AES_CTR",
            MainPath + "\\Data\\DataBase\\AES_CBC",
            MainPath + "\\Data\\DataBase\\AES_CFB",
            MainPath + "\\Data\\DataBase\\AES_OFB",
            MainPath + "\\Data\\DataBase\\AES_ECB"
        };

        public static string[] GetDesEnCryptRoute { get;} = new string[]
        {
            MainPath + "\\Data\\DataBase\\DES_CBC",
            MainPath + "\\Data\\DataBase\\DES_ECB"
        };

        public static string[] GetDes3EnCryptRoute { get; } = new string[]
        {
            MainPath + "\\Data\\DataBase\\DES3_CBC",
            MainPath + "\\Data\\DataBase\\DES3_ECB"
        };

        public static string GetRsaEnCryptRoute
        {
            get { return MainPath + "\\Data\\DataBase\\RSA"; }
        }

        public static string[] GetBaseEnCryptRoute { get; } = new string[]
        {
            MainPath + "\\Data\\DataBase\\Base\\Base16",
            MainPath + "\\Data\\DataBase\\Base\\Base32",
            MainPath + "\\Data\\DataBase\\Base\\Base64",
            MainPath + "\\Data\\DataBase\\Base\\Base85"
        };

        public static string[] GetConvertEnCryptRoute { get; } = new string[]
        {
            MainPath + "\\Data\\DataBase\\Convert\\Base64",
            MainPath + "\\Data\\DataBase\\Convert\\Hex",
            MainPath + "\\Data\\DataBase\\Convert\\QP",
            MainPath + "\\Data\\DataBase\\Convert\\UU"
        };

        public static void ReadFile(string route)
        {
            StreamReader reader = new StreamReader(route);
            string line = reader.ReadLine();
            while (line != null)
            {
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public static string CheakPathRoute()
        {
            string selectpath = Environment.CurrentDirectory;
            selectpath = selectpath.EndsWith("Debug")
                ? GetupLevelDirectory(selectpath, 4)
                : selectpath;
            return selectpath;
        }

        public static string GetupLevelDirectory(string path, int upLevel)
        {
            var directory = File.GetAttributes(path).HasFlag(FileAttributes.Directory)
                ? path
                : Path.GetDirectoryName(path);

            upLevel = upLevel < 0 ? 0 : upLevel;
            for (var i = 0; i < upLevel; i++)
            {
                directory = Path.GetDirectoryName(directory);
            }
            return directory;
        }

        public static bool CryptionOfOpen(string path, string name, int count)
        {
            bool loops = true;
            while (loops)
            {
                foreach (var info in OpenTheFile(path, name, false))
                {
                    if (info.Item2 != string.Empty)
                    {
                        if (info.Item1 != "null" && info.Item2 != "null")
                        {
                            Format.CryptItems[count] = info.Item1;
                            loops = false;
                            return true;
                        }
                        else
                        {
                            loops = false;
                            break;
                        }
                    }
                }
                if (loops) Terminal.ErrorMessage($"請選擇 {name} 的檔案");
            }
            return false;
        }

        public static IEnumerable<Tuple<string,string>> OpenTheFile(string path,string title,bool multiple = true)
        {
            string[] files = Directory.GetFiles(path);
            if (files.Length == 0)
            {
                Terminal.ErrorMessage($"{title} 沒有檔案");
                yield return Tuple.Create("null", "null");
            }
            OpenFileDialog file = new OpenFileDialog();
            file.Title = title;
            file.InitialDirectory = path;
            file.Multiselect = multiple;
            if (file.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < file.FileNames.Length; i++)
                {
                    yield return Tuple.Create(file.FileNames[i], file.SafeFileNames[i]);
                }
            }
            else
            {
                yield return Tuple.Create("null", "null");
            }
        }

        public static void OpenFileAndRead(string file)
        {
            Terminal.DosReady($"\"{Terminal.GetRouteResult("notepad")}\" /A \"{file}\"");
        }

        public static void OpenFileAndReadToTerminal(string file)
        {
            Format.CryptItems[1] = "reader";
            Format.CryptItems[2] = file;
            Terminal.DosExecute(Format.CryptStart, true);
        }
    }
}
