using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        UserCommonData UCD = new UserCommonData();
        public static string id ;
        public static string pass ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            emp1.Hide();
            agent1.Hide();
            admin1.Hide();
            LogoutBtn.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            UCD.Id = IdBoxLogin.Text;
            UCD.Password = PasswordBoxLogin.Text;
            id = IdBoxLogin.Text;
            pass = PasswordBoxLogin.Text;
            bool IsSuccess = UCD.LoginStatus(UCD.Password, UCD.Id);

            if (IsSuccess)
            {
                PassLabel.Hide();
                IdLabel.Hide();
                LoginBtn.Hide();
                PasswordBoxLogin.Hide();
                IdBoxLogin.Hide();
                MessageBox.Show("you are logged in ");

                UCD.UserRole = UCD.CheckUserRole(UCD.Id, UCD.Password);
                if (UCD.UserRole == 0)
                {
                    //this.Hide();
                    MessageBox.Show("signed in as admin");
                    emp1.Hide();
                    agent1.Hide();
                    admin1.Show();
                    LogoutBtn.Show();

                }
                else if (UCD.UserRole == 1)
                {
                    //this.Hide();
                    MessageBox.Show("signed in as Agent");
                    emp1.Hide();
                    agent1.Show();
                    admin1.Hide();
                    LogoutBtn.Show();

                }
                else if (UCD.UserRole == 2)
                {
                   //this.Hide();
                    MessageBox.Show("signed in as Employee");
                    emp1.Show();
                    agent1.Hide();
                    admin1.Hide();
                    LogoutBtn.Show();

                }
                else
                {
                    MessageBox.Show("ERROR : CANNOT SIGN YOU IN");
                    LogoutBtn.Hide();

                }

            }
            else
            {
                PasswordBoxLogin.Text="";
                IdBoxLogin.Text="";
                MessageBox.Show("you are NOT logged in");

            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            PassLabel.Show();
            IdLabel.Show();
            LoginBtn.Show();
            PasswordBoxLogin.Show();
            IdBoxLogin.Show();
            emp1.Hide();
            agent1.Hide();
            admin1.Hide();
            LogoutBtn.Hide();
            IdBoxLogin.Text = "";
            PasswordBoxLogin.Text = "";

        }

        private void agent1_Load(object sender, EventArgs e)
        {

        }
    }
}
