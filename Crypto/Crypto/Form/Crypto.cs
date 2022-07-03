using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Crypto.Method;
using Crypto.CryptoItems;

namespace Crypto
{
    public partial class Crypto : Form
    {
        private bool HaveName
        {
            get { return FileName.Text != string.Empty && !FileName.Text.Contains(" "); }
        }

        public int TerminalToTheEnd
        {
            get
            {
                return Terminal.GetTerminal(terminal.Items.Count, terminal.Height, terminal.ItemHeight);
            }
            set
            {
                var TerminalSettings = Terminal.SetTerminal(value);
                terminal.Items.Add(TerminalSettings.Item1);
                terminal.TopIndex = TerminalSettings.Item2;
            }
        }

        private UserControl[] Cryptos = new UserControl[]
        {
            new AES(),
            new DES(),
            new DES3(),
            new RSA(),
            new UUID(),
            new HASH(),
            new QR()
        };

        private Color[] colors = new Color[]
        {
            Color.Black,
            Color.White,
            Color.Gray,
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Cyan,
            Color.Blue,
            Color.Purple
        };

        public Crypto()
        {
            InitializeComponent();
        }

        private void TerminalClear_Click(object sender, EventArgs e)
        {
            terminal.Items.Clear();
        }

        #region 計時器

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Terminal.result.Count > 0)
            {
                for (int i = 0;i < Terminal.result.Count; i++)
                {
                    terminal.Items.Add(Terminal.result[i]);
                }
                Terminal.result.Clear();
                TerminalToTheEnd = TerminalToTheEnd;
            }
        }

        #endregion

        #region DOS指令

        private void TerminalSingle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Terminal.DosReady(TerminalSingle.Text);
            }
        }

        #endregion

        #region 視窗

        /// <summary>
        /// 視窗初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Crypto_Load(object sender, EventArgs e)
        {
            AES_Page.Controls.Add(Cryptos[0]);
            DES_Page.Controls.Add(Cryptos[1]);
            DES3_Page.Controls.Add(Cryptos[2]);
            RSA_Page.Controls.Add(Cryptos[3]);
            UUID_Page.Controls.Add(Cryptos[4]);
            HASH_Page.Controls.Add(Cryptos[5]);
            QR_Page.Controls.Add(Cryptos[6]);
            CanvasColor.Color = Color.Black;
            terminal.BackColor = CanvasColor.Color;
            CanvasColor.Color = Color.White;
            terminal.ForeColor = CanvasColor.Color;
        }

        /// <summary>
        /// 視窗關閉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Crypto_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool cheak = Terminal.QuestionMessage("是否關閉應用程序?");
            if (cheak)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region 終端複製

        private void terminal_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (terminal.SelectedIndex > -1)
                    Clipboard.SetText(terminal.Items[terminal.SelectedIndex].ToString());
            }
            catch (ArgumentNullException)
            {
                Terminal.ErrorMessage("複製的值為空!");
            }
        }

        #endregion

        private void OpenFile_Click(object sender, EventArgs e)
        {
            foreach (var info in ReadWrite.OpenTheFile(ReadWrite.GetFileRoute, "File", true))
            {
                if (info.Item2 != string.Empty)
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
        }

        private void WriteStart_Click(object sender, EventArgs e)
        {
            if (HaveName)
            {
                string path = ReadWrite.GetFileRoute + "\\" + FileName.Text;
                string create = $"cd /d {ReadWrite.GetFileRoute}\n" +
                    $"echo . 2>{FileName.Text}";
                Terminal.DosReady(create);
                ReadWrite.OpenFileAndRead(path);
            }
            else
            {
                Terminal.ErrorMessage("沒有輸入檔名!\n或檔名有空格");
            }
        }

        #region 終端顏色

        private void BackColors_Click(object sender, EventArgs e)
        {
            if (CanvasColor.ShowDialog() == DialogResult.OK)
            {
                terminal.BackColor = CanvasColor.Color;
            }
        }

        private void FontColors_Click(object sender, EventArgs e)
        {
            if (CanvasColor.ShowDialog() == DialogResult.OK)
            {
                terminal.ForeColor = CanvasColor.Color;
            }
        }

        #endregion

        private void TerminalMultiple_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MultipleComboBox.Items.Add(TerminalMultiple.Text);
            }
            MultipleComboBox.SelectedIndex = MultipleComboBox.Items.Count - 1;
        }

        private void MultipleExecute_Click(object sender, EventArgs e)
        {
            string execute = string.Empty;
            for (int i = 0; i < MultipleComboBox.Items.Count; i++)
            {
                execute += MultipleComboBox.Items[i] + "\n";
            }
            Terminal.DosReady(execute);
        }

        private void MultipleDelete_Click(object sender, EventArgs e)
        {
            if (MultipleComboBox.SelectedIndex > -1)
            {
                MultipleComboBox.Items.RemoveAt(MultipleComboBox.SelectedIndex);
            }
            MultipleComboBox.SelectedIndex = MultipleComboBox.Items.Count - 1;
        }
    }
}
