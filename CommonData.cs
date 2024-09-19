using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class UserCommonData
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserRole { get; set; }




        public DataTable SelectUsers()
        {
            SqlConnection conn = new SqlConnection("data source = 7231AMRIND4168L; initial catalog = EMSS; trusted_connection = true");
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool UpdateToAgent(UserCommonData C)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            try
            {
                string sql = "UPDATE Users SET UserRole=1 WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", C.Id);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) { isSuccess = true; }
                else { isSuccess = false; }
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return isSuccess;
        }
        public bool RevertToEmp(UserCommonData C)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            try
            {
                string sql = "UPDATE Users SET UserRole=2 WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", C.Id);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) { isSuccess = true; }
                else { isSuccess = false; }
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return isSuccess;
        }

        public bool LoginStatus(string password, string id)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("SELECT * from Users where Id=@id AND Password=@password", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                IsSuccess = true;
            }
            else
            {
                MessageBox.Show("error");

            }
            return IsSuccess;
        }

        public int CheckUserRole(string id, string pass)
        {
            int result = 4;
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("SELECT UserRole from Users where Id=@id AND Password=@password", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", pass);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            try
            {
                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;

        }
        public string CheckUserId(string id, string pass)
        {
            string result = "";
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("SELECT Id from Users where Id=@id AND Password=@password", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", pass);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            try
            {
                conn.Open();
                //result = (Int32)cmd.ExecuteScalar();
                SqlDataReader usernameRdr = null;

                usernameRdr = cmd.ExecuteReader();

                while (usernameRdr.Read())
                {
                     result = usernameRdr["username11"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;

        }
    }
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
    class TicketCommonData
    {
        public string TicketID { get; set; }
        public int CreatedBy { get; set; }
        public string AssignedTo { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public DataTable SelectTickets()
        {
            SqlConnection conn = new SqlConnection("data source = 7231AMRIND4168L; initial catalog = EMSS; trusted_connection = true");
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT [TicketID],[CreatedBy],[AssignedTo],[Subject],[Description],[Status] FROM Tickets";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception )
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable SelectTicketsByUser(string id)
        {
            
            SqlConnection conn = new SqlConnection("data source = 7231AMRIND4168L; initial catalog = EMSS; trusted_connection = true");
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT TicketID,CreatedBy,AssignedTo,Subject,Description,Status FROM Tickets where CreatedBy= @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable SelectTicketsByAssignVal(string id)
        {

            SqlConnection conn = new SqlConnection("data source = 7231AMRIND4168L; initial catalog = EMSS; trusted_connection = true");
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT TicketID,[CreatedBy],[AssignedTo],[Subject],[Description],[Status] FROM Tickets where AssignedTo= @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool AssignTicket(TicketCommonData T)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            try
            {
                if (T.Status == 2 )
                {
                    string sql = "UPDATE Tickets SET Status=0,AssignedTo=@assi,AssignedAt=SYSDATETIME() WHERE TicketId=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID", T.TicketID);
                    cmd.Parameters.AddWithValue("@assi", T.AssignedTo);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) { isSuccess = true; }
                    else { isSuccess = false; }
                }
                
                else
                { 
                    MessageBox.Show("error in updating status");
                }
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return isSuccess;
        }

        public bool UpdateStatus(TicketCommonData T)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            try
            {
                
                 if (T.Status == 0)
                {
                    string sql = "UPDATE Tickets SET Status=1 ,ActiveAt=SYSDATETIME() WHERE TicketId=@ID ";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID", T.TicketID);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) { isSuccess = true; }
                    else { isSuccess = false; }
                }
                else if (T.Status == 1)
                {
                    string sql = "UPDATE Tickets SET Status=5, ResolvedAt=SYSDATETIME() WHERE TicketId=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID", T.TicketID);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) { isSuccess = true; }
                    else { isSuccess = false; }
                }
                else 
                {
                    MessageBox.Show("error in updating status");
                }
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return isSuccess;
        }
        public bool RevertStatus(TicketCommonData T)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            try
            {
                
                 if (T.Status == 1)
                {
                    string sql = "UPDATE Tickets SET Status=0 WHERE TicketId=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID", T.TicketID);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) { isSuccess = true; }
                    else { isSuccess = false; }
                }
                else if (T.Status == 5)
                {
                    string sql = "UPDATE Tickets SET Status=1 WHERE TicketId=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID", T.TicketID);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) { isSuccess = true; }
                    else { isSuccess = false; }
                }
                else 
                {
                    MessageBox.Show("error in reverting status");
                }
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return isSuccess;
        }
       
    }

}
