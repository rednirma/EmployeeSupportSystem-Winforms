using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMSStc
{
    public partial class Form1 : Form
    {
        UserCommonData UCD = new UserCommonData();
        public static string user = "";
        public static string pass = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UCD.Id = EmpIDBox.Text;
            UCD.Password = PasswordBox.Text;
            user = EmpIDBox.Text;
            pass = PasswordBox.Text;
            bool IsSuccess = UCD.LoginStatus(UCD.Password, UCD.Id);

            if (IsSuccess)
            {
                MessageBox.Show("you are logged in ");

                UCD.UserRole = UCD.CheckUserRole(UCD.Id, UCD.Password);
                if (UCD.UserRole == 0)
                {
                    admin AD = new admin(EmpIDBox.Text,PasswordBox.Text);
                    AD.Show();
//                    MessageBox.Show("signed in as admin");
                            this.Close();
                }
                else if (UCD.UserRole == 1)
                {
                    Agent ag= new Agent(EmpIDBox.Text, PasswordBox.Text);
                    ag.Show();
                    //MessageBox.Show("signed in as Agent");
                    this.Close();
                }
                else if (UCD.UserRole == 2)
                {
                    Emp em=new Emp(EmpIDBox.Text, PasswordBox.Text);    
                    em.Show();
                    //MessageBox.Show("signed in as Employee");
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("ERROR : CANNOT SIGN YOU IN");
                }

            }
            else
            {
                MessageBox.Show("You could not login");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
