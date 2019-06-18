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
    public partial class AccidentForm : Form
    {
        private Accident data = new Accident();
        public AccidentForm()
        {
            InitializeComponent();
            this.accidentBindingSource.DataSource = data;
        }

        public AccidentForm(Accident accidentData)
        {
            this.data = accidentData;
            InitializeComponent();
            this.accidentBindingSource.DataSource = data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                int pojazdID = (int)this.comboBoxPojazd.SelectedValue;
                data.VehicleData = DataContext.GetVehiclesList().Find(o => o.VehicleId == pojazdID);
                if(data.VehicleData == null)
                {
                    MessageBox.Show("Wybierz pojazd");
                    return;
                }

                int kierowcaID = (int)this.comboBoxKierowca.SelectedValue;
                data.FiremanDataKierowca = DataContext.GetFiremanList().Find(o => o.FiremanId ==kierowcaID);
                if (data.FiremanDataKierowca == null)
                {
                    MessageBox.Show("Wybierz kierowce");
                    return;
                }

                int dowodcaID =  (int)this.comboBoxDowodca.SelectedValue;
                data.FiremanDataDowodca = DataContext.GetFiremanList().Find(o => o.FiremanId == dowodcaID);
                if (data.FiremanDataDowodca == null)
                {
                    MessageBox.Show("Wybierz dowódce");
                    return;
                }

                int iRotaID = (int)this.comboBoxIRota.SelectedValue;
                data.FiremanDataIRota = DataContext.GetFiremanList().Find(o => o.FiremanId == iRotaID);

                int iRotaPomocID = (int)this.comboBoxIRotaPomoc.SelectedValue;
                data.FiremanDataIRotaPomoc = DataContext.GetFiremanList().Find(o => o.FiremanId == iRotaPomocID);

                int iiRotaID = (int)this.comboBoxIIRota.SelectedValue;
                data.FiremanDataIIRota = DataContext.GetFiremanList().Find(o => o.FiremanId == iiRotaID);

                int iiRotaPomocID = (int)this.comboBoxIIRotaPomoc.SelectedValue;
                data.FiremanDataIIRotaPomoc = DataContext.GetFiremanList().Find(o => o.FiremanId == iiRotaPomocID);

                int iiiRotaID = (int)this.comboBoxIIIRota.SelectedValue;
                data.FiremanDataIIIRota = DataContext.GetFiremanList().Find(o => o.FiremanId == iiiRotaID);

                int iiiRotaPomocID = (int)this.comboBoxIIIRotaPomoc.SelectedValue;
                data.FiremanDataIIIRotaPomoc = DataContext.GetFiremanList().Find(o => o.FiremanId == iiiRotaPomocID);

                if (DataContext.AddOrEditAccidents(data)==true)
                {
                    this.Close();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Podczas zapisu wystapil blad: " + x);
            }
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccidentForm_Load(object sender, EventArgs e)
        {
            this.accidentBindingSource.DataSource = data;
            this.firemanBindingSource.DataSource = DataContext.GetFiremanList();
            this.vehicleBindingSource.DataSource = DataContext.GetVehiclesList();

            if(data!=null)
            {
                if(data.VehicleData != null)
                {
                    this.comboBox1.SelectedValue = data.VehicleData.VehicleId;
                }
                if(data.FiremanDataDowodca !=null)
                {
                    this.comboBoxDowodca.SelectedValue = data.FiremanDataDowodca.FiremanId;
                }
                if(data.FiremanDataKierowca !=null)
                {
                    this.comboBoxKierowca.SelectedValue = data.FiremanDataKierowca.FiremanId;
                }

                if(data.FiremanDataIRota !=null)
                {
                    this.comboBoxIRota.SelectedValue = data.FiremanDataIRota.FiremanId;
                }
                if (data.FiremanDataIRotaPomoc != null)
                {
                    this.comboBoxIRotaPomoc.SelectedValue = data.FiremanDataIRotaPomoc.FiremanId;
                }
                if (data.FiremanDataIIRota != null)
                {
                    this.comboBoxIIRota.SelectedValue = data.FiremanDataIIRota.FiremanId;
                }
                if (data.FiremanDataIIRotaPomoc != null)
                {
                    this.comboBoxIIRotaPomoc.SelectedValue = data.FiremanDataIIRotaPomoc.FiremanId;
                }
                if (data.FiremanDataIIIRota != null)
                {
                    this.comboBoxIIIRota.SelectedValue = data.FiremanDataIIIRota.FiremanId;
                }
                if (data.FiremanDataIIIRotaPomoc != null)
                {
                    this.comboBoxIIIRotaPomoc.SelectedValue = data.FiremanDataIIIRotaPomoc.FiremanId;
                }
              
            }

        }

        private void comboBoxPojazd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
