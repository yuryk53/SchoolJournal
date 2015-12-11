namespace SchoolJournalGUI
{
    partial class StudentOverallProgressWindow
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
            this.chartProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProgress
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProgress.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProgress.Legends.Add(legend2);
            this.chartProgress.Location = new System.Drawing.Point(1, -1);
            this.chartProgress.Name = "chartProgress";
            this.chartProgress.Size = new System.Drawing.Size(810, 461);
            this.chartProgress.TabIndex = 3;
            this.chartProgress.Text = "chart1";
            // 
            // StudentOverallProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 463);
            this.Controls.Add(this.chartProgress);
            this.Name = "StudentOverallProgressWindow";
            this.Text = "My overall progress - School Journal";
            this.Load += new System.EventHandler(this.StudentOverallProgressWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgress;
    }
}