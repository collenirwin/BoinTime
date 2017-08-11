namespace BoinTime {
    partial class MainForm {
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
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.txtReminder = new System.Windows.Forms.RichTextBox();
            this.btnFocus = new BoinBoxNS.BoinBox();
            this.btnManageReminders = new BoinBoxNS.BoinBox();
            this.btnSettings = new BoinBoxNS.BoinBox();
            this.btnReallyClose = new BoinBoxNS.BoinBox();
            this.btnClose = new BoinBoxNS.BoinBox();
            this.btnPin = new BoinBoxNS.BoinBox();
            this.lblSec = new BoinTime.LabelAA();
            this.lblMain = new BoinTime.LabelAA();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlTopBar.Controls.Add(this.btnSettings);
            this.pnlTopBar.Controls.Add(this.btnReallyClose);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Controls.Add(this.btnPin);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(201, 25);
            this.pnlTopBar.TabIndex = 4;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.pnlTopBar.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // txtReminder
            // 
            this.txtReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtReminder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReminder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReminder.ForeColor = System.Drawing.Color.White;
            this.txtReminder.Location = new System.Drawing.Point(3, 124);
            this.txtReminder.Name = "txtReminder";
            this.txtReminder.ReadOnly = true;
            this.txtReminder.Size = new System.Drawing.Size(199, 31);
            this.txtReminder.TabIndex = 11;
            this.txtReminder.TabStop = false;
            this.txtReminder.Text = "";
            // 
            // btnFocus
            // 
            this.btnFocus.AntiAliased = false;
            this.btnFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFocus.BorderColor = System.Drawing.Color.Empty;
            this.btnFocus.BorderSize = 0;
            this.btnFocus.FakeDisabled = false;
            this.btnFocus.FlatAppearance.BorderSize = 0;
            this.btnFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFocus.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnFocus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFocus.Location = new System.Drawing.Point(-200, -200);
            this.btnFocus.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnFocus.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFocus.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnFocus.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(75, 23);
            this.btnFocus.TabIndex = 12;
            this.btnFocus.TabStop = false;
            this.btnFocus.UseVisualStyleBackColor = false;
            // 
            // btnManageReminders
            // 
            this.btnManageReminders.AntiAliased = false;
            this.btnManageReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnManageReminders.BorderColor = System.Drawing.Color.Empty;
            this.btnManageReminders.BorderSize = 0;
            this.btnManageReminders.FakeDisabled = false;
            this.btnManageReminders.FlatAppearance.BorderSize = 0;
            this.btnManageReminders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnManageReminders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageReminders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReminders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReminders.ForeColor = System.Drawing.Color.White;
            this.btnManageReminders.Location = new System.Drawing.Point(3, 96);
            this.btnManageReminders.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnManageReminders.MouseDownForeColor = System.Drawing.Color.White;
            this.btnManageReminders.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageReminders.MouseOverForeColor = System.Drawing.Color.White;
            this.btnManageReminders.Name = "btnManageReminders";
            this.btnManageReminders.Size = new System.Drawing.Size(199, 25);
            this.btnManageReminders.TabIndex = 4;
            this.btnManageReminders.Text = "Manage Reminders";
            this.btnManageReminders.UseVisualStyleBackColor = false;
            this.btnManageReminders.Click += new System.EventHandler(this.btnManageReminders_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AntiAliased = false;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::BoinTime.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.BorderColor = System.Drawing.Color.Empty;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.FakeDisabled = false;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSettings.Location = new System.Drawing.Point(178, 0);
            this.btnSettings.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSettings.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSettings.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSettings.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 25);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReallyClose
            // 
            this.btnReallyClose.AntiAliased = false;
            this.btnReallyClose.BackColor = System.Drawing.Color.Transparent;
            this.btnReallyClose.BorderColor = System.Drawing.Color.Empty;
            this.btnReallyClose.BorderSize = 0;
            this.btnReallyClose.FakeDisabled = false;
            this.btnReallyClose.FlatAppearance.BorderSize = 0;
            this.btnReallyClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReallyClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReallyClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReallyClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReallyClose.ForeColor = System.Drawing.Color.White;
            this.btnReallyClose.Location = new System.Drawing.Point(121, 0);
            this.btnReallyClose.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReallyClose.MouseDownForeColor = System.Drawing.Color.White;
            this.btnReallyClose.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReallyClose.MouseOverForeColor = System.Drawing.Color.White;
            this.btnReallyClose.Name = "btnReallyClose";
            this.btnReallyClose.Size = new System.Drawing.Size(51, 25);
            this.btnReallyClose.TabIndex = 2;
            this.btnReallyClose.Text = "Close";
            this.btnReallyClose.UseVisualStyleBackColor = false;
            this.btnReallyClose.Visible = false;
            this.btnReallyClose.Click += new System.EventHandler(this.btnReallyClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.AntiAliased = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Empty;
            this.btnClose.BorderSize = 0;
            this.btnClose.FakeDisabled = false;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(64, 0);
            this.btnClose.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.MouseDownForeColor = System.Drawing.Color.White;
            this.btnClose.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.MouseOverForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPin
            // 
            this.btnPin.AntiAliased = false;
            this.btnPin.BackColor = System.Drawing.Color.Transparent;
            this.btnPin.BorderColor = System.Drawing.Color.Empty;
            this.btnPin.BorderSize = 0;
            this.btnPin.FakeDisabled = false;
            this.btnPin.FlatAppearance.BorderSize = 0;
            this.btnPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPin.ForeColor = System.Drawing.Color.White;
            this.btnPin.Location = new System.Drawing.Point(16, 0);
            this.btnPin.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPin.MouseDownForeColor = System.Drawing.Color.White;
            this.btnPin.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPin.MouseOverForeColor = System.Drawing.Color.White;
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(46, 25);
            this.btnPin.TabIndex = 0;
            this.btnPin.Text = "Pin";
            this.btnPin.UseVisualStyleBackColor = false;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // lblSec
            // 
            this.lblSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblSec.Location = new System.Drawing.Point(155, 35);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(47, 34);
            this.lblSec.TabIndex = 3;
            this.lblSec.Text = "43";
            this.lblSec.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.lblSec.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // lblMain
            // 
            this.lblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMain.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblMain.Location = new System.Drawing.Point(6, 30);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(154, 55);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "11:35";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMain.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.lblMain.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(201, 158);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.btnManageReminders);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.txtReminder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BoinTime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelAA lblMain;
        private LabelAA lblSec;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Panel pnlTopBar;
        private BoinBoxNS.BoinBox btnPin;
        private BoinBoxNS.BoinBox btnReallyClose;
        private BoinBoxNS.BoinBox btnClose;
        private BoinBoxNS.BoinBox btnSettings;
        private BoinBoxNS.BoinBox btnManageReminders;
        private System.Windows.Forms.RichTextBox txtReminder;
        private BoinBoxNS.BoinBox btnFocus;

    }
}

