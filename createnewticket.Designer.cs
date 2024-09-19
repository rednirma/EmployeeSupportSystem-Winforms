namespace WindowsFormsApp1
{
    partial class create_new_ticket
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
            this.TicketSubjectTextBox = new System.Windows.Forms.TextBox();
            this.NewTicketBtn = new System.Windows.Forms.Button();
            this.TicketSubLabel = new System.Windows.Forms.Label();
            this.DiscLabel = new System.Windows.Forms.Label();
            this.DiscTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TicketSubjectTextBox
            // 
            this.TicketSubjectTextBox.Location = new System.Drawing.Point(258, 119);
            this.TicketSubjectTextBox.Name = "TicketSubjectTextBox";
            this.TicketSubjectTextBox.Size = new System.Drawing.Size(295, 20);
            this.TicketSubjectTextBox.TabIndex = 0;
            // 
            // NewTicketBtn
            // 
            this.NewTicketBtn.Location = new System.Drawing.Point(347, 294);
            this.NewTicketBtn.Name = "NewTicketBtn";
            this.NewTicketBtn.Size = new System.Drawing.Size(116, 23);
            this.NewTicketBtn.TabIndex = 1;
            this.NewTicketBtn.Text = "Create Ticket";
            this.NewTicketBtn.UseVisualStyleBackColor = true;
            this.NewTicketBtn.Click += new System.EventHandler(this.NewTicketBtn_Click);
            // 
            // TicketSubLabel
            // 
            this.TicketSubLabel.AutoSize = true;
            this.TicketSubLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketSubLabel.Location = new System.Drawing.Point(255, 103);
            this.TicketSubLabel.Name = "TicketSubLabel";
            this.TicketSubLabel.Size = new System.Drawing.Size(55, 18);
            this.TicketSubLabel.TabIndex = 2;
            this.TicketSubLabel.Text = "Subject";
            // 
            // DiscLabel
            // 
            this.DiscLabel.AutoSize = true;
            this.DiscLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscLabel.Location = new System.Drawing.Point(255, 166);
            this.DiscLabel.Name = "DiscLabel";
            this.DiscLabel.Size = new System.Drawing.Size(75, 18);
            this.DiscLabel.TabIndex = 4;
            this.DiscLabel.Text = "Discription";
            // 
            // DiscTextBox
            // 
            this.DiscTextBox.Location = new System.Drawing.Point(258, 182);
            this.DiscTextBox.Name = "DiscTextBox";
            this.DiscTextBox.Size = new System.Drawing.Size(295, 20);
            this.DiscTextBox.TabIndex = 3;
            // 
            // create_new_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiscLabel);
            this.Controls.Add(this.DiscTextBox);
            this.Controls.Add(this.TicketSubLabel);
            this.Controls.Add(this.NewTicketBtn);
            this.Controls.Add(this.TicketSubjectTextBox);
            this.Name = "create_new_ticket";
            this.Text = "create_new_ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TicketSubjectTextBox;
        private System.Windows.Forms.Button NewTicketBtn;
        private System.Windows.Forms.Label TicketSubLabel;
        private System.Windows.Forms.Label DiscLabel;
        private System.Windows.Forms.TextBox DiscTextBox;
    }
}