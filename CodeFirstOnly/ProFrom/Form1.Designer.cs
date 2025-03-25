namespace ProFrom
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            View1 = new DataGridView();
            Load = new Button();
            Save = new Button();
            FName = new TextBox();
            LName = new TextBox();
            Phone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            update = new Button();
            comboBox1 = new ComboBox();
            Add = new Button();
            Delete = new Button();
            comboDept = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)View1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // View1
            // 
            View1.BackgroundColor = Color.White;
            View1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            View1.DefaultCellStyle = dataGridViewCellStyle3;
            View1.GridColor = Color.SlateGray;
            View1.Location = new Point(-7, 2);
            View1.Margin = new Padding(3, 4, 3, 4);
            View1.Name = "View1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            View1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            View1.Size = new Size(557, 243);
            View1.TabIndex = 0;
            // 
            // Load
            // 
            Load.BackColor = Color.FromArgb(0, 0, 192);
            Load.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Load.ForeColor = Color.White;
            Load.Location = new Point(597, 190);
            Load.Margin = new Padding(3, 4, 3, 4);
            Load.Name = "Load";
            Load.Size = new Size(131, 55);
            Load.TabIndex = 1;
            Load.Text = "Load\r\n";
            Load.UseVisualStyleBackColor = false;
            Load.Click += Load_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(0, 0, 192);
            Save.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Save.ForeColor = Color.White;
            Save.Location = new Point(597, 107);
            Save.Margin = new Padding(3, 4, 3, 4);
            Save.Name = "Save";
            Save.Size = new Size(131, 55);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // FName
            // 
            FName.Location = new Point(143, 350);
            FName.Margin = new Padding(3, 4, 3, 4);
            FName.Name = "FName";
            FName.Size = new Size(81, 25);
            FName.TabIndex = 3;
            // 
            // LName
            // 
            LName.Location = new Point(281, 350);
            LName.Margin = new Padding(3, 4, 3, 4);
            LName.Name = "LName";
            LName.Size = new Size(81, 25);
            LName.TabIndex = 4;
            // 
            // Phone
            // 
            Phone.Location = new Point(143, 408);
            Phone.Margin = new Padding(3, 4, 3, 4);
            Phone.Name = "Phone";
            Phone.Size = new Size(219, 25);
            Phone.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(154, 382);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 7;
            label1.Text = "FName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(295, 382);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 8;
            label2.Text = "LName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(86, 411);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 9;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(22, 308);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 10;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(23, 263);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 13;
            label5.Text = "Instructores";
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(120, 144, 156);
            update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            update.ForeColor = Color.MidnightBlue;
            update.Location = new Point(452, 336);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(324, 45);
            update.TabIndex = 13;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 265);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 25);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(120, 144, 156);
            Add.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Add.ForeColor = SystemColors.HighlightText;
            Add.Location = new Point(452, 285);
            Add.Margin = new Padding(3, 4, 3, 4);
            Add.Name = "Add";
            Add.Size = new Size(324, 43);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(120, 144, 156);
            Delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Delete.ForeColor = Color.Red;
            Delete.Location = new Point(452, 389);
            Delete.Margin = new Padding(3, 4, 3, 4);
            Delete.Name = "Delete";
            Delete.Size = new Size(324, 41);
            Delete.TabIndex = 16;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // comboDept
            // 
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(143, 313);
            comboDept.Margin = new Padding(3, 4, 3, 4);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(219, 25);
            comboDept.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(618, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(815, 494);
            Controls.Add(pictureBox1);
            Controls.Add(comboDept);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(comboBox1);
            Controls.Add(update);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Phone);
            Controls.Add(LName);
            Controls.Add(FName);
            Controls.Add(Save);
            Controls.Add(Load);
            Controls.Add(View1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.IndianRed;
            ((System.ComponentModel.ISupportInitialize)View1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView View1;
        private Button Load;
        private Button Save;
        private TextBox FName;
        private TextBox LName;
        private TextBox Phone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button update;
        private ComboBox comboBox1;
        private BindingSource instructorBindingSource;
        private BindingSource instructorBindingSource1;
        private BindingSource proContextBindingSource;
        private BindingSource proContextBindingSource1;
        private Button Add;
        private Button Delete;
        private ComboBox comboDept;
        private PictureBox pictureBox1;
    }
}
