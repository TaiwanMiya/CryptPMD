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
    public partial class HASH : UserControl
    {
        private RadioButton[] Production;

        public HASH()
        {
            InitializeComponent();
            ComboBoxLoad();
        }

        #region 初始化Combo Box

        private void ComboBoxLoad()
        {
            for (int i = 0; i < HASH_Format.Items.Length; i++)
            {
                FileTypeItems.Items.Add(HASH_Format.Items[i]);
            }
            Generates.Items.Add("File Name");
            Generates.Items.Add("Hash Name");
            Production = new RadioButton[] { MD5 , SHA1 , SHA224 , SHA256 , SHA384 , SHA512 };
            Generates.SelectedIndex = 0;
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
            foreach (var info in ReadWrite.OpenTheFile(HASH_Format.Path[FileTypeItems.SelectedIndex], name))
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

        #region 是否隨機檔名

        private void Generates_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Generates.SelectedIndex)
            {
                case 0:
                    FileName.Enabled = true;
                    break;
                case 1:
                    FileName.Enabled = false;
                    break;
            }
        }

        #endregion

        #region 類型處理

        private void DealWith(int counter)
        {
            string name = Enum.GetName(typeof(HASHname), 0x01 << counter);
            string Text = string.Empty;
            foreach (string text in StringName.Text.Split(' '))
            {
                Text += text + "+";
            }
            Text = Text.TrimEnd('+');
            if (FileName.Enabled)
            {
                if (FileName.Text == string.Empty || FileName.Text.Contains(" "))
                {
                    Terminal.ErrorMessage("沒有輸入檔名\n或檔名有空格");
                    return;
                }
                else
                {
                    Format.CryptItems[2] = FileName.Text;
                }
            }
            Format.CryptItems[0] = "hash";
            Format.CryptItems[1] = name;
            Format.CryptItems[10] = Text == string.Empty ? null : Text ;
            Terminal.DosReady(Format.CryptStart, true);
        }

        #endregion

        #region 創建與生成

        private async void Create_Click(object sender, EventArgs e)
        {
            bool SUCCESS = false;
            for (int i = 0; i < Production.Length; i++)
            {
                if (Production[i].Checked)
                {
                    SUCCESS = true;
                    await Task.Run(() => DealWith(i));
                }
            }
            if (!SUCCESS)
            {
                Terminal.ErrorMessage("請先勾選項目!");
            }
        }

        #endregion

    }
}
