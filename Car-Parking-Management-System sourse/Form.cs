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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginSucces = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (radiobtnManager.Checked)
            {
                using (StreamReader checkpass = new StreamReader("Manager.txt"))
                {
                    while (!checkpass.EndOfStream)
                    {
                        if (username == checkpass.ReadLine() && password == checkpass.ReadLine())
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Manager_Form newForm = new Manager_Form();
                            newForm.Show();
                            this.Hide();
                            loginSucces = true;
                            break;
                        }
                    }
                }
            }
            if (radiobtnAttendant.Checked)
            {
                using (StreamReader checkpass = new StreamReader("Attendant.txt"))
                {
                    while (!checkpass.EndOfStream)
                    {
                        if (username == checkpass.ReadLine() && password == checkpass.ReadLine())
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Attendant_Form newForm = new Attendant_Form();
                            newForm.Show();
                            this.Hide();
                            loginSucces = true;
                            break;
                        }
                    }
                }
            }
            if (radiobtnCustomer.Checked)
            {
                using (StreamReader checkpass = new StreamReader("Customer.txt"))
                {
                    while (!checkpass.EndOfStream)
                    {
                        if (username == checkpass.ReadLine() && password == checkpass.ReadLine())
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Customer_Form newForm = new Customer_Form();
                            newForm.Show();
                            this.Hide();
                            loginSucces = true;
                            break;
                        }
                    }
                }
            }
            if (!loginSucces)
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateNewAccount_Form form = new CreateNewAccount_Form();
            form.ShowDialog();         
        }
    }
}
