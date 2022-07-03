namespace Crypto.CryptoItems
{
    partial class RSA
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.CryptionMethod = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Errors = new System.Windows.Forms.ComboBox();
            this.Encodings = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.FileTypeItems = new System.Windows.Forms.ComboBox();
            this.Open = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EncryptionCode = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.key4096 = new System.Windows.Forms.RadioButton();
            this.key2048 = new System.Windows.Forms.RadioButton();
            this.key1024 = new System.Windows.Forms.RadioButton();
            this.New = new System.Windows.Forms.Button();
            this.key512 = new System.Windows.Forms.RadioButton();
            this.key256 = new System.Windows.Forms.RadioButton();
            this.key128 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.CryptionMethod);
            this.groupBox10.Location = new System.Drawing.Point(224, 396);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(215, 125);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Encryption Decryption method";
            // 
            // CryptionMethod
            // 
            this.CryptionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CryptionMethod.FormattingEnabled = true;
            this.CryptionMethod.Items.AddRange(new object[] {
            "Encrypt/Decrypt All",
            "Encrypt/Decrypt Line"});
            this.CryptionMethod.Location = new System.Drawing.Point(34, 60);
            this.CryptionMethod.Name = "CryptionMethod";
            this.CryptionMethod.Size = new System.Drawing.Size(140, 20);
            this.CryptionMethod.TabIndex = 8;
            this.CryptionMethod.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Errors);
            this.groupBox4.Controls.Add(this.Encodings);
            this.groupBox4.Location = new System.Drawing.Point(224, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 125);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encoding ErrorType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Error";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Encoding";
            // 
            // Errors
            // 
            this.Errors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Errors.FormattingEnabled = true;
            this.Errors.Location = new System.Drawing.Point(77, 76);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(121, 20);
            this.Errors.TabIndex = 1;
            this.Errors.TabStop = false;
            // 
            // Encodings
            // 
            this.Encodings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Encodings.FormattingEnabled = true;
            this.Encodings.Location = new System.Drawing.Point(77, 34);
            this.Encodings.Name = "Encodings";
            this.Encodings.Size = new System.Drawing.Size(121, 20);
            this.Encodings.TabIndex = 0;
            this.Encodings.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.FileTypeItems);
            this.groupBox9.Controls.Add(this.Open);
            this.groupBox9.Location = new System.Drawing.Point(3, 396);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 125);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Read File";
            // 
            // FileTypeItems
            // 
            this.FileTypeItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypeItems.FormattingEnabled = true;
            this.FileTypeItems.Location = new System.Drawing.Point(49, 40);
            this.FileTypeItems.Name = "FileTypeItems";
            this.FileTypeItems.Size = new System.Drawing.Size(121, 20);
            this.FileTypeItems.TabIndex = 8;
            this.FileTypeItems.TabStop = false;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(71, 80);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 1;
            this.Open.TabStop = false;
            this.Open.Text = "Open File";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Decrypt);
            this.groupBox8.Location = new System.Drawing.Point(3, 265);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(215, 125);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Decrypt";
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(59, 53);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(100, 25);
            this.Decrypt.TabIndex = 4;
            this.Decrypt.TabStop = false;
            this.Decrypt.Text = "Open File";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Encrypt);
            this.groupBox7.Location = new System.Drawing.Point(3, 134);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(215, 125);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Encrypt";
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(59, 53);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(100, 25);
            this.Encrypt.TabIndex = 3;
            this.Encrypt.TabStop = false;
            this.Encrypt.Text = "Open File";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.EncryptionCode);
            this.groupBox6.Location = new System.Drawing.Point(224, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 125);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Encryption Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Encoding";
            // 
            // EncryptionCode
            // 
            this.EncryptionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncryptionCode.FormattingEnabled = true;
            this.EncryptionCode.Location = new System.Drawing.Point(82, 54);
            this.EncryptionCode.Name = "EncryptionCode";
            this.EncryptionCode.Size = new System.Drawing.Size(121, 20);
            this.EncryptionCode.TabIndex = 7;
            this.EncryptionCode.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.key4096);
            this.groupBox2.Controls.Add(this.key2048);
            this.groupBox2.Controls.Add(this.key1024);
            this.groupBox2.Controls.Add(this.New);
            this.groupBox2.Controls.Add(this.key512);
            this.groupBox2.Controls.Add(this.key256);
            this.groupBox2.Controls.Add(this.key128);
            this.groupBox2.Location = new System.Drawing.Point(224, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RSA New";
            // 
            // key4096
            // 
            this.key4096.AutoSize = true;
            this.key4096.Location = new System.Drawing.Point(142, 60);
            this.key4096.Name = "key4096";
            this.key4096.Size = new System.Drawing.Size(67, 16);
            this.key4096.TabIndex = 6;
            this.key4096.Text = "key 4096";
            this.key4096.UseVisualStyleBackColor = true;
            // 
            // key2048
            // 
            this.key2048.AutoSize = true;
            this.key2048.Location = new System.Drawing.Point(74, 60);
            this.key2048.Name = "key2048";
            this.key2048.Size = new System.Drawing.Size(67, 16);
            this.key2048.TabIndex = 5;
            this.key2048.Text = "key 2048";
            this.key2048.UseVisualStyleBackColor = true;
            // 
            // key1024
            // 
            this.key1024.AutoSize = true;
            this.key1024.Location = new System.Drawing.Point(6, 60);
            this.key1024.Name = "key1024";
            this.key1024.Size = new System.Drawing.Size(67, 16);
            this.key1024.TabIndex = 4;
            this.key1024.Text = "key 1024";
            this.key1024.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(77, 90);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 3;
            this.New.TabStop = false;
            this.New.Text = "New key";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // key512
            // 
            this.key512.AutoSize = true;
            this.key512.Location = new System.Drawing.Point(142, 21);
            this.key512.Name = "key512";
            this.key512.Size = new System.Drawing.Size(61, 16);
            this.key512.TabIndex = 2;
            this.key512.Text = "key 512";
            this.key512.UseVisualStyleBackColor = true;
            // 
            // key256
            // 
            this.key256.AutoSize = true;
            this.key256.Location = new System.Drawing.Point(74, 21);
            this.key256.Name = "key256";
            this.key256.Size = new System.Drawing.Size(61, 16);
            this.key256.TabIndex = 1;
            this.key256.Text = "key 256";
            this.key256.UseVisualStyleBackColor = true;
            // 
            // key128
            // 
            this.key128.AutoSize = true;
            this.key128.Location = new System.Drawing.Point(6, 21);
            this.key128.Name = "key128";
            this.key128.Size = new System.Drawing.Size(61, 16);
            this.key128.TabIndex = 0;
            this.key128.Text = "key 128";
            this.key128.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(59, 55);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 22);
            this.FileName.TabIndex = 1;
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RSA";
            this.Size = new System.Drawing.Size(450, 550);
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox CryptionMethod;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Errors;
        private System.Windows.Forms.ComboBox Encodings;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox FileTypeItems;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EncryptionCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.RadioButton key512;
        private System.Windows.Forms.RadioButton key256;
        private System.Windows.Forms.RadioButton key128;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.RadioButton key4096;
        private System.Windows.Forms.RadioButton key2048;
        private System.Windows.Forms.RadioButton key1024;
    }
}
