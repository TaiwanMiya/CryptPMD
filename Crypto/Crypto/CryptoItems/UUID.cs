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
    public partial class UUID : UserControl
    {
        private RadioButton[] Production;

        private RadioButton[] NameSpace;

        public UUID()
        {
            InitializeComponent();
            ComboBoxLoad();
        }

        #region 初始化Combo Box

        private void ComboBoxLoad()
        {
            for (int i = 0; i < UUID_Format.Items.Length; i++)
            {
                FileTypeItems.Items.Add(UUID_Format.Items[i]);
            }
            Generates.Items.Add("File Name");
            Generates.Items.Add("Uuid Name");
            Production = new RadioButton[] { UUID1 , UUID3 , UUID4 , UUID5 };
            NameSpace = new RadioButton[] { DNS , URL , OID , X500 };
            AllNameSpaceEnabled(false);
            StringName.Enabled = false;
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
            foreach (var info in ReadWrite.OpenTheFile(UUID_Format.Path[FileTypeItems.SelectedIndex], name))
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
                    CreateCounter.Enabled = false;
                    break;
                case 1:
                    FileName.Enabled = false;
                    CreateCounter.Enabled = true;
                    break;
            }
        }

        #endregion

        #region 是否能使命名空間作動

        private void AllNameSpaceEnabled(bool yesno)
        {
            for (int i = 0; i < NameSpace.Length; i++)
            {
                NameSpace[i].Enabled = yesno;
            }
        }

        private void UUID1_CheckedChanged(object sender, EventArgs e)
        {
            AllNameSpaceEnabled(false);
            StringName.Enabled = false;
        }

        private void UUID3_CheckedChanged(object sender, EventArgs e)
        {
            AllNameSpaceEnabled(true);
            StringName.Enabled = true;
        }

        private void UUID4_CheckedChanged(object sender, EventArgs e)
        {
            AllNameSpaceEnabled(false);
            StringName.Enabled = false;
        }

        private void UUID5_CheckedChanged(object sender, EventArgs e)
        {
            AllNameSpaceEnabled(true);
            StringName.Enabled = true;
        }

        #endregion

        #region 類型處理

        private void DealWith(int counter)
        {
            string name = Enum.GetName(typeof(UUIDname), 0x01 << counter);
            bool SUCCESS = false;
            int[] NeedSelect = new int[] { 1, 3 };
            string Text = string.Empty;
            foreach (string text in StringName.Text.Split(' '))
            {
                Text += text + "+";
            }
            Text = Text.TrimEnd('+');
            if (FileName.Enabled && !NeedSelect.Contains(counter) && FileName.Text != string.Empty)
            {
                Format.CryptItems[0] = "uuid";
                Format.CryptItems[1] = name;
                Format.CryptItems[2] = FileName.Text;
                Terminal.DosReady(Format.CryptStart, true);
                SUCCESS = true;
            }
            else if (FileName.Enabled && NeedSelect.Contains(counter) && StringName.Text != string.Empty && FileName.Text != string.Empty)
            {
                Format.CryptItems[2] = FileName.Text;
                for (int i = 0; i < NameSpace.Length; i++)
                {
                    if (NameSpace[i].Checked)
                    {
                        Format.CryptItems[0] = "uuid";
                        Format.CryptItems[1] = name;
                        Format.CryptItems[9] = NameSpace[i].Text;
                        Format.CryptItems[10] = Text;
                        Terminal.DosReady(Format.CryptStart, true);
                        SUCCESS = true;
                    }
                }
            }
            else if (!FileName.Enabled && !NeedSelect.Contains(counter))
            {
                for (int i = 0; i < CreateCounter.Value; i++)
                {
                    Format.CryptItems[0] = "uuid";
                    Format.CryptItems[1] = name;
                    if (CreateCounter.Value - 1 > i)
                    {
                        Terminal.DosReady(Format.CryptStart, false);
                    }
                    else
                    {
                        Terminal.DosReady(Format.CryptStart, true);
                    }
                    SUCCESS = true;
                }
            }
            else if (!FileName.Enabled && NeedSelect.Contains(counter) && StringName.Text != string.Empty)
            {
                for (int i = 0; i < NameSpace.Length; i++)
                {
                    if (NameSpace[i].Checked)
                    {
                        Format.CryptItems[0] = "uuid";
                        Format.CryptItems[1] = name;
                        Format.CryptItems[9] = NameSpace[i].Text;
                        Format.CryptItems[10] = Text;
                        Terminal.DosReady(Format.CryptStart, true);
                        SUCCESS = true;
                    }
                }
            }
            else if (!SUCCESS)
            {
                Terminal.ErrorMessage("請確認是否需要輸入檔名\n" +
                    "或輸入加鹽字串");
            }
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
