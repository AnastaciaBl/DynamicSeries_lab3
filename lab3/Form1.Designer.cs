namespace lab3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbBeta = new System.Windows.Forms.TrackBar();
            this.btnOpen = new System.Windows.Forms.Button();
            this.chDynamicSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chLinearModel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chExponentialModel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbLB1 = new System.Windows.Forms.TrackBar();
            this.tbLB2 = new System.Windows.Forms.TrackBar();
            this.tbLB3 = new System.Windows.Forms.TrackBar();
            this.tbEB1 = new System.Windows.Forms.TrackBar();
            this.tbEB2 = new System.Windows.Forms.TrackBar();
            this.tbEB3 = new System.Windows.Forms.TrackBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDynamicSeries)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chLinearModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chExponentialModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEB3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbBeta);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.chDynamicSeries);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BraunModel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbBeta
            // 
            this.tbBeta.Location = new System.Drawing.Point(478, 188);
            this.tbBeta.Maximum = 100;
            this.tbBeta.Name = "tbBeta";
            this.tbBeta.Size = new System.Drawing.Size(252, 45);
            this.tbBeta.TabIndex = 2;
            this.tbBeta.Value = 30;
            this.tbBeta.ValueChanged += new System.EventHandler(this.tbBeta_ValueChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(529, 107);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(152, 38);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open file...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chDynamicSeries
            // 
            chartArea12.Name = "ChartArea1";
            this.chDynamicSeries.ChartAreas.Add(chartArea12);
            this.chDynamicSeries.Location = new System.Drawing.Point(0, 0);
            this.chDynamicSeries.Name = "chDynamicSeries";
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.CustomProperties = "PointWidth=1";
            series23.Name = "Series1";
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Name = "Series2";
            this.chDynamicSeries.Series.Add(series23);
            this.chDynamicSeries.Series.Add(series24);
            this.chDynamicSeries.Size = new System.Drawing.Size(412, 423);
            this.chDynamicSeries.TabIndex = 0;
            this.chDynamicSeries.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbLB3);
            this.tabPage2.Controls.Add(this.tbLB2);
            this.tabPage2.Controls.Add(this.tbLB1);
            this.tabPage2.Controls.Add(this.chLinearModel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LinearModel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbEB3);
            this.tabPage3.Controls.Add(this.tbEB2);
            this.tabPage3.Controls.Add(this.tbEB1);
            this.tabPage3.Controls.Add(this.chExponentialModel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ExponentialModel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chLinearModel
            // 
            chartArea10.Name = "ChartArea1";
            this.chLinearModel.ChartAreas.Add(chartArea10);
            this.chLinearModel.Location = new System.Drawing.Point(3, 0);
            this.chLinearModel.Name = "chLinearModel";
            series19.BorderWidth = 2;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.CustomProperties = "PointWidth=1";
            series19.Name = "Series1";
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Name = "Series2";
            this.chLinearModel.Series.Add(series19);
            this.chLinearModel.Series.Add(series20);
            this.chLinearModel.Size = new System.Drawing.Size(412, 423);
            this.chLinearModel.TabIndex = 1;
            this.chLinearModel.Text = "chLinearModel";
            // 
            // chExponentialModel
            // 
            chartArea11.Name = "ChartArea1";
            this.chExponentialModel.ChartAreas.Add(chartArea11);
            this.chExponentialModel.Location = new System.Drawing.Point(0, 0);
            this.chExponentialModel.Name = "chExponentialModel";
            series21.BorderWidth = 2;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.CustomProperties = "PointWidth=1";
            series21.Name = "Series1";
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Name = "Series2";
            this.chExponentialModel.Series.Add(series21);
            this.chExponentialModel.Series.Add(series22);
            this.chExponentialModel.Size = new System.Drawing.Size(412, 423);
            this.chExponentialModel.TabIndex = 1;
            this.chExponentialModel.Text = "chart1";
            // 
            // tbLB1
            // 
            this.tbLB1.Location = new System.Drawing.Point(472, 47);
            this.tbLB1.Maximum = 100;
            this.tbLB1.Name = "tbLB1";
            this.tbLB1.Size = new System.Drawing.Size(252, 45);
            this.tbLB1.TabIndex = 3;
            this.tbLB1.Value = 30;
            this.tbLB1.ValueChanged += new System.EventHandler(this.tbLB1_ValueChanged);
            // 
            // tbLB2
            // 
            this.tbLB2.Location = new System.Drawing.Point(472, 113);
            this.tbLB2.Maximum = 100;
            this.tbLB2.Name = "tbLB2";
            this.tbLB2.Size = new System.Drawing.Size(252, 45);
            this.tbLB2.TabIndex = 4;
            this.tbLB2.Value = 60;
            this.tbLB2.ValueChanged += new System.EventHandler(this.tbLB2_ValueChanged);
            // 
            // tbLB3
            // 
            this.tbLB3.Location = new System.Drawing.Point(472, 179);
            this.tbLB3.Maximum = 100;
            this.tbLB3.Name = "tbLB3";
            this.tbLB3.Size = new System.Drawing.Size(252, 45);
            this.tbLB3.TabIndex = 5;
            this.tbLB3.Value = 80;
            this.tbLB3.ValueChanged += new System.EventHandler(this.tbLB3_ValueChanged);
            // 
            // tbEB1
            // 
            this.tbEB1.Location = new System.Drawing.Point(465, 38);
            this.tbEB1.Maximum = 100;
            this.tbEB1.Name = "tbEB1";
            this.tbEB1.Size = new System.Drawing.Size(252, 45);
            this.tbEB1.TabIndex = 3;
            this.tbEB1.Value = 30;
            this.tbEB1.ValueChanged += new System.EventHandler(this.tbEB1_ValueChanged);
            // 
            // tbEB2
            // 
            this.tbEB2.Location = new System.Drawing.Point(465, 103);
            this.tbEB2.Maximum = 100;
            this.tbEB2.Name = "tbEB2";
            this.tbEB2.Size = new System.Drawing.Size(252, 45);
            this.tbEB2.TabIndex = 4;
            this.tbEB2.Value = 60;
            this.tbEB2.ValueChanged += new System.EventHandler(this.tbEB2_ValueChanged);
            // 
            // tbEB3
            // 
            this.tbEB3.Location = new System.Drawing.Point(465, 175);
            this.tbEB3.Maximum = 100;
            this.tbEB3.Name = "tbEB3";
            this.tbEB3.Size = new System.Drawing.Size(252, 45);
            this.tbEB3.TabIndex = 5;
            this.tbEB3.Value = 80;
            this.tbEB3.ValueChanged += new System.EventHandler(this.tbEB3_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDynamicSeries)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chLinearModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chExponentialModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEB3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDynamicSeries;
        private System.Windows.Forms.TrackBar tbBeta;
        private System.Windows.Forms.TrackBar tbLB3;
        private System.Windows.Forms.TrackBar tbLB2;
        private System.Windows.Forms.TrackBar tbLB1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chLinearModel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TrackBar tbEB3;
        private System.Windows.Forms.TrackBar tbEB2;
        private System.Windows.Forms.TrackBar tbEB1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chExponentialModel;
    }
}

