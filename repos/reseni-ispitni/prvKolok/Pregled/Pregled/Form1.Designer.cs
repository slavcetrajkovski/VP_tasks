namespace Pregled
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
            this.lbPatients = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMetrics = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddMetric = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMetrics = new System.Windows.Forms.ListBox();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPatients
            // 
            this.lbPatients.FormattingEnabled = true;
            this.lbPatients.ItemHeight = 16;
            this.lbPatients.Location = new System.Drawing.Point(32, 48);
            this.lbPatients.Name = "lbPatients";
            this.lbPatients.Size = new System.Drawing.Size(301, 420);
            this.lbPatients.TabIndex = 0;
            this.lbPatients.SelectedIndexChanged += new System.EventHandler(this.lbPatients_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 484);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(301, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додади пациент";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(32, 525);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(301, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Избриши пациент";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пациенти:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudValue);
            this.groupBox1.Controls.Add(this.btnAddMetric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMetrics);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(429, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади мерење";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вид на мерење";
            // 
            // cbMetrics
            // 
            this.cbMetrics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetrics.FormattingEnabled = true;
            this.cbMetrics.Location = new System.Drawing.Point(9, 47);
            this.cbMetrics.Name = "cbMetrics";
            this.cbMetrics.Size = new System.Drawing.Size(332, 24);
            this.cbMetrics.TabIndex = 1;
            this.cbMetrics.SelectedIndexChanged += new System.EventHandler(this.cbMetrics_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вредност:";
            // 
            // btnAddMetric
            // 
            this.btnAddMetric.Location = new System.Drawing.Point(194, 146);
            this.btnAddMetric.Name = "btnAddMetric";
            this.btnAddMetric.Size = new System.Drawing.Size(147, 23);
            this.btnAddMetric.TabIndex = 4;
            this.btnAddMetric.Text = "Додади мерење";
            this.btnAddMetric.UseVisualStyleBackColor = true;
            this.btnAddMetric.Click += new System.EventHandler(this.btnAddMetric_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Мерења";
            // 
            // lbMetrics
            // 
            this.lbMetrics.FormattingEnabled = true;
            this.lbMetrics.ItemHeight = 16;
            this.lbMetrics.Location = new System.Drawing.Point(432, 260);
            this.lbMetrics.Name = "lbMetrics";
            this.lbMetrics.Size = new System.Drawing.Size(338, 212);
            this.lbMetrics.TabIndex = 6;
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(7, 104);
            this.nudValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(334, 22);
            this.nudValue.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 581);
            this.Controls.Add(this.lbMetrics);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbPatients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPatients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddMetric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMetrics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbMetrics;
        private System.Windows.Forms.NumericUpDown nudValue;
    }
}

