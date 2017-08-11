namespace BoinTime {
    partial class EditReminder {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtpStarting = new System.Windows.Forms.DateTimePicker();
            this.lblStarting = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblOccurs = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkNotification = new System.Windows.Forms.CheckBox();
            this.txtNotification = new System.Windows.Forms.NumericUpDown();
            this.lblNotificationMins = new System.Windows.Forms.Label();
            this.txtEvery = new System.Windows.Forms.NumericUpDown();
            this.cboEvery = new System.Windows.Forms.ComboBox();
            this.btnDone = new BoinBoxNS.BoinBox();
            this.btnClose = new BoinBoxNS.BoinBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvery)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStarting
            // 
            this.dtpStarting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStarting.CustomFormat = " MM/dd/yyyy, h:mm";
            this.dtpStarting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStarting.Location = new System.Drawing.Point(93, 112);
            this.dtpStarting.Name = "dtpStarting";
            this.dtpStarting.Size = new System.Drawing.Size(146, 23);
            this.dtpStarting.TabIndex = 15;
            // 
            // lblStarting
            // 
            this.lblStarting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStarting.AutoSize = true;
            this.lblStarting.Location = new System.Drawing.Point(36, 117);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(51, 15);
            this.lblStarting.TabIndex = 14;
            this.lblStarting.Text = "Starting:";
            // 
            // cboType
            // 
            this.cboType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "hourly",
            "daily",
            "weekly",
            "monthly",
            "yearly",
            "every",
            "once"});
            this.cboType.Location = new System.Drawing.Point(93, 83);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(146, 23);
            this.cboType.TabIndex = 12;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lblOccurs
            // 
            this.lblOccurs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOccurs.AutoSize = true;
            this.lblOccurs.Location = new System.Drawing.Point(40, 86);
            this.lblOccurs.Name = "lblOccurs";
            this.lblOccurs.Size = new System.Drawing.Size(47, 15);
            this.lblOccurs.TabIndex = 11;
            this.lblOccurs.Text = "Occurs:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(93, 54);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(324, 23);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 57);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "New Reminder";
            // 
            // chkNotification
            // 
            this.chkNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkNotification.AutoSize = true;
            this.chkNotification.Checked = true;
            this.chkNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotification.Location = new System.Drawing.Point(93, 141);
            this.chkNotification.Name = "chkNotification";
            this.chkNotification.Size = new System.Drawing.Size(121, 19);
            this.chkNotification.TabIndex = 16;
            this.chkNotification.Text = "Show Notification";
            this.chkNotification.UseVisualStyleBackColor = true;
            this.chkNotification.CheckedChanged += new System.EventHandler(this.chkNotification_CheckedChanged);
            // 
            // txtNotification
            // 
            this.txtNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNotification.Location = new System.Drawing.Point(93, 166);
            this.txtNotification.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(57, 23);
            this.txtNotification.TabIndex = 17;
            this.txtNotification.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblNotificationMins
            // 
            this.lblNotificationMins.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotificationMins.AutoSize = true;
            this.lblNotificationMins.Location = new System.Drawing.Point(156, 170);
            this.lblNotificationMins.Name = "lblNotificationMins";
            this.lblNotificationMins.Size = new System.Drawing.Size(87, 15);
            this.lblNotificationMins.TabIndex = 18;
            this.lblNotificationMins.Text = "minutes before";
            // 
            // txtEvery
            // 
            this.txtEvery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEvery.Location = new System.Drawing.Point(245, 83);
            this.txtEvery.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtEvery.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtEvery.Name = "txtEvery";
            this.txtEvery.Size = new System.Drawing.Size(57, 23);
            this.txtEvery.TabIndex = 19;
            this.txtEvery.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.txtEvery.Visible = false;
            // 
            // cboEvery
            // 
            this.cboEvery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEvery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvery.FormattingEnabled = true;
            this.cboEvery.Items.AddRange(new object[] {
            "minutes",
            "hours",
            "days",
            "weeks",
            "months",
            "years"});
            this.cboEvery.Location = new System.Drawing.Point(308, 83);
            this.cboEvery.Name = "cboEvery";
            this.cboEvery.Size = new System.Drawing.Size(109, 23);
            this.cboEvery.TabIndex = 20;
            this.cboEvery.Visible = false;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDone.AntiAliased = false;
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDone.BorderColor = System.Drawing.Color.Empty;
            this.btnDone.BorderSize = 0;
            this.btnDone.FakeDisabled = false;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(350, 159);
            this.btnDone.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDone.MouseDownForeColor = System.Drawing.Color.White;
            this.btnDone.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDone.MouseOverForeColor = System.Drawing.Color.White;
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(67, 30);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.AntiAliased = false;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.BorderColor = System.Drawing.Color.Empty;
            this.btnClose.BorderSize = 0;
            this.btnClose.FakeDisabled = false;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(386, 9);
            this.btnClose.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.MouseDownForeColor = System.Drawing.Color.White;
            this.btnClose.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.MouseOverForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 21;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "✖";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EditReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboEvery);
            this.Controls.Add(this.txtEvery);
            this.Controls.Add(this.lblNotificationMins);
            this.Controls.Add(this.txtNotification);
            this.Controls.Add(this.chkNotification);
            this.Controls.Add(this.dtpStarting);
            this.Controls.Add(this.lblStarting);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblOccurs);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(430, 200);
            this.Name = "EditReminder";
            this.Size = new System.Drawing.Size(430, 200);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStarting;
        private System.Windows.Forms.Label lblStarting;
        private BoinBoxNS.BoinBox btnDone;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblOccurs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkNotification;
        private System.Windows.Forms.NumericUpDown txtNotification;
        private System.Windows.Forms.Label lblNotificationMins;
        private System.Windows.Forms.NumericUpDown txtEvery;
        private System.Windows.Forms.ComboBox cboEvery;
        private BoinBoxNS.BoinBox btnClose;

    }
}
