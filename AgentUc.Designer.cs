namespace EMSStc
{
    partial class AgentUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentUc));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AgentTabControl = new System.Windows.Forms.TabControl();
            this.AgentTicketsTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdateTicketLabel = new System.Windows.Forms.Label();
            this.RevertTicketLabel = new System.Windows.Forms.Label();
            this.RevertTicketPic = new System.Windows.Forms.PictureBox();
            this.UpdateTicketPic = new System.Windows.Forms.PictureBox();
            this.AgentTicketsDGV = new System.Windows.Forms.DataGridView();
            this.AgentTicketPageDiscLabel = new System.Windows.Forms.Label();
            this.AgentTicketsPageLabel = new System.Windows.Forms.Label();
            this.AgentAnalyticsTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.AgentAnalysisPageDisc = new System.Windows.Forms.Label();
            this.AgentAnalyticsPageLabel = new System.Windows.Forms.Label();
            this.AgentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AgentTabControl.SuspendLayout();
            this.AgentTicketsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevertTicketPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTicketPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentTicketsDGV)).BeginInit();
            this.AgentAnalyticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgentChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentTabControl
            // 
            this.AgentTabControl.Controls.Add(this.AgentTicketsTab);
            this.AgentTabControl.Controls.Add(this.AgentAnalyticsTab);
            this.AgentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgentTabControl.Location = new System.Drawing.Point(0, 0);
            this.AgentTabControl.Name = "AgentTabControl";
            this.AgentTabControl.SelectedIndex = 0;
            this.AgentTabControl.Size = new System.Drawing.Size(816, 489);
            this.AgentTabControl.TabIndex = 2;
            // 
            // AgentTicketsTab
            // 
            this.AgentTicketsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AgentTicketsTab.Controls.Add(this.button2);
            this.AgentTicketsTab.Controls.Add(this.UpdateTicketLabel);
            this.AgentTicketsTab.Controls.Add(this.RevertTicketLabel);
            this.AgentTicketsTab.Controls.Add(this.RevertTicketPic);
            this.AgentTicketsTab.Controls.Add(this.UpdateTicketPic);
            this.AgentTicketsTab.Controls.Add(this.AgentTicketsDGV);
            this.AgentTicketsTab.Controls.Add(this.AgentTicketPageDiscLabel);
            this.AgentTicketsTab.Controls.Add(this.AgentTicketsPageLabel);
            this.AgentTicketsTab.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentTicketsTab.Location = new System.Drawing.Point(4, 22);
            this.AgentTicketsTab.Name = "AgentTicketsTab";
            this.AgentTicketsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AgentTicketsTab.Size = new System.Drawing.Size(808, 463);
            this.AgentTicketsTab.TabIndex = 0;
            this.AgentTicketsTab.Text = "Users";
            this.AgentTicketsTab.Click += new System.EventHandler(this.AgentTicketsTab_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UpdateTicketLabel
            // 
            this.UpdateTicketLabel.AutoSize = true;
            this.UpdateTicketLabel.Location = new System.Drawing.Point(716, 116);
            this.UpdateTicketLabel.Name = "UpdateTicketLabel";
            this.UpdateTicketLabel.Size = new System.Drawing.Size(52, 18);
            this.UpdateTicketLabel.TabIndex = 6;
            this.UpdateTicketLabel.Text = "Update";
            // 
            // RevertTicketLabel
            // 
            this.RevertTicketLabel.AutoSize = true;
            this.RevertTicketLabel.Location = new System.Drawing.Point(618, 115);
            this.RevertTicketLabel.Name = "RevertTicketLabel";
            this.RevertTicketLabel.Size = new System.Drawing.Size(48, 18);
            this.RevertTicketLabel.TabIndex = 5;
            this.RevertTicketLabel.Text = "Revert";
            // 
            // RevertTicketPic
            // 
            this.RevertTicketPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RevertTicketPic.Image = ((System.Drawing.Image)(resources.GetObject("RevertTicketPic.Image")));
            this.RevertTicketPic.Location = new System.Drawing.Point(614, 50);
            this.RevertTicketPic.Name = "RevertTicketPic";
            this.RevertTicketPic.Size = new System.Drawing.Size(54, 54);
            this.RevertTicketPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RevertTicketPic.TabIndex = 4;
            this.RevertTicketPic.TabStop = false;
            // 
            // UpdateTicketPic
            // 
            this.UpdateTicketPic.Image = ((System.Drawing.Image)(resources.GetObject("UpdateTicketPic.Image")));
            this.UpdateTicketPic.Location = new System.Drawing.Point(713, 50);
            this.UpdateTicketPic.Name = "UpdateTicketPic";
            this.UpdateTicketPic.Size = new System.Drawing.Size(54, 54);
            this.UpdateTicketPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateTicketPic.TabIndex = 3;
            this.UpdateTicketPic.TabStop = false;
            // 
            // AgentTicketsDGV
            // 
            this.AgentTicketsDGV.AllowUserToAddRows = false;
            this.AgentTicketsDGV.AllowUserToDeleteRows = false;
            this.AgentTicketsDGV.AllowUserToResizeColumns = false;
            this.AgentTicketsDGV.AllowUserToResizeRows = false;
            this.AgentTicketsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgentTicketsDGV.Location = new System.Drawing.Point(27, 145);
            this.AgentTicketsDGV.Name = "AgentTicketsDGV";
            this.AgentTicketsDGV.Size = new System.Drawing.Size(740, 250);
            this.AgentTicketsDGV.TabIndex = 2;
            // 
            // AgentTicketPageDiscLabel
            // 
            this.AgentTicketPageDiscLabel.AutoSize = true;
            this.AgentTicketPageDiscLabel.Location = new System.Drawing.Point(24, 67);
            this.AgentTicketPageDiscLabel.Name = "AgentTicketPageDiscLabel";
            this.AgentTicketPageDiscLabel.Size = new System.Drawing.Size(238, 54);
            this.AgentTicketPageDiscLabel.TabIndex = 1;
            this.AgentTicketPageDiscLabel.Text = "View all assigned Tickets !\r\nSelect one and and Update its status!\r\nor Revert it " +
    "back.\r\n";
            // 
            // AgentTicketsPageLabel
            // 
            this.AgentTicketsPageLabel.AutoSize = true;
            this.AgentTicketsPageLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentTicketsPageLabel.Location = new System.Drawing.Point(23, 26);
            this.AgentTicketsPageLabel.Name = "AgentTicketsPageLabel";
            this.AgentTicketsPageLabel.Size = new System.Drawing.Size(160, 24);
            this.AgentTicketsPageLabel.TabIndex = 0;
            this.AgentTicketsPageLabel.Text = "Agent Dashboard";
            // 
            // AgentAnalyticsTab
            // 
            this.AgentAnalyticsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AgentAnalyticsTab.Controls.Add(this.button1);
            this.AgentAnalyticsTab.Controls.Add(this.AgentAnalysisPageDisc);
            this.AgentAnalyticsTab.Controls.Add(this.AgentAnalyticsPageLabel);
            this.AgentAnalyticsTab.Controls.Add(this.AgentChart);
            this.AgentAnalyticsTab.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentAnalyticsTab.Location = new System.Drawing.Point(4, 22);
            this.AgentAnalyticsTab.Name = "AgentAnalyticsTab";
            this.AgentAnalyticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AgentAnalyticsTab.Size = new System.Drawing.Size(792, 424);
            this.AgentAnalyticsTab.TabIndex = 2;
            this.AgentAnalyticsTab.Text = "Analytics";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AgentAnalysisPageDisc
            // 
            this.AgentAnalysisPageDisc.AutoSize = true;
            this.AgentAnalysisPageDisc.Location = new System.Drawing.Point(25, 69);
            this.AgentAnalysisPageDisc.Name = "AgentAnalysisPageDisc";
            this.AgentAnalysisPageDisc.Size = new System.Drawing.Size(174, 18);
            this.AgentAnalysisPageDisc.TabIndex = 6;
            this.AgentAnalysisPageDisc.Text = "View Your Ticket Analysis !\r\n";
            // 
            // AgentAnalyticsPageLabel
            // 
            this.AgentAnalyticsPageLabel.AutoSize = true;
            this.AgentAnalyticsPageLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentAnalyticsPageLabel.Location = new System.Drawing.Point(24, 28);
            this.AgentAnalyticsPageLabel.Name = "AgentAnalyticsPageLabel";
            this.AgentAnalyticsPageLabel.Size = new System.Drawing.Size(160, 24);
            this.AgentAnalyticsPageLabel.TabIndex = 5;
            this.AgentAnalyticsPageLabel.Text = "Agent Dashboard";
            // 
            // AgentChart
            // 
            chartArea2.Name = "ChartArea1";
            this.AgentChart.ChartAreas.Add(chartArea2);
            this.AgentChart.Location = new System.Drawing.Point(28, 108);
            this.AgentChart.Name = "AgentChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.CustomProperties = "PixelPointWidth=25";
            series4.IsValueShownAsLabel = true;
            series4.Name = "Time_Taken_To_Assign";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.CustomProperties = "PixelPointWidth=25";
            series5.IsValueShownAsLabel = true;
            series5.Name = "Time_Taken_To_Activate";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.CustomProperties = "PixelPointWidth=25";
            series6.IsValueShownAsLabel = true;
            series6.Name = "Time_Taken_To_Resolve";
            this.AgentChart.Series.Add(series4);
            this.AgentChart.Series.Add(series5);
            this.AgentChart.Series.Add(series6);
            this.AgentChart.Size = new System.Drawing.Size(740, 289);
            this.AgentChart.TabIndex = 10;
            this.AgentChart.Text = "chart1";
            // 
            // AgentUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AgentTabControl);
            this.Name = "AgentUc";
            this.Size = new System.Drawing.Size(816, 489);
            this.AgentTabControl.ResumeLayout(false);
            this.AgentTicketsTab.ResumeLayout(false);
            this.AgentTicketsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevertTicketPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTicketPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentTicketsDGV)).EndInit();
            this.AgentAnalyticsTab.ResumeLayout(false);
            this.AgentAnalyticsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgentChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AgentTabControl;
        private System.Windows.Forms.TabPage AgentTicketsTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label UpdateTicketLabel;
        private System.Windows.Forms.Label RevertTicketLabel;
        private System.Windows.Forms.PictureBox RevertTicketPic;
        private System.Windows.Forms.PictureBox UpdateTicketPic;
        private System.Windows.Forms.DataGridView AgentTicketsDGV;
        private System.Windows.Forms.Label AgentTicketPageDiscLabel;
        private System.Windows.Forms.Label AgentTicketsPageLabel;
        private System.Windows.Forms.TabPage AgentAnalyticsTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AgentAnalysisPageDisc;
        private System.Windows.Forms.Label AgentAnalyticsPageLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart AgentChart;
    }
}
