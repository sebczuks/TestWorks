namespace FamilyCalender
{
    partial class AddTasksWindow
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
            this.BTN_ADDTask = new System.Windows.Forms.Button();
            this.PN_Tasks = new System.Windows.Forms.Panel();
            this.PN_TaskInput = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBOX_TaskName = new System.Windows.Forms.ComboBox();
            this.BTN_ADDNote = new System.Windows.Forms.Button();
            this.PN_AddNote = new System.Windows.Forms.Panel();
            this.PN_NoteInput = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CBOX_Note = new System.Windows.Forms.ComboBox();
            this.PN_Tasks.SuspendLayout();
            this.PN_TaskInput.SuspendLayout();
            this.PN_AddNote.SuspendLayout();
            this.PN_NoteInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_ADDTask
            // 
            this.BTN_ADDTask.BackColor = System.Drawing.Color.White;
            this.BTN_ADDTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BTN_ADDTask.Location = new System.Drawing.Point(402, 150);
            this.BTN_ADDTask.Name = "BTN_ADDTask";
            this.BTN_ADDTask.Size = new System.Drawing.Size(174, 45);
            this.BTN_ADDTask.TabIndex = 0;
            this.BTN_ADDTask.Text = "Dodaj Zadanie";
            this.BTN_ADDTask.UseVisualStyleBackColor = false;
            this.BTN_ADDTask.Click += new System.EventHandler(this.BTN_ADDTask_Click);
            // 
            // PN_Tasks
            // 
            this.PN_Tasks.Controls.Add(this.PN_TaskInput);
            this.PN_Tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Tasks.Location = new System.Drawing.Point(0, 0);
            this.PN_Tasks.Name = "PN_Tasks";
            this.PN_Tasks.Size = new System.Drawing.Size(800, 224);
            this.PN_Tasks.TabIndex = 1;
            // 
            // PN_TaskInput
            // 
            this.PN_TaskInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(129)))), ((int)(((byte)(119)))));
            this.PN_TaskInput.Controls.Add(this.label7);
            this.PN_TaskInput.Controls.Add(this.label1);
            this.PN_TaskInput.Controls.Add(this.CBOX_TaskName);
            this.PN_TaskInput.Controls.Add(this.BTN_ADDTask);
            this.PN_TaskInput.Location = new System.Drawing.Point(13, 13);
            this.PN_TaskInput.Name = "PN_TaskInput";
            this.PN_TaskInput.Size = new System.Drawing.Size(579, 198);
            this.PN_TaskInput.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(397, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodaj Zadanie z listy";
            // 
            // CBOX_TaskName
            // 
            this.CBOX_TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CBOX_TaskName.FormattingEnabled = true;
            this.CBOX_TaskName.Location = new System.Drawing.Point(194, 9);
            this.CBOX_TaskName.Name = "CBOX_TaskName";
            this.CBOX_TaskName.Size = new System.Drawing.Size(201, 28);
            this.CBOX_TaskName.TabIndex = 0;
            this.CBOX_TaskName.SelectedIndexChanged += new System.EventHandler(this.CBOX_TaskName_SelectedIndexChanged);
            // 
            // BTN_ADDNote
            // 
            this.BTN_ADDNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BTN_ADDNote.Location = new System.Drawing.Point(402, 150);
            this.BTN_ADDNote.Name = "BTN_ADDNote";
            this.BTN_ADDNote.Size = new System.Drawing.Size(174, 45);
            this.BTN_ADDNote.TabIndex = 0;
            this.BTN_ADDNote.Text = "Dodaj Ocene";
            this.BTN_ADDNote.UseVisualStyleBackColor = true;
            this.BTN_ADDNote.Click += new System.EventHandler(this.BTN_ADDNote_Click);
            // 
            // PN_AddNote
            // 
            this.PN_AddNote.Controls.Add(this.PN_NoteInput);
            this.PN_AddNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_AddNote.Location = new System.Drawing.Point(0, 224);
            this.PN_AddNote.Name = "PN_AddNote";
            this.PN_AddNote.Size = new System.Drawing.Size(800, 224);
            this.PN_AddNote.TabIndex = 2;
            // 
            // PN_NoteInput
            // 
            this.PN_NoteInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(129)))), ((int)(((byte)(119)))));
            this.PN_NoteInput.Controls.Add(this.label8);
            this.PN_NoteInput.Controls.Add(this.label5);
            this.PN_NoteInput.Controls.Add(this.label4);
            this.PN_NoteInput.Controls.Add(this.label3);
            this.PN_NoteInput.Controls.Add(this.label2);
            this.PN_NoteInput.Controls.Add(this.comboBox2);
            this.PN_NoteInput.Controls.Add(this.BTN_ADDNote);
            this.PN_NoteInput.Controls.Add(this.comboBox1);
            this.PN_NoteInput.Controls.Add(this.CBOX_Note);
            this.PN_NoteInput.Location = new System.Drawing.Point(13, 13);
            this.PN_NoteInput.Name = "PN_NoteInput";
            this.PN_NoteInput.Size = new System.Drawing.Size(579, 198);
            this.PN_NoteInput.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(397, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(340, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Typ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(99, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unterricht:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ocena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(24, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dodaj Ocene";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(343, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // CBOX_Note
            // 
            this.CBOX_Note.FormattingEnabled = true;
            this.CBOX_Note.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CBOX_Note.Location = new System.Drawing.Point(24, 60);
            this.CBOX_Note.Name = "CBOX_Note";
            this.CBOX_Note.Size = new System.Drawing.Size(57, 21);
            this.CBOX_Note.TabIndex = 1;
            // 
            // AddTasksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PN_AddNote);
            this.Controls.Add(this.PN_Tasks);
            this.Name = "AddTasksWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj Zadania i Oceny";
            this.Load += new System.EventHandler(this.AddTasksWindow_Load);
            this.PN_Tasks.ResumeLayout(false);
            this.PN_TaskInput.ResumeLayout(false);
            this.PN_TaskInput.PerformLayout();
            this.PN_AddNote.ResumeLayout(false);
            this.PN_NoteInput.ResumeLayout(false);
            this.PN_NoteInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_ADDTask;
        private System.Windows.Forms.Panel PN_Tasks;
        private System.Windows.Forms.Button BTN_ADDNote;
        private System.Windows.Forms.Panel PN_AddNote;
        private System.Windows.Forms.Panel PN_TaskInput;
        private System.Windows.Forms.ComboBox CBOX_TaskName;
        private System.Windows.Forms.Panel PN_NoteInput;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CBOX_Note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}