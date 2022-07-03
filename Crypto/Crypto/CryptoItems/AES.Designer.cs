namespace Crypto.CryptoItems
{
    partial class AES
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.New = new System.Windows.Forms.Button();
            this.key256 = new System.Windows.Forms.RadioButton();
            this.key192 = new System.Windows.Forms.RadioButton();
            this.key128 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iv = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Errors = new System.Windows.Forms.ComboBox();
            this.Encodings = new System.Windows.Forms.ComboBox();
            this.AES_Type = new System.Windows.Forms.GroupBox();
            this.ECB = new System.Windows.Forms.RadioButton();
            this.CBC = new System.Windows.Forms.RadioButton();
            this.OFB = new System.Windows.Forms.RadioButton();
            this.CFB = new System.Windows.Forms.RadioButton();
            this.CTR = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EncryptionCode = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EncryptSizeCFB = new System.Windows.Forms.TextBox();
            this.EncryptPadding = new System.Windows.Forms.CheckBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DecryptSizeCFB = new System.Windows.Forms.TextBox();
            this.DecryptPadding = new System.Windows.Forms.CheckBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.FileTypeItems = new System.Windows.Forms.ComboBox();
            this.Open = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.CryptionMethod = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.AES_Type.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(59, 38);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 22);
            this.FileName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.New);
            this.groupBox2.Controls.Add(this.key256);
            this.groupBox2.Controls.Add(this.key192);
            this.groupBox2.Controls.Add(this.key128);
            this.groupBox2.Location = new System.Drawing.Point(224, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES New";
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(105, 38);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 3;
            this.New.TabStop = false;
            this.New.Text = "New key";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // key256
            // 
            this.key256.AutoSize = true;
            this.key256.Location = new System.Drawing.Point(6, 66);
            this.key256.Name = "key256";
            this.key256.Size = new System.Drawing.Size(61, 16);
            this.key256.TabIndex = 2;
            this.key256.Text = "key 256";
            this.key256.UseVisualStyleBackColor = true;
            // 
            // key192
            // 
            this.key192.AutoSize = true;
            this.key192.Location = new System.Drawing.Point(6, 44);
            this.key192.Name = "key192";
            this.key192.Size = new System.Drawing.Size(61, 16);
            this.key192.TabIndex = 1;
            this.key192.Text = "key 192";
            this.key192.UseVisualStyleBackColor = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.iv);
            this.groupBox3.Controls.Add(this.key);
            this.groupBox3.Controls.Add(this.Create);
            this.groupBox3.Location = new System.Drawing.Point(3, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AES Create";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "IV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "KEY";
            // 
            // iv
            // 
            this.iv.Location = new System.Drawing.Point(59, 43);
            this.iv.Name = "iv";
            this.iv.Size = new System.Drawing.Size(100, 22);
            this.iv.TabIndex = 3;
            this.iv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyiv_KeyDown);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(59, 15);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(100, 22);
            this.key.TabIndex = 2;
            this.key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyiv_KeyDown);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(71, 71);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 0;
            this.Create.TabStop = false;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Errors);
            this.groupBox4.Controls.Add(this.Encodings);
            this.groupBox4.Location = new System.Drawing.Point(3, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encoding ErrorType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Error";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Encoding";
            // 
            // Errors
            // 
            this.Errors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Errors.FormattingEnabled = true;
            this.Errors.Location = new System.Drawing.Point(77, 63);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(121, 20);
            this.Errors.TabIndex = 1;
            this.Errors.TabStop = false;
            // 
            // Encodings
            // 
            this.Encodings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Encodings.FormattingEnabled = true;
            this.Encodings.Location = new System.Drawing.Point(77, 21);
            this.Encodings.Name = "Encodings";
            this.Encodings.Size = new System.Drawing.Size(121, 20);
            this.Encodings.TabIndex = 0;
            this.Encodings.TabStop = false;
            // 
            // AES_Type
            // 
            this.AES_Type.Controls.Add(this.ECB);
            this.AES_Type.Controls.Add(this.CBC);
            this.AES_Type.Controls.Add(this.OFB);
            this.AES_Type.Controls.Add(this.CFB);
            this.AES_Type.Controls.Add(this.CTR);
            this.AES_Type.Location = new System.Drawing.Point(224, 3);
            this.AES_Type.Name = "AES_Type";
            this.AES_Type.Size = new System.Drawing.Size(215, 100);
            this.AES_Type.TabIndex = 2;
            this.AES_Type.TabStop = false;
            this.AES_Type.Text = "AES Crypto Function";
            // 
            // ECB
            // 
            this.ECB.AutoSize = true;
            this.ECB.Location = new System.Drawing.Point(133, 65);
            this.ECB.Name = "ECB";
            this.ECB.Size = new System.Drawing.Size(46, 16);
            this.ECB.TabIndex = 8;
            this.ECB.Text = "ECB";
            this.ECB.UseVisualStyleBackColor = true;
            // 
            // CBC
            // 
            this.CBC.AutoSize = true;
            this.CBC.Location = new System.Drawing.Point(133, 21);
            this.CBC.Name = "CBC";
            this.CBC.Size = new System.Drawing.Size(47, 16);
            this.CBC.TabIndex = 7;
            this.CBC.Text = "CBC";
            this.CBC.UseVisualStyleBackColor = true;
            // 
            // OFB
            // 
            this.OFB.AutoSize = true;
            this.OFB.Location = new System.Drawing.Point(31, 65);
            this.OFB.Name = "OFB";
            this.OFB.Size = new System.Drawing.Size(45, 16);
            this.OFB.TabIndex = 6;
            this.OFB.Text = "OFB";
            this.OFB.UseVisualStyleBackColor = true;
            // 
            // CFB
            // 
            this.CFB.AutoSize = true;
            this.CFB.Location = new System.Drawing.Point(83, 43);
            this.CFB.Name = "CFB";
            this.CFB.Size = new System.Drawing.Size(45, 16);
            this.CFB.TabIndex = 5;
            this.CFB.Text = "CFB";
            this.CFB.UseVisualStyleBackColor = true;
            // 
            // CTR
            // 
            this.CTR.AutoSize = true;
            this.CTR.Location = new System.Drawing.Point(31, 21);
            this.CTR.Name = "CTR";
            this.CTR.Size = new System.Drawing.Size(46, 16);
            this.CTR.TabIndex = 4;
            this.CTR.Text = "CTR";
            this.CTR.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.EncryptionCode);
            this.groupBox6.Location = new System.Drawing.Point(224, 215);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Encryption Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Encoding";
            // 
            // EncryptionCode
            // 
            this.EncryptionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncryptionCode.FormattingEnabled = true;
            this.EncryptionCode.Location = new System.Drawing.Point(77, 39);
            this.EncryptionCode.Name = "EncryptionCode";
            this.EncryptionCode.Size = new System.Drawing.Size(121, 20);
            this.EncryptionCode.TabIndex = 7;
            this.EncryptionCode.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.EncryptSizeCFB);
            this.groupBox7.Controls.Add(this.EncryptPadding);
            this.groupBox7.Controls.Add(this.Encrypt);
            this.groupBox7.Location = new System.Drawing.Point(3, 321);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(215, 100);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Encrypt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "CFB Segment";
            // 
            // EncryptSizeCFB
            // 
            this.EncryptSizeCFB.Location = new System.Drawing.Point(55, 34);
            this.EncryptSizeCFB.Name = "EncryptSizeCFB";
            this.EncryptSizeCFB.Size = new System.Drawing.Size(100, 22);
            this.EncryptSizeCFB.TabIndex = 4;
            // 
            // EncryptPadding
            // 
            this.EncryptPadding.AutoSize = true;
            this.EncryptPadding.Location = new System.Drawing.Point(21, 66);
            this.EncryptPadding.Name = "EncryptPadding";
            this.EncryptPadding.Size = new System.Drawing.Size(66, 16);
            this.EncryptPadding.TabIndex = 4;
            this.EncryptPadding.TabStop = false;
            this.EncryptPadding.Text = "Paddings";
            this.EncryptPadding.UseVisualStyleBackColor = true;
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(105, 62);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 3;
            this.Encrypt.TabStop = false;
            this.Encrypt.Text = "Open File";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.DecryptSizeCFB);
            this.groupBox8.Controls.Add(this.DecryptPadding);
            this.groupBox8.Controls.Add(this.Decrypt);
            this.groupBox8.Location = new System.Drawing.Point(224, 321);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(215, 100);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Decrypt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "CFB Segment";
            // 
            // DecryptSizeCFB
            // 
            this.DecryptSizeCFB.Location = new System.Drawing.Point(62, 34);
            this.DecryptSizeCFB.Name = "DecryptSizeCFB";
            this.DecryptSizeCFB.Size = new System.Drawing.Size(100, 22);
            this.DecryptSizeCFB.TabIndex = 5;
            // 
            // DecryptPadding
            // 
            this.DecryptPadding.AutoSize = true;
            this.DecryptPadding.Location = new System.Drawing.Point(28, 66);
            this.DecryptPadding.Name = "DecryptPadding";
            this.DecryptPadding.Size = new System.Drawing.Size(66, 16);
            this.DecryptPadding.TabIndex = 5;
            this.DecryptPadding.TabStop = false;
            this.DecryptPadding.Text = "Paddings";
            this.DecryptPadding.UseVisualStyleBackColor = true;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(112, 62);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 4;
            this.Decrypt.TabStop = false;
            this.Decrypt.Text = "Open File";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.FileTypeItems);
            this.groupBox9.Controls.Add(this.Open);
            this.groupBox9.Location = new System.Drawing.Point(3, 427);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 100);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Read File";
            // 
            // FileTypeItems
            // 
            this.FileTypeItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypeItems.FormattingEnabled = true;
            this.FileTypeItems.Location = new System.Drawing.Point(49, 21);
            this.FileTypeItems.Name = "FileTypeItems";
            this.FileTypeItems.Size = new System.Drawing.Size(121, 20);
            this.FileTypeItems.TabIndex = 8;
            this.FileTypeItems.TabStop = false;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(71, 60);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 1;
            this.Open.TabStop = false;
            this.Open.Text = "Open File";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.CryptionMethod);
            this.groupBox10.Location = new System.Drawing.Point(224, 427);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(215, 100);
            this.groupBox10.TabIndex = 1;
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
            this.CryptionMethod.Location = new System.Drawing.Point(40, 45);
            this.CryptionMethod.Name = "CryptionMethod";
            this.CryptionMethod.Size = new System.Drawing.Size(140, 20);
            this.CryptionMethod.TabIndex = 8;
            this.CryptionMethod.TabStop = false;
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.AES_Type);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AES";
            this.Size = new System.Drawing.Size(450, 550);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.AES_Type.ResumeLayout(false);
            this.AES_Type.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.RadioButton key256;
        private System.Windows.Forms.RadioButton key192;
        private System.Windows.Forms.RadioButton key128;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox AES_Type;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iv;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ComboBox Encodings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Errors;
        private System.Windows.Forms.RadioButton ECB;
        private System.Windows.Forms.RadioButton CBC;
        private System.Windows.Forms.RadioButton OFB;
        private System.Windows.Forms.RadioButton CFB;
        private System.Windows.Forms.RadioButton CTR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EncryptionCode;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.ComboBox FileTypeItems;
        private System.Windows.Forms.CheckBox EncryptPadding;
        private System.Windows.Forms.CheckBox DecryptPadding;
        private System.Windows.Forms.TextBox EncryptSizeCFB;
        private System.Windows.Forms.TextBox DecryptSizeCFB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CryptionMethod;
    }
}
