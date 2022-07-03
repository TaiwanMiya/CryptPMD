namespace Crypto.CryptoItems
{
    partial class UUID
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.FileTypeItems = new System.Windows.Forms.ComboBox();
            this.Open = new System.Windows.Forms.Button();
            this.AES_Type = new System.Windows.Forms.GroupBox();
            this.UUID5 = new System.Windows.Forms.RadioButton();
            this.UUID3 = new System.Windows.Forms.RadioButton();
            this.UUID4 = new System.Windows.Forms.RadioButton();
            this.UUID1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Generates = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StringName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.X500 = new System.Windows.Forms.RadioButton();
            this.URL = new System.Windows.Forms.RadioButton();
            this.OID = new System.Windows.Forms.RadioButton();
            this.DNS = new System.Windows.Forms.RadioButton();
            this.CreateCounter = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Create = new System.Windows.Forms.Button();
            this.groupBox9.SuspendLayout();
            this.AES_Type.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateCounter)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.FileTypeItems);
            this.groupBox9.Controls.Add(this.Open);
            this.groupBox9.Location = new System.Drawing.Point(224, 141);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 130);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Read File";
            // 
            // FileTypeItems
            // 
            this.FileTypeItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypeItems.FormattingEnabled = true;
            this.FileTypeItems.Location = new System.Drawing.Point(41, 30);
            this.FileTypeItems.Name = "FileTypeItems";
            this.FileTypeItems.Size = new System.Drawing.Size(150, 20);
            this.FileTypeItems.TabIndex = 8;
            this.FileTypeItems.TabStop = false;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(63, 80);
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
            this.AES_Type.Controls.Add(this.UUID5);
            this.AES_Type.Controls.Add(this.UUID3);
            this.AES_Type.Controls.Add(this.UUID4);
            this.AES_Type.Controls.Add(this.UUID1);
            this.AES_Type.Location = new System.Drawing.Point(3, 275);
            this.AES_Type.Name = "AES_Type";
            this.AES_Type.Size = new System.Drawing.Size(215, 130);
            this.AES_Type.TabIndex = 12;
            this.AES_Type.TabStop = false;
            this.AES_Type.Text = "UUID Production Type";
            // 
            // UUID5
            // 
            this.UUID5.AutoSize = true;
            this.UUID5.Location = new System.Drawing.Point(130, 90);
            this.UUID5.Name = "UUID5";
            this.UUID5.Size = new System.Drawing.Size(51, 16);
            this.UUID5.TabIndex = 8;
            this.UUID5.Text = "SHA1";
            this.UUID5.UseVisualStyleBackColor = true;
            this.UUID5.CheckedChanged += new System.EventHandler(this.UUID5_CheckedChanged);
            // 
            // UUID3
            // 
            this.UUID3.AutoSize = true;
            this.UUID3.Location = new System.Drawing.Point(130, 40);
            this.UUID3.Name = "UUID3";
            this.UUID3.Size = new System.Drawing.Size(47, 16);
            this.UUID3.TabIndex = 7;
            this.UUID3.Text = "MD5";
            this.UUID3.UseVisualStyleBackColor = true;
            this.UUID3.CheckedChanged += new System.EventHandler(this.UUID3_CheckedChanged);
            // 
            // UUID4
            // 
            this.UUID4.AutoSize = true;
            this.UUID4.Location = new System.Drawing.Point(30, 90);
            this.UUID4.Name = "UUID4";
            this.UUID4.Size = new System.Drawing.Size(73, 16);
            this.UUID4.TabIndex = 6;
            this.UUID4.Text = "RANDOM";
            this.UUID4.UseVisualStyleBackColor = true;
            this.UUID4.CheckedChanged += new System.EventHandler(this.UUID4_CheckedChanged);
            // 
            // UUID1
            // 
            this.UUID1.AutoSize = true;
            this.UUID1.Location = new System.Drawing.Point(30, 40);
            this.UUID1.Name = "UUID1";
            this.UUID1.Size = new System.Drawing.Size(53, 16);
            this.UUID1.TabIndex = 4;
            this.UUID1.Text = "DATE";
            this.UUID1.UseVisualStyleBackColor = true;
            this.UUID1.CheckedChanged += new System.EventHandler(this.UUID1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 130);
            this.groupBox1.TabIndex = 7;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Generates);
            this.groupBox2.Location = new System.Drawing.Point(224, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 130);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Type";
            // 
            // Generates
            // 
            this.Generates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Generates.FormattingEnabled = true;
            this.Generates.Location = new System.Drawing.Point(41, 55);
            this.Generates.Name = "Generates";
            this.Generates.Size = new System.Drawing.Size(150, 20);
            this.Generates.TabIndex = 8;
            this.Generates.TabStop = false;
            this.Generates.SelectedIndexChanged += new System.EventHandler(this.Generates_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StringName);
            this.groupBox3.Location = new System.Drawing.Point(3, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 130);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "String";
            // 
            // StringName
            // 
            this.StringName.Location = new System.Drawing.Point(35, 55);
            this.StringName.Name = "StringName";
            this.StringName.Size = new System.Drawing.Size(150, 22);
            this.StringName.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.X500);
            this.groupBox4.Controls.Add(this.URL);
            this.groupBox4.Controls.Add(this.OID);
            this.groupBox4.Controls.Add(this.DNS);
            this.groupBox4.Location = new System.Drawing.Point(224, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 130);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Name Space";
            // 
            // X500
            // 
            this.X500.AutoSize = true;
            this.X500.Location = new System.Drawing.Point(130, 90);
            this.X500.Name = "X500";
            this.X500.Size = new System.Drawing.Size(49, 16);
            this.X500.TabIndex = 8;
            this.X500.Text = "X500";
            this.X500.UseVisualStyleBackColor = true;
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(130, 40);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(46, 16);
            this.URL.TabIndex = 7;
            this.URL.Text = "URL";
            this.URL.UseVisualStyleBackColor = true;
            // 
            // OID
            // 
            this.OID.AutoSize = true;
            this.OID.Location = new System.Drawing.Point(30, 90);
            this.OID.Name = "OID";
            this.OID.Size = new System.Drawing.Size(43, 16);
            this.OID.TabIndex = 6;
            this.OID.Text = "OID";
            this.OID.UseVisualStyleBackColor = true;
            // 
            // DNS
            // 
            this.DNS.AutoSize = true;
            this.DNS.Location = new System.Drawing.Point(30, 40);
            this.DNS.Name = "DNS";
            this.DNS.Size = new System.Drawing.Size(45, 16);
            this.DNS.TabIndex = 4;
            this.DNS.Text = "DNS";
            this.DNS.UseVisualStyleBackColor = true;
            // 
            // CreateCounter
            // 
            this.CreateCounter.Location = new System.Drawing.Point(41, 55);
            this.CreateCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CreateCounter.Name = "CreateCounter";
            this.CreateCounter.Size = new System.Drawing.Size(150, 22);
            this.CreateCounter.TabIndex = 9;
            this.CreateCounter.TabStop = false;
            this.CreateCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Create);
            this.groupBox5.Location = new System.Drawing.Point(3, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 130);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create UUID";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CreateCounter);
            this.groupBox6.Location = new System.Drawing.Point(224, 411);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 130);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Counter";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(35, 55);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(150, 25);
            this.Create.TabIndex = 2;
            this.Create.TabStop = false;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // UUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.AES_Type);
            this.Controls.Add(this.groupBox1);
            this.Name = "UUID";
            this.Size = new System.Drawing.Size(450, 550);
            this.groupBox9.ResumeLayout(false);
            this.AES_Type.ResumeLayout(false);
            this.AES_Type.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateCounter)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox FileTypeItems;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.GroupBox AES_Type;
        private System.Windows.Forms.RadioButton UUID5;
        private System.Windows.Forms.RadioButton UUID3;
        private System.Windows.Forms.RadioButton UUID4;
        private System.Windows.Forms.RadioButton UUID1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Generates;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox StringName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton X500;
        private System.Windows.Forms.RadioButton URL;
        private System.Windows.Forms.RadioButton OID;
        private System.Windows.Forms.RadioButton DNS;
        private System.Windows.Forms.NumericUpDown CreateCounter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}
