namespace ProFrom
{
    partial class CourseSession
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
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            comboCourse = new ComboBox();
            comboInstructor = new ComboBox();
            comboSession = new ComboBox();
            txtTitle = new TextBox();
            dateTimePicker1 = new DateTimePicker();
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
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(132, 306);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(121, 23);
            comboCourse.TabIndex = 1;
            // 
            // comboInstructor
            // 
            comboInstructor.FormattingEnabled = true;
            comboInstructor.Location = new Point(132, 355);
            comboInstructor.Name = "comboInstructor";
            comboInstructor.Size = new Size(121, 23);
            comboInstructor.TabIndex = 2;
            // 
            // comboSession
            // 
            comboSession.FormattingEnabled = true;
            comboSession.Location = new Point(132, 267);
            comboSession.Name = "comboSession";
            comboSession.Size = new Size(121, 23);
            comboSession.TabIndex = 3;
            comboSession.SelectedIndexChanged += comboSession_SelectedIndexChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(132, 397);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(121, 23);
            txtTitle.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 426);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // View1
            // 
            View1.BackgroundColor = Color.White;
            View1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = SystemColors.Window;
            dataGridViewCellStyle35.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle35.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle35.SelectionBackColor = Color.White;
            dataGridViewCellStyle35.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = DataGridViewTriState.False;
            View1.DefaultCellStyle = dataGridViewCellStyle35;
            View1.GridColor = Color.SlateGray;
            View1.Location = new Point(2, -1);
            View1.Margin = new Padding(3, 4, 3, 4);
            View1.Name = "View1";
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = SystemColors.Control;
            dataGridViewCellStyle36.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle36.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle36.SelectionBackColor = Color.White;
            dataGridViewCellStyle36.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.True;
            View1.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            View1.Size = new Size(557, 246);
            View1.TabIndex = 7;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(0, 0, 192);
            Save.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Save.ForeColor = Color.White;
            Save.Location = new Point(616, 72);
            Save.Margin = new Padding(3, 4, 3, 4);
            Save.Name = "Save";
            Save.Size = new Size(131, 55);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Load
            // 
            Load.BackColor = Color.FromArgb(0, 0, 192);
            Load.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Load.ForeColor = Color.White;
            Load.Location = new Point(616, 155);
            Load.Margin = new Padding(3, 4, 3, 4);
            Load.Name = "Load";
            Load.Size = new Size(131, 55);
            Load.TabIndex = 9;
            Load.Text = "Load\r\n";
            Load.UseVisualStyleBackColor = false;
            Load.CommandCanExecuteChanged += Load_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(120, 144, 156);
            Add.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Add.ForeColor = SystemColors.HighlightText;
            Add.Location = new Point(436, 267);
            Add.Margin = new Padding(3, 4, 3, 4);
            Add.Name = "Add";
            Add.Size = new Size(324, 43);
            Add.TabIndex = 16;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.CommandChanged += Add_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(120, 144, 156);
            update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            update.ForeColor = Color.MidnightBlue;
            update.Location = new Point(436, 333);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(324, 45);
            update.TabIndex = 17;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.CommandChanged += update_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(120, 144, 156);
            Delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Delete.ForeColor = Color.Red;
            Delete.Location = new Point(436, 397);
            Delete.Margin = new Padding(3, 4, 3, 4);
            Delete.Name = "Delete";
            Delete.Size = new Size(324, 41);
            Delete.TabIndex = 18;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.CommandChanged += Delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 267);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 19;
            label5.Text = "Sessions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 306);
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
            label2.Location = new Point(12, 353);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 21;
            label2.Text = "Instructores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 395);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 22;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 426);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 23;
            label4.Text = "Date";
            // 
            // CourseSession
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
            Controls.Add(dateTimePicker1);
            Controls.Add(txtTitle);
            Controls.Add(comboSession);
            Controls.Add(comboInstructor);
            Controls.Add(comboCourse);
            Name = "CourseSession";
            Text = "CourseSession";
            ((System.ComponentModel.ISupportInitialize)View1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboCourse;
        private ComboBox comboInstructor;
        private ComboBox comboSession;
        private TextBox txtTitle;
        private DateTimePicker dateTimePicker1;
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