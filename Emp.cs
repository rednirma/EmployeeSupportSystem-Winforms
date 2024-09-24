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
    public partial class Emp : Form
    {
        UserCommonData UCD1 = new UserCommonData();
        String U = "";

        TicketCommonData TIC = new TicketCommonData();
        public Emp(String UID, String Pass)
        {
            InitializeComponent();
            U = UID;
            String pa = Pass;
            DataTable dt = TIC.SelectTicketsByUser(U);
            EmpTicketsDGV.DataSource = dt;
            Fillchart(U);
        }
        public void Fillchart(string aea)
        {
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            DataSet dt = new DataSet();
            conn.Open();
            string sql = "select AssignedTo,TicketIDre,Time_Taken_To_Activate,Time_Taken_To_Assign,Time_Taken_To_Resolve from Tickets right join TicketTime on Tickets.TicketID=TicketTime.TicketIDre where CreatedBy=@ato;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ato", aea);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //AdminChart.DataSource = dt;
            DataView source = new DataView(dt.Tables[0]);
            EmpChart.DataSource = source;
            conn.Close();
            EmpChart.Series["Time_Taken_To_Assign"].XValueMember = "TicketIDre";
            EmpChart.Series["Time_Taken_To_Assign"].YValueMembers = "Time_Taken_To_Assign";
            EmpChart.Series["Time_Taken_To_Activate"].XValueMember = "TicketIDre";
            EmpChart.Series["Time_Taken_To_Activate"].YValueMembers = "Time_Taken_To_Activate";
            EmpChart.Series["Time_Taken_To_Resolve"].XValueMember = "TicketIDre";
            EmpChart.Series["Time_Taken_To_Resolve"].YValueMembers = "Time_Taken_To_Resolve";
            EmpChart.DataBind();

        }

        private void EmpTicketsTab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmpCreateTab_Click(object sender, EventArgs e)
        {

        }

        private void CreateTicPic_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source = 7231AMRIND4168L; initial catalog = EMSS; trusted_connection = true");
            try
            {
                if (TicketSubjectTextBox.Text != "" && DiscTextBox.Text != "")
                {
                    string sql = "INSERT INTO Tickets (TicketID, CreatedBy,Subject,Description,Status,CreatedAt) Values ('TICKET-' + LEFT(NEWID(),8),@id,@subject,@disc,2,SYSDATETIME())";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", U);
                    cmd.Parameters.AddWithValue("@subject", TicketSubjectTextBox.Text);
                    cmd.Parameters.AddWithValue("@disc", DiscTextBox.Text);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("ticket created");
                    }
                    else
                    {
                        MessageBox.Show("ticket not created");
                    }
                }
                else
                {
                    MessageBox.Show("ticket not created");
                }

            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void Emp_Load(object sender, EventArgs e)
        {

        }
    }
}
