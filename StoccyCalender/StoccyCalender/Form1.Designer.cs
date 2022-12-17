namespace StoccyCalender
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
            this.MainCalender = new System.Windows.Forms.DataGridView();
            this.Wtorek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sroda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MainCalender)).BeginInit();
            this.SuspendLayout();
            // 
            // MainCalender
            // 
            this.MainCalender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainCalender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Wtorek,
            this.Sroda});
            this.MainCalender.Location = new System.Drawing.Point(1, 145);
            this.MainCalender.Name = "MainCalender";
            this.MainCalender.Size = new System.Drawing.Size(944, 574);
            this.MainCalender.TabIndex = 0;
            // 
            // Wtorek
            // 
            this.Wtorek.HeaderText = "Column1";
            this.Wtorek.Name = "Wtorek";
            // 
            // Sroda
            // 
            this.Sroda.HeaderText = "Column1";
            this.Sroda.Name = "Sroda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 731);
            this.Controls.Add(this.MainCalender);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainCalender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainCalender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wtorek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sroda;
    }
}

