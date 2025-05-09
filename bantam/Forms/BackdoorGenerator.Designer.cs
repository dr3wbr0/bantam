﻿namespace bantam.Forms
{
    partial class BackdoorGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBoxBackdoor = new System.Windows.Forms.RichTextBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblRequestVarName = new System.Windows.Forms.Label();
            this.txtBoxVarName = new System.Windows.Forms.TextBox();
            this.chkbxMinifyCode = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVarType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chckbxGzipDecodeRequest = new System.Windows.Forms.CheckBox();
            this.labelOr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIVVarName = new System.Windows.Forms.TextBox();
            this.checkBoxSendIVInRequest = new System.Windows.Forms.CheckBox();
            this.buttonRandomIV = new System.Windows.Forms.Button();
            this.buttonRandomKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEncrpytionIV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEncrpytionKey = new System.Windows.Forms.TextBox();
            this.checkBoxEncryptRequest = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRequestEncryptionType = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddShell = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxBackdoor
            // 
            this.richTextBoxBackdoor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBackdoor.Location = new System.Drawing.Point(15, 28);
            this.richTextBoxBackdoor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxBackdoor.Name = "richTextBoxBackdoor";
            this.richTextBoxBackdoor.Size = new System.Drawing.Size(675, 421);
            this.richTextBoxBackdoor.TabIndex = 2;
            this.richTextBoxBackdoor.Text = "";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "eval",
            "create_function",
            "tmp include"});
            this.comboBoxMethod.Location = new System.Drawing.Point(86, 470);
            this.comboBoxMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(143, 24);
            this.comboBoxMethod.TabIndex = 3;
            this.comboBoxMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(10, 474);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(57, 16);
            this.lblMethod.TabIndex = 4;
            this.lblMethod.Text = "Method:";
            // 
            // lblRequestVarName
            // 
            this.lblRequestVarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRequestVarName.AutoSize = true;
            this.lblRequestVarName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestVarName.Location = new System.Drawing.Point(10, 544);
            this.lblRequestVarName.Name = "lblRequestVarName";
            this.lblRequestVarName.Size = new System.Drawing.Size(70, 16);
            this.lblRequestVarName.TabIndex = 5;
            this.lblRequestVarName.Text = "Var Name:";
            // 
            // txtBoxVarName
            // 
            this.txtBoxVarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxVarName.Location = new System.Drawing.Point(86, 539);
            this.txtBoxVarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxVarName.Name = "txtBoxVarName";
            this.txtBoxVarName.Size = new System.Drawing.Size(143, 24);
            this.txtBoxVarName.TabIndex = 6;
            this.txtBoxVarName.Text = "command";
            this.txtBoxVarName.TextChanged += new System.EventHandler(this.txtBoxVarName_TextChanged);
            // 
            // chkbxMinifyCode
            // 
            this.chkbxMinifyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxMinifyCode.AutoSize = true;
            this.chkbxMinifyCode.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.chkbxMinifyCode.Location = new System.Drawing.Point(496, 474);
            this.chkbxMinifyCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbxMinifyCode.Name = "chkbxMinifyCode";
            this.chkbxMinifyCode.Size = new System.Drawing.Size(97, 20);
            this.chkbxMinifyCode.TabIndex = 7;
            this.chkbxMinifyCode.Text = "Minify Code";
            this.chkbxMinifyCode.UseVisualStyleBackColor = true;
            this.chkbxMinifyCode.CheckedChanged += new System.EventHandler(this.chkbxMinifyCode_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Var Type:";
            // 
            // comboBoxVarType
            // 
            this.comboBoxVarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxVarType.FormattingEnabled = true;
            this.comboBoxVarType.Items.AddRange(new object[] {
            "cookie",
            "post",
            "request"});
            this.comboBoxVarType.Location = new System.Drawing.Point(86, 505);
            this.comboBoxVarType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxVarType.Name = "comboBoxVarType";
            this.comboBoxVarType.Size = new System.Drawing.Size(143, 24);
            this.comboBoxVarType.TabIndex = 9;
            this.comboBoxVarType.SelectedIndexChanged += new System.EventHandler(this.comboBoxVarType_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.saveAsToolStripMenuItem1});
            this.saveAsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.saveAsToolStripMenuItem.Text = "File";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addClientToolStripMenuItem.Text = "Add Shell";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // chckbxGzipDecodeRequest
            // 
            this.chckbxGzipDecodeRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chckbxGzipDecodeRequest.AutoSize = true;
            this.chckbxGzipDecodeRequest.Location = new System.Drawing.Point(496, 506);
            this.chckbxGzipDecodeRequest.Name = "chckbxGzipDecodeRequest";
            this.chckbxGzipDecodeRequest.Size = new System.Drawing.Size(159, 20);
            this.chckbxGzipDecodeRequest.TabIndex = 11;
            this.chckbxGzipDecodeRequest.Text = "Gzip Decode Requests";
            this.chckbxGzipDecodeRequest.UseVisualStyleBackColor = true;
            this.chckbxGzipDecodeRequest.CheckedChanged += new System.EventHandler(this.chckbxGzipDecodeRequest_CheckedChanged);
            // 
            // labelOr
            // 
            this.labelOr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOr.AutoSize = true;
            this.labelOr.Location = new System.Drawing.Point(189, 706);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(21, 16);
            this.labelOr.TabIndex = 37;
            this.labelOr.Text = "or";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 729);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "IV Var Name:";
            // 
            // textBoxIVVarName
            // 
            this.textBoxIVVarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIVVarName.Enabled = false;
            this.textBoxIVVarName.Location = new System.Drawing.Point(118, 726);
            this.textBoxIVVarName.MaxLength = 16;
            this.textBoxIVVarName.Name = "textBoxIVVarName";
            this.textBoxIVVarName.Size = new System.Drawing.Size(163, 24);
            this.textBoxIVVarName.TabIndex = 35;
            this.textBoxIVVarName.TextChanged += new System.EventHandler(this.textBoxIVVarName_TextChanged);
            // 
            // checkBoxSendIVInRequest
            // 
            this.checkBoxSendIVInRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSendIVInRequest.AutoSize = true;
            this.checkBoxSendIVInRequest.Enabled = false;
            this.checkBoxSendIVInRequest.Location = new System.Drawing.Point(145, 602);
            this.checkBoxSendIVInRequest.Name = "checkBoxSendIVInRequest";
            this.checkBoxSendIVInRequest.Size = new System.Drawing.Size(136, 20);
            this.checkBoxSendIVInRequest.TabIndex = 34;
            this.checkBoxSendIVInRequest.Text = "Send IV In Request";
            this.checkBoxSendIVInRequest.UseVisualStyleBackColor = true;
            this.checkBoxSendIVInRequest.CheckedChanged += new System.EventHandler(this.checkBoxSendIVInRequest_CheckedChanged);
            // 
            // buttonRandomIV
            // 
            this.buttonRandomIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRandomIV.Enabled = false;
            this.buttonRandomIV.Image = global::bantam.Properties.Resources.generate_16x16;
            this.buttonRandomIV.Location = new System.Drawing.Point(287, 678);
            this.buttonRandomIV.Name = "buttonRandomIV";
            this.buttonRandomIV.Size = new System.Drawing.Size(24, 24);
            this.buttonRandomIV.TabIndex = 33;
            this.buttonRandomIV.UseVisualStyleBackColor = true;
            this.buttonRandomIV.Click += new System.EventHandler(this.buttonRandomIV_Click);
            // 
            // buttonRandomKey
            // 
            this.buttonRandomKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRandomKey.Enabled = false;
            this.buttonRandomKey.Image = global::bantam.Properties.Resources.generate_16x16;
            this.buttonRandomKey.Location = new System.Drawing.Point(402, 639);
            this.buttonRandomKey.Name = "buttonRandomKey";
            this.buttonRandomKey.Size = new System.Drawing.Size(24, 24);
            this.buttonRandomKey.TabIndex = 32;
            this.buttonRandomKey.UseVisualStyleBackColor = true;
            this.buttonRandomKey.Click += new System.EventHandler(this.buttonRandomKey_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 639);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Encryption Key:";
            this.toolTip1.SetToolTip(this.label6, "Must be 32 charectors long.");
            // 
            // textBoxEncrpytionIV
            // 
            this.textBoxEncrpytionIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxEncrpytionIV.Enabled = false;
            this.textBoxEncrpytionIV.Location = new System.Drawing.Point(118, 678);
            this.textBoxEncrpytionIV.MaxLength = 16;
            this.textBoxEncrpytionIV.Name = "textBoxEncrpytionIV";
            this.textBoxEncrpytionIV.Size = new System.Drawing.Size(163, 24);
            this.textBoxEncrpytionIV.TabIndex = 30;
            this.toolTip1.SetToolTip(this.textBoxEncrpytionIV, "Must be 16 charectors long.");
            this.textBoxEncrpytionIV.TextChanged += new System.EventHandler(this.textBoxEncrpytionIV_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Encryption IV:";
            this.toolTip1.SetToolTip(this.label2, "Must be 16 charectors long.");
            // 
            // textBoxEncrpytionKey
            // 
            this.textBoxEncrpytionKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxEncrpytionKey.Enabled = false;
            this.textBoxEncrpytionKey.Location = new System.Drawing.Point(118, 639);
            this.textBoxEncrpytionKey.MaxLength = 32;
            this.textBoxEncrpytionKey.Name = "textBoxEncrpytionKey";
            this.textBoxEncrpytionKey.Size = new System.Drawing.Size(278, 24);
            this.textBoxEncrpytionKey.TabIndex = 28;
            this.toolTip1.SetToolTip(this.textBoxEncrpytionKey, "Must be 32 charectors long.");
            this.textBoxEncrpytionKey.TextChanged += new System.EventHandler(this.textBoxEncrpytionKey_TextChanged);
            // 
            // checkBoxEncryptRequest
            // 
            this.checkBoxEncryptRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxEncryptRequest.AutoSize = true;
            this.checkBoxEncryptRequest.Location = new System.Drawing.Point(14, 602);
            this.checkBoxEncryptRequest.Name = "checkBoxEncryptRequest";
            this.checkBoxEncryptRequest.Size = new System.Drawing.Size(121, 20);
            this.checkBoxEncryptRequest.TabIndex = 27;
            this.checkBoxEncryptRequest.Text = "Encrypt Request";
            this.checkBoxEncryptRequest.UseVisualStyleBackColor = true;
            this.checkBoxEncryptRequest.CheckedChanged += new System.EventHandler(this.checkBoxEncryptRequest_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(13, 585);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(674, 1);
            this.label7.TabIndex = 38;
            // 
            // comboBoxRequestEncryptionType
            // 
            this.comboBoxRequestEncryptionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxRequestEncryptionType.Enabled = false;
            this.comboBoxRequestEncryptionType.FormattingEnabled = true;
            this.comboBoxRequestEncryptionType.Location = new System.Drawing.Point(287, 600);
            this.comboBoxRequestEncryptionType.Name = "comboBoxRequestEncryptionType";
            this.comboBoxRequestEncryptionType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRequestEncryptionType.TabIndex = 39;
            this.comboBoxRequestEncryptionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRequestEncryptionType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 770);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(674, 1);
            this.label3.TabIndex = 40;
            // 
            // btnAddShell
            // 
            this.btnAddShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddShell.Location = new System.Drawing.Point(15, 784);
            this.btnAddShell.Name = "btnAddShell";
            this.btnAddShell.Size = new System.Drawing.Size(80, 36);
            this.btnAddShell.TabIndex = 41;
            this.btnAddShell.Text = "Add Shell";
            this.btnAddShell.UseVisualStyleBackColor = true;
            this.btnAddShell.Click += new System.EventHandler(this.btnAddShell_Click);
            // 
            // BackdoorGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 833);
            this.Controls.Add(this.btnAddShell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRequestEncryptionType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelOr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxIVVarName);
            this.Controls.Add(this.checkBoxSendIVInRequest);
            this.Controls.Add(this.buttonRandomIV);
            this.Controls.Add(this.buttonRandomKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEncrpytionIV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEncrpytionKey);
            this.Controls.Add(this.checkBoxEncryptRequest);
            this.Controls.Add(this.chckbxGzipDecodeRequest);
            this.Controls.Add(this.comboBoxVarType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkbxMinifyCode);
            this.Controls.Add(this.txtBoxVarName);
            this.Controls.Add(this.lblRequestVarName);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.richTextBoxBackdoor);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackdoorGenerator";
            this.ShowIcon = false;
            this.Text = "PHP Backdoor Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxBackdoor;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblRequestVarName;
        private System.Windows.Forms.TextBox txtBoxVarName;
        private System.Windows.Forms.CheckBox chkbxMinifyCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVarType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.CheckBox chckbxGzipDecodeRequest;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIVVarName;
        private System.Windows.Forms.CheckBox checkBoxSendIVInRequest;
        private System.Windows.Forms.Button buttonRandomIV;
        private System.Windows.Forms.Button buttonRandomKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEncrpytionIV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEncrpytionKey;
        private System.Windows.Forms.CheckBox checkBoxEncryptRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRequestEncryptionType;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddShell;
    }
}