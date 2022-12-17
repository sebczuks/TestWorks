namespace ReAn
{
    partial class Form1
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
            this.CBOX_RechnungAngebot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBOX_RechnungAngebot
            // 
            this.CBOX_RechnungAngebot.FormattingEnabled = true;
            this.CBOX_RechnungAngebot.Items.AddRange(new object[] {
            "Rechnung",
            "Angebot"});
            this.CBOX_RechnungAngebot.Location = new System.Drawing.Point(55, 30);
            this.CBOX_RechnungAngebot.Name = "CBOX_RechnungAngebot";
            this.CBOX_RechnungAngebot.Size = new System.Drawing.Size(121, 21);
            this.CBOX_RechnungAngebot.TabIndex = 0;
            this.CBOX_RechnungAngebot.SelectedIndexChanged += new System.EventHandler(this.CBOX_RechnungAngebot_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(825, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBOX_RechnungAngebot);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Rechnun / Angebot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBOX_RechnungAngebot;
        private System.Windows.Forms.Label label1;
    }
}

