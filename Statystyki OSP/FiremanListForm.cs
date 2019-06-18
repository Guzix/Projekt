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
    public partial class FiremanListForm : Form
    {
        public FiremanListForm()
        {
            InitializeComponent();
            this.firemanBindingSource.DataSource = DataContext.GetFiremanList();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FiremanForm fireman = new FiremanForm();
            fireman.MdiParent = this.ParentForm;
            fireman.Show();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Fireman fireman = row.DataBoundItem as Fireman;
                if(fireman!=null)
                {
                    FiremanForm firemanForm = new FiremanForm(fireman);
                    firemanForm.MdiParent = this.ParentForm;
                    firemanForm.Show();
                }
            }
        }

        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            this.firemanBindingSource.ResetBindings(true);
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
