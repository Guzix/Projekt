namespace Statystyki_OSP
{
    partial class AccidentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccidentListForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.buttonOdswiez = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.accidentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWyjazduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firemanNameKierowcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firemanNameDowodcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firemanNameIRotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firemanNameIRotaPomocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firemanNameIIRotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firemanNameIIRotaPomocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firemanNameIIIRotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firemanNameIIIRotaPomocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opisDataGridViewTextBoxColumn,
            this.dataWyjazduDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn,
            this.firemanNameKierowcaDataGridViewTextBoxColumn,
            this.firemanNameDowodcaDataGridViewTextBoxColumn,
            this.firemanNameIRotaDataGridViewTextBoxColumn,
            this.firemanNameIRotaPomocDataGridViewTextBoxColumn,
            this.firemanNameIIRotaDataGridViewTextBoxColumn,
            this.firemanNameIIRotaPomocDataGridViewTextBoxColumn,
            this.firemanNameIIIRotaDataGridViewTextBoxColumn,
            this.firemanNameIIIRotaPomocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accidentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // accidentBindingSource
            // 
            this.accidentBindingSource.DataSource = typeof(Statystyki_OSP.Dane.Accident);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(1143, 404);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(91, 39);
            this.buttonZamknij.TabIndex = 8;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.Location = new System.Drawing.Point(206, 404);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(91, 39);
            this.buttonOdswiez.TabIndex = 7;
            this.buttonOdswiez.Text = "Odśwież";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            this.buttonOdswiez.Click += new System.EventHandler(this.buttonOdswiez_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(109, 404);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(91, 39);
            this.buttonEdytuj.TabIndex = 6;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 404);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(91, 39);
            this.buttonDodaj.TabIndex = 5;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // accidentBindingSource1
            // 
            this.accidentBindingSource1.DataSource = typeof(Statystyki_OSP.Dane.Accident);
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataWyjazduDataGridViewTextBoxColumn
            // 
            this.dataWyjazduDataGridViewTextBoxColumn.DataPropertyName = "DataWyjazdu";
            this.dataWyjazduDataGridViewTextBoxColumn.HeaderText = "Data Wyjazdu";
            this.dataWyjazduDataGridViewTextBoxColumn.Name = "dataWyjazduDataGridViewTextBoxColumn";
            this.dataWyjazduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleModelDataGridViewTextBoxColumn
            // 
            this.vehicleModelDataGridViewTextBoxColumn.DataPropertyName = "VehicleModel";
            this.vehicleModelDataGridViewTextBoxColumn.HeaderText = "Pojazd";
            this.vehicleModelDataGridViewTextBoxColumn.Name = "vehicleModelDataGridViewTextBoxColumn";
            this.vehicleModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firemanNameKierowcaDataGridViewTextBoxColumn
            // 
            this.firemanNameKierowcaDataGridViewTextBoxColumn.DataPropertyName = "FiremanNameKierowca";
            this.firemanNameKierowcaDataGridViewTextBoxColumn.HeaderText = "Kierowca";
            this.firemanNameKierowcaDataGridViewTextBoxColumn.Name = "firemanNameKierowcaDataGridViewTextBoxColumn";
            this.firemanNameKierowcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firemanNameDowodcaDataGridViewTextBoxColumn
            // 
            this.firemanNameDowodcaDataGridViewTextBoxColumn.DataPropertyName = "FiremanNameDowodca";
            this.firemanNameDowodcaDataGridViewTextBoxColumn.HeaderText = "Dowodca";
            this.firemanNameDowodcaDataGridViewTextBoxColumn.Name = "firemanNameDowodcaDataGridViewTextBoxColumn";
            this.firemanNameDowodcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firemanNameIRotaDataGridViewTextBoxColumn
            // 
            this.firemanNameIRotaDataGridViewTextBoxColumn.DataPropertyName = "FiremanNameIRota";
            this.firemanNameIRotaDataGridViewTextBoxColumn.HeaderText = "I Rota";
            this.firemanNameIRotaDataGridViewTextBoxColumn.Name = "firemanNameIRotaDataGridViewTextBoxColumn";
            this.firemanNameIRotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firemanNameIRotaPomocDataGridViewTextBoxColumn
            // 
            this.firemanNameIRotaPomocDataGridViewTextBoxColumn.DataPropertyName = "FiremanNameIRotaPomoc";
            this.firemanNameIRotaPomocDataGridViewTextBoxColumn.HeaderText = "I Rota Pomoc";
            this.firemanNameIRotaPomocDataGridViewTextBoxColumn.Name = "firemanNameIRotaPomocDataGridViewTextBoxColumn";
            this.firemanNameIRotaPomocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firemanNameIIRotaDataGridViewTextBoxColumn
            // 
            this.firemanNameIIRotaDataGridViewTextBoxColumn.DataPropertyName = "FiremanNameIIRota";
            this.firemanNameIIRotaDataGridViewTextBoxColumn.HeaderText = "II Rota";
            this.firemanNameIIRotaDataGridViewTextBoxColumn.Name = "firemanNameIIRotaDataGridViewTextBoxColumn";
            this.firemanNameIIRotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firemanNameIIRotaPomocDataGridViewTextBoxColumn
            // 
            this.firemanNameIIRotaPomocDataGridViewTextBoxColumn.DataPropertyName = "FiremanNameIIRotaPomoc";
            this.firemanNameIIRotaPomocDataGridViewTextBoxColumn.HeaderText = "II Rota Pomoc";
            this.firemanNameIIRotaPomocDataGridViewTextBoxColumn.Name = "firemanNameIIRotaPomocDataGridViewTextBoxColumn";
            this.firemanNameIIRotaPomocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firemanNameIIIRotaDataGridViewTextBoxColumn
            // 
            this.firemanNameIIIRotaDataGridViewTextBoxColumn.DataPropertyName = "FiremanNameIIIRota";
            this.firemanNameIIIRotaDataGridViewTextBoxColumn.HeaderText = "III Rota";
            this.firemanNameIIIRotaDataGridViewTextBoxColumn.Name = "firemanNameIIIRotaDataGridViewTextBoxColumn";
            this.firemanNameIIIRotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firemanNameIIIRotaPomocDataGridViewTextBoxColumn
            // 
            this.firemanNameIIIRotaPomocDataGridViewTextBoxColumn.DataPropertyName = "FiremanNameIIIRotaPomoc";
            this.firemanNameIIIRotaPomocDataGridViewTextBoxColumn.HeaderText = "III Rota Pomoc";
            this.firemanNameIIIRotaPomocDataGridViewTextBoxColumn.Name = "firemanNameIIIRotaPomocDataGridViewTextBoxColumn";
            this.firemanNameIIIRotaPomocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AccidentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 446);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonOdswiez);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccidentListForm";
            this.Text = "Lista wyjazdów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource accidentBindingSource;
        private System.Windows.Forms.BindingSource accidentBindingSource1;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Button buttonOdswiez;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWyjazduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firemanNameKierowcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firemanNameDowodcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firemanNameIRotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firemanNameIRotaPomocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firemanNameIIRotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firemanNameIIRotaPomocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firemanNameIIIRotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firemanNameIIIRotaPomocDataGridViewTextBoxColumn;
    }
}