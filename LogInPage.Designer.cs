namespace WindowsFormsApp1
{
    partial class LogInPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdBoxLogin = new System.Windows.Forms.TextBox();
            this.PasswordBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // IdBoxLogin
            // 
            this.IdBoxLogin.Location = new System.Drawing.Point(276, 73);
            this.IdBoxLogin.Name = "IdBoxLogin";
            this.IdBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.IdBoxLogin.TabIndex = 1;
            // 
            // PasswordBoxLogin
            // 
            this.PasswordBoxLogin.Location = new System.Drawing.Point(276, 118);
            this.PasswordBoxLogin.Name = "PasswordBoxLogin";
            this.PasswordBoxLogin.PasswordChar = '*';
            this.PasswordBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.PasswordBoxLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(256, 213);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Signin";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "LogInPage";
            this.Size = new System.Drawing.Size(600, 420);
            this.Load += new System.EventHandler(this.LogInPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdBoxLogin;
        private System.Windows.Forms.TextBox PasswordBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
    }
}
