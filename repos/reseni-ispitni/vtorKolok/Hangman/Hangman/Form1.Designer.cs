namespace Hangman
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
            this.tbWordState = new System.Windows.Forms.TextBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGuessedLetter = new System.Windows.Forms.TextBox();
            this.pbTries = new System.Windows.Forms.ProgressBar();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbWordState
            // 
            this.tbWordState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWordState.Location = new System.Drawing.Point(48, 64);
            this.tbWordState.Multiline = true;
            this.tbWordState.Name = "tbWordState";
            this.tbWordState.ReadOnly = true;
            this.tbWordState.Size = new System.Drawing.Size(525, 47);
            this.tbWordState.TabIndex = 0;
            // 
            // tbTimer
            // 
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimer.Location = new System.Drawing.Point(650, 32);
            this.tbTimer.Multiline = true;
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(80, 42);
            this.tbTimer.TabIndex = 1;
            this.tbTimer.Text = "02:00";
            this.tbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLetter
            // 
            this.tbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetter.Location = new System.Drawing.Point(48, 216);
            this.tbLetter.Multiline = true;
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(108, 46);
            this.tbLetter.TabIndex = 2;
            this.tbLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(172, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 46);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Погодени букви";
            // 
            // tbGuessedLetter
            // 
            this.tbGuessedLetter.Location = new System.Drawing.Point(48, 322);
            this.tbGuessedLetter.Multiline = true;
            this.tbGuessedLetter.Name = "tbGuessedLetter";
            this.tbGuessedLetter.ReadOnly = true;
            this.tbGuessedLetter.Size = new System.Drawing.Size(525, 40);
            this.tbGuessedLetter.TabIndex = 5;
            this.tbGuessedLetter.Text = "\r\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            // 
            // pbTries
            // 
            this.pbTries.Location = new System.Drawing.Point(48, 393);
            this.pbTries.Name = "pbTries";
            this.pbTries.Size = new System.Drawing.Size(525, 23);
            this.pbTries.TabIndex = 6;
            // 
            // pbTimer
            // 
            this.pbTimer.Location = new System.Drawing.Point(48, 444);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(525, 23);
            this.pbTimer.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 490);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.pbTries);
            this.Controls.Add(this.tbGuessedLetter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.tbWordState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWordState;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGuessedLetter;
        private System.Windows.Forms.ProgressBar pbTries;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

