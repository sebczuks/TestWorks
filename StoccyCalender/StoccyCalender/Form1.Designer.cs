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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainCalender = new System.Windows.Forms.DataGridView();
            this.Wtorek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sroda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Tasks = new System.Windows.Forms.Button();
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
            // BTN_Tasks
            // 
            this.BTN_Tasks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Tasks.BackgroundImage")));
            this.BTN_Tasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Tasks.Location = new System.Drawing.Point(965, 145);
            this.BTN_Tasks.Name = "BTN_Tasks";
            this.BTN_Tasks.Size = new System.Drawing.Size(173, 125);
            this.BTN_Tasks.TabIndex = 1;
            this.BTN_Tasks.Text = "Zadania";
            this.BTN_Tasks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Tasks.UseVisualStyleBackColor = true;
            this.BTN_Tasks.Click += new System.EventHandler(this.BTN_Tasks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 731);
            this.Controls.Add(this.BTN_Tasks);
            this.Controls.Add(this.MainCalender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainCalender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainCalender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wtorek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sroda;
        private System.Windows.Forms.Button BTN_Tasks;
    }
}

