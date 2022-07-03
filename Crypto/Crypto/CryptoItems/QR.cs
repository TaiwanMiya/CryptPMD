using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto.Method;

namespace Crypto.CryptoItems
{
    public partial class QR : UserControl
    {
        private RadioButton[] Production;

        private byte[] ColorMode
        {
            get;
            set;
        }

        public QR()
        {
            InitializeComponent();
            ComboBoxLoad();
        }

        #region 初始化Combo Box

        private void ComboBoxLoad()
        {
            Encodings.Items.Clear();
            foreach (string name in Enum.GetNames(typeof(EncodingItems)))
            {
                Encodings.Items.Add(name);
            }
            for (int i = 0; i < QR_Format.Items.Length; i++)
            {
                FileTypeItems.Items.Add(QR_Format.Items[i]);
            }
            Production = new RadioButton[] { Show , Png , Svg , Eps , Txt , Xbm };
            ModeColor.Color = Color.Black;
            BackColor.Color = Color.White;
            ColorMode = new byte[]
            {
                ModeColor.Color.R,
                ModeColor.Color.G,
                ModeColor.Color.B,
                BackColor.Color.R,
                BackColor.Color.G,
                BackColor.Color.B,
            };
            Encodings.SelectedIndex = 2;
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
            foreach (var info in ReadWrite.OpenTheFile(QR_Format.Path[FileTypeItems.SelectedIndex], name))
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

        #region QR顏色

        private void ModeBtn_Click(object sender, EventArgs e)
        {
            if (ModeColor.ShowDialog() == DialogResult.OK)
            {
                ModeColor.Color = ModeColor.Color;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (BackColor.ShowDialog() == DialogResult.OK)
            {
                BackColor.Color = BackColor.Color;
            }
        }

        private void SettingsQrColor()
        {
            ColorMode = new byte[6];
            ColorMode[0] = ModeColor.Color.R;
            ColorMode[1] = ModeColor.Color.G;
            ColorMode[2] = ModeColor.Color.B;
            ColorMode[3] = BackColor.Color.R;
            ColorMode[4] = BackColor.Color.G;
            ColorMode[5] = BackColor.Color.B;
        }

        #endregion

        #region 類型處理

        private void DealWith(int counter)
        {
            string name = Enum.GetName(typeof(QRname), 0x01 << counter);
            int[] Need3Data = new int[] { 0 , 1 , 2 , 3 };
            if (counter != 0)
            {
                if (FileName.Text == string.Empty || FileName.Text.Contains(" "))
                {
                    Terminal.ErrorMessage("沒有輸入檔名\n或檔名有空格");
                    return;
                }
            }
            if (Content.Text == string.Empty)
            {
                Terminal.ErrorMessage("沒有輸入QRcode的內容!");
                return;
            }
            string Text = string.Empty;
            foreach (string text in Content.Text.Split(' '))
            {
                Text += text + "(+)";
            }
            if (Need3Data.Contains(counter))
            {
                SettingsQrColor();
                string data = string.Empty;
                for (int i = 0; i < ColorMode.Length; i++)
                {
                    data += ColorMode[i].ToString();
                    if (i == 2)
                        data += ":";
                    else if (i != ColorMode.Length - 1)
                        data += ",";
                }
                data += ":" + Scale.Value.ToString();
                Format.CryptItems[9] = data;
            }
            else if (counter == 5)
            {
                Format.CryptItems[9] = Scale.Value.ToString();
            }
            Format.CryptItems[0] = "qr";
            Format.CryptItems[1] = name;
            if (counter != 0)
                Format.CryptItems[2] = FileName.Text;
            Format.CryptItems[3] = Encodings.SelectedItem.ToString();
            Format.CryptItems[10] = Text;
            Format.CryptItems[12] = ZoneSize.Value.ToString();
            Terminal.DosReady(Format.CryptStart, true);
        }

        #endregion

        #region QR功能執行

        private void Create_Click(object sender, EventArgs e)
        {
            bool SUCCESS = false;
            for (int i = 0; i < Production.Length; i++)
            {
                if (Production[i].Checked)
                {
                    SUCCESS = true;
                    DealWith(i);
                }
            }
            if (!SUCCESS)
            {
                Terminal.ErrorMessage("請先選擇QR方法!");
            }
        }

        #endregion
    }
}
