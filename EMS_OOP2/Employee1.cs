using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_OOP2
{
    public partial class Employee1 : Form
    {
        public Employee1()
        {
            InitializeComponent();
        }

        private void Employee1_Load(object sender, EventArgs e)
        {
            HomeBtn.Parent = EMS1;
            HomeBtn.BackColor = Color.Transparent;
            HomeLabel.Parent = EMS1;
            HomeLabel.BackColor = Color.Transparent;
            Logout.Parent = EMS1;
            Logout.BackColor = Color.Transparent;
        }
    }
}
