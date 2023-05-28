namespace Avtobusi
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
            this.lbBus = new System.Windows.Forms.ListBox();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.tbAverageLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBus
            // 
            this.lbBus.FormattingEnabled = true;
            this.lbBus.ItemHeight = 16;
            this.lbBus.Location = new System.Drawing.Point(12, 50);
            this.lbBus.Name = "lbBus";
            this.lbBus.Size = new System.Drawing.Size(313, 308);
            this.lbBus.TabIndex = 0;
            this.lbBus.SelectedIndexChanged += new System.EventHandler(this.lbBus_SelectedIndexChanged);
            this.lbBus.SelectedValueChanged += new System.EventHandler(this.lbBus_SelectedValueChanged);
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.ItemHeight = 16;
            this.lbLines.Location = new System.Drawing.Point(331, 50);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(394, 308);
            this.lbLines.TabIndex = 1;
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(12, 381);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(313, 23);
            this.btnAddBus.TabIndex = 2;
            this.btnAddBus.Text = "Додади автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.Location = new System.Drawing.Point(12, 429);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(313, 23);
            this.btnDeleteBus.TabIndex = 3;
            this.btnDeleteBus.Text = "Избриши автобус";
            this.btnDeleteBus.UseVisualStyleBackColor = true;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(12, 479);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(313, 23);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Додади линија";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAverageLine);
            this.groupBox1.Controls.Add(this.tbMostExpensive);
            this.groupBox1.Location = new System.Drawing.Point(331, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Линии";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Автобуси";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Линии";
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.BackColor = System.Drawing.SystemColors.Control;
            this.tbMostExpensive.Location = new System.Drawing.Point(6, 45);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.ReadOnly = true;
            this.tbMostExpensive.Size = new System.Drawing.Size(382, 22);
            this.tbMostExpensive.TabIndex = 0;
            // 
            // tbAverageLine
            // 
            this.tbAverageLine.BackColor = System.Drawing.SystemColors.Control;
            this.tbAverageLine.Location = new System.Drawing.Point(6, 91);
            this.tbAverageLine.Name = "tbAverageLine";
            this.tbAverageLine.ReadOnly = true;
            this.tbAverageLine.Size = new System.Drawing.Size(382, 22);
            this.tbAverageLine.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Најскапа линија";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Просечна цена на линиите";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.lbBus);
            this.Name = "Form1";
            this.Text = "Автобуси";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBus;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAverageLine;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

