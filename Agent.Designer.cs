﻿namespace WindowsFormsApp1
{
    partial class Agent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AgentLabel = new System.Windows.Forms.Label();
            this.ShowAgentAnalyticsBtn = new System.Windows.Forms.Button();
            this.AgentListDGV = new System.Windows.Forms.DataGridView();
            this.AgentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSSDataSet = new WindowsFormsApp1.EMSSDataSet();
            this.ShowTicketBtn = new System.Windows.Forms.Button();
            this.UpdateTicketBtn = new System.Windows.Forms.Button();
            this.RevertStatusBtn = new System.Windows.Forms.Button();
            this.ticketsTableAdapter = new WindowsFormsApp1.EMSSDataSetTableAdapters.TicketsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgentListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentLabel
            // 
            this.AgentLabel.AutoSize = true;
            this.AgentLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentLabel.Location = new System.Drawing.Point(24, 35);
            this.AgentLabel.Name = "AgentLabel";
            this.AgentLabel.Size = new System.Drawing.Size(112, 18);
            this.AgentLabel.TabIndex = 0;
            this.AgentLabel.Text = "Agent Dashboard";
            // 
            // ShowAgentAnalyticsBtn
            // 
            this.ShowAgentAnalyticsBtn.Location = new System.Drawing.Point(287, 33);
            this.ShowAgentAnalyticsBtn.Name = "ShowAgentAnalyticsBtn";
            this.ShowAgentAnalyticsBtn.Size = new System.Drawing.Size(89, 23);
            this.ShowAgentAnalyticsBtn.TabIndex = 1;
            this.ShowAgentAnalyticsBtn.Text = "Show Analytics";
            this.ShowAgentAnalyticsBtn.UseVisualStyleBackColor = true;
            this.ShowAgentAnalyticsBtn.Click += new System.EventHandler(this.ShowAgentAnalyticsBtn_Click);
            // 
            // AgentListDGV
            // 
            this.AgentListDGV.AllowUserToAddRows = false;
            this.AgentListDGV.AllowUserToDeleteRows = false;
            this.AgentListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgentListDGV.Location = new System.Drawing.Point(59, 88);
            this.AgentListDGV.Name = "AgentListDGV";
            this.AgentListDGV.Size = new System.Drawing.Size(482, 280);
            this.AgentListDGV.TabIndex = 2;
            this.AgentListDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AgentListDGV_RowHeaderMouseClick);
            // 
            // AgentChart
            // 
            chartArea1.Name = "ChartArea1";
            this.AgentChart.ChartAreas.Add(chartArea1);
            this.AgentChart.DataSource = this.ticketsBindingSource;
            this.AgentChart.Location = new System.Drawing.Point(0, 88);
            this.AgentChart.Name = "AgentChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.CustomProperties = "PixelPointWidth=25";
            series1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Name = "Time_Taken_To_Assign";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series2.CustomProperties = "PixelPointWidth=25";
            series2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Name = "Time_Taken_To_Activate";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series3.CustomProperties = "PixelPointWidth=25";
            series3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.Name = "Time_Taken_To_Resolve";
            this.AgentChart.Series.Add(series1);
            this.AgentChart.Series.Add(series2);
            this.AgentChart.Series.Add(series3);
            this.AgentChart.Size = new System.Drawing.Size(597, 280);
            this.AgentChart.TabIndex = 3;
            this.AgentChart.Text = "chart1";
            this.AgentChart.Click += new System.EventHandler(this.AgentChart_Click);
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.eMSSDataSet;
            // 
            // eMSSDataSet
            // 
            this.eMSSDataSet.DataSetName = "EMSSDataSet";
            this.eMSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShowTicketBtn
            // 
            this.ShowTicketBtn.Location = new System.Drawing.Point(173, 33);
            this.ShowTicketBtn.Name = "ShowTicketBtn";
            this.ShowTicketBtn.Size = new System.Drawing.Size(89, 23);
            this.ShowTicketBtn.TabIndex = 4;
            this.ShowTicketBtn.Text = "Show Tickets";
            this.ShowTicketBtn.UseVisualStyleBackColor = true;
            this.ShowTicketBtn.Click += new System.EventHandler(this.ShowTicketBtn_Click);
            // 
            // UpdateTicketBtn
            // 
            this.UpdateTicketBtn.Location = new System.Drawing.Point(399, 19);
            this.UpdateTicketBtn.Name = "UpdateTicketBtn";
            this.UpdateTicketBtn.Size = new System.Drawing.Size(89, 23);
            this.UpdateTicketBtn.TabIndex = 5;
            this.UpdateTicketBtn.Text = "Change Status";
            this.UpdateTicketBtn.UseVisualStyleBackColor = true;
            this.UpdateTicketBtn.Click += new System.EventHandler(this.UpdateTicketBtn_Click);
            // 
            // RevertStatusBtn
            // 
            this.RevertStatusBtn.Location = new System.Drawing.Point(399, 52);
            this.RevertStatusBtn.Name = "RevertStatusBtn";
            this.RevertStatusBtn.Size = new System.Drawing.Size(89, 23);
            this.RevertStatusBtn.TabIndex = 6;
            this.RevertStatusBtn.Text = "Revert Status";
            this.RevertStatusBtn.UseVisualStyleBackColor = true;
            this.RevertStatusBtn.Click += new System.EventHandler(this.RevertStatusBtn_Click);
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Time Taken to Resolve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Time Taken to Activate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Time Taken to Assign";
            // 
            // Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RevertStatusBtn);
            this.Controls.Add(this.UpdateTicketBtn);
            this.Controls.Add(this.ShowTicketBtn);
            this.Controls.Add(this.ShowAgentAnalyticsBtn);
            this.Controls.Add(this.AgentLabel);
            this.Controls.Add(this.AgentChart);
            this.Controls.Add(this.AgentListDGV);
            this.Name = "Agent";
            this.Size = new System.Drawing.Size(600, 420);
            this.Load += new System.EventHandler(this.Agent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgentListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgentLabel;
        private System.Windows.Forms.Button ShowAgentAnalyticsBtn;
        private System.Windows.Forms.DataGridView AgentListDGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart AgentChart;
        private System.Windows.Forms.Button ShowTicketBtn;
        private System.Windows.Forms.Button UpdateTicketBtn;
        private System.Windows.Forms.Button RevertStatusBtn;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private EMSSDataSet eMSSDataSet;
        private EMSSDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
