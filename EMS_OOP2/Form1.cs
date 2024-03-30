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

namespace EMS_OOP2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            L1.Parent = EMSBox1;
            L1.BackColor = Color.Transparent;
            L2.Parent = EMSBox1;
            L2.BackColor = Color.Transparent;
            L3.Parent = EMSBox1;
            L3.BackColor = Color.Transparent;
            L4.Parent = EMSBox1;
            L4.BackColor = Color.Transparent;
            login_checkpass.Parent = EMSBox1;
            login_checkpass.BackColor = Color.Transparent;
            L6.Parent = EMSBox1;
            L6.BackColor = Color.Transparent;
            register_click.Parent = EMSBox1;
            register_click.BackColor = Color.Transparent;

        }

        private void register_click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration aForm = new Registration();
            aForm.Show();
            this.Hide();
        }

        private void login_checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if(login_checkpass.Checked)
            {
                login_pass.PasswordChar = '\0';
            }
            else 
            {
                login_pass.PasswordChar = '*';
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string dbSource = @"(localdb)\MSSQLLocalDB";
            string db = "user";
            string connString = @"Data Source=" + dbSource + ";Initial Catalog=" + db + ";Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            string userLogin = login_user.Text;
            string passLogin = login_pass.Text;

            if(userLogin == string.Empty && passLogin == string.Empty)
            {
                MessageBox.Show($"Invalid Credentials", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "Select username, password From userDetails";

                    using(SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        while(reader.Read())
                        {
                            string username = reader.GetString(0);
                            string password = reader.GetString(1);
                            if(username == userLogin)
                            {
                                if(password != passLogin)
                                {
                                    MessageBox.Show($"Wrong Password, Please Try Again", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show($"Login Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    EMSMenu gForm = new EMSMenu();
                                    gForm.Show();
                                    this.Hide();
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}