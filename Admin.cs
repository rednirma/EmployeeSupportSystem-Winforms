﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Admin : UserControl
    {
        UserCommonData UCD = new UserCommonData();
        TicketCommonData TIC = new TicketCommonData();
        string id = "";
        string TicID = "";
        string AssiTo = "";
        int ticST;
        public Admin()
        {
            InitializeComponent();
            HideEverything();
        }

        private void HideEverything()
        { 
            AllTicketsDGV.Hide();
            UserListDGV.Hide();
            AdminChart.Hide();
        }
        private void ViewAnalyticsBtn_Click(object sender, EventArgs e)
        {
            AllTicketsDGV.Hide();
            UserListDGV.Hide();
            AdminChart.Show();
            //Fillchart();
        }

        private void ViewTicketsBtn_Click(object sender, EventArgs e)
        {
            AllTicketsDGV.Show();
            UserListDGV.Hide();
            AdminChart.Hide();
            DataTable dt1 = TIC.SelectTickets();
            AllTicketsDGV.DataSource = dt1;
            FillComboBox();
        }

        private void ViewUsersBtn_Click(object sender, EventArgs e)
        {
            AllTicketsDGV.Hide();
            UserListDGV.Show();
            AdminChart.Hide();
            DataTable dt = UCD.SelectUsers();
            UserListDGV.DataSource = dt;
        }

        private void ChangeUserRole_Click(object sender, EventArgs e)
        {
            UCD.Id =id;
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
            UserListDGV.DataSource = dt;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            DataTable dt = UCD.SelectUsers();
            UserListDGV.DataSource = dt;
            DataTable dt1 = TIC.SelectTickets();
            AllTicketsDGV.DataSource= dt1;
            FillComboBox();
        }
        private void FillComboBox() 
        {
            AgentSelectCBox.Items.Clear();
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
                AgentSelectCBox.Items.Add(dr["Id"].ToString());
            }
            conn.Close();
            AssiTo = AgentSelectCBox.Text;
        }


        private void UserListDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id = UserListDGV.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TIC.TicketID = TicID;
            string selval = AgentSelectCBox.Text;
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

        private void RevertUserRoleBtn_Click(object sender, EventArgs e)
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
            UserListDGV.DataSource = dt;
        }

        private void AllTicketsDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TicID = AllTicketsDGV.Rows[rowIndex].Cells[0].Value.ToString();
            ticST = Convert.ToInt32( AllTicketsDGV.Rows[rowIndex].Cells[5].Value);

        }
        //public void Fillchart()
        //{
        //    SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
        //    DataTable dt = new DataTable();
        //    conn.Open();
        //    SqlDataAdapter da = new SqlDataAdapter("select DATEDIFF(MINUTE, (select CreatedAt from Tickets where TicketID='TICKET-036900A1'),(select AssignedAt from Tickets where TicketID='TICKET-036900A1') ) AS Time_Taken_To_Assign\r\n,DATEDIFF(MINUTE, (select AssignedAt from Tickets where TicketID='TICKET-036900A1'),(select ActiveAt from Tickets where TicketID='TICKET-036900A1') ) AS Time_Taken_To_Activate\r\n,DATEDIFF(MINUTE, (select ActiveAt from Tickets where TicketID='TICKET-036900A1'),(select ResolvedAt from Tickets where TicketID='TICKET-036900A1') ) AS Time_Taken_To_Activate;",conn);
        //    da.Fill(dt);
        //    AdminChart.DataSource = dt;
        //    conn.Close();
        //    AdminChart.Series["Series 1"].XValueMember = "min";
        //    AdminChart.Series["Series 1"].YValueMembers = "min";


        //}
    }
}
