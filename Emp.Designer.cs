namespace WindowsFormsApp1
{
    partial class Emp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.ShowTicketsBtn = new System.Windows.Forms.Button();
            this.EmployeeTicketsDGV = new System.Windows.Forms.DataGridView();
            this.EmployeeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowAnalyticsBtn = new System.Windows.Forms.Button();
            this.CreateNewTicketBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTicketsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLabel.Location = new System.Drawing.Point(24, 35);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(135, 18);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee Dashboard";
            // 
            // ShowTicketsBtn
            // 
            this.ShowTicketsBtn.Location = new System.Drawing.Point(176, 33);
            this.ShowTicketsBtn.Name = "ShowTicketsBtn";
            this.ShowTicketsBtn.Size = new System.Drawing.Size(83, 23);
            this.ShowTicketsBtn.TabIndex = 2;
            this.ShowTicketsBtn.Text = "Show Tickets ";
            this.ShowTicketsBtn.UseVisualStyleBackColor = true;
            this.ShowTicketsBtn.Click += new System.EventHandler(this.ShowTicketsBtn_Click);
            // 
            // EmployeeTicketsDGV
            // 
            this.EmployeeTicketsDGV.AllowUserToAddRows = false;
            this.EmployeeTicketsDGV.AllowUserToDeleteRows = false;
            this.EmployeeTicketsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeTicketsDGV.Location = new System.Drawing.Point(59, 88);
            this.EmployeeTicketsDGV.Name = "EmployeeTicketsDGV";
            this.EmployeeTicketsDGV.Size = new System.Drawing.Size(482, 280);
            this.EmployeeTicketsDGV.TabIndex = 3;
            // 
            // EmployeeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.EmployeeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.EmployeeChart.Legends.Add(legend1);
            this.EmployeeChart.Location = new System.Drawing.Point(59, 88);
            this.EmployeeChart.Name = "EmployeeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.EmployeeChart.Series.Add(series1);
            this.EmployeeChart.Size = new System.Drawing.Size(482, 280);
            this.EmployeeChart.TabIndex = 4;
            this.EmployeeChart.Text = "chart1";
            this.EmployeeChart.Click += new System.EventHandler(this.EmployeeChart_Click);
            // 
            // ShowAnalyticsBtn
            // 
            this.ShowAnalyticsBtn.Location = new System.Drawing.Point(288, 30);
            this.ShowAnalyticsBtn.Name = "ShowAnalyticsBtn";
            this.ShowAnalyticsBtn.Size = new System.Drawing.Size(90, 23);
            this.ShowAnalyticsBtn.TabIndex = 5;
            this.ShowAnalyticsBtn.Text = "Show Analytics ";
            this.ShowAnalyticsBtn.UseVisualStyleBackColor = true;
            this.ShowAnalyticsBtn.Click += new System.EventHandler(this.ShowAnalyticsBtn_Click);
            // 
            // CreateNewTicketBtn
            // 
            this.CreateNewTicketBtn.Location = new System.Drawing.Point(403, 30);
            this.CreateNewTicketBtn.Name = "CreateNewTicketBtn";
            this.CreateNewTicketBtn.Size = new System.Drawing.Size(90, 23);
            this.CreateNewTicketBtn.TabIndex = 6;
            this.CreateNewTicketBtn.Text = "Create Ticket";
            this.CreateNewTicketBtn.UseVisualStyleBackColor = true;
            this.CreateNewTicketBtn.Click += new System.EventHandler(this.CreateNewTicketBtn_Click);
            // 
            // Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.CreateNewTicketBtn);
            this.Controls.Add(this.ShowAnalyticsBtn);
            this.Controls.Add(this.ShowTicketsBtn);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.EmployeeChart);
            this.Controls.Add(this.EmployeeTicketsDGV);
            this.Name = "Emp";
            this.Size = new System.Drawing.Size(600, 420);
            this.Load += new System.EventHandler(this.Emp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTicketsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Button ShowTicketsBtn;
        private System.Windows.Forms.DataGridView EmployeeTicketsDGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmployeeChart;
        private System.Windows.Forms.Button ShowAnalyticsBtn;
        private System.Windows.Forms.Button CreateNewTicketBtn;
    }
}
