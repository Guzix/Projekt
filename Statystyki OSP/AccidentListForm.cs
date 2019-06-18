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
    public partial class AccidentListForm : Form
    {
        public AccidentListForm()
        {
            InitializeComponent();
            this.accidentBindingSource.DataSource = DataContext.GetAccidentsList();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            AccidentForm accidentForm = new AccidentForm();
            accidentForm.MdiParent = this.ParentForm;
            accidentForm.Show();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Accident accident = row.DataBoundItem as Accident;
                if(accident != null)
                {
                    AccidentForm accidentForm = new AccidentForm(accident);
                    accidentForm.MdiParent = this.ParentForm;
                    accidentForm.Show();
                }
            }
           
        }

        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            this.accidentBindingSource.ResetBindings(true);
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
