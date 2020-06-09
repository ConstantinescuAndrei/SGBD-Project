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
    public partial class UnoccupiedCars : Form
    {
        public UnoccupiedCars()
        {
            InitializeComponent();
        }

        private void UnoccupiedCars_Load(object sender, EventArgs e)
        {
            DataAccess dbAccess = new DataAccess();

            List<Car> cars = dbAccess.ShowUnoccupiedCars();

            carsDataGrid.DataSource = cars;
        }

        private void rentACarLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string row = rentACarTextbox.Text;

            DataAccess dbAccess = new DataAccess();

            dbAccess.rentACar(row);
        }

        private void rentACarTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
