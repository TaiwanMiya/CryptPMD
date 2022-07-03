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
    public partial class DES3 : UserControl
    {
        private bool HaveName
        {
            get { return FileName.Text != string.Empty && !FileName.Text.Contains(" "); }
        }

        private RadioButton[] Cryption;

        public DES3()
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
            for (int i = 0; i < DES3_Format.Items.Length; i++)
            {
                FileTypeItems.Items.Add(DES3_Format.Items[i]);
            }
            Cryption = new RadioButton[] { CBC, ECB };
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
                else if (key192.Checked) size = 192;
                else
                {
                    Terminal.ErrorMessage("請先選擇大小!");
                    return;
                }
                Format.CryptItems[0] = "des3";
                Format.CryptItems[1] = "new";
                Format.CryptItems[10] = size.ToString();
                Format.CryptItems[2] = FileName.Text;
                Format.CryptItems[3] = Encodings.SelectedItem.ToString();
                Format.CryptItems[4] = EncryptionCode.SelectedItem.ToString();
                Format.CryptItems[11] = Errors.SelectedItem.ToString();
                Terminal.DosReady(Format.CryptStart, true);
            }
            else
            {
                Terminal.ErrorMessage("沒有輸入檔名\n或檔名有空格!");
            }
        }

        #endregion

        #region 創建新鑰匙

        private void CreateKeyAndIv()
        {
            int[] KeyLength = new int[] { 16, 24 };
            string Error = string.Empty;
            if (!KeyLength.Contains(key.Text.Length))
                Error += $"KEY長度無效\n只接受<16,24>\n你給出{key.Text.Length}\n\n";
            if (iv.Text.Length != 8)
                Error += $"IV長度無效\n只接受<8>\n你給出{iv.Text.Length}\n\n";
            if (!HaveName)
                Error += $"沒有輸入檔名\n或檔名有空格";
            if (Error == string.Empty)
            {
                Format.CryptItems[0] = "des3";
                Format.CryptItems[1] = "create";
                Format.CryptItems[5] = key.Text;
                Format.CryptItems[6] = iv.Text;
                Format.CryptItems[2] = FileName.Text;
                Format.CryptItems[3] = Encodings.SelectedItem.ToString();
                Format.CryptItems[4] = EncryptionCode.SelectedItem.ToString();
                Format.CryptItems[11] = Errors.SelectedItem.ToString();
                Terminal.DosReady(Format.CryptStart, true);
            }
            else
            {
                Terminal.ErrorMessage(Error.Trim());
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateKeyAndIv();
        }

        private void keyiv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateKeyAndIv();
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
            foreach (var info in ReadWrite.OpenTheFile(DES3_Format.Path[FileTypeItems.SelectedIndex], name))
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

        private void DealWith(string path, int counter, bool IsEncrypt)
        {
            string name = Enum.GetName(typeof(DESname), 0x01 << counter);
            int[] NeedIV = new int[] { 0 };
            int[] NeedPadding = new int[] { 0, 1 };
            if (!IsEncrypt)
            {
                if (!ReadWrite.CryptionOfOpen(path, name, 10)) // 密文路徑
                {
                    return;
                }
                if (NeedPadding.Contains(counter) && DecryptPadding.Checked)
                {
                    Format.CryptItems[9] = "padding"; // Padding填充
                }
            }
            else
            {
                if (NeedPadding.Contains(counter) && EncryptPadding.Checked)
                {
                    Format.CryptItems[9] = "padding"; // Padding填充
                }
                if (!ReadWrite.CryptionOfOpen(ReadWrite.GetFileRoute, name, 10)) // 明文路徑
                {
                    return;
                }
            }
            if (!ReadWrite.CryptionOfOpen(ReadWrite.GetDes3Route[0], $"{name} Keys", 5)) // key路徑
            {
                return;
            }
            if (NeedIV.Contains(counter))
            {
                if (!ReadWrite.CryptionOfOpen(ReadWrite.GetDes3Route[1], $"{name} IV", 6)) // iv路徑
                {
                    return;
                }
            }
            string names = IsEncrypt ? "_encrypt" : "_decrypt";
            Format.CryptItems[0] = "des3";
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
            int counteres = -1;
            string path = string.Empty;
            if (!HaveName)
            {
                Terminal.ErrorMessage("沒有輸入檔名\n或檔名有空格");
                return;
            }
            for (int i = 0; i < Cryption.Length; i++)
            {
                if (Cryption[i].Checked)
                {
                    counteres = i;
                    path = ReadWrite.GetDes3EnCryptRoute[i];
                    break;
                }
            }
            if (counteres > -1 && path != string.Empty)
            {
                DealWith(path, counteres, true);
            }
            else
            {
                Terminal.ErrorMessage("請先選擇加密或解密類型!");
            }
        }

        #endregion

        #region 解密

        private void Decrypt_Click(object sender, EventArgs e)
        {
            int counteres = -1;
            string path = string.Empty;
            if (!HaveName)
            {
                Terminal.ErrorMessage("沒有輸入檔名\n或檔名有空格");
                return;
            }
            for (int i = 0; i < Cryption.Length; i++)
            {
                if (Cryption[i].Checked)
                {
                    counteres = i;
                    path = ReadWrite.GetDes3EnCryptRoute[i];
                    break;
                }
            }
            if (counteres > -1 && path != string.Empty)
            {
                DealWith(path, counteres, false);
            }
            else
            {
                Terminal.ErrorMessage("請先選擇加密或解密類型!");
            }

        }

        #endregion

    }
}
