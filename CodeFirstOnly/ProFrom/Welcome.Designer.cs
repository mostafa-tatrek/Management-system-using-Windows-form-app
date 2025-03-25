namespace ProFrom
{
    partial class Welcome
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
            Instructor = new Button();
            button1 = new Button();
            Students = new Button();
            CoursesSession = new Button();
            Courses = new Button();
            CoursesSessionAtt = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // Instructor
            // 
            Instructor.BackColor = Color.FromArgb(120, 144, 156);
            Instructor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Instructor.ForeColor = Color.MidnightBlue;
            Instructor.Location = new Point(23, 173);
            Instructor.Margin = new Padding(3, 4, 3, 4);
            Instructor.Name = "Instructor";
            Instructor.Size = new Size(324, 45);
            Instructor.TabIndex = 14;
            Instructor.Text = "Instructor";
            Instructor.UseVisualStyleBackColor = false;
            Instructor.Click += Instructor_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(120, 144, 156);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(23, 251);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(324, 45);
            button1.TabIndex = 15;
            button1.Text = "Department";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Students
            // 
            Students.BackColor = Color.FromArgb(120, 144, 156);
            Students.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Students.ForeColor = Color.MidnightBlue;
            Students.Location = new Point(414, 328);
            Students.Margin = new Padding(3, 4, 3, 4);
            Students.Name = "Students";
            Students.Size = new Size(324, 45);
            Students.TabIndex = 16;
            Students.Text = "Students";
            Students.UseVisualStyleBackColor = false;
            Students.Click += Students_Click;
            // 
            // CoursesSession
            // 
            CoursesSession.BackColor = Color.FromArgb(120, 144, 156);
            CoursesSession.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CoursesSession.ForeColor = Color.MidnightBlue;
            CoursesSession.Location = new Point(414, 173);
            CoursesSession.Margin = new Padding(3, 4, 3, 4);
            CoursesSession.Name = "CoursesSession";
            CoursesSession.Size = new Size(324, 45);
            CoursesSession.TabIndex = 17;
            CoursesSession.Text = "Courses Session";
            CoursesSession.UseVisualStyleBackColor = false;
            CoursesSession.Click += CoursesSession_Click;
            // 
            // Courses
            // 
            Courses.BackColor = Color.FromArgb(120, 144, 156);
            Courses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Courses.ForeColor = Color.MidnightBlue;
            Courses.Location = new Point(23, 328);
            Courses.Margin = new Padding(3, 4, 3, 4);
            Courses.Name = "Courses";
            Courses.Size = new Size(324, 45);
            Courses.TabIndex = 18;
            Courses.Text = "Courses";
            Courses.UseVisualStyleBackColor = false;
            Courses.Click += Courses_Click;
            // 
            // CoursesSessionAtt
            // 
            CoursesSessionAtt.BackColor = Color.FromArgb(120, 144, 156);
            CoursesSessionAtt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CoursesSessionAtt.ForeColor = Color.MidnightBlue;
            CoursesSessionAtt.Location = new Point(414, 251);
            CoursesSessionAtt.Margin = new Padding(3, 4, 3, 4);
            CoursesSessionAtt.Name = "CoursesSessionAtt";
            CoursesSessionAtt.Size = new Size(324, 45);
            CoursesSessionAtt.TabIndex = 19;
            CoursesSessionAtt.Text = "Session Attendance";
            CoursesSessionAtt.UseVisualStyleBackColor = false;
            CoursesSessionAtt.Click += CoursesSessionAtt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(153, 69);
            label5.Name = "label5";
            label5.Size = new Size(450, 37);
            label5.TabIndex = 20;
            label5.Text = "Welcome, please select the section";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(CoursesSessionAtt);
            Controls.Add(Courses);
            Controls.Add(CoursesSession);
            Controls.Add(Students);
            Controls.Add(button1);
            Controls.Add(Instructor);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Instructor;
        private Button button1;
        private Button Students;
        private Button CoursesSession;
        private Button Courses;
        private Button CoursesSessionAtt;
        private Label label5;
    }
}