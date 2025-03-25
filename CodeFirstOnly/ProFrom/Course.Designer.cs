namespace ProFrom
{
    partial class Course
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
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            comboBox1 = new ComboBox();
            comboBoxinst = new ComboBox();
            comboDept = new ComboBox();
            name = new TextBox();
            duration = new TextBox();
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxinst
            // 
            comboBoxinst.FormattingEnabled = true;
            comboBoxinst.Location = new Point(119, 323);
            comboBoxinst.Name = "comboBoxinst";
            comboBoxinst.Size = new Size(121, 23);
            comboBoxinst.TabIndex = 7;
            // 
            // comboDept
            // 
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(118, 281);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(121, 23);
            comboDept.TabIndex = 8;
            // 
            // name
            // 
            name.Location = new Point(119, 364);
            name.Name = "name";
            name.Size = new Size(121, 23);
            name.TabIndex = 9;
            // 
            // duration
            // 
            duration.Location = new Point(120, 402);
            duration.Name = "duration";
            duration.Size = new Size(121, 23);
            duration.TabIndex = 10;
            // 
            // View1
            // 
            View1.BackgroundColor = Color.White;
            View1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = SystemColors.Window;
            dataGridViewCellStyle39.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle39.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle39.SelectionBackColor = Color.White;
            dataGridViewCellStyle39.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.False;
            View1.DefaultCellStyle = dataGridViewCellStyle39;
            View1.GridColor = Color.SlateGray;
            View1.Location = new Point(-4, -2);
            View1.Margin = new Padding(3, 4, 3, 4);
            View1.Name = "View1";
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = SystemColors.Control;
            dataGridViewCellStyle40.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle40.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle40.SelectionBackColor = Color.White;
            dataGridViewCellStyle40.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle40.WrapMode = DataGridViewTriState.True;
            View1.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            View1.Size = new Size(805, 220);
            View1.TabIndex = 11;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(0, 0, 192);
            Save.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Save.ForeColor = Color.White;
            Save.Location = new Point(647, 245);
            Save.Margin = new Padding(3, 4, 3, 4);
            Save.Name = "Save";
            Save.Size = new Size(131, 55);
            Save.TabIndex = 12;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Load
            // 
            Load.BackColor = Color.FromArgb(0, 0, 192);
            Load.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Load.ForeColor = Color.White;
            Load.Location = new Point(647, 365);
            Load.Margin = new Padding(3, 4, 3, 4);
            Load.Name = "Load";
            Load.Size = new Size(131, 55);
            Load.TabIndex = 13;
            Load.Text = "Load\r\n";
            Load.UseVisualStyleBackColor = false;
            Load.Click += Load_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(120, 144, 156);
            Add.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Add.ForeColor = SystemColors.HighlightText;
            Add.Location = new Point(297, 249);
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
            update.Location = new Point(297, 311);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(324, 45);
            update.TabIndex = 17;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(120, 144, 156);
            Delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Delete.ForeColor = Color.Red;
            Delete.Location = new Point(297, 379);
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
            label5.Location = new Point(10, 242);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 19;
            label5.Text = "Courses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 278);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 20;
            label1.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1, 323);
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
            label3.Location = new Point(10, 365);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 22;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 402);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 23;
            label4.Text = "Duration";
            // 
            // Course
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
            Controls.Add(duration);
            Controls.Add(name);
            Controls.Add(comboDept);
            Controls.Add(comboBoxinst);
            Controls.Add(comboBox1);
            Name = "Course";
            Text = "Course";
            ((System.ComponentModel.ISupportInitialize)View1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBoxinst;
        private ComboBox comboDept;
        private TextBox name;
        private TextBox duration;
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