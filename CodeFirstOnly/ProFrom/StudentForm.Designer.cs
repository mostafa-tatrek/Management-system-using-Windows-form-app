namespace ProFrom
{
    partial class StudentForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            comboCourse = new ComboBox();
            comboStudent = new ComboBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
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
            Addcourse = new Button();
            removecourse = new Button();
            ((System.ComponentModel.ISupportInitialize)View1).BeginInit();
            SuspendLayout();
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(109, 368);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(231, 23);
            comboCourse.TabIndex = 1;
            // 
            // comboStudent
            // 
            comboStudent.FormattingEnabled = true;
            comboStudent.Location = new Point(109, 268);
            comboStudent.Name = "comboStudent";
            comboStudent.Size = new Size(151, 23);
            comboStudent.TabIndex = 2;
            comboStudent.SelectedIndexChanged += comboStudent_SelectedIndexChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(114, 296);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(67, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(292, 300);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(60, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(109, 326);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(136, 23);
            txtPhone.TabIndex = 5;
            // 
            // View1
            // 
            View1.BackgroundColor = Color.White;
            View1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            View1.DefaultCellStyle = dataGridViewCellStyle1;
            View1.GridColor = Color.SlateGray;
            View1.Location = new Point(0, 2);
            View1.Margin = new Padding(3, 4, 3, 4);
            View1.Name = "View1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            View1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            View1.Size = new Size(557, 237);
            View1.TabIndex = 6;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(0, 0, 192);
            Save.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Save.ForeColor = Color.White;
            Save.Location = new Point(612, 127);
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
            Load.Location = new Point(612, 34);
            Load.Margin = new Padding(3, 4, 3, 4);
            Load.Name = "Load";
            Load.Size = new Size(131, 55);
            Load.TabIndex = 8;
            Load.Text = "Load\r\n";
            Load.UseVisualStyleBackColor = false;
            Load.Click += StudentForm_Load;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(120, 144, 156);
            Add.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Add.ForeColor = SystemColors.HighlightText;
            Add.Location = new Point(449, 247);
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
            update.Location = new Point(449, 307);
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
            Delete.Location = new Point(449, 376);
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
            label5.Location = new Point(12, 265);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 19;
            label5.Text = "Studentes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 368);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 20;
            label1.Text = "Courses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 323);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 21;
            label2.Text = "Phone ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(190, 297);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 22;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 294);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 23;
            label4.Text = "First Name";
            // 
            // Addcourse
            // 
            Addcourse.BackColor = Color.FromArgb(120, 144, 156);
            Addcourse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Addcourse.ForeColor = SystemColors.HighlightText;
            Addcourse.Location = new Point(56, 401);
            Addcourse.Margin = new Padding(3, 4, 3, 4);
            Addcourse.Name = "Addcourse";
            Addcourse.Size = new Size(133, 41);
            Addcourse.TabIndex = 24;
            Addcourse.Text = "Add course";
            Addcourse.UseVisualStyleBackColor = false;
            Addcourse.Click += btnAddCourseToStudent_Click;
            // 
            // removecourse
            // 
            removecourse.BackColor = Color.FromArgb(120, 144, 156);
            removecourse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            removecourse.ForeColor = Color.Red;
            removecourse.Location = new Point(207, 401);
            removecourse.Margin = new Padding(3, 4, 3, 4);
            removecourse.Name = "removecourse";
            removecourse.Size = new Size(133, 41);
            removecourse.TabIndex = 25;
            removecourse.Text = "remove course";
            removecourse.UseVisualStyleBackColor = false;
            removecourse.Click += btnRemoveCourseFromStudent_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(removecourse);
            Controls.Add(Addcourse);
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
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(comboStudent);
            Controls.Add(comboCourse);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)View1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboCourse;
        private ComboBox comboStudent;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
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
        private Button Addcourse;
        private Button removecourse;
    }
}