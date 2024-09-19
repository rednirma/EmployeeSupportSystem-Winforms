using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogInPage : UserControl
    {
        UserCommonData UCD = new UserCommonData();
        public static string user = "";
        public static string pass = "";
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UCD.Id = IdBoxLogin.Text;
            UCD.Password = PasswordBoxLogin.Text;
            user= UCD.Id ;
            pass= UCD.Password ;
            bool IsSuccess = UCD.LoginStatus(UCD.Password, UCD.Id );

            if (IsSuccess)
            {
                MessageBox.Show("you are logged in ");
               
                UCD.UserRole= UCD.CheckUserRole(UCD.Id,UCD.Password);
                if (UCD.UserRole==0)
                {
                    this.Hide();
                    MessageBox.Show("signed in as admin");
                }
                else if (UCD.UserRole==1)
                {
                    this.Hide();
                    MessageBox.Show("signed in as Agent");
                }
                else if (UCD.UserRole==2)
                {
                    this.Hide();
                    MessageBox.Show("signed in as Employee");
                }
                else 
                {
                    MessageBox.Show("ERROR : CANNOT SIGN YOU IN");
                }
                
            }
            else
            {
                MessageBox.Show("you are NOT logged in");

            }
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }
    }
}
