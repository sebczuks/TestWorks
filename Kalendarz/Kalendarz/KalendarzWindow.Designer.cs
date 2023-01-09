namespace Kalendarz
{
    partial class KalendarzWindow
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
            if (disposing && (components != null))
            {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_DisplayTasksWindow = new System.Windows.Forms.Button();
            this.GB_UserNames = new System.Windows.Forms.GroupBox();
            this.BTN_Info = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GB_UserNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(225)))), ((int)(((byte)(100)))));
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.BTN_Login);
            this.groupBox1.Controls.Add(this.BTN_DisplayTasksWindow);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(703, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 601);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okno glowne";
            // 
            // BTN_Login
            // 
            this.BTN_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Login.Location = new System.Drawing.Point(3, 77);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(235, 61);
            this.BTN_Login.TabIndex = 1;
            this.BTN_Login.Text = "Kim Jestes???";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_DisplayTasksWindow
            // 
            this.BTN_DisplayTasksWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_DisplayTasksWindow.Location = new System.Drawing.Point(3, 16);
            this.BTN_DisplayTasksWindow.Name = "BTN_DisplayTasksWindow";
            this.BTN_DisplayTasksWindow.Size = new System.Drawing.Size(235, 61);
            this.BTN_DisplayTasksWindow.TabIndex = 0;
            this.BTN_DisplayTasksWindow.Text = "Zadania";
            this.BTN_DisplayTasksWindow.UseVisualStyleBackColor = true;
            this.BTN_DisplayTasksWindow.Click += new System.EventHandler(this.BTN_DisplayTasksWindow_Click);
            // 
            // GB_UserNames
            // 
            this.GB_UserNames.Controls.Add(this.BTN_Info);
            this.GB_UserNames.Location = new System.Drawing.Point(38, 77);
            this.GB_UserNames.Name = "GB_UserNames";
            this.GB_UserNames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_UserNames.Size = new System.Drawing.Size(639, 61);
            this.GB_UserNames.TabIndex = 0;
            this.GB_UserNames.TabStop = false;
            // 
            // BTN_Info
            // 
            this.BTN_Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_Info.Location = new System.Drawing.Point(3, 16);
            this.BTN_Info.Name = "BTN_Info";
            this.BTN_Info.Size = new System.Drawing.Size(22, 42);
            this.BTN_Info.TabIndex = 0;
            this.BTN_Info.Text = "INFO";
            this.BTN_Info.UseVisualStyleBackColor = true;
            // 
            // KalendarzWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.GB_UserNames);
            this.Controls.Add(this.groupBox1);
            this.Name = "KalendarzWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalendarz";
            this.Load += new System.EventHandler(this.KalendarzWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.GB_UserNames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_DisplayTasksWindow;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.GroupBox GB_UserNames;
        private System.Windows.Forms.Button BTN_Info;
    }
}

