using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_SGBD
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            DataAccess dbAccess = new DataAccess();

            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            string firstName = firstNameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string emailAddress = emailAddressTextbox.Text;          

            var account = dbAccess.InsertData(username, password, firstName, lastName, emailAddress);

            if(account == null)
            {
                MessageBox.Show("Register failed !");
            }
            else
            {
                this.Hide();

                profileForm profileForm = new profileForm(account.Username, account.Password);
                profileForm.ShowDialog();

                this.Close();
            }

            
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            this.Close();
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            passwordTextbox.PasswordChar = '*';
        }
    }
}
