namespace ProiectIP
{
    partial class FormChestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChestionar));
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.richTextBoxQuestionUser = new System.Windows.Forms.RichTextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonDisconectUser = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonA.Location = new System.Drawing.Point(76, 505);
            this.buttonA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(272, 89);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonB.Location = new System.Drawing.Point(372, 505);
            this.buttonB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(272, 89);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonC.Location = new System.Drawing.Point(668, 505);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(272, 89);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonD.Location = new System.Drawing.Point(964, 505);
            this.buttonD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(272, 89);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext.Image")));
            this.buttonNext.Location = new System.Drawing.Point(1072, 671);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(192, 71);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // richTextBoxQuestionUser
            // 
            this.richTextBoxQuestionUser.Location = new System.Drawing.Point(76, 96);
            this.richTextBoxQuestionUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxQuestionUser.Name = "richTextBoxQuestionUser";
            this.richTextBoxQuestionUser.Size = new System.Drawing.Size(1159, 336);
            this.richTextBoxQuestionUser.TabIndex = 5;
            this.richTextBoxQuestionUser.Text = "";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNumber.Location = new System.Drawing.Point(643, 693);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(51, 25);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "1/10";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelTimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTimer.Location = new System.Drawing.Point(1268, 11);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(44, 31);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "30";
            // 
            // buttonDisconectUser
            // 
            this.buttonDisconectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDisconectUser.Location = new System.Drawing.Point(884, 671);
            this.buttonDisconectUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisconectUser.Name = "buttonDisconectUser";
            this.buttonDisconectUser.Size = new System.Drawing.Size(180, 71);
            this.buttonDisconectUser.TabIndex = 8;
            this.buttonDisconectUser.Text = "Disconnect";
            this.buttonDisconectUser.UseVisualStyleBackColor = true;
            this.buttonDisconectUser.Click += new System.EventHandler(this.buttonDisconect_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelUser.Location = new System.Drawing.Point(16, 11);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(80, 31);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "User:";
            // 
            // FormChestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 780);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonDisconectUser);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.richTextBoxQuestionUser);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChestionar";
            this.Text = "FormChestionar";
            this.Load += new System.EventHandler(this.FormChestionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.RichTextBox richTextBoxQuestionUser;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonDisconectUser;
        private System.Windows.Forms.Label labelUser;
    }
}