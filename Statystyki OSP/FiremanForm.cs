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
    /// FiremanForm
    /// </summary>
    public partial class FiremanForm : Form
    {
        private Fireman data= new Fireman();
        /// <summary>
        /// FiremanForm
        /// </summary>
        /// <remarks>kontruktor klasy</remarks>
        public FiremanForm()
        {
            
            InitializeComponent();
            this.firemanBindingSource.DataSource = data;
        }
        /// <summary>
        /// FiremanForm
        /// </summary>
        /// <param name="firemanData">zmienna typu Fireman</param>
        /// <remarks>przeciazony konstruktor klasy</remarks>
        public FiremanForm(Fireman firemanData)
        {
            this.data = firemanData;

            InitializeComponent();
            this.firemanBindingSource.DataSource = data;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataContext.AddOrEditFiremans(data) == true)
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
