using Statystyki_OSP.Dane;
using Statystyki_OSP.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statystyki_OSP
{
    /// <summary>
    /// VehicleForm
    /// </summary>
    public partial class VehicleFrom : Form
    {
        private Vehicle data = new Vehicle();
        /// <summary>
        /// VehicleForm
        /// </summary>
        /// <remarks>konstruktor formularza</remarks>
        public VehicleFrom()
        {
            
            InitializeComponent();
            this.vehicleBindingSource.DataSource = data;
        }


        /// <summary>
        /// VehicleForm
        /// </summary>
        /// <param name="vehicleData">zmienna typu Vehicle</param>
        /// <remarks>przeciazony konstruktor formularza</remarks>
        public VehicleFrom(Vehicle vehicleData)
        {
            this.data = vehicleData;

            InitializeComponent();
            this.vehicleBindingSource.DataSource = data;
        }

        private void VehicleFrom_Load(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataContext.AddOrEditVehicles(data) == true)
                {
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas zapisu wystapil blad: " + x);
            }
            
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
