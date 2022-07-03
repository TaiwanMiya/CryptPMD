using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto.Method;

namespace Crypto.CryptoItems
{
    public partial class RSA : UserControl
    {
        private bool HaveName
        {
            get { return FileName.Text != string.Empty && !FileName.Text.Contains(" "); }
        }

        public RSA()
        {
            InitializeComponent();
            ComboBoxLoad();
        }

        #region 初始化Combo Box

        private void ComboBoxLoad()
        {
            Encodings.Items.Clear();
            EncryptionCode.Items.Clear();
            Errors.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(EncodingItems)))
            {
                Encodings.Items.Add(name);
            }
            foreach (string name in Enum.GetNames(typeof(EncryptionCodings)))
            {
                EncryptionCode.Items.Add(name);
            }
            foreach (string name in Enum.GetNames(typeof(ErrorType)))
            {
                Errors.Items.Add(name);
            }
            for (int i = 0; i < RSA_Format.Items.Length; i++)
            {
                FileTypeItems.Items.Add(RSA_Format.Items[i]);
            }
            Encodings.SelectedIndex = 0;
            Errors.SelectedIndex = 0;
            EncryptionCode.SelectedIndex = 0;
            CryptionMethod.SelectedIndex = 0;
        }

        #endregion

        #region 生成新鑰匙

        private void New_Click(object sender, EventArgs e)
        {
            if (HaveName)
            {
                int size = 0;
                if (key128.Checked) size = 128;
                else if (key256.Checked) size = 256;
                else if (key512.Checked) size = 512;
                else if (key1024.Checked) size = 1024;
                else if (key2048.Checked) size = 2048;
                else if (key4096.Checked) size = 4096;
                else
                {
                    Terminal.ErrorMessage("請先選擇大小!");
                    return;
                }
                Format.CryptItems[0] = "rsa";
                Format.CryptItems[1] = "new";
                Format.CryptItems[10] = size.ToString();
                Format.CryptItems[2] = FileName.Text;
                Terminal.DosReady(Format.CryptStart, true);
            }
            else
            {
                Terminal.ErrorMessage("沒有輸入檔名\n或檔名有空格!");
            }
        }

        #endregion

        #region 讀取檔案

        private void Open_Click(object sender, EventArgs e)
        {
            if (FileTypeItems.SelectedIndex < 0)
            {
                Terminal.ErrorMessage("請先選擇檔案類型!");
                return;
            }
            string name = FileTypeItems.SelectedItem.ToString();
            foreach (var info in ReadWrite.OpenTheFile(RSA_Format.Path[FileTypeItems.SelectedIndex], name))
            {
                if (info.Item1 != "null" && info.Item2 != "null")
                {
                    if (info.Item2 != string.Empty) ReadWrite.OpenFileAndRead(info.Item1);
                    if (info.Item2 != string.Empty) ReadWrite.OpenFileAndReadToTerminal(info.Item1);
                }
                else
                {
                    break;
                }
            }
        }

        #endregion

        #region 類型處理

        private void DealWith(string path, bool IsEncrypt)
        {
            string name = Enum.GetName(typeof(RSAname), 0x01);
            if (!IsEncrypt)
            {
                if (!ReadWrite.CryptionOfOpen(path, name, 10)) // 密文路徑
                {
                    return;
                }
            }
            else
            {
                if (!ReadWrite.CryptionOfOpen(ReadWrite.GetFileRoute, name, 10)) // 明文路徑
                {
                    return;
                }
            }
            if (!ReadWrite.CryptionOfOpen(ReadWrite.GetRsaRoute[0], $"{name} PiblicKey", 7)) // 公鑰
            {
                return;
            }
            if (!ReadWrite.CryptionOfOpen(ReadWrite.GetRsaRoute[1], $"{name} PrivateKey", 8)) // 私鑰
            {
                return;
            }
            string names = IsEncrypt ? "_encrypt" : "_decrypt";
            Format.CryptItems[0] = "rsa";
            Format.CryptItems[1] = name + names;
            Format.CryptItems[2] = FileName.Text;
            Format.CryptItems[3] = Encodings.SelectedItem.ToString();
            Format.CryptItems[4] = EncryptionCode.SelectedItem.ToString();
            Format.CryptItems[11] = Errors.SelectedItem.ToString();
            Format.CryptItems[12] = CryptionMethod.SelectedIndex.ToString();
            Terminal.DosReady(Format.CryptStart, true);
        }

        #endregion

        #region 加密

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (!HaveName)
            {
                Terminal.ErrorMessage("沒有輸入檔名\n或檔名有空格");
                return;
            }
            DealWith(ReadWrite.GetRsaEnCryptRoute, true);
        }

        #endregion

        #region 解密

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (!HaveName)
            {
                Terminal.ErrorMessage("沒有輸入檔名\n或檔名有空格");
                return;
            }
            DealWith(ReadWrite.GetRsaEnCryptRoute, false);
        }

        #endregion

    }
}
