namespace TvProgram
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
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTv = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.lbSeries = new System.Windows.Forms.ListBox();
            this.lblTV = new System.Windows.Forms.Label();
            this.btnAddTv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.nudMin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTv);
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Избриши програма";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(221, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Додади програма";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(9, 165);
            this.nudMin.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(156, 22);
            this.nudMin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Времетрање(мин)";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 109);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(421, 22);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Телевизија:";
            // 
            // cbTv
            // 
            this.cbTv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTv.FormattingEnabled = true;
            this.cbTv.Location = new System.Drawing.Point(6, 50);
            this.cbTv.Name = "cbTv";
            this.cbTv.Size = new System.Drawing.Size(424, 24);
            this.cbTv.TabIndex = 0;
            this.cbTv.SelectedIndexChanged += new System.EventHandler(this.cbTv_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbAverage);
            this.groupBox2.Controls.Add(this.lbSeries);
            this.groupBox2.Controls.Add(this.lblTV);
            this.groupBox2.Location = new System.Drawing.Point(488, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 403);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Просечно времетрање:";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(19, 367);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(411, 22);
            this.tbAverage.TabIndex = 4;
            this.tbAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSeries
            // 
            this.lbSeries.FormattingEnabled = true;
            this.lbSeries.ItemHeight = 16;
            this.lbSeries.Location = new System.Drawing.Point(19, 81);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(411, 228);
            this.lbSeries.TabIndex = 3;
            // 
            // lblTV
            // 
            this.lblTV.AutoSize = true;
            this.lblTV.Location = new System.Drawing.Point(29, 41);
            this.lblTV.Name = "lblTV";
            this.lblTV.Size = new System.Drawing.Size(0, 16);
            this.lblTV.TabIndex = 2;
            // 
            // btnAddTv
            // 
            this.btnAddTv.Location = new System.Drawing.Point(24, 394);
            this.btnAddTv.Name = "btnAddTv";
            this.btnAddTv.Size = new System.Drawing.Size(207, 31);
            this.btnAddTv.TabIndex = 6;
            this.btnAddTv.Text = "Додади ТВ";
            this.btnAddTv.UseVisualStyleBackColor = true;
            this.btnAddTv.Click += new System.EventHandler(this.btnAddTv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 459);
            this.Controls.Add(this.btnAddTv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.ListBox lbSeries;
        private System.Windows.Forms.Button btnAddTv;
    }
}

