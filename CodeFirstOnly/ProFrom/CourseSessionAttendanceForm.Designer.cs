namespace ProFrom
{
    partial class CourseSessionAttendanceForm
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
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            comboSession = new ComboBox();
            comboStudent = new ComboBox();
            comboAttendance = new ComboBox();
            txtGrade = new TextBox();
            txtNotes = new TextBox();
            View1 = new DataGridView();
            Save = new Button();
            Load = new Button();
            Add = new Button();
            update = new Button();
            Delete = new Button();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)View1).BeginInit();
            SuspendLayout();
            // 
            // comboSession
            // 
            comboSession.FormattingEnabled = true;
            comboSession.Location = new Point(121, 313);
            comboSession.Name = "comboSession";
            comboSession.Size = new Size(143, 23);
            comboSession.TabIndex = 1;
            // 
            // comboStudent
            // 
            comboStudent.FormattingEnabled = true;
            comboStudent.Location = new Point(121, 356);
            comboStudent.Name = "comboStudent";
            comboStudent.Size = new Size(143, 23);
            comboStudent.TabIndex = 2;
            // 
            // comboAttendance
            // 
            comboAttendance.FormattingEnabled = true;
            comboAttendance.Location = new Point(121, 278);
            comboAttendance.Name = "comboAttendance";
            comboAttendance.Size = new Size(143, 23);
            comboAttendance.TabIndex = 3;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(81, 424);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(183, 23);
            txtGrade.TabIndex = 4;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(81, 395);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(183, 23);
            txtNotes.TabIndex = 5;
            // 
            // View1
            // 
            View1.BackgroundColor = Color.White;
            View1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = SystemColors.Window;
            dataGridViewCellStyle41.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle41.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle41.SelectionBackColor = Color.White;
            dataGridViewCellStyle41.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.False;
            View1.DefaultCellStyle = dataGridViewCellStyle41;
            View1.GridColor = Color.SlateGray;
            View1.Location = new Point(-1, 2);
            View1.Margin = new Padding(3, 4, 3, 4);
            View1.Name = "View1";
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = SystemColors.Control;
            dataGridViewCellStyle42.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle42.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle42.SelectionBackColor = Color.White;
            dataGridViewCellStyle42.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            View1.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            View1.Size = new Size(560, 254);
            View1.TabIndex = 6;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(0, 0, 192);
            Save.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Save.ForeColor = Color.White;
            Save.Location = new Point(610, 160);
            Save.Margin = new Padding(3, 4, 3, 4);
            Save.Name = "Save";
            Save.Size = new Size(131, 55);
            Save.TabIndex = 7;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Load
            // 
            Load.BackColor = Color.FromArgb(0, 0, 192);
            Load.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Load.ForeColor = Color.White;
            Load.Location = new Point(610, 70);
            Load.Margin = new Padding(3, 4, 3, 4);
            Load.Name = "Load";
            Load.Size = new Size(131, 55);
            Load.TabIndex = 8;
            Load.Text = "Load\r\n";
            Load.UseVisualStyleBackColor = false;
            Load.Click += Load_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(120, 144, 156);
            Add.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Add.ForeColor = SystemColors.HighlightText;
            Add.Location = new Point(417, 278);
            Add.Margin = new Padding(3, 4, 3, 4);
            Add.Name = "Add";
            Add.Size = new Size(324, 43);
            Add.TabIndex = 16;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(120, 144, 156);
            update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            update.ForeColor = Color.MidnightBlue;
            update.Location = new Point(417, 334);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(324, 45);
            update.TabIndex = 17;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(120, 144, 156);
            Delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Delete.ForeColor = Color.Red;
            Delete.Location = new Point(417, 396);
            Delete.Margin = new Padding(3, 4, 3, 4);
            Delete.Name = "Delete";
            Delete.Size = new Size(324, 41);
            Delete.TabIndex = 18;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 19;
            label5.Text = "Attendance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 313);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 20;
            label1.Text = "Sessions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(39, 353);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 21;
            label2.Text = "Stuents";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(13, 396);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 22;
            label3.Text = "Notes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 424);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 23;
            label4.Text = "Grade";
            // 
            // CourseSessionAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(Delete);
            Controls.Add(update);
            Controls.Add(Add);
            Controls.Add(Load);
            Controls.Add(Save);
            Controls.Add(View1);
            Controls.Add(txtNotes);
            Controls.Add(txtGrade);
            Controls.Add(comboAttendance);
            Controls.Add(comboStudent);
            Controls.Add(comboSession);
            Name = "CourseSessionAttendanceForm";
            Text = "CourseSessionAttendanceForm";
            ((System.ComponentModel.ISupportInitialize)View1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboSession;
        private ComboBox comboStudent;
        private ComboBox comboAttendance;
        private TextBox txtGrade;
        private TextBox txtNotes;
        private DataGridView View1;
        private Button Save;
        private Button Load;
        private Button Add;
        private Button update;
        private Button Delete;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}