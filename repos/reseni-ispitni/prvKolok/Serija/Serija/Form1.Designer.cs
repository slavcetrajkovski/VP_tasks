namespace Serija
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbProduction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSeasons = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddProduction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMostSeasons = new System.Windows.Forms.TextBox();
            this.tbAverageRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSeries = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasons)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.nudSeasons);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudRating);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbProduction);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нова Серија";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продукција";
            // 
            // cbProduction
            // 
            this.cbProduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduction.FormattingEnabled = true;
            this.cbProduction.Location = new System.Drawing.Point(9, 49);
            this.cbProduction.Name = "cbProduction";
            this.cbProduction.Size = new System.Drawing.Size(359, 24);
            this.cbProduction.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 107);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(359, 22);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рејтинг:";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(7, 161);
            this.nudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 22);
            this.nudRating.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Број на сезони:";
            // 
            // nudSeasons
            // 
            this.nudSeasons.Location = new System.Drawing.Point(7, 214);
            this.nudSeasons.Name = "nudSeasons";
            this.nudSeasons.Size = new System.Drawing.Size(120, 22);
            this.nudSeasons.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Додади серија";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Избриши серија";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddProduction
            // 
            this.btnAddProduction.Location = new System.Drawing.Point(21, 383);
            this.btnAddProduction.Name = "btnAddProduction";
            this.btnAddProduction.Size = new System.Drawing.Size(188, 23);
            this.btnAddProduction.TabIndex = 10;
            this.btnAddProduction.Text = "Додади продукција";
            this.btnAddProduction.UseVisualStyleBackColor = true;
            this.btnAddProduction.Click += new System.EventHandler(this.btnAddProduction_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSeries);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbAverageRating);
            this.groupBox2.Controls.Add(this.tbMostSeasons);
            this.groupBox2.Location = new System.Drawing.Point(403, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 295);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Листа на серии";
            // 
            // tbMostSeasons
            // 
            this.tbMostSeasons.Location = new System.Drawing.Point(6, 257);
            this.tbMostSeasons.Name = "tbMostSeasons";
            this.tbMostSeasons.ReadOnly = true;
            this.tbMostSeasons.Size = new System.Drawing.Size(361, 22);
            this.tbMostSeasons.TabIndex = 0;
            // 
            // tbAverageRating
            // 
            this.tbAverageRating.Location = new System.Drawing.Point(9, 213);
            this.tbAverageRating.Name = "tbAverageRating";
            this.tbAverageRating.ReadOnly = true;
            this.tbAverageRating.Size = new System.Drawing.Size(361, 22);
            this.tbAverageRating.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Најмногу сезони:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Просечен рејтинг:";
            // 
            // lbSeries
            // 
            this.lbSeries.FormattingEnabled = true;
            this.lbSeries.ItemHeight = 16;
            this.lbSeries.Location = new System.Drawing.Point(12, 21);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(355, 164);
            this.lbSeries.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAddProduction);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasons)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudSeasons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProduction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbSeries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAverageRating;
        private System.Windows.Forms.TextBox tbMostSeasons;
    }
}

