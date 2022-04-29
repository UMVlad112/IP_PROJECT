
namespace ProiectIP
{
    partial class FormRegisterAdmin
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
            this.textBoxUserAdmin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordAdmin = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAddAdmin = new System.Windows.Forms.Button();
            this.labelUserAdmin = new System.Windows.Forms.Label();
            this.labelPasswordAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserAdmin
            // 
            this.textBoxUserAdmin.Location = new System.Drawing.Point(147, 47);
            this.textBoxUserAdmin.Name = "textBoxUserAdmin";
            this.textBoxUserAdmin.Size = new System.Drawing.Size(200, 22);
            this.textBoxUserAdmin.TabIndex = 0;
            // 
            // textBoxPasswordAdmin
            // 
            this.textBoxPasswordAdmin.Location = new System.Drawing.Point(147, 106);
            this.textBoxPasswordAdmin.Name = "textBoxPasswordAdmin";
            this.textBoxPasswordAdmin.Size = new System.Drawing.Size(200, 22);
            this.textBoxPasswordAdmin.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonAddAdmin
            // 
            this.buttonAddAdmin.Location = new System.Drawing.Point(192, 170);
            this.buttonAddAdmin.Name = "buttonAddAdmin";
            this.buttonAddAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAdmin.TabIndex = 3;
            this.buttonAddAdmin.Text = "Add";
            this.buttonAddAdmin.UseVisualStyleBackColor = true;
            this.buttonAddAdmin.Click += new System.EventHandler(this.buttonAddAdmin_Click);
            // 
            // labelUserAdmin
            // 
            this.labelUserAdmin.AutoSize = true;
            this.labelUserAdmin.Location = new System.Drawing.Point(41, 47);
            this.labelUserAdmin.Name = "labelUserAdmin";
            this.labelUserAdmin.Size = new System.Drawing.Size(73, 17);
            this.labelUserAdmin.TabIndex = 4;
            this.labelUserAdmin.Text = "Username";
            // 
            // labelPasswordAdmin
            // 
            this.labelPasswordAdmin.AutoSize = true;
            this.labelPasswordAdmin.Location = new System.Drawing.Point(41, 106);
            this.labelPasswordAdmin.Name = "labelPasswordAdmin";
            this.labelPasswordAdmin.Size = new System.Drawing.Size(69, 17);
            this.labelPasswordAdmin.TabIndex = 5;
            this.labelPasswordAdmin.Text = "Password";
            // 
            // FormRegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 225);
            this.Controls.Add(this.labelPasswordAdmin);
            this.Controls.Add(this.labelUserAdmin);
            this.Controls.Add(this.buttonAddAdmin);
            this.Controls.Add(this.textBoxPasswordAdmin);
            this.Controls.Add(this.textBoxUserAdmin);
            this.Name = "FormRegisterAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegisterAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserAdmin;
        private System.Windows.Forms.TextBox textBoxPasswordAdmin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonAddAdmin;
        private System.Windows.Forms.Label labelUserAdmin;
        private System.Windows.Forms.Label labelPasswordAdmin;
    }
}