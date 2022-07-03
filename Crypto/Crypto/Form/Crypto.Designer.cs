namespace Crypto
{
    partial class Crypto
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crypto));
            this.pages = new System.Windows.Forms.TabControl();
            this.Settings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.WriteStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TerminalSingle = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TerminalClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FontColors = new System.Windows.Forms.Button();
            this.BackColors = new System.Windows.Forms.Button();
            this.AES_Page = new System.Windows.Forms.TabPage();
            this.DES_Page = new System.Windows.Forms.TabPage();
            this.DES3_Page = new System.Windows.Forms.TabPage();
            this.RSA_Page = new System.Windows.Forms.TabPage();
            this.UUID_Page = new System.Windows.Forms.TabPage();
            this.HASH_Page = new System.Windows.Forms.TabPage();
            this.QR_Page = new System.Windows.Forms.TabPage();
            this.terminal = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AES_open = new System.Windows.Forms.OpenFileDialog();
            this.CanvasColor = new System.Windows.Forms.ColorDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TerminalMultiple = new System.Windows.Forms.TextBox();
            this.MultipleExecute = new System.Windows.Forms.Button();
            this.MultipleDelete = new System.Windows.Forms.Button();
            this.MultipleComboBox = new System.Windows.Forms.ComboBox();
            this.pages.SuspendLayout();
            this.Settings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.Settings);
            this.pages.Controls.Add(this.AES_Page);
            this.pages.Controls.Add(this.DES_Page);
            this.pages.Controls.Add(this.DES3_Page);
            this.pages.Controls.Add(this.RSA_Page);
            this.pages.Controls.Add(this.UUID_Page);
            this.pages.Controls.Add(this.HASH_Page);
            this.pages.Controls.Add(this.QR_Page);
            this.pages.Location = new System.Drawing.Point(12, 12);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(470, 592);
            this.pages.TabIndex = 0;
            this.pages.TabStop = false;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.groupBox6);
            this.Settings.Controls.Add(this.groupBox2);
            this.Settings.Controls.Add(this.groupBox1);
            this.Settings.Controls.Add(this.groupBox5);
            this.Settings.Controls.Add(this.groupBox4);
            this.Settings.Controls.Add(this.groupBox3);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(462, 566);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FileName);
            this.groupBox2.Controls.Add(this.WriteStart);
            this.groupBox2.Location = new System.Drawing.Point(3, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 175);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "File Name";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(82, 52);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(121, 22);
            this.FileName.TabIndex = 4;
            // 
            // WriteStart
            // 
            this.WriteStart.Location = new System.Drawing.Point(63, 121);
            this.WriteStart.Name = "WriteStart";
            this.WriteStart.Size = new System.Drawing.Size(100, 25);
            this.WriteStart.TabIndex = 3;
            this.WriteStart.Text = "Start";
            this.WriteStart.UseVisualStyleBackColor = true;
            this.WriteStart.Click += new System.EventHandler(this.WriteStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenFile);
            this.groupBox1.Location = new System.Drawing.Point(229, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read File";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(65, 86);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(100, 25);
            this.OpenFile.TabIndex = 3;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TerminalSingle);
            this.groupBox5.Location = new System.Drawing.Point(3, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 175);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DOS Single";
            // 
            // TerminalSingle
            // 
            this.TerminalSingle.Location = new System.Drawing.Point(63, 80);
            this.TerminalSingle.Name = "TerminalSingle";
            this.TerminalSingle.Size = new System.Drawing.Size(100, 22);
            this.TerminalSingle.TabIndex = 3;
            this.TerminalSingle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TerminalSingle_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TerminalClear);
            this.groupBox4.Location = new System.Drawing.Point(229, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 175);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Terminal Clear";
            // 
            // TerminalClear
            // 
            this.TerminalClear.Location = new System.Drawing.Point(65, 70);
            this.TerminalClear.Name = "TerminalClear";
            this.TerminalClear.Size = new System.Drawing.Size(100, 25);
            this.TerminalClear.TabIndex = 2;
            this.TerminalClear.Text = "Terminal Clear";
            this.TerminalClear.UseVisualStyleBackColor = true;
            this.TerminalClear.Click += new System.EventHandler(this.TerminalClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FontColors);
            this.groupBox3.Controls.Add(this.BackColors);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 175);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terminal Color";
            // 
            // FontColors
            // 
            this.FontColors.Location = new System.Drawing.Point(63, 106);
            this.FontColors.Name = "FontColors";
            this.FontColors.Size = new System.Drawing.Size(100, 25);
            this.FontColors.TabIndex = 4;
            this.FontColors.Text = "Font Color";
            this.FontColors.UseVisualStyleBackColor = true;
            this.FontColors.Click += new System.EventHandler(this.FontColors_Click);
            // 
            // BackColors
            // 
            this.BackColors.Location = new System.Drawing.Point(63, 40);
            this.BackColors.Name = "BackColors";
            this.BackColors.Size = new System.Drawing.Size(100, 25);
            this.BackColors.TabIndex = 3;
            this.BackColors.Text = "Back Color";
            this.BackColors.UseVisualStyleBackColor = true;
            this.BackColors.Click += new System.EventHandler(this.BackColors_Click);
            // 
            // AES_Page
            // 
            this.AES_Page.Location = new System.Drawing.Point(4, 22);
            this.AES_Page.Name = "AES_Page";
            this.AES_Page.Size = new System.Drawing.Size(462, 566);
            this.AES_Page.TabIndex = 3;
            this.AES_Page.Text = "AES";
            this.AES_Page.UseVisualStyleBackColor = true;
            // 
            // DES_Page
            // 
            this.DES_Page.Location = new System.Drawing.Point(4, 22);
            this.DES_Page.Name = "DES_Page";
            this.DES_Page.Size = new System.Drawing.Size(462, 566);
            this.DES_Page.TabIndex = 4;
            this.DES_Page.Text = "DES";
            this.DES_Page.UseVisualStyleBackColor = true;
            // 
            // DES3_Page
            // 
            this.DES3_Page.Location = new System.Drawing.Point(4, 22);
            this.DES3_Page.Name = "DES3_Page";
            this.DES3_Page.Size = new System.Drawing.Size(462, 566);
            this.DES3_Page.TabIndex = 5;
            this.DES3_Page.Text = "3DES";
            this.DES3_Page.UseVisualStyleBackColor = true;
            // 
            // RSA_Page
            // 
            this.RSA_Page.Location = new System.Drawing.Point(4, 22);
            this.RSA_Page.Name = "RSA_Page";
            this.RSA_Page.Size = new System.Drawing.Size(462, 566);
            this.RSA_Page.TabIndex = 6;
            this.RSA_Page.Text = "RSA";
            this.RSA_Page.UseVisualStyleBackColor = true;
            // 
            // UUID_Page
            // 
            this.UUID_Page.Location = new System.Drawing.Point(4, 22);
            this.UUID_Page.Name = "UUID_Page";
            this.UUID_Page.Size = new System.Drawing.Size(462, 566);
            this.UUID_Page.TabIndex = 7;
            this.UUID_Page.Text = "UUID";
            this.UUID_Page.UseVisualStyleBackColor = true;
            // 
            // HASH_Page
            // 
            this.HASH_Page.Location = new System.Drawing.Point(4, 22);
            this.HASH_Page.Name = "HASH_Page";
            this.HASH_Page.Size = new System.Drawing.Size(462, 566);
            this.HASH_Page.TabIndex = 8;
            this.HASH_Page.Text = "HASH";
            this.HASH_Page.UseVisualStyleBackColor = true;
            // 
            // QR_Page
            // 
            this.QR_Page.Location = new System.Drawing.Point(4, 22);
            this.QR_Page.Name = "QR_Page";
            this.QR_Page.Size = new System.Drawing.Size(462, 566);
            this.QR_Page.TabIndex = 9;
            this.QR_Page.Text = "QR";
            this.QR_Page.UseVisualStyleBackColor = true;
            // 
            // terminal
            // 
            this.terminal.FormattingEnabled = true;
            this.terminal.ItemHeight = 12;
            this.terminal.Location = new System.Drawing.Point(502, 7);
            this.terminal.Name = "terminal";
            this.terminal.Size = new System.Drawing.Size(470, 592);
            this.terminal.TabIndex = 0;
            this.terminal.TabStop = false;
            this.terminal.DoubleClick += new System.EventHandler(this.terminal_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AES_open
            // 
            this.AES_open.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.MultipleComboBox);
            this.groupBox6.Controls.Add(this.MultipleDelete);
            this.groupBox6.Controls.Add(this.MultipleExecute);
            this.groupBox6.Controls.Add(this.TerminalMultiple);
            this.groupBox6.Location = new System.Drawing.Point(229, 184);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(220, 175);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DOS Multiple";
            // 
            // TerminalMultiple
            // 
            this.TerminalMultiple.Location = new System.Drawing.Point(65, 37);
            this.TerminalMultiple.Name = "TerminalMultiple";
            this.TerminalMultiple.Size = new System.Drawing.Size(100, 22);
            this.TerminalMultiple.TabIndex = 0;
            this.TerminalMultiple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TerminalMultiple_KeyDown);
            // 
            // MultipleExecute
            // 
            this.MultipleExecute.Location = new System.Drawing.Point(19, 134);
            this.MultipleExecute.Name = "MultipleExecute";
            this.MultipleExecute.Size = new System.Drawing.Size(75, 24);
            this.MultipleExecute.TabIndex = 4;
            this.MultipleExecute.Text = "Execute";
            this.MultipleExecute.UseVisualStyleBackColor = true;
            this.MultipleExecute.Click += new System.EventHandler(this.MultipleExecute_Click);
            // 
            // MultipleDelete
            // 
            this.MultipleDelete.Location = new System.Drawing.Point(129, 134);
            this.MultipleDelete.Name = "MultipleDelete";
            this.MultipleDelete.Size = new System.Drawing.Size(75, 24);
            this.MultipleDelete.TabIndex = 5;
            this.MultipleDelete.Text = "Delete";
            this.MultipleDelete.UseVisualStyleBackColor = true;
            this.MultipleDelete.Click += new System.EventHandler(this.MultipleDelete_Click);
            // 
            // MultipleComboBox
            // 
            this.MultipleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MultipleComboBox.FormattingEnabled = true;
            this.MultipleComboBox.Location = new System.Drawing.Point(55, 87);
            this.MultipleComboBox.Name = "MultipleComboBox";
            this.MultipleComboBox.Size = new System.Drawing.Size(121, 20);
            this.MultipleComboBox.TabIndex = 6;
            // 
            // Crypto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.terminal);
            this.Controls.Add(this.pages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Crypto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Crypto_FormClosing);
            this.Load += new System.EventHandler(this.Crypto_Load);
            this.pages.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.ListBox terminal;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button TerminalClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TerminalSingle;
        private System.Windows.Forms.TabPage AES_Page;
        private System.Windows.Forms.TabPage DES_Page;
        private System.Windows.Forms.TabPage DES3_Page;
        private System.Windows.Forms.TabPage RSA_Page;
        private System.Windows.Forms.OpenFileDialog AES_open;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button WriteStart;
        private System.Windows.Forms.Button FontColors;
        private System.Windows.Forms.Button BackColors;
        private System.Windows.Forms.ColorDialog CanvasColor;
        private System.Windows.Forms.TabPage UUID_Page;
        private System.Windows.Forms.TabPage HASH_Page;
        private System.Windows.Forms.TabPage QR_Page;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox MultipleComboBox;
        private System.Windows.Forms.Button MultipleDelete;
        private System.Windows.Forms.Button MultipleExecute;
        private System.Windows.Forms.TextBox TerminalMultiple;
    }
}

