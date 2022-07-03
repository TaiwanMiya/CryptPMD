namespace Crypto.CryptoItems
{
    partial class HASH
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
            this.StringName = new System.Windows.Forms.TextBox();
            this.Generates = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.FileTypeItems = new System.Windows.Forms.ComboBox();
            this.Open = new System.Windows.Forms.Button();
            this.AES_Type = new System.Windows.Forms.GroupBox();
            this.SHA256 = new System.Windows.Forms.RadioButton();
            this.MD5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.SHA384 = new System.Windows.Forms.RadioButton();
            this.SHA1 = new System.Windows.Forms.RadioButton();
            this.SHA512 = new System.Windows.Forms.RadioButton();
            this.SHA224 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.AES_Type.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.StringName);
            this.groupBox5.Controls.Add(this.Create);
            this.groupBox5.Location = new System.Drawing.Point(224, 269);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 260);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create HASH";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(35, 167);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(150, 25);
            this.Create.TabIndex = 2;
            this.Create.TabStop = false;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // StringName
            // 
            this.StringName.Location = new System.Drawing.Point(35, 66);
            this.StringName.Name = "StringName";
            this.StringName.Size = new System.Drawing.Size(150, 22);
            this.StringName.TabIndex = 1;
            // 
            // Generates
            // 
            this.Generates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Generates.FormattingEnabled = true;
            this.Generates.Location = new System.Drawing.Point(36, 68);
            this.Generates.Name = "Generates";
            this.Generates.Size = new System.Drawing.Size(150, 20);
            this.Generates.TabIndex = 8;
            this.Generates.TabStop = false;
            this.Generates.SelectedIndexChanged += new System.EventHandler(this.Generates_SelectedIndexChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.FileTypeItems);
            this.groupBox9.Controls.Add(this.Open);
            this.groupBox9.Location = new System.Drawing.Point(224, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 260);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Read File";
            // 
            // FileTypeItems
            // 
            this.FileTypeItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypeItems.FormattingEnabled = true;
            this.FileTypeItems.Location = new System.Drawing.Point(35, 75);
            this.FileTypeItems.Name = "FileTypeItems";
            this.FileTypeItems.Size = new System.Drawing.Size(150, 20);
            this.FileTypeItems.TabIndex = 8;
            this.FileTypeItems.TabStop = false;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(61, 154);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 25);
            this.Open.TabIndex = 1;
            this.Open.TabStop = false;
            this.Open.Text = "Open File";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // AES_Type
            // 
            this.AES_Type.Controls.Add(this.SHA512);
            this.AES_Type.Controls.Add(this.SHA224);
            this.AES_Type.Controls.Add(this.SHA384);
            this.AES_Type.Controls.Add(this.SHA1);
            this.AES_Type.Controls.Add(this.SHA256);
            this.AES_Type.Controls.Add(this.MD5);
            this.AES_Type.Location = new System.Drawing.Point(3, 269);
            this.AES_Type.Name = "AES_Type";
            this.AES_Type.Size = new System.Drawing.Size(215, 260);
            this.AES_Type.TabIndex = 22;
            this.AES_Type.TabStop = false;
            this.AES_Type.Text = "Hash Create Type";
            // 
            // SHA256
            // 
            this.SHA256.AutoSize = true;
            this.SHA256.Location = new System.Drawing.Point(123, 120);
            this.SHA256.Name = "SHA256";
            this.SHA256.Size = new System.Drawing.Size(63, 16);
            this.SHA256.TabIndex = 8;
            this.SHA256.Text = "SHA256";
            this.SHA256.UseVisualStyleBackColor = true;
            // 
            // MD5
            // 
            this.MD5.AutoSize = true;
            this.MD5.Location = new System.Drawing.Point(22, 50);
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(47, 16);
            this.MD5.TabIndex = 7;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Generates);
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 260);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(36, 170);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(150, 22);
            this.FileName.TabIndex = 1;
            // 
            // SHA384
            // 
            this.SHA384.AutoSize = true;
            this.SHA384.Location = new System.Drawing.Point(22, 190);
            this.SHA384.Name = "SHA384";
            this.SHA384.Size = new System.Drawing.Size(63, 16);
            this.SHA384.TabIndex = 10;
            this.SHA384.Text = "SHA384";
            this.SHA384.UseVisualStyleBackColor = true;
            // 
            // SHA1
            // 
            this.SHA1.AutoSize = true;
            this.SHA1.Location = new System.Drawing.Point(123, 50);
            this.SHA1.Name = "SHA1";
            this.SHA1.Size = new System.Drawing.Size(51, 16);
            this.SHA1.TabIndex = 9;
            this.SHA1.Text = "SHA1";
            this.SHA1.UseVisualStyleBackColor = true;
            // 
            // SHA512
            // 
            this.SHA512.AutoSize = true;
            this.SHA512.Location = new System.Drawing.Point(123, 190);
            this.SHA512.Name = "SHA512";
            this.SHA512.Size = new System.Drawing.Size(63, 16);
            this.SHA512.TabIndex = 12;
            this.SHA512.Text = "SHA512";
            this.SHA512.UseVisualStyleBackColor = true;
            // 
            // SHA224
            // 
            this.SHA224.AutoSize = true;
            this.SHA224.Location = new System.Drawing.Point(22, 120);
            this.SHA224.Name = "SHA224";
            this.SHA224.Size = new System.Drawing.Size(63, 16);
            this.SHA224.TabIndex = 11;
            this.SHA224.Text = "SHA224";
            this.SHA224.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salt String";
            // 
            // HASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.AES_Type);
            this.Controls.Add(this.groupBox1);
            this.Name = "HASH";
            this.Size = new System.Drawing.Size(450, 550);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.AES_Type.ResumeLayout(false);
            this.AES_Type.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox StringName;
        private System.Windows.Forms.ComboBox Generates;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox FileTypeItems;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.GroupBox AES_Type;
        private System.Windows.Forms.RadioButton SHA256;
        private System.Windows.Forms.RadioButton MD5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.RadioButton SHA512;
        private System.Windows.Forms.RadioButton SHA224;
        private System.Windows.Forms.RadioButton SHA384;
        private System.Windows.Forms.RadioButton SHA1;
        private System.Windows.Forms.Label label1;
    }
}
