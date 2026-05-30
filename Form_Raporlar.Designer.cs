namespace Stok_Program
{
    partial class Form_Raporlar
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
            this.txtToplamCiro = new System.Windows.Forms.TextBox();
            this.txtSatisAdedi = new System.Windows.Forms.TextBox();
            this.gridKritikStok = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.chartCiro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gridKritikStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCiro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtToplamCiro
            // 
            this.txtToplamCiro.Location = new System.Drawing.Point(675, 104);
            this.txtToplamCiro.Name = "txtToplamCiro";
            this.txtToplamCiro.Size = new System.Drawing.Size(100, 22);
            this.txtToplamCiro.TabIndex = 0;
            // 
            // txtSatisAdedi
            // 
            this.txtSatisAdedi.Location = new System.Drawing.Point(675, 170);
            this.txtSatisAdedi.Name = "txtSatisAdedi";
            this.txtSatisAdedi.Size = new System.Drawing.Size(100, 22);
            this.txtSatisAdedi.TabIndex = 1;
            // 
            // gridKritikStok
            // 
            this.gridKritikStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKritikStok.Location = new System.Drawing.Point(22, 34);
            this.gridKritikStok.Name = "gridKritikStok";
            this.gridKritikStok.RowHeadersWidth = 51;
            this.gridKritikStok.RowTemplate.Height = 24;
            this.gridKritikStok.Size = new System.Drawing.Size(537, 261);
            this.gridKritikStok.TabIndex = 2;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(782, 211);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(150, 33);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Raporları Güncelle";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // chartCiro
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCiro.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCiro.Legends.Add(legend2);
            this.chartCiro.Location = new System.Drawing.Point(357, 318);
            this.chartCiro.Name = "chartCiro";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCiro.Series.Add(series2);
            this.chartCiro.Size = new System.Drawing.Size(608, 315);
            this.chartCiro.TabIndex = 4;
            this.chartCiro.Text = "chart1";
            // 
            // Form_Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.chartCiro);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.gridKritikStok);
            this.Controls.Add(this.txtSatisAdedi);
            this.Controls.Add(this.txtToplamCiro);
            this.Name = "Form_Raporlar";
            this.Text = "Form_Raporlar";
            this.Load += new System.EventHandler(this.Form_Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKritikStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToplamCiro;
        private System.Windows.Forms.TextBox txtSatisAdedi;
        private System.Windows.Forms.DataGridView gridKritikStok;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCiro;
    }
}