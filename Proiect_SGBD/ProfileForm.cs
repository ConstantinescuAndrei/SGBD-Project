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
    public partial class profileForm : Form
    {
        DataAccess dbAccess = new DataAccess();
        public profileForm(string username, string password)
        {
            InitializeComponent();

            Account account = dbAccess.GetUserInformation(username, password);

            usernameLabel.Text = account.Username;
            firstNameLabel.Text = account.FirstName;
            lastNameLabel.Text = account.LastName;
            emailAddressLabel.Text = account.EmailAddress;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carListButton_Click(object sender, EventArgs e)
        {
            
            ListOfCars listOfCars = new ListOfCars();
            listOfCars.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            UnoccupiedCars unoccupiedCars = new UnoccupiedCars();

            unoccupiedCars.ShowDialog();
        }
    }
}
