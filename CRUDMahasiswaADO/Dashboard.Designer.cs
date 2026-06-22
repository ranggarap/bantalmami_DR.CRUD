namespace CRUDMahasiswaADO
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.LoadDataChart = new System.Windows.Forms.Button();
            this.buttonClickReset = new System.Windows.Forms.Button();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
            this.chartProdi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDataMahasiswa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rekap Data Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tahun Masuk";
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(200, 75);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalMasuk.TabIndex = 2;
            // 
            // LoadDataChart
            // 
            this.LoadDataChart.Location = new System.Drawing.Point(454, 77);
            this.LoadDataChart.Name = "LoadDataChart";
            this.LoadDataChart.Size = new System.Drawing.Size(75, 23);
            this.LoadDataChart.TabIndex = 3;
            this.LoadDataChart.Text = "Load";
            this.LoadDataChart.UseVisualStyleBackColor = true;
            this.LoadDataChart.Click += new System.EventHandler(this.LoadDataChart_Click);
            // 
            // buttonClickReset
            // 
            this.buttonClickReset.Location = new System.Drawing.Point(587, 77);
            this.buttonClickReset.Name = "buttonClickReset";
            this.buttonClickReset.Size = new System.Drawing.Size(75, 23);
            this.buttonClickReset.TabIndex = 4;
            this.buttonClickReset.Text = "Reset";
            this.buttonClickReset.UseVisualStyleBackColor = true;
            this.buttonClickReset.Click += new System.EventHandler(this.buttonClickReset_Click);
            // 
            // cmbTipe
            // 
            this.cmbTipe.FormattingEnabled = true;
            this.cmbTipe.Location = new System.Drawing.Point(687, 32);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(121, 28);
            this.cmbTipe.TabIndex = 5;
            this.cmbTipe.SelectedValueChanged += new System.EventHandler(this.cmbTipe_SelectedValueChanged);
            // 
            // chartProdi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProdi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdi.Legends.Add(legend1);
            this.chartProdi.Location = new System.Drawing.Point(42, 107);
            this.chartProdi.Name = "chartProdi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProdi.Series.Add(series1);
            this.chartProdi.Size = new System.Drawing.Size(593, 324);
            this.chartProdi.TabIndex = 6;
            this.chartProdi.Text = "chartProdi";
            // 
            // btnDataMahasiswa
            // 
            this.btnDataMahasiswa.Location = new System.Drawing.Point(687, 77);
            this.btnDataMahasiswa.Name = "btnDataMahasiswa";
            this.btnDataMahasiswa.Size = new System.Drawing.Size(143, 24);
            this.btnDataMahasiswa.TabIndex = 7;
            this.btnDataMahasiswa.Text = "Data Mahasiswa";
            this.btnDataMahasiswa.UseVisualStyleBackColor = true;
            this.btnDataMahasiswa.Click += new System.EventHandler(this.btnDataMahasiswa_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 530);
            this.Controls.Add(this.btnDataMahasiswa);
            this.Controls.Add(this.chartProdi);
            this.Controls.Add(this.cmbTipe);
            this.Controls.Add(this.buttonClickReset);
            this.Controls.Add(this.LoadDataChart);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Button LoadDataChart;
        private System.Windows.Forms.Button buttonClickReset;
        private System.Windows.Forms.ComboBox cmbTipe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdi;
        private System.Windows.Forms.Button btnDataMahasiswa;
    }
}