using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Diagnostics;
using System.Windows;
using System.Diagnostics.Tracing;

namespace EMS_OOP2
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login zForm = new Login();
            zForm.Show();
            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string dbSource = @"(localdb)\MSSQLLocalDB";
            string db = "user";
            string connString = @"Data Source=" + dbSource + ";Initial Catalog=" + db + ";Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            string registerUser = register_user.Text;
            string registerPass = register_pass.Text;
            string registerEmail = register_email.Text;

            if (registerUser == string.Empty || registerPass == string.Empty || registerEmail == string.Empty)
            {
                MessageBox.Show($"Please fill all of the blanks.", "Incomplete Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();

                    string checkUsernameQuery = $"SELECT COUNT(*) FROM userDetails WHERE username = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkUsernameQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", registerUser);

                        int userCount = (int)checkCmd.ExecuteScalar();

                        if(userCount > 0)
                        {
                            MessageBox.Show($"{registerUser} already exists.", "Existed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                        string sqlQuery = $"Insert Into userDetails(username, password, email) Values ('{register_user.Text}', '{register_pass.Text}', '{register_email.Text}')";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", registerUser);
                        cmd.Parameters.AddWithValue("@password", registerPass);
                        cmd.Parameters.AddWithValue("@email", registerEmail);

                        cmd.ExecuteNonQuery();
                    }
                        MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Login zForm = new Login();
                        zForm.Show();
                        this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void register_checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if(register_checkpass.Checked)
            {
                register_pass.PasswordChar = '\0';
            }
            else
            {
                register_pass.PasswordChar = '*';
            }
        }
    }
}