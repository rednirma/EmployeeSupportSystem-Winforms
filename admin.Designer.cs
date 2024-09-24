namespace EMSStc
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.AdminUsersTab = new System.Windows.Forms.TabPage();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.UpdateUserLabel = new System.Windows.Forms.Label();
            this.RevertUserLabel = new System.Windows.Forms.Label();
            this.RevertUserPic = new System.Windows.Forms.PictureBox();
            this.UpdateUserPic = new System.Windows.Forms.PictureBox();
            this.AdminUserDGV = new System.Windows.Forms.DataGridView();
            this.AdminUserPageDiscLabel = new System.Windows.Forms.Label();
            this.AdminUserPageLabel = new System.Windows.Forms.Label();
            this.AdminTicketsTab = new System.Windows.Forms.TabPage();
            this.AllTicketsDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectAgentLabel = new System.Windows.Forms.Label();
            this.SelectAgentCB = new System.Windows.Forms.ComboBox();
            this.AssignTicPic = new System.Windows.Forms.PictureBox();
            this.AdminTicketsPageDiscLabel = new System.Windows.Forms.Label();
            this.AdminTicketsPageLabel = new System.Windows.Forms.Label();
            this.AdminAnalyticsTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AdminTabControl.SuspendLayout();
            this.AdminUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevertUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminUserDGV)).BeginInit();
            this.AdminTicketsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllTicketsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignTicPic)).BeginInit();
            this.AdminAnalyticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.AdminUsersTab);
            this.AdminTabControl.Controls.Add(this.AdminTicketsTab);
            this.AdminTabControl.Controls.Add(this.AdminAnalyticsTab);
            this.AdminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTabControl.Location = new System.Drawing.Point(0, 0);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(800, 450);
            this.AdminTabControl.TabIndex = 0;
            this.AdminTabControl.SelectedIndexChanged += new System.EventHandler(this.AdminTabControl_SelectedIndexChanged);
            // 
            // AdminUsersTab
            // 
            this.AdminUsersTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AdminUsersTab.Controls.Add(this.LogOutbtn);
            this.AdminUsersTab.Controls.Add(this.UpdateUserLabel);
            this.AdminUsersTab.Controls.Add(this.RevertUserLabel);
            this.AdminUsersTab.Controls.Add(this.RevertUserPic);
            this.AdminUsersTab.Controls.Add(this.UpdateUserPic);
            this.AdminUsersTab.Controls.Add(this.AdminUserDGV);
            this.AdminUsersTab.Controls.Add(this.AdminUserPageDiscLabel);
            this.AdminUsersTab.Controls.Add(this.AdminUserPageLabel);
            this.AdminUsersTab.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUsersTab.Location = new System.Drawing.Point(4, 22);
            this.AdminUsersTab.Name = "AdminUsersTab";
            this.AdminUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdminUsersTab.Size = new System.Drawing.Size(792, 424);
            this.AdminUsersTab.TabIndex = 0;
            this.AdminUsersTab.Text = "Users";
            this.AdminUsersTab.Click += new System.EventHandler(this.AdminUsersTab_Click);
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(711, 6);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(75, 35);
            this.LogOutbtn.TabIndex = 7;
            this.LogOutbtn.Text = "LogOut";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // UpdateUserLabel
            // 
            this.UpdateUserLabel.AutoSize = true;
            this.UpdateUserLabel.Location = new System.Drawing.Point(716, 113);
            this.UpdateUserLabel.Name = "UpdateUserLabel";
            this.UpdateUserLabel.Size = new System.Drawing.Size(52, 18);
            this.UpdateUserLabel.TabIndex = 6;
            this.UpdateUserLabel.Text = "Update";
            // 
            // RevertUserLabel
            // 
            this.RevertUserLabel.AutoSize = true;
            this.RevertUserLabel.Location = new System.Drawing.Point(618, 112);
            this.RevertUserLabel.Name = "RevertUserLabel";
            this.RevertUserLabel.Size = new System.Drawing.Size(48, 18);
            this.RevertUserLabel.TabIndex = 5;
            this.RevertUserLabel.Text = "Revert";
            // 
            // RevertUserPic
            // 
            this.RevertUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RevertUserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevertUserPic.Image = ((System.Drawing.Image)(resources.GetObject("RevertUserPic.Image")));
            this.RevertUserPic.Location = new System.Drawing.Point(614, 47);
            this.RevertUserPic.Name = "RevertUserPic";
            this.RevertUserPic.Size = new System.Drawing.Size(54, 54);
            this.RevertUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RevertUserPic.TabIndex = 4;
            this.RevertUserPic.TabStop = false;
            this.RevertUserPic.Click += new System.EventHandler(this.RevertUserPic_Click);
            // 
            // UpdateUserPic
            // 
            this.UpdateUserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateUserPic.Image = ((System.Drawing.Image)(resources.GetObject("UpdateUserPic.Image")));
            this.UpdateUserPic.Location = new System.Drawing.Point(713, 47);
            this.UpdateUserPic.Name = "UpdateUserPic";
            this.UpdateUserPic.Size = new System.Drawing.Size(54, 54);
            this.UpdateUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateUserPic.TabIndex = 3;
            this.UpdateUserPic.TabStop = false;
            this.UpdateUserPic.Click += new System.EventHandler(this.UpdateUserPic_Click);
            // 
            // AdminUserDGV
            // 
            this.AdminUserDGV.AllowUserToAddRows = false;
            this.AdminUserDGV.AllowUserToDeleteRows = false;
            this.AdminUserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminUserDGV.Location = new System.Drawing.Point(27, 145);
            this.AdminUserDGV.Name = "AdminUserDGV";
            this.AdminUserDGV.Size = new System.Drawing.Size(740, 250);
            this.AdminUserDGV.TabIndex = 2;
            this.AdminUserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllTicketsDGV_CellContentClick);
            this.AdminUserDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AdminUserDGV_RowHeaderMouseClick);
            // 
            // AdminUserPageDiscLabel
            // 
            this.AdminUserPageDiscLabel.AutoSize = true;
            this.AdminUserPageDiscLabel.Location = new System.Drawing.Point(24, 67);
            this.AdminUserPageDiscLabel.Name = "AdminUserPageDiscLabel";
            this.AdminUserPageDiscLabel.Size = new System.Drawing.Size(270, 54);
            this.AdminUserPageDiscLabel.TabIndex = 1;
            this.AdminUserPageDiscLabel.Text = "View all users !\r\nSelect one and Promote them to an Agent !\r\nor Revert back to an" +
    " employee.\r\n";
            this.AdminUserPageDiscLabel.Click += new System.EventHandler(this.AdminUserPageDiscLabel_Click);
            // 
            // AdminUserPageLabel
            // 
            this.AdminUserPageLabel.AutoSize = true;
            this.AdminUserPageLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUserPageLabel.Location = new System.Drawing.Point(23, 26);
            this.AdminUserPageLabel.Name = "AdminUserPageLabel";
            this.AdminUserPageLabel.Size = new System.Drawing.Size(164, 24);
            this.AdminUserPageLabel.TabIndex = 0;
            this.AdminUserPageLabel.Text = "Admin Dashboard";
            this.AdminUserPageLabel.Click += new System.EventHandler(this.AdminUserPageLabel_Click);
            // 
            // AdminTicketsTab
            // 
            this.AdminTicketsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AdminTicketsTab.Controls.Add(this.AllTicketsDGV);
            this.AdminTicketsTab.Controls.Add(this.button1);
            this.AdminTicketsTab.Controls.Add(this.SelectAgentLabel);
            this.AdminTicketsTab.Controls.Add(this.SelectAgentCB);
            this.AdminTicketsTab.Controls.Add(this.AssignTicPic);
            this.AdminTicketsTab.Controls.Add(this.AdminTicketsPageDiscLabel);
            this.AdminTicketsTab.Controls.Add(this.AdminTicketsPageLabel);
            this.AdminTicketsTab.Location = new System.Drawing.Point(4, 22);
            this.AdminTicketsTab.Name = "AdminTicketsTab";
            this.AdminTicketsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdminTicketsTab.Size = new System.Drawing.Size(792, 424);
            this.AdminTicketsTab.TabIndex = 1;
            this.AdminTicketsTab.Text = "Tickets";
            this.AdminTicketsTab.Click += new System.EventHandler(this.AdminTicketsTab_Click);
            // 
            // AllTicketsDGV
            // 
            this.AllTicketsDGV.AllowUserToAddRows = false;
            this.AllTicketsDGV.AllowUserToDeleteRows = false;
            this.AllTicketsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTicketsDGV.Location = new System.Drawing.Point(27, 145);
            this.AllTicketsDGV.Name = "AllTicketsDGV";
            this.AllTicketsDGV.Size = new System.Drawing.Size(740, 250);
            this.AllTicketsDGV.TabIndex = 13;
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
            // SelectAgentLabel
            // 
            this.SelectAgentLabel.AutoSize = true;
            this.SelectAgentLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAgentLabel.Location = new System.Drawing.Point(644, 100);
            this.SelectAgentLabel.Name = "SelectAgentLabel";
            this.SelectAgentLabel.Size = new System.Drawing.Size(125, 18);
            this.SelectAgentLabel.TabIndex = 11;
            this.SelectAgentLabel.Text = "Select Your Agent :";
            // 
            // SelectAgentCB
            // 
            this.SelectAgentCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SelectAgentCB.FormattingEnabled = true;
            this.SelectAgentCB.Location = new System.Drawing.Point(647, 120);
            this.SelectAgentCB.Name = "SelectAgentCB";
            this.SelectAgentCB.Size = new System.Drawing.Size(121, 21);
            this.SelectAgentCB.TabIndex = 10;
            // 
            // AssignTicPic
            // 
            this.AssignTicPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignTicPic.Image = ((System.Drawing.Image)(resources.GetObject("AssignTicPic.Image")));
            this.AssignTicPic.Location = new System.Drawing.Point(714, 46);
            this.AssignTicPic.Name = "AssignTicPic";
            this.AssignTicPic.Size = new System.Drawing.Size(54, 54);
            this.AssignTicPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AssignTicPic.TabIndex = 9;
            this.AssignTicPic.TabStop = false;
            this.AssignTicPic.Click += new System.EventHandler(this.AssignTicPic_Click);
            // 
            // AdminTicketsPageDiscLabel
            // 
            this.AdminTicketsPageDiscLabel.AutoSize = true;
            this.AdminTicketsPageDiscLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTicketsPageDiscLabel.Location = new System.Drawing.Point(25, 69);
            this.AdminTicketsPageDiscLabel.Name = "AdminTicketsPageDiscLabel";
            this.AdminTicketsPageDiscLabel.Size = new System.Drawing.Size(345, 54);
            this.AdminTicketsPageDiscLabel.TabIndex = 6;
            this.AdminTicketsPageDiscLabel.Text = "View all Tickets !\r\nSelect one and Assign them to an Agent !\r\nSelect your Agent f" +
    "rom the combo box below the Icon !\r\n";
            // 
            // AdminTicketsPageLabel
            // 
            this.AdminTicketsPageLabel.AutoSize = true;
            this.AdminTicketsPageLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTicketsPageLabel.Location = new System.Drawing.Point(24, 28);
            this.AdminTicketsPageLabel.Name = "AdminTicketsPageLabel";
            this.AdminTicketsPageLabel.Size = new System.Drawing.Size(164, 24);
            this.AdminTicketsPageLabel.TabIndex = 5;
            this.AdminTicketsPageLabel.Text = "Admin Dashboard";
            // 
            // AdminAnalyticsTab
            // 
            this.AdminAnalyticsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AdminAnalyticsTab.Controls.Add(this.button2);
            this.AdminAnalyticsTab.Controls.Add(this.label3);
            this.AdminAnalyticsTab.Controls.Add(this.label4);
            this.AdminAnalyticsTab.Controls.Add(this.AdminChart);
            this.AdminAnalyticsTab.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAnalyticsTab.Location = new System.Drawing.Point(4, 22);
            this.AdminAnalyticsTab.Name = "AdminAnalyticsTab";
            this.AdminAnalyticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdminAnalyticsTab.Size = new System.Drawing.Size(792, 424);
            this.AdminAnalyticsTab.TabIndex = 2;
            this.AdminAnalyticsTab.Text = "Analytics";
            this.AdminAnalyticsTab.Click += new System.EventHandler(this.AdminAnalyticsTab_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Admin Dashboard";
            // 
            // AdminChart
            // 
            chartArea1.Name = "ChartArea1";
            this.AdminChart.ChartAreas.Add(chartArea1);
            this.AdminChart.Location = new System.Drawing.Point(28, 108);
            this.AdminChart.Name = "AdminChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.CustomProperties = "PixelPointWidth=25";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Time_Taken_To_Assign";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.CustomProperties = "PixelPointWidth=25";
            series2.IsValueShownAsLabel = true;
            series2.Name = "Time_Taken_To_Activate";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.CustomProperties = "PixelPointWidth=25";
            series3.IsValueShownAsLabel = true;
            series3.Name = "Time_Taken_To_Resolve";
            this.AdminChart.Series.Add(series1);
            this.AdminChart.Series.Add(series2);
            this.AdminChart.Series.Add(series3);
            this.AdminChart.Size = new System.Drawing.Size(740, 289);
            this.AdminChart.TabIndex = 10;
            this.AdminChart.Text = "chart1";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminTabControl);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load_1);
            this.AdminTabControl.ResumeLayout(false);
            this.AdminUsersTab.ResumeLayout(false);
            this.AdminUsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevertUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminUserDGV)).EndInit();
            this.AdminTicketsTab.ResumeLayout(false);
            this.AdminTicketsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllTicketsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignTicPic)).EndInit();
            this.AdminAnalyticsTab.ResumeLayout(false);
            this.AdminAnalyticsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage AdminTicketsTab;
        private System.Windows.Forms.TabPage AdminAnalyticsTab;
        private System.Windows.Forms.TabPage AdminUsersTab;
        private System.Windows.Forms.PictureBox UpdateUserPic;
        private System.Windows.Forms.DataGridView AdminUserDGV;
        private System.Windows.Forms.Label AdminUserPageDiscLabel;
        private System.Windows.Forms.Label AdminUserPageLabel;
        private System.Windows.Forms.PictureBox RevertUserPic;
        private System.Windows.Forms.Label SelectAgentLabel;
        private System.Windows.Forms.ComboBox SelectAgentCB;
        private System.Windows.Forms.PictureBox AssignTicPic;
        private System.Windows.Forms.Label AdminTicketsPageDiscLabel;
        private System.Windows.Forms.Label AdminTicketsPageLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart AdminChart;
        private System.Windows.Forms.Label UpdateUserLabel;
        private System.Windows.Forms.Label RevertUserLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView AllTicketsDGV;
    }
}