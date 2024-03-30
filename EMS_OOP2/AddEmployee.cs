using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_OOP2
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        OleDbConnection myConn;
        private void empadd_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM EmployeeLists WHERE Name = @Empname";
            string insertQuery = "INSERT INTO EmployeeLists (Name, Age, Birthdate, Position, Email, Address, ContactNumber, Salary) " +
                                 "VALUES (@Empname, @Empage, @birthde, @Pos, @mail, @Add, @Contactnum, @Sal)";

            string EmployeesName = EmpName.Text;
            string EmployeesAge = EmpAge.Text;
            string EmployeesDob = EmpDob.Text;
            string EmployeesPosition = EmpPos.Text;
            string EmployeesEmail = EmpEmail.Text;
            string EmployeesAddress = EmpAddress.Text;
            string EmployeesContactNo = EmpContact.Text;
            string EmployeesSalary = EmpSal.Text;

            if(string.IsNullOrEmpty(EmployeesName) || string.IsNullOrEmpty(EmployeesAge) || string.IsNullOrEmpty(EmployeesDob) ||
                string.IsNullOrEmpty(EmployeesPosition) || string.IsNullOrEmpty(EmployeesEmail) || string.IsNullOrEmpty(EmployeesAddress) ||
                string.IsNullOrEmpty(EmployeesContactNo) || string.IsNullOrEmpty(EmployeesSalary))
            {
                MessageBox.Show("Incomplete Credentials", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                "C:\\Users\\Micha\\OneDrive\\Desktop\\EmployeeManagementSystem\\Employees\\EmployeeListss.mdb"))
            {
                myConn.Open();

                using (OleDbCommand checkCmd = new OleDbCommand(query, myConn))
                {
                    checkCmd.Parameters.AddWithValue("@Empname", EmployeesName);
                    int existingCount = (int)checkCmd.ExecuteScalar();

                    if(existingCount > 0)
                    {
                        MessageBox.Show($"{EmployeesName} already exists!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, myConn))
                {
                    insertCmd.Parameters.AddWithValue("@Empname", EmployeesName);
                    insertCmd.Parameters.AddWithValue("@Empage", EmployeesAge);
                    insertCmd.Parameters.AddWithValue("@birthde", EmployeesDob);
                    insertCmd.Parameters.AddWithValue("@Pos", EmployeesPosition);
                    insertCmd.Parameters.AddWithValue("@mail", EmployeesEmail);
                    insertCmd.Parameters.AddWithValue("@Add", EmployeesAddress);
                    insertCmd.Parameters.AddWithValue("@Contactnum", EmployeesContactNo);
                    insertCmd.Parameters.AddWithValue("@Sal", EmployeesSalary);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                myConn.Close();
            }
        }
    }
}