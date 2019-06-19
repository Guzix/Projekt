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
    /// VehicleListForm
    /// </summary>
    public partial class VehicleListForm : Form
    {
        /// <summary>
        /// VehicelListForm
        /// </summary>
        public VehicleListForm()
        {
            InitializeComponent();
            this.vehicleBindingSource.DataSource = DataContext.GetVehiclesList();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            VehicleFrom vehicleFrom = new VehicleFrom();
            vehicleFrom.MdiParent = this.ParentForm;
            vehicleFrom.Show();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Vehicle vehicle = row.DataBoundItem as Vehicle;
                if(vehicle!=null)
                {
                    VehicleFrom vehicleFrom = new VehicleFrom(vehicle);
                    vehicleFrom.MdiParent = this.ParentForm;
                    vehicleFrom.Show();
                }
            }
        }

        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.ResetBindings(true);
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
