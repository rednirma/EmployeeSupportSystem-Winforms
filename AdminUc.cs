using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMSStc
{
    public partial class AdminUc : UserControl
    {
        public AdminUc()
        {
            InitializeComponent();
            DataTable dt1 = TIC.SelectTickets();
            AllTicketsDGV.DataSource = dt1;
            DataTable dt = UCD.SelectUsers();
            AdminUserDGV.DataSource = dt;
            Fillchart();
            FillComboBox();
            adminlogin = true;
        }

        
        public bool adminlogin = false;
        UserCommonData UCD = new UserCommonData();
        TicketCommonData TIC = new TicketCommonData();
        string id = Form1.user;
        string TicID = "";
        string AssiTo = "";
        int ticST;
        private void Admin_Load(object sender, EventArgs e)
        {
            adminlogin = true;
            DataTable dt = UCD.SelectUsers();
            AdminUserDGV.DataSource = dt;
            DataTable dt1 = TIC.SelectTickets();
            AllTicketsDGV.DataSource = dt1;
            FillComboBox();
            Fillchart();
        }
        private void FillComboBox()
        {
            SelectAgentCB.Items.Clear();
            SqlConnection conn = new SqlConnection("data source = 7231AMRIND4168L; initial catalog = EMSS; trusted_connection = true");
            conn.Open();
            string sql = "Select Id from Users WHERE UserRole=1";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                SelectAgentCB.Items.Add(dr["Id"].ToString());
            }
            conn.Close();
            AssiTo = SelectAgentCB.Text;
        }
        //public admin(String UID, String Pass)
        //{
        //    InitializeComponent();
        //    String U = UID;
        //    String pa = Pass;
        //    DataTable dt1 = TIC.SelectTickets();
        //    AllTicketsDGV.DataSource = dt1;
        //    DataTable dt = UCD.SelectUsers();
        //    AdminUserDGV.DataSource = dt;
        //    Fillchart();
        //    FillComboBox();
        //    adminlogin = true;

        //}

        private void UpdateUserPic_Click(object sender, EventArgs e)
        {
            UCD.Id = id;
            bool success = UCD.UpdateToAgent(UCD);
            if (success == true)
            {
                MessageBox.Show("cont updated");

            }
            else
            {
                MessageBox.Show("cont not updated");
            }
            DataTable dt = UCD.SelectUsers();
            AdminUserDGV.DataSource = dt;
        }

        private void AdminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminUsersTab_Click(object sender, EventArgs e)
        {

        }

        private void AdminTicketsTab_Click(object sender, EventArgs e)
        {

        }

        private void AdminAnalyticsTab_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserPageLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserPageDiscLabel_Click(object sender, EventArgs e)
        {

        }

        private void AllTicketsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RevertUserPic_Click(object sender, EventArgs e)

        {
            UCD.Id = id;
            bool success = UCD.RevertToEmp(UCD);
            if (success == true)
            {
                MessageBox.Show("cont updated");

            }
            else
            {
                MessageBox.Show("cont not updated");
            }
            DataTable dt = UCD.SelectUsers();
            AdminUserDGV.DataSource = dt;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id = AdminUserDGV.Rows[rowIndex].Cells[0].Value.ToString();

        }

        private void AssignTicPic_Click(object sender, EventArgs e)
        {
            TIC.TicketID = TicID;
            string selval = SelectAgentCB.Text;
            TIC.AssignedTo = selval;
            TIC.Status = ticST;
            //MessageBox.Show("sel val: " +selval);
            //MessageBox.Show("tic :" +TIC.AssignedTo);
            //MessageBox.Show("ticid :" +TIC.TicketID);
            //MessageBox.Show("ticst :" +TIC.Status);

            bool success = TIC.AssignTicket(TIC);
            if (success == true)
            {
                MessageBox.Show("cont updated");

            }
            else
            {
                MessageBox.Show("cont not updated");
            }
            DataTable dt = TIC.SelectTickets();
            AllTicketsDGV.DataSource = dt;
        }

        public void Fillchart()
        {
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            DataSet dt = new DataSet();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select TicketIDre, Time_Taken_To_Assign, Time_Taken_To_Activate,Time_Taken_To_Resolve from TicketTime", conn);
            da.Fill(dt);
            //AdminChart.DataSource = dt;
            DataView source = new DataView(dt.Tables[0]);
            AdminChart.DataSource = source;
            conn.Close();
            AdminChart.Series["Time_Taken_To_Assign"].XValueMember = "TicketIDre";
            AdminChart.Series["Time_Taken_To_Assign"].YValueMembers = "Time_Taken_To_Assign";
            AdminChart.Series["Time_Taken_To_Activate"].XValueMember = "TicketIDre";
            AdminChart.Series["Time_Taken_To_Activate"].YValueMembers = "Time_Taken_To_Activate";
            AdminChart.Series["Time_Taken_To_Resolve"].XValueMember = "TicketIDre";
            AdminChart.Series["Time_Taken_To_Resolve"].YValueMembers = "Time_Taken_To_Resolve";
            AdminChart.DataBind();

        }

        private void AllTicketsDGV_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TicID = AllTicketsDGV.Rows[rowIndex].Cells[0].Value.ToString();
            ticST = Convert.ToInt32(AllTicketsDGV.Rows[rowIndex].Cells[5].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adminlogin = false;
            //Form1 fm = new Form1();
            //fm.Show();
            this.Hide();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            //adminlogin = false;
            //Form1 fm = new Form1();
            //fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adminlogin = false;
            //Form1 fm = new Form1();
            //fm.Show();
            this.Hide();
        }

        private void AdminAnalyticsTab_Click_1(object sender, EventArgs e)
        {

        }
    }
}
