namespace Statystyki_OSP
{
    partial class AccidentForm
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
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.comboBoxPojazd = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxKierowca = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDowodca = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxIRota = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxIRotaPomoc = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxIIRota = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxIIRotaPomoc = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxIIIRota = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxIIIRotaPomoc = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.accidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(12, 396);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(102, 42);
            this.buttonZapisz.TabIndex = 0;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(304, 396);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(102, 42);
            this.buttonZamknij.TabIndex = 1;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxPojazd
            // 
            this.comboBoxPojazd.DataSource = this.vehicleBindingSource;
            this.comboBoxPojazd.DisplayMember = "Marka";
            this.comboBoxPojazd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPojazd.FormattingEnabled = true;
            this.comboBoxPojazd.Location = new System.Drawing.Point(103, 126);
            this.comboBoxPojazd.Name = "comboBoxPojazd";
            this.comboBoxPojazd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPojazd.TabIndex = 2;
            this.comboBoxPojazd.ValueMember = "VehicleId";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(Statystyki_OSP.Dane.Vehicle);
            // 
            // comboBoxKierowca
            // 
            this.comboBoxKierowca.DataSource = this.firemanBindingSource;
            this.comboBoxKierowca.DisplayMember = "Nazwisko";
            this.comboBoxKierowca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKierowca.FormattingEnabled = true;
            this.comboBoxKierowca.Location = new System.Drawing.Point(103, 154);
            this.comboBoxKierowca.Name = "comboBoxKierowca";
            this.comboBoxKierowca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKierowca.TabIndex = 3;
            this.comboBoxKierowca.ValueMember = "FiremanId";
            // 
            // firemanBindingSource
            // 
            this.firemanBindingSource.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // comboBoxDowodca
            // 
            this.comboBoxDowodca.DataSource = this.firemanBindingSource1;
            this.comboBoxDowodca.DisplayMember = "Nazwisko";
            this.comboBoxDowodca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDowodca.FormattingEnabled = true;
            this.comboBoxDowodca.Location = new System.Drawing.Point(103, 182);
            this.comboBoxDowodca.Name = "comboBoxDowodca";
            this.comboBoxDowodca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDowodca.TabIndex = 4;
            this.comboBoxDowodca.ValueMember = "FiremanId";
            // 
            // firemanBindingSource1
            // 
            this.firemanBindingSource1.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // comboBoxIRota
            // 
            this.comboBoxIRota.DataSource = this.firemanBindingSource2;
            this.comboBoxIRota.DisplayMember = "Nazwisko";
            this.comboBoxIRota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIRota.FormattingEnabled = true;
            this.comboBoxIRota.Location = new System.Drawing.Point(103, 210);
            this.comboBoxIRota.Name = "comboBoxIRota";
            this.comboBoxIRota.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIRota.TabIndex = 5;
            this.comboBoxIRota.ValueMember = "FiremanId";
            // 
            // firemanBindingSource2
            // 
            this.firemanBindingSource2.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // comboBoxIRotaPomoc
            // 
            this.comboBoxIRotaPomoc.DataSource = this.firemanBindingSource3;
            this.comboBoxIRotaPomoc.DisplayMember = "Nazwisko";
            this.comboBoxIRotaPomoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIRotaPomoc.FormattingEnabled = true;
            this.comboBoxIRotaPomoc.Location = new System.Drawing.Point(103, 238);
            this.comboBoxIRotaPomoc.Name = "comboBoxIRotaPomoc";
            this.comboBoxIRotaPomoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIRotaPomoc.TabIndex = 6;
            this.comboBoxIRotaPomoc.ValueMember = "FiremanId";
            // 
            // firemanBindingSource3
            // 
            this.firemanBindingSource3.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // comboBoxIIRota
            // 
            this.comboBoxIIRota.DataSource = this.firemanBindingSource4;
            this.comboBoxIIRota.DisplayMember = "Nazwisko";
            this.comboBoxIIRota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIIRota.FormattingEnabled = true;
            this.comboBoxIIRota.Location = new System.Drawing.Point(103, 266);
            this.comboBoxIIRota.Name = "comboBoxIIRota";
            this.comboBoxIIRota.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIIRota.TabIndex = 7;
            this.comboBoxIIRota.ValueMember = "FiremanId";
            // 
            // firemanBindingSource4
            // 
            this.firemanBindingSource4.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // comboBoxIIRotaPomoc
            // 
            this.comboBoxIIRotaPomoc.DataSource = this.firemanBindingSource5;
            this.comboBoxIIRotaPomoc.DisplayMember = "Nazwisko";
            this.comboBoxIIRotaPomoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIIRotaPomoc.FormattingEnabled = true;
            this.comboBoxIIRotaPomoc.Location = new System.Drawing.Point(103, 294);
            this.comboBoxIIRotaPomoc.Name = "comboBoxIIRotaPomoc";
            this.comboBoxIIRotaPomoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIIRotaPomoc.TabIndex = 8;
            this.comboBoxIIRotaPomoc.ValueMember = "FiremanId";
            // 
            // firemanBindingSource5
            // 
            this.firemanBindingSource5.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // comboBoxIIIRota
            // 
            this.comboBoxIIIRota.DataSource = this.firemanBindingSource6;
            this.comboBoxIIIRota.DisplayMember = "Nazwisko";
            this.comboBoxIIIRota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIIIRota.FormattingEnabled = true;
            this.comboBoxIIIRota.Location = new System.Drawing.Point(103, 322);
            this.comboBoxIIIRota.Name = "comboBoxIIIRota";
            this.comboBoxIIIRota.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIIIRota.TabIndex = 9;
            this.comboBoxIIIRota.ValueMember = "FiremanId";
            // 
            // firemanBindingSource6
            // 
            this.firemanBindingSource6.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // comboBoxIIIRotaPomoc
            // 
            this.comboBoxIIIRotaPomoc.DataSource = this.firemanBindingSource7;
            this.comboBoxIIIRotaPomoc.DisplayMember = "Nazwisko";
            this.comboBoxIIIRotaPomoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIIIRotaPomoc.FormattingEnabled = true;
            this.comboBoxIIIRotaPomoc.Location = new System.Drawing.Point(103, 350);
            this.comboBoxIIIRotaPomoc.Name = "comboBoxIIIRotaPomoc";
            this.comboBoxIIIRotaPomoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIIIRotaPomoc.TabIndex = 10;
            this.comboBoxIIIRotaPomoc.ValueMember = "FiremanId";
            // 
            // firemanBindingSource7
            // 
            this.firemanBindingSource7.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accidentBindingSource, "DataWyjazdu", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // accidentBindingSource
            // 
            this.accidentBindingSource.DataSource = typeof(Statystyki_OSP.Dane.Accident);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accidentBindingSource, "Opis", true));
            this.textBox1.Location = new System.Drawing.Point(103, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 82);
            this.textBox1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Kierowca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "II rota";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "III rota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "II rota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "III rota ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "I rota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "I rota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Dowódca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Pojazd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Data wyjazdu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Opis";
            // 
            // AccidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 453);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxIIIRotaPomoc);
            this.Controls.Add(this.comboBoxIIIRota);
            this.Controls.Add(this.comboBoxIIRotaPomoc);
            this.Controls.Add(this.comboBoxIIRota);
            this.Controls.Add(this.comboBoxIRotaPomoc);
            this.Controls.Add(this.comboBoxIRota);
            this.Controls.Add(this.comboBoxDowodca);
            this.Controls.Add(this.comboBoxKierowca);
            this.Controls.Add(this.comboBoxPojazd);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonZapisz);
            this.Name = "AccidentForm";
            this.Text = "TestAccident";
            this.Load += new System.EventHandler(this.TestAccident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.ComboBox comboBoxDowodca;
        private System.Windows.Forms.ComboBox comboBoxIRota;
        private System.Windows.Forms.ComboBox comboBoxIRotaPomoc;
        private System.Windows.Forms.ComboBox comboBoxIIRota;
        private System.Windows.Forms.ComboBox comboBoxIIRotaPomoc;
        private System.Windows.Forms.ComboBox comboBoxIIIRota;
        private System.Windows.Forms.ComboBox comboBoxIIIRotaPomoc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource accidentBindingSource;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.BindingSource firemanBindingSource;
        private System.Windows.Forms.BindingSource firemanBindingSource1;
        private System.Windows.Forms.BindingSource firemanBindingSource2;
        private System.Windows.Forms.BindingSource firemanBindingSource3;
        private System.Windows.Forms.BindingSource firemanBindingSource4;
        private System.Windows.Forms.BindingSource firemanBindingSource5;
        private System.Windows.Forms.BindingSource firemanBindingSource6;
        private System.Windows.Forms.BindingSource firemanBindingSource7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPojazd;
        private System.Windows.Forms.ComboBox comboBoxKierowca;
    }
}