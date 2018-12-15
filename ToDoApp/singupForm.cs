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
    public partial class singupForm : Form
    {
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        string connectionString = "Data Source=DESKTOP-9K28DPD\\SQLEXPRESS;Initial Catalog=ToDoDB;Integrated Security=True;Pooling=False";
        SqlConnection cnn;
        string userName, password, email;
        public singupForm()
        {
            InitializeComponent();
        }

        private void singupForm_Load(object sender, EventArgs e)
        {
            txtbx_pass.PasswordChar = '*';
            txtbx_pass.MaxLength = 14;
        }

        private void close_form_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            email = txtbx_email.Text;
            userName = txtbx_userName.Text;
            password = txtbx_pass.Text;

            cnn = new SqlConnection(connectionString);
            
            try
            {
                bool durum = IsValidEmail(txtbx_email.Text);
                if(txtbx_email.Text == "" || txtbx_pass.Text=="" || txtbx_userName.Text == "")
                {
                    durum = false;
                }
                if (durum)
                {
                    string command = "INSERT INTO Tbl_Users (userName, userPass, userEmail) VALUES(@userName, @userPass, @userEmail)";
                    SqlCommand cmd = new SqlCommand(command, cnn);
                    cmd.Parameters.AddWithValue("@userName", txtbx_userName.Text);
                    cmd.Parameters.AddWithValue("@userPass", txtbx_pass.Text);
                    cmd.Parameters.AddWithValue("@userEmail", txtbx_email.Text);
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı!");
                        cnn.Close();
                        Close();
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("Hata : " + ex);
                    }
                    
                    
                }
                else MessageBox.Show("Girdiğiniz Bilgileri Kontrol Edin");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
            


        }
    }
}
