namespace Avtomobili
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
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudConsumption = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddMarka = new System.Windows.Forms.Button();
            this.lbMarki = new System.Windows.Forms.ListBox();
            this.lbCars = new System.Windows.Forms.GroupBox();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMostEconomical = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCarList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsumption)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.lbCars.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMarka
            // 
            this.cbMarka.BackColor = System.Drawing.SystemColors.Control;
            this.cbMarka.DisplayMember = "BMW";
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(6, 49);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(384, 24);
            this.cbMarka.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.nudPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudConsumption);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMarka);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нов автомобил:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(221, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Избриши автомобил";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Додади автомобили";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(9, 218);
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(131, 22);
            this.nudPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена:";
            // 
            // nudConsumption
            // 
            this.nudConsumption.DecimalPlaces = 1;
            this.nudConsumption.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudConsumption.Location = new System.Drawing.Point(6, 158);
            this.nudConsumption.Name = "nudConsumption";
            this.nudConsumption.Size = new System.Drawing.Size(131, 22);
            this.nudConsumption.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Потрошувачка:";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(6, 105);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(384, 22);
            this.tbModel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модел:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddMarka);
            this.groupBox2.Controls.Add(this.lbMarki);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Марки на автомобили:";
            // 
            // btnAddMarka
            // 
            this.btnAddMarka.Location = new System.Drawing.Point(208, 201);
            this.btnAddMarka.Name = "btnAddMarka";
            this.btnAddMarka.Size = new System.Drawing.Size(182, 23);
            this.btnAddMarka.TabIndex = 1;
            this.btnAddMarka.Text = "Додади нова марка";
            this.btnAddMarka.UseVisualStyleBackColor = true;
            this.btnAddMarka.Click += new System.EventHandler(this.btnAddMarka_Click);
            // 
            // lbMarki
            // 
            this.lbMarki.FormattingEnabled = true;
            this.lbMarki.ItemHeight = 16;
            this.lbMarki.Location = new System.Drawing.Point(9, 21);
            this.lbMarki.Name = "lbMarki";
            this.lbMarki.Size = new System.Drawing.Size(381, 164);
            this.lbMarki.TabIndex = 0;
            // 
            // lbCars
            // 
            this.lbCars.Controls.Add(this.tbMostExpensive);
            this.lbCars.Controls.Add(this.label7);
            this.lbCars.Controls.Add(this.tbMostEconomical);
            this.lbCars.Controls.Add(this.label6);
            this.lbCars.Controls.Add(this.tbAverage);
            this.lbCars.Controls.Add(this.label5);
            this.lbCars.Controls.Add(this.lbCarList);
            this.lbCars.Location = new System.Drawing.Point(439, 24);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(388, 528);
            this.lbCars.TabIndex = 3;
            this.lbCars.TabStop = false;
            this.lbCars.Text = "Листа на автомобили:";
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.BackColor = System.Drawing.SystemColors.Control;
            this.tbMostExpensive.Location = new System.Drawing.Point(9, 495);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.ReadOnly = true;
            this.tbMostExpensive.Size = new System.Drawing.Size(373, 22);
            this.tbMostExpensive.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Најскап:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbMostEconomical
            // 
            this.tbMostEconomical.BackColor = System.Drawing.SystemColors.Control;
            this.tbMostEconomical.Location = new System.Drawing.Point(9, 451);
            this.tbMostEconomical.Name = "tbMostEconomical";
            this.tbMostEconomical.ReadOnly = true;
            this.tbMostEconomical.Size = new System.Drawing.Size(373, 22);
            this.tbMostEconomical.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Најекономичен:";
            // 
            // tbAverage
            // 
            this.tbAverage.BackColor = System.Drawing.SystemColors.Control;
            this.tbAverage.Location = new System.Drawing.Point(206, 376);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(176, 22);
            this.tbAverage.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Просечна потрошувачка:";
            // 
            // lbCarList
            // 
            this.lbCarList.FormattingEnabled = true;
            this.lbCarList.ItemHeight = 16;
            this.lbCarList.Location = new System.Drawing.Point(6, 21);
            this.lbCarList.Name = "lbCarList";
            this.lbCarList.Size = new System.Drawing.Size(376, 340);
            this.lbCarList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 577);
            this.Controls.Add(this.lbCars);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsumption)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.lbCars.ResumeLayout(false);
            this.lbCars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudConsumption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddMarka;
        private System.Windows.Forms.ListBox lbMarki;
        private System.Windows.Forms.GroupBox lbCars;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbCarList;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMostEconomical;
        private System.Windows.Forms.Label label6;
    }
}

