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
    public partial class MenuGlowne : Form
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FiremanForm firemanForm = new FiremanForm();
            firemanForm.MdiParent = this;
            firemanForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            VehicleFrom vehicleFrom = new VehicleFrom();
            vehicleFrom.MdiParent = this;
            vehicleFrom.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AccidentForm accidentForm = new AccidentForm();
            accidentForm.MdiParent = this;
            accidentForm.Show();
        }

        private void dodajStrażakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiremanForm firemanForm = new FiremanForm();
            firemanForm.MdiParent = this;
            firemanForm.Show();
        }

        private void dodajPojazdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleFrom vehicleFrom = new VehicleFrom();
            vehicleFrom.MdiParent = this;
            vehicleFrom.Show();
        }

        private void dodajWyjazdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccidentForm accidentForm = new AccidentForm();
            accidentForm.MdiParent = this;
            accidentForm.Show();
        }

        private void uszeregujWPoziomieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void uszeregujWPionieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void uszeregujKaskadowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void listaStrażakówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiremanListForm firemanListForm = new FiremanListForm();
            firemanListForm.MdiParent = this;
            firemanListForm.Show();
        }

        private void listaPojazdówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleListForm vehicleListForm = new VehicleListForm();
            vehicleListForm.MdiParent = this;
            vehicleListForm.Show();
        }

        private void listaWyjazdówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccidentListForm accidentListForm = new AccidentListForm();
            accidentListForm.MdiParent = this;
            accidentListForm.Show();
        }
    }
}
