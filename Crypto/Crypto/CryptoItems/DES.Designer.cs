namespace Crypto.CryptoItems
{
    partial class DES
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
            this.DecryptPadding = new System.Windows.Forms.CheckBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.EncryptPadding = new System.Windows.Forms.CheckBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EncryptionCode = new System.Windows.Forms.ComboBox();
            this.AES_Type = new System.Windows.Forms.GroupBox();
            this.ECB = new System.Windows.Forms.RadioButton();
            this.CBC = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iv = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.New = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.AES_Type.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.CryptionMethod);
            this.groupBox10.Location = new System.Drawing.Point(224, 427);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(215, 100);
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
            this.CryptionMethod.Location = new System.Drawing.Point(40, 45);
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
            this.groupBox4.Location = new System.Drawing.Point(3, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 100);
            this.groupBox4.TabIndex = 9;
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.FileTypeItems);
            this.groupBox9.Controls.Add(this.Open);
            this.groupBox9.Location = new System.Drawing.Point(3, 427);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 100);
            this.groupBox9.TabIndex = 15;
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
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.DecryptPadding);
            this.groupBox8.Controls.Add(this.Decrypt);
            this.groupBox8.Location = new System.Drawing.Point(224, 321);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(215, 100);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Decrypt";
            // 
            // DecryptPadding
            // 
            this.DecryptPadding.AutoSize = true;
            this.DecryptPadding.Location = new System.Drawing.Point(28, 45);
            this.DecryptPadding.Name = "DecryptPadding";
            this.DecryptPadding.Size = new System.Drawing.Size(66, 16);
            this.DecryptPadding.TabIndex = 5;
            this.DecryptPadding.TabStop = false;
            this.DecryptPadding.Text = "Paddings";
            this.DecryptPadding.UseVisualStyleBackColor = true;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(112, 41);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 4;
            this.Decrypt.TabStop = false;
            this.Decrypt.Text = "Open File";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.EncryptPadding);
            this.groupBox7.Controls.Add(this.Encrypt);
            this.groupBox7.Location = new System.Drawing.Point(3, 321);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(215, 100);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Encrypt";
            // 
            // EncryptPadding
            // 
            this.EncryptPadding.AutoSize = true;
            this.EncryptPadding.Location = new System.Drawing.Point(21, 45);
            this.EncryptPadding.Name = "EncryptPadding";
            this.EncryptPadding.Size = new System.Drawing.Size(66, 16);
            this.EncryptPadding.TabIndex = 4;
            this.EncryptPadding.TabStop = false;
            this.EncryptPadding.Text = "Paddings";
            this.EncryptPadding.UseVisualStyleBackColor = true;
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(105, 41);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox6.Location = new System.Drawing.Point(224, 215);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 100);
            this.groupBox6.TabIndex = 13;
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
            // AES_Type
            // 
            this.AES_Type.Controls.Add(this.ECB);
            this.AES_Type.Controls.Add(this.CBC);
            this.AES_Type.Location = new System.Drawing.Point(224, 3);
            this.AES_Type.Name = "AES_Type";
            this.AES_Type.Size = new System.Drawing.Size(215, 100);
            this.AES_Type.TabIndex = 12;
            this.AES_Type.TabStop = false;
            this.AES_Type.Text = "DES Crypto Function";
            // 
            // ECB
            // 
            this.ECB.AutoSize = true;
            this.ECB.Location = new System.Drawing.Point(124, 43);
            this.ECB.Name = "ECB";
            this.ECB.Size = new System.Drawing.Size(46, 16);
            this.ECB.TabIndex = 8;
            this.ECB.Text = "ECB";
            this.ECB.UseVisualStyleBackColor = true;
            // 
            // CBC
            // 
            this.CBC.AutoSize = true;
            this.CBC.Location = new System.Drawing.Point(40, 43);
            this.CBC.Name = "CBC";
            this.CBC.Size = new System.Drawing.Size(47, 16);
            this.CBC.TabIndex = 7;
            this.CBC.Text = "CBC";
            this.CBC.UseVisualStyleBackColor = true;
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
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DES Create";
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
            this.iv.TabIndex = 2;
            this.iv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyiv_KeyDown);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(59, 15);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(100, 22);
            this.key.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.New);
            this.groupBox2.Location = new System.Drawing.Point(224, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DES New";
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(77, 41);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 3;
            this.New.TabStop = false;
            this.New.Text = "New key";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(59, 38);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 22);
            this.FileName.TabIndex = 0;
            // 
            // DES
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
            this.Name = "DES";
            this.Size = new System.Drawing.Size(450, 550);
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.AES_Type.ResumeLayout(false);
            this.AES_Type.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox DecryptPadding;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox EncryptPadding;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EncryptionCode;
        private System.Windows.Forms.GroupBox AES_Type;
        private System.Windows.Forms.RadioButton ECB;
        private System.Windows.Forms.RadioButton CBC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iv;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FileName;
    }
}
