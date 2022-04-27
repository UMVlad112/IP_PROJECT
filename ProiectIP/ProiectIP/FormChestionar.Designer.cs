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
            this.buttonA.Location = new System.Drawing.Point(57, 410);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(204, 72);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonB.Location = new System.Drawing.Point(279, 410);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(204, 72);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonC.Location = new System.Drawing.Point(501, 410);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(204, 72);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonD.Location = new System.Drawing.Point(723, 410);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(204, 72);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext.Image")));
            this.buttonNext.Location = new System.Drawing.Point(804, 545);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(144, 58);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // richTextBoxQuestionUser
            // 
            this.richTextBoxQuestionUser.Location = new System.Drawing.Point(57, 78);
            this.richTextBoxQuestionUser.Name = "richTextBoxQuestionUser";
            this.richTextBoxQuestionUser.Size = new System.Drawing.Size(870, 274);
            this.richTextBoxQuestionUser.TabIndex = 5;
            this.richTextBoxQuestionUser.Text = "";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNumber.Location = new System.Drawing.Point(482, 563);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(40, 20);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "1/10";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelTimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTimer.Location = new System.Drawing.Point(951, 9);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(36, 26);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "30";
            // 
            // buttonDisconectUser
            // 
            this.buttonDisconectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDisconectUser.Location = new System.Drawing.Point(663, 545);
            this.buttonDisconectUser.Name = "buttonDisconectUser";
            this.buttonDisconectUser.Size = new System.Drawing.Size(135, 58);
            this.buttonDisconectUser.TabIndex = 8;
            this.buttonDisconectUser.Text = "Disconnect";
            this.buttonDisconectUser.UseVisualStyleBackColor = true;
            this.buttonDisconectUser.Click += new System.EventHandler(this.buttonDisconect_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelUser.Location = new System.Drawing.Point(12, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(64, 26);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "User:";
            // 
            // FormChestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 634);
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
            this.Name = "FormChestionar";
            this.Text = "FormChestionar";
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