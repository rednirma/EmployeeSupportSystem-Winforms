namespace WindowsFormsApp1
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.UserListDGV = new System.Windows.Forms.DataGridView();
            this.AllTicketsDGV = new System.Windows.Forms.DataGridView();
            this.AdminChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AdminHeading = new System.Windows.Forms.Label();
            this.ViewAnalyticsBtn = new System.Windows.Forms.Button();
            this.ViewTicketsBtn = new System.Windows.Forms.Button();
            this.ViewUsersBtn = new System.Windows.Forms.Button();
            this.ChangeUserRole = new System.Windows.Forms.Button();
            this.AssignTicketBtn = new System.Windows.Forms.Button();
            this.RevertUserRoleBtn = new System.Windows.Forms.Button();
            this.AgentSelectCBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSSDataSet = new WindowsFormsApp1.EMSSDataSet();
            this.eMSSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApp1.EMSSDataSetTableAdapters.UsersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTicketsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserListDGV
            // 
            this.UserListDGV.AllowUserToAddRows = false;
            this.UserListDGV.AllowUserToDeleteRows = false;
            this.UserListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListDGV.Location = new System.Drawing.Point(0, 88);
            this.UserListDGV.Name = "UserListDGV";
            this.UserListDGV.Size = new System.Drawing.Size(597, 280);
            this.UserListDGV.TabIndex = 0;
            this.UserListDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserListDGV_RowHeaderMouseClick);
            // 
            // AllTicketsDGV
            // 
            this.AllTicketsDGV.AllowUserToAddRows = false;
            this.AllTicketsDGV.AllowUserToDeleteRows = false;
            this.AllTicketsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTicketsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.AllTicketsDGV.Location = new System.Drawing.Point(0, 88);
            this.AllTicketsDGV.Name = "AllTicketsDGV";
            this.AllTicketsDGV.Size = new System.Drawing.Size(597, 280);
            this.AllTicketsDGV.TabIndex = 1;
            this.AllTicketsDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllTicketsDGV_RowHeaderMouseClick);
            // 
            // AdminChart
            // 
            chartArea3.Name = "ChartArea1";
            this.AdminChart.ChartAreas.Add(chartArea3);
            this.AdminChart.Location = new System.Drawing.Point(0, 88);
            this.AdminChart.Name = "AdminChart";
            series7.BorderWidth = 0;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series7.CustomProperties = "PixelPointWidth=25";
            series7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.IsValueShownAsLabel = true;
            series7.LegendText = "Time Taken To Assign";
            series7.LegendToolTip = "Time Taken to Assign ";
            series7.Name = "Time_Taken_To_Assign";
            series7.ToolTip = "Time Taken to Assign";
            series8.BorderWidth = 0;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series8.CustomProperties = "PixelPointWidth=25";
            series8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.IsValueShownAsLabel = true;
            series8.LegendText = "Time Taken To Activate";
            series8.LegendToolTip = "Time Taken to Activate";
            series8.Name = "Time_Taken_To_Activate";
            series8.ToolTip = "Time Taken to Activate";
            series9.BorderWidth = 0;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series9.CustomProperties = "PixelPointWidth=25";
            series9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.IsValueShownAsLabel = true;
            series9.LegendToolTip = "Time Taken to Resolve ";
            series9.Name = "Time_Taken_To_Resolve";
            series9.ToolTip = "Time Taken to Resolve";
            this.AdminChart.Series.Add(series7);
            this.AdminChart.Series.Add(series8);
            this.AdminChart.Series.Add(series9);
            this.AdminChart.Size = new System.Drawing.Size(597, 280);
            this.AdminChart.TabIndex = 2;
            this.AdminChart.Text = "chart1";
            // 
            // AdminHeading
            // 
            this.AdminHeading.AutoSize = true;
            this.AdminHeading.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHeading.Location = new System.Drawing.Point(24, 35);
            this.AdminHeading.Name = "AdminHeading";
            this.AdminHeading.Size = new System.Drawing.Size(116, 18);
            this.AdminHeading.TabIndex = 3;
            this.AdminHeading.Text = "Admin Dashboard";
            // 
            // ViewAnalyticsBtn
            // 
            this.ViewAnalyticsBtn.Location = new System.Drawing.Point(246, 16);
            this.ViewAnalyticsBtn.Name = "ViewAnalyticsBtn";
            this.ViewAnalyticsBtn.Size = new System.Drawing.Size(94, 25);
            this.ViewAnalyticsBtn.TabIndex = 4;
            this.ViewAnalyticsBtn.Text = "View Analytics";
            this.ViewAnalyticsBtn.UseVisualStyleBackColor = true;
            this.ViewAnalyticsBtn.Click += new System.EventHandler(this.ViewAnalyticsBtn_Click);
            // 
            // ViewTicketsBtn
            // 
            this.ViewTicketsBtn.Location = new System.Drawing.Point(146, 16);
            this.ViewTicketsBtn.Name = "ViewTicketsBtn";
            this.ViewTicketsBtn.Size = new System.Drawing.Size(94, 25);
            this.ViewTicketsBtn.TabIndex = 5;
            this.ViewTicketsBtn.Text = "View Tickets";
            this.ViewTicketsBtn.UseVisualStyleBackColor = true;
            this.ViewTicketsBtn.Click += new System.EventHandler(this.ViewTicketsBtn_Click);
            // 
            // ViewUsersBtn
            // 
            this.ViewUsersBtn.Location = new System.Drawing.Point(146, 47);
            this.ViewUsersBtn.Name = "ViewUsersBtn";
            this.ViewUsersBtn.Size = new System.Drawing.Size(94, 25);
            this.ViewUsersBtn.TabIndex = 6;
            this.ViewUsersBtn.Text = "View Users";
            this.ViewUsersBtn.UseVisualStyleBackColor = true;
            this.ViewUsersBtn.Click += new System.EventHandler(this.ViewUsersBtn_Click);
            // 
            // ChangeUserRole
            // 
            this.ChangeUserRole.Location = new System.Drawing.Point(246, 47);
            this.ChangeUserRole.Name = "ChangeUserRole";
            this.ChangeUserRole.Size = new System.Drawing.Size(103, 25);
            this.ChangeUserRole.TabIndex = 7;
            this.ChangeUserRole.Text = "Change User Role";
            this.ChangeUserRole.UseVisualStyleBackColor = true;
            this.ChangeUserRole.Click += new System.EventHandler(this.ChangeUserRole_Click);
            // 
            // AssignTicketBtn
            // 
            this.AssignTicketBtn.Location = new System.Drawing.Point(355, 47);
            this.AssignTicketBtn.Name = "AssignTicketBtn";
            this.AssignTicketBtn.Size = new System.Drawing.Size(94, 25);
            this.AssignTicketBtn.TabIndex = 8;
            this.AssignTicketBtn.Text = "assign ticket";
            this.AssignTicketBtn.UseVisualStyleBackColor = true;
            this.AssignTicketBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RevertUserRoleBtn
            // 
            this.RevertUserRoleBtn.Location = new System.Drawing.Point(346, 18);
            this.RevertUserRoleBtn.Name = "RevertUserRoleBtn";
            this.RevertUserRoleBtn.Size = new System.Drawing.Size(103, 25);
            this.RevertUserRoleBtn.TabIndex = 9;
            this.RevertUserRoleBtn.Text = "Revert User Role";
            this.RevertUserRoleBtn.UseVisualStyleBackColor = true;
            this.RevertUserRoleBtn.Click += new System.EventHandler(this.RevertUserRoleBtn_Click);
            // 
            // AgentSelectCBox
            // 
            this.AgentSelectCBox.FormattingEnabled = true;
            this.AgentSelectCBox.Location = new System.Drawing.Point(458, 49);
            this.AgentSelectCBox.Name = "AgentSelectCBox";
            this.AgentSelectCBox.Size = new System.Drawing.Size(85, 21);
            this.AgentSelectCBox.TabIndex = 10;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.eMSSDataSet;
            // 
            // eMSSDataSet
            // 
            this.eMSSDataSet.DataSetName = "EMSSDataSet";
            this.eMSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMSSDataSetBindingSource
            // 
            this.eMSSDataSetBindingSource.DataSource = this.eMSSDataSet;
            this.eMSSDataSetBindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time Taken to Assign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Time Taken to Activate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Time Taken to Resolve";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgentSelectCBox);
            this.Controls.Add(this.RevertUserRoleBtn);
            this.Controls.Add(this.AssignTicketBtn);
            this.Controls.Add(this.ChangeUserRole);
            this.Controls.Add(this.ViewUsersBtn);
            this.Controls.Add(this.ViewTicketsBtn);
            this.Controls.Add(this.ViewAnalyticsBtn);
            this.Controls.Add(this.AdminHeading);
            this.Controls.Add(this.AdminChart);
            this.Controls.Add(this.AllTicketsDGV);
            this.Controls.Add(this.UserListDGV);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(600, 420);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllTicketsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserListDGV;
        private System.Windows.Forms.DataGridView AllTicketsDGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart AdminChart;
        private System.Windows.Forms.Label AdminHeading;
        private System.Windows.Forms.Button ViewAnalyticsBtn;
        private System.Windows.Forms.Button ViewTicketsBtn;
        private System.Windows.Forms.Button ViewUsersBtn;
        private System.Windows.Forms.Button ChangeUserRole;
        private System.Windows.Forms.Button AssignTicketBtn;
        private System.Windows.Forms.Button RevertUserRoleBtn;
        private System.Windows.Forms.BindingSource eMSSDataSetBindingSource;
        private EMSSDataSet eMSSDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private EMSSDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox AgentSelectCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
