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

namespace EMS_OOP2
{
    public partial class EmployeeSearch : Form
    {
        public EmployeeSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        OleDbConnection myConn;
        OleDbDataAdapter da;
        DataSet ds;

        private void EmployeeSearch_Load(object sender, EventArgs e)
        {
            EmpSearchLabel.Parent = EmpSearchPicBox;
            EmpSearchLabel.BackColor = Color.Transparent;
        }

        private void EmpSearch1_Click(object sender, EventArgs e)
        {
            string employeeID = EmpSearchBox1.Text.Trim();

            if(string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Please Enter an Employee ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                    "C:\\Users\\Micha\\OneDrive\\Desktop\\EmployeeManagementSystem\\Employees\\EmployeeListss.mdb");

                da = new OleDbDataAdapter("SELECT * FROM EmployeeLists WHERE ID = @EmployeeID", myConn);
                da.SelectCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "EmployeeLists");
                myConn.Close();

                if(ds.Tables["EmployeeLists"].Rows.Count > 0)
                {
                    EmployeeData.DataSource = ds.Tables["EmployeeLists"];
                }
                else
                {
                    MessageBox.Show("Employee not found.", "Search Result Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                myConn.Close();
            }
        }
    }
}
