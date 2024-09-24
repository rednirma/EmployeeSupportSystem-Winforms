namespace EMSStc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EmpTabControl = new System.Windows.Forms.TabControl();
            this.EmpCreateTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.RevertUserLabel = new System.Windows.Forms.Label();
            this.CreateTicPic = new System.Windows.Forms.PictureBox();
            this.DiscriptionLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.DiscTextBox = new System.Windows.Forms.TextBox();
            this.TicketSubjectTextBox = new System.Windows.Forms.TextBox();
            this.EmpUserPageDiscLabel = new System.Windows.Forms.Label();
            this.EmpUserPageLabel = new System.Windows.Forms.Label();
            this.EmpTicketsTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.EmpTicketsPageDiscLabel = new System.Windows.Forms.Label();
            this.EmpTicketsPageLabel = new System.Windows.Forms.Label();
            this.EmpTicketsDGV = new System.Windows.Forms.DataGridView();
            this.EmpAnalyticsTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EmpTabControl.SuspendLayout();
            this.EmpCreateTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTicPic)).BeginInit();
            this.EmpTicketsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTicketsDGV)).BeginInit();
            this.EmpAnalyticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpChart)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpTabControl
            // 
            this.EmpTabControl.Controls.Add(this.EmpCreateTab);
            this.EmpTabControl.Controls.Add(this.EmpTicketsTab);
            this.EmpTabControl.Controls.Add(this.EmpAnalyticsTab);
            this.EmpTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpTabControl.Location = new System.Drawing.Point(0, 0);
            this.EmpTabControl.Name = "EmpTabControl";
            this.EmpTabControl.SelectedIndex = 0;
            this.EmpTabControl.Size = new System.Drawing.Size(800, 450);
            this.EmpTabControl.TabIndex = 1;
            // 
            // EmpCreateTab
            // 
            this.EmpCreateTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmpCreateTab.Controls.Add(this.button2);
            this.EmpCreateTab.Controls.Add(this.RevertUserLabel);
            this.EmpCreateTab.Controls.Add(this.CreateTicPic);
            this.EmpCreateTab.Controls.Add(this.DiscriptionLabel);
            this.EmpCreateTab.Controls.Add(this.SubjectLabel);
            this.EmpCreateTab.Controls.Add(this.DiscTextBox);
            this.EmpCreateTab.Controls.Add(this.TicketSubjectTextBox);
            this.EmpCreateTab.Controls.Add(this.EmpUserPageDiscLabel);
            this.EmpCreateTab.Controls.Add(this.EmpUserPageLabel);
            this.EmpCreateTab.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpCreateTab.Location = new System.Drawing.Point(4, 22);
            this.EmpCreateTab.Name = "EmpCreateTab";
            this.EmpCreateTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmpCreateTab.Size = new System.Drawing.Size(792, 424);
            this.EmpCreateTab.TabIndex = 0;
            this.EmpCreateTab.Text = "Create Ticket";
            this.EmpCreateTab.Click += new System.EventHandler(this.EmpCreateTab_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RevertUserLabel
            // 
            this.RevertUserLabel.AutoSize = true;
            this.RevertUserLabel.Location = new System.Drawing.Point(373, 383);
            this.RevertUserLabel.Name = "RevertUserLabel";
            this.RevertUserLabel.Size = new System.Drawing.Size(48, 18);
            this.RevertUserLabel.TabIndex = 12;
            this.RevertUserLabel.Text = "Create";
            // 
            // CreateTicPic
            // 
            this.CreateTicPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTicPic.Image = ((System.Drawing.Image)(resources.GetObject("CreateTicPic.Image")));
            this.CreateTicPic.Location = new System.Drawing.Point(366, 316);
            this.CreateTicPic.Name = "CreateTicPic";
            this.CreateTicPic.Size = new System.Drawing.Size(63, 63);
            this.CreateTicPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreateTicPic.TabIndex = 11;
            this.CreateTicPic.TabStop = false;
            this.CreateTicPic.Click += new System.EventHandler(this.CreateTicPic_Click);
            // 
            // DiscriptionLabel
            // 
            this.DiscriptionLabel.AutoSize = true;
            this.DiscriptionLabel.Location = new System.Drawing.Point(191, 246);
            this.DiscriptionLabel.Name = "DiscriptionLabel";
            this.DiscriptionLabel.Size = new System.Drawing.Size(75, 18);
            this.DiscriptionLabel.TabIndex = 10;
            this.DiscriptionLabel.Text = "Discription";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(191, 178);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(55, 18);
            this.SubjectLabel.TabIndex = 9;
            this.SubjectLabel.Text = "Subject";
            this.SubjectLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DiscTextBox
            // 
            this.DiscTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DiscTextBox.Location = new System.Drawing.Point(194, 267);
            this.DiscTextBox.Name = "DiscTextBox";
            this.DiscTextBox.Size = new System.Drawing.Size(418, 23);
            this.DiscTextBox.TabIndex = 8;
            // 
            // TicketSubjectTextBox
            // 
            this.TicketSubjectTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TicketSubjectTextBox.Location = new System.Drawing.Point(194, 199);
            this.TicketSubjectTextBox.Name = "TicketSubjectTextBox";
            this.TicketSubjectTextBox.Size = new System.Drawing.Size(418, 23);
            this.TicketSubjectTextBox.TabIndex = 7;
            // 
            // EmpUserPageDiscLabel
            // 
            this.EmpUserPageDiscLabel.AutoSize = true;
            this.EmpUserPageDiscLabel.Location = new System.Drawing.Point(24, 67);
            this.EmpUserPageDiscLabel.Name = "EmpUserPageDiscLabel";
            this.EmpUserPageDiscLabel.Size = new System.Drawing.Size(376, 54);
            this.EmpUserPageDiscLabel.TabIndex = 1;
            this.EmpUserPageDiscLabel.Text = "Create A new Ticket!\r\nAdd A Subject to explain your problem in a short one liner " +
    "!\r\nAdd A Discription to explain it in detail !\r\n";
            // 
            // EmpUserPageLabel
            // 
            this.EmpUserPageLabel.AutoSize = true;
            this.EmpUserPageLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpUserPageLabel.Location = new System.Drawing.Point(23, 26);
            this.EmpUserPageLabel.Name = "EmpUserPageLabel";
            this.EmpUserPageLabel.Size = new System.Drawing.Size(195, 24);
            this.EmpUserPageLabel.TabIndex = 0;
            this.EmpUserPageLabel.Text = "Employee Dashboard";
            // 
            // EmpTicketsTab
            // 
            this.EmpTicketsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmpTicketsTab.Controls.Add(this.button1);
            this.EmpTicketsTab.Controls.Add(this.EmpTicketsPageDiscLabel);
            this.EmpTicketsTab.Controls.Add(this.EmpTicketsPageLabel);
            this.EmpTicketsTab.Controls.Add(this.EmpTicketsDGV);
            this.EmpTicketsTab.Location = new System.Drawing.Point(4, 22);
            this.EmpTicketsTab.Name = "EmpTicketsTab";
            this.EmpTicketsTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmpTicketsTab.Size = new System.Drawing.Size(792, 424);
            this.EmpTicketsTab.TabIndex = 1;
            this.EmpTicketsTab.Text = "Ticket";
            this.EmpTicketsTab.Click += new System.EventHandler(this.EmpTicketsTab_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(711, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpTicketsPageDiscLabel
            // 
            this.EmpTicketsPageDiscLabel.AutoSize = true;
            this.EmpTicketsPageDiscLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTicketsPageDiscLabel.Location = new System.Drawing.Point(25, 69);
            this.EmpTicketsPageDiscLabel.Name = "EmpTicketsPageDiscLabel";
            this.EmpTicketsPageDiscLabel.Size = new System.Drawing.Size(175, 18);
            this.EmpTicketsPageDiscLabel.TabIndex = 6;
            this.EmpTicketsPageDiscLabel.Text = "View all your past Tickets !\r\n";
            // 
            // EmpTicketsPageLabel
            // 
            this.EmpTicketsPageLabel.AutoSize = true;
            this.EmpTicketsPageLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTicketsPageLabel.Location = new System.Drawing.Point(24, 28);
            this.EmpTicketsPageLabel.Name = "EmpTicketsPageLabel";
            this.EmpTicketsPageLabel.Size = new System.Drawing.Size(195, 24);
            this.EmpTicketsPageLabel.TabIndex = 5;
            this.EmpTicketsPageLabel.Text = "Employee Dashboard";
            // 
            // EmpTicketsDGV
            // 
            this.EmpTicketsDGV.AllowUserToAddRows = false;
            this.EmpTicketsDGV.AllowUserToDeleteRows = false;
            this.EmpTicketsDGV.AllowUserToResizeColumns = false;
            this.EmpTicketsDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpTicketsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpTicketsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpTicketsDGV.Location = new System.Drawing.Point(28, 111);
            this.EmpTicketsDGV.Name = "EmpTicketsDGV";
            this.EmpTicketsDGV.RowHeadersVisible = false;
            this.EmpTicketsDGV.Size = new System.Drawing.Size(740, 286);
            this.EmpTicketsDGV.TabIndex = 7;
            // 
            // EmpAnalyticsTab
            // 
            this.EmpAnalyticsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmpAnalyticsTab.Controls.Add(this.button3);
            this.EmpAnalyticsTab.Controls.Add(this.label3);
            this.EmpAnalyticsTab.Controls.Add(this.label4);
            this.EmpAnalyticsTab.Controls.Add(this.EmpChart);
            this.EmpAnalyticsTab.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAnalyticsTab.Location = new System.Drawing.Point(4, 22);
            this.EmpAnalyticsTab.Name = "EmpAnalyticsTab";
            this.EmpAnalyticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmpAnalyticsTab.Size = new System.Drawing.Size(792, 424);
            this.EmpAnalyticsTab.TabIndex = 2;
            this.EmpAnalyticsTab.Text = "Analytics";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(711, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "LogOut";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "View Your Ticket Analysis !\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee Dashboard";
            // 
            // EmpChart
            // 
            chartArea1.Name = "ChartArea1";
            this.EmpChart.ChartAreas.Add(chartArea1);
            this.EmpChart.Location = new System.Drawing.Point(28, 108);
            this.EmpChart.Name = "EmpChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.CustomProperties = "PixelPointWidth=25";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Name = "Time_Taken_To_Assign";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.CustomProperties = "PixelPointWidth=25";
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Name = "Time_Taken_To_Activate";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.CustomProperties = "PixelPointWidth=25";
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.Name = "Time_Taken_To_Resolve";
            this.EmpChart.Series.Add(series1);
            this.EmpChart.Series.Add(series2);
            this.EmpChart.Series.Add(series3);
            this.EmpChart.Size = new System.Drawing.Size(740, 289);
            this.EmpChart.TabIndex = 10;
            this.EmpChart.Text = "EmpChart";
            // 
            // Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmpTabControl);
            this.Name = "Emp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emp";
            this.Load += new System.EventHandler(this.Emp_Load);
            this.EmpTabControl.ResumeLayout(false);
            this.EmpCreateTab.ResumeLayout(false);
            this.EmpCreateTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTicPic)).EndInit();
            this.EmpTicketsTab.ResumeLayout(false);
            this.EmpTicketsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTicketsDGV)).EndInit();
            this.EmpAnalyticsTab.ResumeLayout(false);
            this.EmpAnalyticsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EmpTabControl;
        private System.Windows.Forms.TabPage EmpCreateTab;
        private System.Windows.Forms.Label EmpUserPageDiscLabel;
        private System.Windows.Forms.Label EmpUserPageLabel;
        private System.Windows.Forms.TabPage EmpTicketsTab;
        private System.Windows.Forms.Label EmpTicketsPageDiscLabel;
        private System.Windows.Forms.Label EmpTicketsPageLabel;
        private System.Windows.Forms.TabPage EmpAnalyticsTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpChart;
        private System.Windows.Forms.DataGridView EmpTicketsDGV;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.TextBox DiscTextBox;
        private System.Windows.Forms.TextBox TicketSubjectTextBox;
        private System.Windows.Forms.Label DiscriptionLabel;
        private System.Windows.Forms.PictureBox CreateTicPic;
        private System.Windows.Forms.Label RevertUserLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}