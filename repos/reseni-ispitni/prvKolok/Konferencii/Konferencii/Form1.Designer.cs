namespace ConferencePapers
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
            this.lbConference = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnAddConf = new System.Windows.Forms.Button();
            this.btnCancelConf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelConf);
            this.groupBox1.Controls.Add(this.btnAddConf);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbConference);
            this.groupBox1.Location = new System.Drawing.Point(29, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Конференции";
            // 
            // lbConference
            // 
            this.lbConference.FormattingEnabled = true;
            this.lbConference.ItemHeight = 16;
            this.lbConference.Location = new System.Drawing.Point(6, 21);
            this.lbConference.Name = "lbConference";
            this.lbConference.Size = new System.Drawing.Size(364, 324);
            this.lbConference.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Година:";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(10, 381);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(360, 24);
            this.cbYear.TabIndex = 2;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // btnAddConf
            // 
            this.btnAddConf.Location = new System.Drawing.Point(10, 412);
            this.btnAddConf.Name = "btnAddConf";
            this.btnAddConf.Size = new System.Drawing.Size(360, 28);
            this.btnAddConf.TabIndex = 3;
            this.btnAddConf.Text = "Додади конференција";
            this.btnAddConf.UseVisualStyleBackColor = true;
            this.btnAddConf.Click += new System.EventHandler(this.btnAddConf_Click);
            // 
            // btnCancelConf
            // 
            this.btnCancelConf.Location = new System.Drawing.Point(10, 446);
            this.btnCancelConf.Name = "btnCancelConf";
            this.btnCancelConf.Size = new System.Drawing.Size(360, 28);
            this.btnCancelConf.TabIndex = 4;
            this.btnCancelConf.Text = "Избриши конференција";
            this.btnCancelConf.UseVisualStyleBackColor = true;
            this.btnCancelConf.Click += new System.EventHandler(this.btnCancelConf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 529);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Конференција";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelConf;
        private System.Windows.Forms.Button btnAddConf;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbConference;
    }
}

