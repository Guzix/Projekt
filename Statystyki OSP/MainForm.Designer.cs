namespace Statystyki_OSP
{
    partial class MenuGlowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGlowne));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStrażakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPojazdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajWyjazdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaStrażakówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPojazdówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaWyjazdówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uszeregujWPoziomieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uszeregujWPionieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uszeregujKaskadowoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.operacjeToolStripMenuItem,
            this.daneToolStripMenuItem,
            this.formularzeToolStripMenuItem,
            this.widokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.formularzeToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijProgramToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijProgramToolStripMenuItem
            // 
            this.zamknijProgramToolStripMenuItem.Name = "zamknijProgramToolStripMenuItem";
            this.zamknijProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamknijProgramToolStripMenuItem.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem_Click);
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajStrażakaToolStripMenuItem,
            this.dodajPojazdToolStripMenuItem,
            this.dodajWyjazdToolStripMenuItem});
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjeToolStripMenuItem.Text = "Operacje";
            // 
            // dodajStrażakaToolStripMenuItem
            // 
            this.dodajStrażakaToolStripMenuItem.Name = "dodajStrażakaToolStripMenuItem";
            this.dodajStrażakaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajStrażakaToolStripMenuItem.Text = "Dodaj strażaka";
            this.dodajStrażakaToolStripMenuItem.Click += new System.EventHandler(this.dodajStrażakaToolStripMenuItem_Click);
            // 
            // dodajPojazdToolStripMenuItem
            // 
            this.dodajPojazdToolStripMenuItem.Name = "dodajPojazdToolStripMenuItem";
            this.dodajPojazdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajPojazdToolStripMenuItem.Text = "Dodaj pojazd";
            this.dodajPojazdToolStripMenuItem.Click += new System.EventHandler(this.dodajPojazdToolStripMenuItem_Click);
            // 
            // dodajWyjazdToolStripMenuItem
            // 
            this.dodajWyjazdToolStripMenuItem.Name = "dodajWyjazdToolStripMenuItem";
            this.dodajWyjazdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajWyjazdToolStripMenuItem.Text = "Dodaj wyjazd";
            this.dodajWyjazdToolStripMenuItem.Click += new System.EventHandler(this.dodajWyjazdToolStripMenuItem_Click);
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaStrażakówToolStripMenuItem,
            this.listaPojazdówToolStripMenuItem,
            this.listaWyjazdówToolStripMenuItem});
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.daneToolStripMenuItem.Text = "Dane";
            // 
            // listaStrażakówToolStripMenuItem
            // 
            this.listaStrażakówToolStripMenuItem.Name = "listaStrażakówToolStripMenuItem";
            this.listaStrażakówToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaStrażakówToolStripMenuItem.Text = "Lista strażaków";
            this.listaStrażakówToolStripMenuItem.Click += new System.EventHandler(this.listaStrażakówToolStripMenuItem_Click);
            // 
            // listaPojazdówToolStripMenuItem
            // 
            this.listaPojazdówToolStripMenuItem.Name = "listaPojazdówToolStripMenuItem";
            this.listaPojazdówToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaPojazdówToolStripMenuItem.Text = "Lista pojazdów";
            this.listaPojazdówToolStripMenuItem.Click += new System.EventHandler(this.listaPojazdówToolStripMenuItem_Click);
            // 
            // listaWyjazdówToolStripMenuItem
            // 
            this.listaWyjazdówToolStripMenuItem.Name = "listaWyjazdówToolStripMenuItem";
            this.listaWyjazdówToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaWyjazdówToolStripMenuItem.Text = "Lista wyjazdów";
            this.listaWyjazdówToolStripMenuItem.Click += new System.EventHandler(this.listaWyjazdówToolStripMenuItem_Click);
            // 
            // formularzeToolStripMenuItem
            // 
            this.formularzeToolStripMenuItem.Name = "formularzeToolStripMenuItem";
            this.formularzeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.formularzeToolStripMenuItem.Text = "Formularze";
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uszeregujWPoziomieToolStripMenuItem,
            this.uszeregujWPionieToolStripMenuItem,
            this.uszeregujKaskadowoToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // uszeregujWPoziomieToolStripMenuItem
            // 
            this.uszeregujWPoziomieToolStripMenuItem.Name = "uszeregujWPoziomieToolStripMenuItem";
            this.uszeregujWPoziomieToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.uszeregujWPoziomieToolStripMenuItem.Text = "Uszereguj w poziomie";
            this.uszeregujWPoziomieToolStripMenuItem.Click += new System.EventHandler(this.uszeregujWPoziomieToolStripMenuItem_Click);
            // 
            // uszeregujWPionieToolStripMenuItem
            // 
            this.uszeregujWPionieToolStripMenuItem.Name = "uszeregujWPionieToolStripMenuItem";
            this.uszeregujWPionieToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.uszeregujWPionieToolStripMenuItem.Text = "Uszereguj w pionie";
            this.uszeregujWPionieToolStripMenuItem.Click += new System.EventHandler(this.uszeregujWPionieToolStripMenuItem_Click);
            // 
            // uszeregujKaskadowoToolStripMenuItem
            // 
            this.uszeregujKaskadowoToolStripMenuItem.Name = "uszeregujKaskadowoToolStripMenuItem";
            this.uszeregujKaskadowoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.uszeregujKaskadowoToolStripMenuItem.Text = "Uszereguj kaskadowo";
            this.uszeregujKaskadowoToolStripMenuItem.Click += new System.EventHandler(this.uszeregujKaskadowoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 842);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1627, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(298, 17);
            this.toolStripStatusLabel1.Text = "Program prowadzenia statystyk OSP- wyk. Marcin Guzy";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1627, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 22);
            this.toolStripButton1.Text = "Dodaj strażaka";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(96, 22);
            this.toolStripButton2.Text = "Dodaj pojazd";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton3.Text = "Dodaj wyjazd";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // MenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 864);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuGlowne";
            this.Text = "OSP Czarna Sędziszowska";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStrażakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPojazdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajWyjazdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaStrażakówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPojazdówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaWyjazdówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem formularzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uszeregujWPoziomieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uszeregujWPionieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uszeregujKaskadowoToolStripMenuItem;
    }
}

