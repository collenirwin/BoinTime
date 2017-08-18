namespace BoinTime {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblSettings = new System.Windows.Forms.Label();
            this.chkCloseWarning = new System.Windows.Forms.CheckBox();
            this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblBoinTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.chk24Hour = new System.Windows.Forms.CheckBox();
            this.chkShowAMPM = new System.Windows.Forms.CheckBox();
            this.btnSave = new BoinBoxNS.BoinBox();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(12, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(79, 25);
            this.lblSettings.TabIndex = 10;
            this.lblSettings.Text = "Settings";
            // 
            // chkCloseWarning
            // 
            this.chkCloseWarning.AutoSize = true;
            this.chkCloseWarning.Location = new System.Drawing.Point(17, 64);
            this.chkCloseWarning.Name = "chkCloseWarning";
            this.chkCloseWarning.Size = new System.Drawing.Size(116, 19);
            this.chkCloseWarning.TabIndex = 0;
            this.chkCloseWarning.Text = "One click closing";
            this.chkCloseWarning.UseVisualStyleBackColor = true;
            // 
            // chkShowInTaskbar
            // 
            this.chkShowInTaskbar.AutoSize = true;
            this.chkShowInTaskbar.Location = new System.Drawing.Point(17, 89);
            this.chkShowInTaskbar.Name = "chkShowInTaskbar";
            this.chkShowInTaskbar.Size = new System.Drawing.Size(109, 19);
            this.chkShowInTaskbar.TabIndex = 1;
            this.chkShowInTaskbar.Text = "Show in taskbar";
            this.chkShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblBoinTime
            // 
            this.lblBoinTime.AutoSize = true;
            this.lblBoinTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoinTime.Location = new System.Drawing.Point(152, 9);
            this.lblBoinTime.Name = "lblBoinTime";
            this.lblBoinTime.Size = new System.Drawing.Size(75, 21);
            this.lblBoinTime.TabIndex = 11;
            this.lblBoinTime.Text = "BoinTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "by Collen Irwin";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.ForeColor = System.Drawing.Color.Silver;
            this.lblVersion.Location = new System.Drawing.Point(42, 45);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(185, 16);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Tag = "version ";
            this.lblVersion.Text = "version 2.0.0.1283";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chk24Hour
            // 
            this.chk24Hour.AutoSize = true;
            this.chk24Hour.Location = new System.Drawing.Point(17, 114);
            this.chk24Hour.Name = "chk24Hour";
            this.chk24Hour.Size = new System.Drawing.Size(105, 19);
            this.chk24Hour.TabIndex = 2;
            this.chk24Hour.Text = "24 hour format";
            this.chk24Hour.UseVisualStyleBackColor = true;
            this.chk24Hour.CheckedChanged += new System.EventHandler(this.chk24Hour_CheckedChanged);
            // 
            // chkShowAMPM
            // 
            this.chkShowAMPM.AutoSize = true;
            this.chkShowAMPM.Location = new System.Drawing.Point(17, 139);
            this.chkShowAMPM.Name = "chkShowAMPM";
            this.chkShowAMPM.Size = new System.Drawing.Size(106, 19);
            this.chkShowAMPM.TabIndex = 3;
            this.chkShowAMPM.Text = "Show AM / PM";
            this.chkShowAMPM.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AntiAliased = false;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSave.BorderColor = System.Drawing.Color.Empty;
            this.btnSave.BorderSize = 0;
            this.btnSave.FakeDisabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(178, 154);
            this.btnSave.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.MouseDownForeColor = System.Drawing.Color.White;
            this.btnSave.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.MouseOverForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(239, 196);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkShowAMPM);
            this.Controls.Add(this.chk24Hour);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBoinTime);
            this.Controls.Add(this.chkShowInTaskbar);
            this.Controls.Add(this.chkCloseWarning);
            this.Controls.Add(this.lblSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings - BoinTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.CheckBox chkCloseWarning;
        private System.Windows.Forms.CheckBox chkShowInTaskbar;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblBoinTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.CheckBox chk24Hour;
        private System.Windows.Forms.CheckBox chkShowAMPM;
        private BoinBoxNS.BoinBox btnSave;
    }
}