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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfPersons listOfPerson = new ListOfPersons();
            listOfPerson.ShowDialog();

            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterForm register = new RegisterForm();
            register.ShowDialog();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataAccess dbAccess = new DataAccess();

            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            if(dbAccess.ExistAccount(username, password))
            {
                this.Hide();
                profileForm profile = new profileForm(username, password);
                profile.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid account !!!");
            }
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            passwordTextbox.PasswordChar = '*';
        }
    }
}
