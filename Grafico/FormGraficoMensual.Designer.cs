namespace Desk.Grafico
{
    partial class FormGraficoMensual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAnual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnual)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAnual
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAnual.ChartAreas.Add(chartArea1);
            this.chartAnual.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartAnual.Legends.Add(legend1);
            this.chartAnual.Location = new System.Drawing.Point(-5, 0);
            this.chartAnual.Name = "chartAnual";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAnual.Series.Add(series1);
            this.chartAnual.Size = new System.Drawing.Size(617, 295);
            this.chartAnual.TabIndex = 0;
            this.chartAnual.Text = "chart1";
            // 
            // FormGraficoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 296);
            this.Controls.Add(this.chartAnual);
            this.Name = "FormGraficoMensual";
            this.Text = "FormGraficoMensual";
            ((System.ComponentModel.ISupportInitialize)(this.chartAnual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnual;
    }
}