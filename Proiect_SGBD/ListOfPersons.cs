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
    public partial class ListOfPersons : Form
    {
        List<Person> people;
        public ListOfPersons()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            //people = db.GetPeople(lastNameText.Text);

            UpdateBinding();
        }
        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void ListOfPersons_Load(object sender, EventArgs e)
        {

        }
    }
}
