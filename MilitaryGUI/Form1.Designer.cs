namespace MilitaryGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CountriesNames = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PickData = new System.Windows.Forms.ListBox();
            this.DrawChart = new System.Windows.Forms.Button();
            this.GetAllies = new System.Windows.Forms.Button();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ChartPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // CountriesNames
            // 
            this.CountriesNames.FormattingEnabled = true;
            this.CountriesNames.Location = new System.Drawing.Point(12, 25);
            this.CountriesNames.Name = "CountriesNames";
            this.CountriesNames.Size = new System.Drawing.Size(159, 329);
            this.CountriesNames.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 329);
            this.dataGridView1.TabIndex = 3;
            // 
            // PickData
            // 
            this.PickData.FormattingEnabled = true;
            this.PickData.Location = new System.Drawing.Point(629, 25);
            this.PickData.Name = "PickData";
            this.PickData.Size = new System.Drawing.Size(159, 329);
            this.PickData.TabIndex = 4;
            // 
            // DrawChart
            // 
            this.DrawChart.Location = new System.Drawing.Point(629, 366);
            this.DrawChart.Name = "DrawChart";
            this.DrawChart.Size = new System.Drawing.Size(159, 55);
            this.DrawChart.TabIndex = 5;
            this.DrawChart.Text = "Draw Chart";
            this.DrawChart.UseVisualStyleBackColor = true;
            this.DrawChart.Click += new System.EventHandler(this.DrawChart_Click);
            // 
            // GetAllies
            // 
            this.GetAllies.Location = new System.Drawing.Point(12, 366);
            this.GetAllies.Name = "GetAllies";
            this.GetAllies.Size = new System.Drawing.Size(159, 55);
            this.GetAllies.TabIndex = 6;
            this.GetAllies.Text = "Get Allies";
            this.GetAllies.UseVisualStyleBackColor = true;
            this.GetAllies.Click += new System.EventHandler(this.GetAllies_Click);
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.Chart1);
            this.ChartPanel.Controls.Add(this.Back);
            this.ChartPanel.Location = new System.Drawing.Point(0, 0);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(790, 437);
            this.ChartPanel.TabIndex = 7;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(25, 366);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(113, 45);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ChartPanel);
            this.MainPanel.Controls.Add(this.DrawChart);
            this.MainPanel.Controls.Add(this.PickData);
            this.MainPanel.Controls.Add(this.CountriesNames);
            this.MainPanel.Controls.Add(this.GetAllies);
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Location = new System.Drawing.Point(-2, 1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(790, 422);
            this.MainPanel.TabIndex = 7;
            // 
            // Chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart1.Legends.Add(legend3);
            this.Chart1.Location = new System.Drawing.Point(25, 22);
            this.Chart1.Name = "Chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(745, 338);
            this.Chart1.TabIndex = 1;
            this.Chart1.Text = "Chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ChartPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox CountriesNames;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox PickData;
        private System.Windows.Forms.Button DrawChart;
        private System.Windows.Forms.Button GetAllies;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
    }
}

