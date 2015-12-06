namespace SchoolJournalGUI
{
    partial class ChildOverallProgress
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboChild = new System.Windows.Forms.ComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.chartProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // comboChild
            // 
            this.comboChild.FormattingEnabled = true;
            this.comboChild.Location = new System.Drawing.Point(158, 4);
            this.comboChild.Name = "comboChild";
            this.comboChild.Size = new System.Drawing.Size(184, 21);
            this.comboChild.TabIndex = 1;
            this.comboChild.SelectedIndexChanged += new System.EventHandler(this.comboChild_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(133, 22);
            this.toolStripLabel1.Text = "Choose child to display:";
            // 
            // chartProgress
            // 
            chartArea3.Name = "ChartArea1";
            this.chartProgress.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartProgress.Legends.Add(legend3);
            this.chartProgress.Location = new System.Drawing.Point(0, 29);
            this.chartProgress.Name = "chartProgress";
            this.chartProgress.Size = new System.Drawing.Size(810, 461);
            this.chartProgress.TabIndex = 2;
            this.chartProgress.Text = "chart1";
            // 
            // ChildOverallProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 491);
            this.Controls.Add(this.chartProgress);
            this.Controls.Add(this.comboChild);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ChildOverallProgress";
            this.Text = "Child Overall Progress - School Journal";
            this.Load += new System.EventHandler(this.ChildOverallProgress_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox comboChild;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgress;
    }
}