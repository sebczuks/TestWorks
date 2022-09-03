namespace WinFormsJEREMIAS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_ExitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_ExitProgram
            // 
            this.BTN_ExitProgram.Image = global::WinFormsJEREMIAS.Properties.Resources.blauFarbe1;
            this.BTN_ExitProgram.Location = new System.Drawing.Point(441, 771);
            this.BTN_ExitProgram.Name = "BTN_ExitProgram";
            this.BTN_ExitProgram.Size = new System.Drawing.Size(131, 78);
            this.BTN_ExitProgram.TabIndex = 0;
            this.BTN_ExitProgram.Text = "EXIT";
            this.BTN_ExitProgram.UseVisualStyleBackColor = true;
            this.BTN_ExitProgram.Click += new System.EventHandler(this.BTN_ExitProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WinFormsJEREMIAS.Properties.Resources.blauFarbe;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.BTN_ExitProgram);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BTN_ExitProgram;
    }
}