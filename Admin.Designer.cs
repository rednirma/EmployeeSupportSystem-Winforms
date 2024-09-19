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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.UserListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListDGV.Location = new System.Drawing.Point(59, 88);
            this.UserListDGV.Name = "UserListDGV";
            this.UserListDGV.Size = new System.Drawing.Size(480, 280);
            this.UserListDGV.TabIndex = 0;
            this.UserListDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserListDGV_RowHeaderMouseClick);
            // 
            // AllTicketsDGV
            // 
            this.AllTicketsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTicketsDGV.Location = new System.Drawing.Point(59, 88);
            this.AllTicketsDGV.Name = "AllTicketsDGV";
            this.AllTicketsDGV.Size = new System.Drawing.Size(480, 280);
            this.AllTicketsDGV.TabIndex = 1;
            this.AllTicketsDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllTicketsDGV_RowHeaderMouseClick);
            // 
            // AdminChart
            // 
            chartArea2.Name = "ChartArea1";
            this.AdminChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.AdminChart.Legends.Add(legend2);
            this.AdminChart.Location = new System.Drawing.Point(59, 88);
            this.AdminChart.Name = "AdminChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.AdminChart.Series.Add(series2);
            this.AdminChart.Size = new System.Drawing.Size(482, 280);
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
            this.AgentSelectCBox.Location = new System.Drawing.Point(456, 35);
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.AgentSelectCBox);
            this.Controls.Add(this.RevertUserRoleBtn);
            this.Controls.Add(this.AssignTicketBtn);
            this.Controls.Add(this.ChangeUserRole);
            this.Controls.Add(this.ViewUsersBtn);
            this.Controls.Add(this.ViewTicketsBtn);
            this.Controls.Add(this.ViewAnalyticsBtn);
            this.Controls.Add(this.AdminHeading);
            this.Controls.Add(this.AllTicketsDGV);
            this.Controls.Add(this.UserListDGV);
            this.Controls.Add(this.AdminChart);
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
    }
}
