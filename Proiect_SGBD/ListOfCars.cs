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
    public partial class ListOfCars : Form
    {
        public ListOfCars()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListOfCars_Load(object sender, EventArgs e)
        {
            DataAccess dbAccess = new DataAccess();

            List<Car> cars = dbAccess.GetTheListOfCars();

            dataGridView1.DataSource = cars;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rowForDeleting = deleteRoxTextbox.Text;

            DataAccess dbAccess = new DataAccess();

            dbAccess.deleteRow(rowForDeleting);
        }

        private void showCarsButton_Click(object sender, EventArgs e)
        {
            DataAccess dbAccess = new DataAccess();

            List<Car> cars = dbAccess.GetTheListOfCars();

            dataGridView1.DataSource = cars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 1;
            if (makeRadioButton.Checked)
                index = 1;
            if (modelButton.Checked)
                index = 2;
            if (carYearButton.Checked)
                index = 3; 
            
            string columnValue = valueTextBox.Text;
            string row = rowTextBox.Text;

            DataAccess dbAccess = new DataAccess();

            dbAccess.updateInfromation(index, columnValue, row);
        }

    }
}
