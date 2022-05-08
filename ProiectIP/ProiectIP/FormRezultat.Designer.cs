
namespace ProiectIP
{
    partial class FormRezultat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.chartHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelHistory = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRezultat
            // 
            this.labelRezultat.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRezultat.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezultat.Location = new System.Drawing.Point(0, 0);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(775, 30);
            this.labelRezultat.TabIndex = 2;
            this.labelRezultat.Text = "Ai raspuns corect la 5 dintrebari din 10. Felicitari!";
            this.labelRezultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRezultat.UseCompatibleTextRendering = true;
            // 
            // chartHistory
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHistory.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHistory.Legends.Add(legend2);
            this.chartHistory.Location = new System.Drawing.Point(51, 142);
            this.chartHistory.Name = "chartHistory";
            this.chartHistory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Score";
            this.chartHistory.Series.Add(series2);
            this.chartHistory.Size = new System.Drawing.Size(673, 295);
            this.chartHistory.TabIndex = 3;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistory.Location = new System.Drawing.Point(47, 102);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(214, 24);
            this.labelHistory.TabIndex = 4;
            this.labelHistory.Text = "Your previous scores:";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(51, 479);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(649, 479);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(75, 23);
            this.buttonRedo.TabIndex = 6;
            this.buttonRedo.Text = "Start again";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // FormRezultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 541);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.chartHistory);
            this.Controls.Add(this.labelRezultat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormRezultat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRezultat";
            this.Load += new System.EventHandler(this.FormRezultat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRezultat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistory;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonRedo;
    }
}