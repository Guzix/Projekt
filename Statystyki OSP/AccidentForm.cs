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
    /// AccidentForm
    /// </summary>
    public partial class AccidentForm : Form
    {
        private Accident data = new Accident();
        /// <summary>
        /// AccidentForm
        /// </summary>
        /// <remarks>konstruktor formularza</remarks>
        public AccidentForm()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// AccidentForm
        /// </summary>
        /// <param name="accidentData">zmienna typu Accident</param>
        /// <remarks>przeciazony konstruktor formularza</remarks>
        public AccidentForm(Accident accidentData)
        {
            this.data = accidentData;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pojazdID = (int)this.comboBoxPojazd.SelectedValue;
                data.VehicleData = DataContext.GetVehiclesList().Find(o => o.VehicleId == pojazdID);
                if (data.VehicleData == null)
                {
                    MessageBox.Show("Wybierz pojazd");
                    return;
                }

                int kierowcaID = (int)this.comboBoxKierowca.SelectedValue;
                data.FiremanDataKierowca = DataContext.GetFiremanList().Find(o => o.FiremanId == kierowcaID);
                if (data.FiremanDataKierowca == null)
                {
                    MessageBox.Show("Wybierz kierowce");
                    return;
                }

                int dowodcaID = (int)this.comboBoxDowodca.SelectedValue;
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

                if (DataContext.AddOrEditAccidents(data) == true)
                {
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas zapisu wystapil blad: " + x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TestAccident_Load(object sender, EventArgs e)
        {
            this.accidentBindingSource.DataSource = data;
            this.vehicleBindingSource.DataSource = DataContext.GetVehiclesList();
            this.firemanBindingSource.DataSource = DataContext.GetFiremanList();
            this.firemanBindingSource1.DataSource = DataContext.GetFiremanList();
            this.firemanBindingSource2.DataSource = DataContext.GetFiremanList();
            this.firemanBindingSource3.DataSource = DataContext.GetFiremanList();
            this.firemanBindingSource4.DataSource = DataContext.GetFiremanList();
            this.firemanBindingSource5.DataSource = DataContext.GetFiremanList();
            this.firemanBindingSource6.DataSource = DataContext.GetFiremanList();
            this.firemanBindingSource7.DataSource = DataContext.GetFiremanList();

            if (data != null)
            {
                if (data.VehicleData != null)
                {
                    this.comboBoxPojazd.SelectedValue = data.VehicleData.VehicleId;
                }
                if (data.FiremanDataDowodca != null)
                {
                    this.comboBoxDowodca.SelectedValue = data.FiremanDataDowodca.FiremanId;
                }
                if (data.FiremanDataKierowca != null)
                {
                    this.comboBoxKierowca.SelectedValue = data.FiremanDataKierowca.FiremanId;
                }

                if (data.FiremanDataIRota != null)
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
    }
}
