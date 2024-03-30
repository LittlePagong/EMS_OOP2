using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EMS_OOP2
{
    public partial class EMSMenu : Form
    {
        public EMSMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;

        private void EMSMenu_Load(object sender, EventArgs e)
        {
            EMSMenuLabel.Parent = EMS3;
            EMSMenuLabel.BackColor = Color.Transparent;
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                                         "C:\\Users\\Micha\\OneDrive\\Desktop\\EmployeeManagementSystem\\Employees\\EmployeeListss.mdb");

            da = new OleDbDataAdapter("SELECT * FROM EmployeeLists", myConn);
            ds = new DataSet();

            try
            {
                myConn.Open();
                da.Fill(ds, "EmployeeLists");
                EmployeeData.DataSource = ds.Tables["EmployeeLists"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEmployee addemployee = new AddEmployee();
            addemployee.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(EmployeeData.CurrentRow != null)
            {
                string query = "DELETE FROM EmployeeLists WHERE ID = @id";
                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@id", EmployeeData.CurrentRow.Cells[0].Value);

                    try
                    {
                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        LoadEmployeeData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        myConn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            EmployeeSearch s1Form = new EmployeeSearch();
            s1Form.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Login azForm = new Login();
                azForm.Show();
                this.Hide();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeData.CurrentRow != null)
            {
                int employeeID = Convert.ToInt32(EmployeeData.CurrentRow.Cells["ID"].Value);

                //UpdateEmployeeForm updateForm = new UpdateEmployeeForm(employeeID);
                //updateForm.ShowDialog();

                LoadEmployeeData();
            }
            else
            {
                MessageBox.Show("Please select an employee to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}