using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_Parking_Management_System_sourse
{
    public partial class CreateNewAccount_Form : Form
    {
        public CreateNewAccount_Form()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string user=txtUser.Text;
            string pass=txtPass.Text;
            using (StreamWriter swriter = new StreamWriter("Customer.txt",true))
            {
                swriter.WriteLine(user);
                swriter.WriteLine(pass);
                swriter.Flush();
                MessageBox.Show("Create successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
