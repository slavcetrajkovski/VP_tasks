namespace Ispiti
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbExams = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPoints1 = new System.Windows.Forms.NumericUpDown();
            this.tbDesc1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPoints2 = new System.Windows.Forms.NumericUpDown();
            this.tbDesc2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lbExams);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Испити";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(310, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Избриши испит";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(310, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додади испит";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbExams
            // 
            this.lbExams.FormattingEnabled = true;
            this.lbExams.ItemHeight = 16;
            this.lbExams.Location = new System.Drawing.Point(6, 21);
            this.lbExams.Name = "lbExams";
            this.lbExams.Size = new System.Drawing.Size(310, 356);
            this.lbExams.TabIndex = 0;
            this.lbExams.SelectedIndexChanged += new System.EventHandler(this.lbExams_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudPoints1);
            this.groupBox2.Controls.Add(this.tbDesc1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(349, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 221);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задача 1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Зачувај";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поени:";
            // 
            // nudPoints1
            // 
            this.nudPoints1.Location = new System.Drawing.Point(10, 153);
            this.nudPoints1.Name = "nudPoints1";
            this.nudPoints1.Size = new System.Drawing.Size(120, 22);
            this.nudPoints1.TabIndex = 2;
            // 
            // tbDesc1
            // 
            this.tbDesc1.Location = new System.Drawing.Point(10, 42);
            this.tbDesc1.Multiline = true;
            this.tbDesc1.Name = "tbDesc1";
            this.tbDesc1.Size = new System.Drawing.Size(310, 88);
            this.tbDesc1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Опис:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nudPoints2);
            this.groupBox3.Controls.Add(this.tbDesc2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(349, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 221);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задача 2";
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(244, 192);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 4;
            this.btnSave1.Text = "Зачувај";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поени:";
            // 
            // nudPoints2
            // 
            this.nudPoints2.Location = new System.Drawing.Point(10, 153);
            this.nudPoints2.Name = "nudPoints2";
            this.nudPoints2.Size = new System.Drawing.Size(120, 22);
            this.nudPoints2.TabIndex = 2;
            // 
            // tbDesc2
            // 
            this.tbDesc2.Location = new System.Drawing.Point(10, 42);
            this.tbDesc2.Multiline = true;
            this.tbDesc2.Name = "tbDesc2";
            this.tbDesc2.Size = new System.Drawing.Size(310, 88);
            this.tbDesc2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Опис:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPoints1;
        private System.Windows.Forms.TextBox tbDesc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPoints2;
        private System.Windows.Forms.TextBox tbDesc2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbExams;
    }
}

