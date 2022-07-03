namespace Crypto.CryptoItems
{
    partial class QR
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Create = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ModeBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Content = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.FileTypeItems = new System.Windows.Forms.ComboBox();
            this.Open = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.AES_Type = new System.Windows.Forms.GroupBox();
            this.Xbm = new System.Windows.Forms.RadioButton();
            this.Svg = new System.Windows.Forms.RadioButton();
            this.Txt = new System.Windows.Forms.RadioButton();
            this.Png = new System.Windows.Forms.RadioButton();
            this.Eps = new System.Windows.Forms.RadioButton();
            this.Show = new System.Windows.Forms.RadioButton();
            this.ModeColor = new System.Windows.Forms.ColorDialog();
            this.BackColor = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ZoneSize = new System.Windows.Forms.NumericUpDown();
            this.Scale = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Encodings = new System.Windows.Forms.ComboBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AES_Type.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoneSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Create);
            this.groupBox5.Location = new System.Drawing.Point(224, 413);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 130);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Start QRcode Function";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(35, 57);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(150, 25);
            this.Create.TabIndex = 2;
            this.Create.TabStop = false;
            this.Create.Text = "Start";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BackBtn);
            this.groupBox4.Controls.Add(this.ModeBtn);
            this.groupBox4.Location = new System.Drawing.Point(3, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 130);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "QRcode Color";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(60, 85);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 25);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.TabStop = false;
            this.BackBtn.Text = "Back Color";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ModeBtn
            // 
            this.ModeBtn.Location = new System.Drawing.Point(60, 35);
            this.ModeBtn.Name = "ModeBtn";
            this.ModeBtn.Size = new System.Drawing.Size(100, 25);
            this.ModeBtn.TabIndex = 9;
            this.ModeBtn.TabStop = false;
            this.ModeBtn.Text = "Module Color";
            this.ModeBtn.UseVisualStyleBackColor = true;
            this.ModeBtn.Click += new System.EventHandler(this.ModeBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Content);
            this.groupBox3.Location = new System.Drawing.Point(224, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 130);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QRcode Content";
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(35, 53);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(150, 22);
            this.Content.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.FileTypeItems);
            this.groupBox9.Controls.Add(this.Open);
            this.groupBox9.Location = new System.Drawing.Point(224, 277);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 130);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Read File";
            // 
            // FileTypeItems
            // 
            this.FileTypeItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypeItems.FormattingEnabled = true;
            this.FileTypeItems.Location = new System.Drawing.Point(35, 35);
            this.FileTypeItems.Name = "FileTypeItems";
            this.FileTypeItems.Size = new System.Drawing.Size(150, 20);
            this.FileTypeItems.TabIndex = 8;
            this.FileTypeItems.TabStop = false;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(60, 85);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 25);
            this.Open.TabIndex = 1;
            this.Open.TabStop = false;
            this.Open.Text = "Open File";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 130);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(35, 55);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(150, 22);
            this.FileName.TabIndex = 1;
            // 
            // AES_Type
            // 
            this.AES_Type.Controls.Add(this.Xbm);
            this.AES_Type.Controls.Add(this.Svg);
            this.AES_Type.Controls.Add(this.Txt);
            this.AES_Type.Controls.Add(this.Png);
            this.AES_Type.Controls.Add(this.Eps);
            this.AES_Type.Controls.Add(this.Show);
            this.AES_Type.Location = new System.Drawing.Point(3, 413);
            this.AES_Type.Name = "AES_Type";
            this.AES_Type.Size = new System.Drawing.Size(215, 130);
            this.AES_Type.TabIndex = 28;
            this.AES_Type.TabStop = false;
            this.AES_Type.Text = "Hash Create Type";
            // 
            // Xbm
            // 
            this.Xbm.AutoSize = true;
            this.Xbm.Location = new System.Drawing.Point(120, 105);
            this.Xbm.Name = "Xbm";
            this.Xbm.Size = new System.Drawing.Size(49, 16);
            this.Xbm.TabIndex = 12;
            this.Xbm.Text = "XBM";
            this.Xbm.UseVisualStyleBackColor = true;
            // 
            // Svg
            // 
            this.Svg.AutoSize = true;
            this.Svg.Location = new System.Drawing.Point(20, 65);
            this.Svg.Name = "Svg";
            this.Svg.Size = new System.Drawing.Size(45, 16);
            this.Svg.TabIndex = 11;
            this.Svg.Text = "SVG";
            this.Svg.UseVisualStyleBackColor = true;
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Location = new System.Drawing.Point(20, 105);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(45, 16);
            this.Txt.TabIndex = 10;
            this.Txt.Text = "TXT";
            this.Txt.UseVisualStyleBackColor = true;
            // 
            // Png
            // 
            this.Png.AutoSize = true;
            this.Png.Location = new System.Drawing.Point(120, 25);
            this.Png.Name = "Png";
            this.Png.Size = new System.Drawing.Size(45, 16);
            this.Png.TabIndex = 9;
            this.Png.Text = "PNG";
            this.Png.UseVisualStyleBackColor = true;
            // 
            // Eps
            // 
            this.Eps.AutoSize = true;
            this.Eps.Location = new System.Drawing.Point(120, 65);
            this.Eps.Name = "Eps";
            this.Eps.Size = new System.Drawing.Size(42, 16);
            this.Eps.TabIndex = 8;
            this.Eps.Text = "EPS";
            this.Eps.UseVisualStyleBackColor = true;
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Location = new System.Drawing.Point(20, 25);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(49, 16);
            this.Show.TabIndex = 7;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ZoneSize);
            this.groupBox2.Controls.Add(this.Scale);
            this.groupBox2.Location = new System.Drawing.Point(3, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 130);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QRcode Scale And Peripheral size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Scale";
            // 
            // ZoneSize
            // 
            this.ZoneSize.Location = new System.Drawing.Point(65, 85);
            this.ZoneSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZoneSize.Name = "ZoneSize";
            this.ZoneSize.Size = new System.Drawing.Size(125, 22);
            this.ZoneSize.TabIndex = 10;
            this.ZoneSize.TabStop = false;
            this.ZoneSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Scale
            // 
            this.Scale.Location = new System.Drawing.Point(65, 35);
            this.Scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(125, 22);
            this.Scale.TabIndex = 10;
            this.Scale.TabStop = false;
            this.Scale.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.Encodings);
            this.groupBox6.Location = new System.Drawing.Point(224, 141);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 130);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Encoding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Encoding";
            // 
            // Encodings
            // 
            this.Encodings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Encodings.FormattingEnabled = true;
            this.Encodings.Location = new System.Drawing.Point(77, 60);
            this.Encodings.Name = "Encodings";
            this.Encodings.Size = new System.Drawing.Size(121, 20);
            this.Encodings.TabIndex = 7;
            this.Encodings.TabStop = false;
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AES_Type);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox1);
            this.Name = "QR";
            this.Size = new System.Drawing.Size(450, 550);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AES_Type.ResumeLayout(false);
            this.AES_Type.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoneSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox FileTypeItems;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ModeBtn;
        private System.Windows.Forms.GroupBox AES_Type;
        private System.Windows.Forms.RadioButton Xbm;
        private System.Windows.Forms.RadioButton Svg;
        private System.Windows.Forms.RadioButton Txt;
        private System.Windows.Forms.RadioButton Png;
        private System.Windows.Forms.RadioButton Eps;
        private System.Windows.Forms.RadioButton Show;
        private System.Windows.Forms.ColorDialog ModeColor;
        private System.Windows.Forms.ColorDialog BackColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown Scale;
        private System.Windows.Forms.NumericUpDown ZoneSize;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Encodings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
