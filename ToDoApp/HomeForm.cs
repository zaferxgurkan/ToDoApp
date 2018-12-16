using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ToDoApp
{
    public partial class HomeForm : Form
    {
        string task,username;
        string connectionString = "Data Source=DESKTOP-9K28DPD\\SQLEXPRESS;Initial Catalog=ToDoDB;Integrated Security=True;Pooling=False";
        SqlConnection cnn;

        
        public HomeForm(string username)
        {
            this.username = username;

            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var today = DateTime.Now;
            var tomorrow = today.AddDays(+1);
            var ttomorrow = tomorrow.AddDays(+1);
            label1.Text = today.ToString("dd/MM/yyyy");
            label2.Text = tomorrow.ToString("dd/MM/yyyy");
            label3.Text = ttomorrow.ToString("dd/MM/yyyy");
        }

        private void txtbx_Today_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Today.PerformClick();
        }

        private void btn_Today_Click(object sender, EventArgs e)
        {
            string turAd = comboBox1.SelectedItem.ToString();
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            var today = DateTime.Now;
            task = txtbx_Today.Text;


            string command = "INSERT INTO Tbl_Tasks (task, date,userID) VALUES(@task, @date,@id)";


            SqlCommand cmd = new SqlCommand(command, cnn);
            cmd.Parameters.AddWithValue("@task", task);
            cmd.Parameters.AddWithValue("@date", today);
            cmd.Parameters.AddWithValue("@id", getID().ToString());
            cmd.CommandType = CommandType.Text;
            try
            {

                cmd.ExecuteNonQuery();
                int TurID = GetTurID(turAd);
                int TaskID = GetTaskID(task);
                cnn.Open();
                command = "INSERT INTO TurTask (TurID, TaskID) VALUES(@turID, @taskID)";
                cmd = new SqlCommand(command, cnn);
                cmd.Parameters.AddWithValue("@turID", TurID.ToString());
                cmd.Parameters.AddWithValue("@taskID", TaskID.ToString());
                cmd.ExecuteNonQuery();
                checkedListBox1.Items.Clear();

                Today_List();
                cnn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata : " + ex);
            }


        }
        private int GetTurID(string turAd)
        {
            int id = 0;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string command = "Select Id FROM Tbl_Tur WHERE turAd = @turAd";
            SqlCommand cmd = new SqlCommand(command, cnn);
            cmd.Parameters.AddWithValue("@turAd", turAd);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string yd = dt.Rows[0][0].ToString();
            id = Int16.Parse(yd);
            cnn.Close();
            return id;
        }
        private int GetTaskID(string task)
        {
            int id = 0;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string command = "Select Id FROM Tbl_Tasks WHERE task = @task";
            SqlCommand cmd = new SqlCommand(command, cnn);
            cmd.Parameters.AddWithValue("@task", task);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string yd = dt.Rows[0][0].ToString();
            id = Int16.Parse(yd);
            cnn.Close();
            return id;
        }
        private void Tur_List()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            var today = DateTime.Now;
            string command = "Select * from Tbl_Tur";
            SqlCommand cmd = new SqlCommand(command, cnn);
            

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string fil1 = rdr.GetString(1);
                comboBox1.Items.Add(fil1);
            }
            rdr.Close();
            cnn.Close();
        }
        private void Today_List()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            var today = DateTime.Now;
            string command = "Select * from Tbl_Tasks where userID = @id";
            SqlCommand cmd = new SqlCommand(command, cnn);
            cmd.Parameters.AddWithValue("@id", getID().ToString());

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string fil1 = rdr.GetString(1);
                checkedListBox1.Items.Add(fil1);
            }
            rdr.Close();
            cnn.Close();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            Today_List();
            Tur_List();
            comboBox1.SelectedIndex = 0; 
        }
        private int getID()
        {
            int id = 0;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string command = "Select Id FROM Tbl_Users WHERE userName = @userName";
            SqlCommand cmd = new SqlCommand(command, cnn);
            cmd.Parameters.AddWithValue("@userName", username);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string yd=dt.Rows[0][0].ToString();
            id = Int16.Parse(yd);
            cnn.Close();
                return id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getID().ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            
            MessageBox.Show(checkedListBox1.SelectedIndex.ToString());
            foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                int TaskID = GetTaskID(item);
               
                    string command = "DELETE FROM TurTask WHERE TaskID = @taskID";
                    SqlCommand cmd = new SqlCommand(command, cnn);
                    cmd.Parameters.AddWithValue("@taskID", TaskID.ToString());
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        checkedListBox1.Items.Remove(item);
                        cnn.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Hata : " + ex);
                    }
                command = "DELETE FROM Tbl_Tasks WHERE task = @item";
                cmd = new SqlCommand(command, cnn);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    checkedListBox1.Items.Remove(item);
                    cnn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Hata : " + ex);
                }
               
            }
            
        }
    }
}
