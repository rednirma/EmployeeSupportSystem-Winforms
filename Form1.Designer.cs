namespace WindowsFormsApp1
{
    partial class Form1
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordBoxLogin = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.IdBoxLogin = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.agent1 = new WindowsFormsApp1.Agent();
            this.emp1 = new WindowsFormsApp1.Emp();
            this.admin1 = new WindowsFormsApp1.Admin();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(354, 253);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Signin";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordBoxLogin
            // 
            this.PasswordBoxLogin.Location = new System.Drawing.Point(374, 158);
            this.PasswordBoxLogin.Name = "PasswordBoxLogin";
            this.PasswordBoxLogin.PasswordChar = '*';
            this.PasswordBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.PasswordBoxLogin.TabIndex = 8;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(293, 158);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(70, 18);
            this.PassLabel.TabIndex = 7;
            this.PassLabel.Text = "Password:";
            // 
            // IdBoxLogin
            // 
            this.IdBoxLogin.Location = new System.Drawing.Point(374, 113);
            this.IdBoxLogin.Name = "IdBoxLogin";
            this.IdBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.IdBoxLogin.TabIndex = 6;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(312, 116);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(29, 18);
            this.IdLabel.TabIndex = 5;
            this.IdLabel.Text = "Id :";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(713, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 10;
            this.LogoutBtn.Text = "logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // agent1
            // 
            this.agent1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.agent1.Location = new System.Drawing.Point(102, 12);
            this.agent1.Name = "agent1";
            this.agent1.Size = new System.Drawing.Size(600, 420);
            this.agent1.TabIndex = 3;
            this.agent1.Load += new System.EventHandler(this.agent1_Load);
            // 
            // emp1
            // 
            this.emp1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.emp1.Location = new System.Drawing.Point(102, 12);
            this.emp1.Name = "emp1";
            this.emp1.Size = new System.Drawing.Size(600, 420);
            this.emp1.TabIndex = 0;
            // 
            // admin1
            // 
            this.admin1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.admin1.Location = new System.Drawing.Point(102, 12);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(600, 420);
            this.admin1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordBoxLogin);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.IdBoxLogin);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.agent1);
            this.Controls.Add(this.emp1);
            this.Controls.Add(this.admin1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emp emp1;
        private Admin admin1;
        private Agent agent1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswordBoxLogin;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox IdBoxLogin;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button LogoutBtn;
    }
}

