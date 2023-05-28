namespace Studenti
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.nudSubjects = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lbSubjects = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbHighestAverage = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на студенти";
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(30, 43);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(343, 420);
            this.lbStudents.TabIndex = 1;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(30, 478);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(343, 35);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Нов студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(30, 519);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(343, 35);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Избриши студент";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // nudSubjects
            // 
            this.nudSubjects.Location = new System.Drawing.Point(393, 43);
            this.nudSubjects.Name = "nudSubjects";
            this.nudSubjects.Size = new System.Drawing.Size(152, 22);
            this.nudSubjects.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(393, 72);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(152, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Генерирај досие";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lbSubjects
            // 
            this.lbSubjects.FormattingEnabled = true;
            this.lbSubjects.ItemHeight = 16;
            this.lbSubjects.Location = new System.Drawing.Point(564, 43);
            this.lbSubjects.Name = "lbSubjects";
            this.lbSubjects.Size = new System.Drawing.Size(343, 420);
            this.lbSubjects.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Просек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Највисок просек";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(732, 478);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(174, 22);
            this.tbAverage.TabIndex = 9;
            // 
            // tbHighestAverage
            // 
            this.tbHighestAverage.Location = new System.Drawing.Point(732, 506);
            this.tbHighestAverage.Name = "tbHighestAverage";
            this.tbHighestAverage.Size = new System.Drawing.Size(174, 22);
            this.tbHighestAverage.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 564);
            this.Controls.Add(this.tbHighestAverage);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSubjects);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.nudSubjects);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.NumericUpDown nudSubjects;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lbSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.TextBox tbHighestAverage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

