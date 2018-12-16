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
    public partial class loginForm : Form
    {
        string userName_Email, password;
        bool durum=false;
        string connectionString = "Data Source=DESKTOP-9K28DPD\\SQLEXPRESS;Initial Catalog=ToDoDB;Integrated Security=True;Pooling=False";
        SqlConnection cnn;
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            userName_Email = txtbx_userName.Text;
            password = txtbx_pass.Text;

            cnn = new SqlConnection(connectionString);

            try
            {

                if (txtbx_pass.Text == "" || txtbx_userName.Text == "")
                {
                    durum = false;
                }
                else durum = true;
                if (durum)
                {
                    string command = "SELECT * FROM Tbl_Users WHERE userName = @userName and userPass = @userPass";
                    SqlCommand cmd = new SqlCommand(command, cnn);
                    cmd.Parameters.AddWithValue("@userName", txtbx_userName.Text);
                    cmd.Parameters.AddWithValue("@userPass", txtbx_pass.Text);
                  
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        HomeForm homeForm = new HomeForm(userName_Email);
                        homeForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bilgilerini Kontrol Et!"+ dt.Rows.Count);
                    }


                }
                else MessageBox.Show("Girdiğiniz Bilgileri Kontrol Edin");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }

        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_giris.PerformClick();
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_giris.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbx_pass.PasswordChar = '*';
            txtbx_pass.MaxLength = 14;
            txtbx_userName.Text = "zaferxgurkan";
            txtbx_pass.Text = "123456";

        }

        private void link_lbl_singup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            singupForm singupForm = new singupForm();
            singupForm.Show();
        }

        private void close_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
