namespace Statystyki_OSP
{
    partial class FiremanListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firemanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badaniaWazneDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursPodstawowyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kursTechnicznyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kursDowodcyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kursPilarzaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kPPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prawoJazdyCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonOdswiez = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.badaniaWazneDoDataGridViewTextBoxColumn,
            this.kursPodstawowyDataGridViewCheckBoxColumn,
            this.kursTechnicznyDataGridViewCheckBoxColumn,
            this.kursDowodcyDataGridViewCheckBoxColumn,
            this.kursPilarzaDataGridViewCheckBoxColumn,
            this.kPPDataGridViewCheckBoxColumn,
            this.prawoJazdyCDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.firemanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(933, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // firemanBindingSource
            // 
            this.firemanBindingSource.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "Data Urodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // badaniaWazneDoDataGridViewTextBoxColumn
            // 
            this.badaniaWazneDoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.badaniaWazneDoDataGridViewTextBoxColumn.DataPropertyName = "BadaniaWazneDo";
            this.badaniaWazneDoDataGridViewTextBoxColumn.HeaderText = "Badania Wazne Do";
            this.badaniaWazneDoDataGridViewTextBoxColumn.Name = "badaniaWazneDoDataGridViewTextBoxColumn";
            this.badaniaWazneDoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kursPodstawowyDataGridViewCheckBoxColumn
            // 
            this.kursPodstawowyDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kursPodstawowyDataGridViewCheckBoxColumn.DataPropertyName = "KursPodstawowy";
            this.kursPodstawowyDataGridViewCheckBoxColumn.HeaderText = "Kurs Podstawowy";
            this.kursPodstawowyDataGridViewCheckBoxColumn.Name = "kursPodstawowyDataGridViewCheckBoxColumn";
            this.kursPodstawowyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kursTechnicznyDataGridViewCheckBoxColumn
            // 
            this.kursTechnicznyDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kursTechnicznyDataGridViewCheckBoxColumn.DataPropertyName = "KursTechniczny";
            this.kursTechnicznyDataGridViewCheckBoxColumn.HeaderText = "Kurs Techniczny";
            this.kursTechnicznyDataGridViewCheckBoxColumn.Name = "kursTechnicznyDataGridViewCheckBoxColumn";
            this.kursTechnicznyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kursDowodcyDataGridViewCheckBoxColumn
            // 
            this.kursDowodcyDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kursDowodcyDataGridViewCheckBoxColumn.DataPropertyName = "KursDowodcy";
            this.kursDowodcyDataGridViewCheckBoxColumn.HeaderText = "Kurs Dowodcy";
            this.kursDowodcyDataGridViewCheckBoxColumn.Name = "kursDowodcyDataGridViewCheckBoxColumn";
            this.kursDowodcyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kursPilarzaDataGridViewCheckBoxColumn
            // 
            this.kursPilarzaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kursPilarzaDataGridViewCheckBoxColumn.DataPropertyName = "KursPilarza";
            this.kursPilarzaDataGridViewCheckBoxColumn.HeaderText = "Kurs Pilarza";
            this.kursPilarzaDataGridViewCheckBoxColumn.Name = "kursPilarzaDataGridViewCheckBoxColumn";
            this.kursPilarzaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kPPDataGridViewCheckBoxColumn
            // 
            this.kPPDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kPPDataGridViewCheckBoxColumn.DataPropertyName = "KPP";
            this.kPPDataGridViewCheckBoxColumn.HeaderText = "KPP";
            this.kPPDataGridViewCheckBoxColumn.Name = "kPPDataGridViewCheckBoxColumn";
            this.kPPDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // prawoJazdyCDataGridViewCheckBoxColumn
            // 
            this.prawoJazdyCDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prawoJazdyCDataGridViewCheckBoxColumn.DataPropertyName = "PrawoJazdyC";
            this.prawoJazdyCDataGridViewCheckBoxColumn.HeaderText = "Prawo Jazdy kat.C";
            this.prawoJazdyCDataGridViewCheckBoxColumn.Name = "prawoJazdyCDataGridViewCheckBoxColumn";
            this.prawoJazdyCDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 409);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(104, 32);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(122, 409);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(104, 32);
            this.buttonEdytuj.TabIndex = 2;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.Location = new System.Drawing.Point(232, 409);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(104, 32);
            this.buttonOdswiez.TabIndex = 3;
            this.buttonOdswiez.Text = "Odśwież";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            this.buttonOdswiez.Click += new System.EventHandler(this.buttonOdswiez_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(815, 409);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(104, 32);
            this.buttonZamknij.TabIndex = 4;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // FiremanListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonOdswiez);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FiremanListForm";
            this.Text = "FiremanListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource firemanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badaniaWazneDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kursPodstawowyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kursTechnicznyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kursDowodcyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kursPilarzaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kPPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prawoJazdyCDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonOdswiez;
        private System.Windows.Forms.Button buttonZamknij;
    }
}