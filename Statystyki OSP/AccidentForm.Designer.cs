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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccidentForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.accidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxPojazd = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.comboBoxDowodca = new System.Windows.Forms.ComboBox();
            this.firemanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxKierowca = new System.Windows.Forms.ComboBox();
            this.comboBoxIRota = new System.Windows.Forms.ComboBox();
            this.comboBoxIRotaPomoc = new System.Windows.Forms.ComboBox();
            this.comboBoxIIRota = new System.Windows.Forms.ComboBox();
            this.comboBoxIIRotaPomoc = new System.Windows.Forms.ComboBox();
            this.comboBoxIIIRota = new System.Windows.Forms.ComboBox();
            this.comboBoxIIIRotaPomoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accidentBindingSource, "Opis", true));
            this.textBox1.Location = new System.Drawing.Point(135, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 70);
            this.textBox1.TabIndex = 2;
            // 
            // accidentBindingSource
            // 
            this.accidentBindingSource.DataSource = typeof(Statystyki_OSP.Dane.Accident);
            // 
            // comboBoxPojazd
            // 
            this.comboBoxPojazd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxPojazd.DataSource = this.vehicleBindingSource;
            this.comboBoxPojazd.DisplayMember = "Marka";
            this.comboBoxPojazd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPojazd.FormattingEnabled = true;
            this.comboBoxPojazd.Location = new System.Drawing.Point(135, 114);
            this.comboBoxPojazd.Name = "comboBoxPojazd";
            this.comboBoxPojazd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPojazd.TabIndex = 4;
            this.comboBoxPojazd.ValueMember = "VehicleId";
            
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(Statystyki_OSP.Dane.Vehicle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data/Godzina wyjazdu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pojazd";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accidentBindingSource, "DataWyjazdu", true));
            this.dateTimePicker3.Location = new System.Drawing.Point(135, 88);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(150, 379);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(96, 37);
            this.buttonZapisz.TabIndex = 13;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(312, 379);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(96, 37);
            this.buttonZamknij.TabIndex = 14;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // comboBoxDowodca
            // 
            this.comboBoxDowodca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxDowodca.DataSource = this.firemanBindingSource;
            this.comboBoxDowodca.DisplayMember = "Nazwisko";
            this.comboBoxDowodca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDowodca.FormattingEnabled = true;
            this.comboBoxDowodca.Location = new System.Drawing.Point(135, 141);
            this.comboBoxDowodca.Name = "comboBoxDowodca";
            this.comboBoxDowodca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDowodca.TabIndex = 15;
            this.comboBoxDowodca.ValueMember = "FiremanId";
            // 
            // firemanBindingSource
            // 
            this.firemanBindingSource.DataSource = typeof(Statystyki_OSP.Dane.Fireman);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dowódca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "I rota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "I rota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "III rota ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "II rota";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "III rota";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "II rota";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Kierowca";
            // 
            // comboBoxKierowca
            // 
            this.comboBoxKierowca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxKierowca.DataSource = this.firemanBindingSource;
            this.comboBoxKierowca.DisplayMember = "Nazwisko";
            this.comboBoxKierowca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKierowca.FormattingEnabled = true;
            this.comboBoxKierowca.Location = new System.Drawing.Point(135, 168);
            this.comboBoxKierowca.Name = "comboBoxKierowca";
            this.comboBoxKierowca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKierowca.TabIndex = 31;
            this.comboBoxKierowca.ValueMember = "FiremanId";
            // 
            // comboBoxIRota
            // 
            this.comboBoxIRota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxIRota.DataSource = this.firemanBindingSource;
            this.comboBoxIRota.DisplayMember = "Nazwisko";
            this.comboBoxIRota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIRota.FormattingEnabled = true;
            this.comboBoxIRota.Location = new System.Drawing.Point(135, 195);
            this.comboBoxIRota.Name = "comboBoxIRota";
            this.comboBoxIRota.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIRota.TabIndex = 32;
            this.comboBoxIRota.ValueMember = "FiremanId";
            // 
            // comboBoxIRotaPomoc
            // 
            this.comboBoxIRotaPomoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxIRotaPomoc.DataSource = this.firemanBindingSource;
            this.comboBoxIRotaPomoc.DisplayMember = "Nazwisko";
            this.comboBoxIRotaPomoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIRotaPomoc.FormattingEnabled = true;
            this.comboBoxIRotaPomoc.Location = new System.Drawing.Point(135, 222);
            this.comboBoxIRotaPomoc.Name = "comboBoxIRotaPomoc";
            this.comboBoxIRotaPomoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIRotaPomoc.TabIndex = 33;
            this.comboBoxIRotaPomoc.ValueMember = "FiremanId";
            // 
            // comboBoxIIRota
            // 
            this.comboBoxIIRota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxIIRota.DataSource = this.firemanBindingSource;
            this.comboBoxIIRota.DisplayMember = "Nazwisko";
            this.comboBoxIIRota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIIRota.FormattingEnabled = true;
            this.comboBoxIIRota.Location = new System.Drawing.Point(135, 249);
            this.comboBoxIIRota.Name = "comboBoxIIRota";
            this.comboBoxIIRota.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIIRota.TabIndex = 34;
            this.comboBoxIIRota.ValueMember = "FiremanId";
            // 
            // comboBoxIIRotaPomoc
            // 
            this.comboBoxIIRotaPomoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxIIRotaPomoc.DataSource = this.firemanBindingSource;
            this.comboBoxIIRotaPomoc.DisplayMember = "Nazwisko";
            this.comboBoxIIRotaPomoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIIRotaPomoc.FormattingEnabled = true;
            this.comboBoxIIRotaPomoc.Location = new System.Drawing.Point(135, 276);
            this.comboBoxIIRotaPomoc.Name = "comboBoxIIRotaPomoc";
            this.comboBoxIIRotaPomoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIIRotaPomoc.TabIndex = 35;
            this.comboBoxIIRotaPomoc.ValueMember = "FiremanId";
            // 
            // comboBoxIIIRota
            // 
            this.comboBoxIIIRota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxIIIRota.DataSource = this.firemanBindingSource;
            this.comboBoxIIIRota.DisplayMember = "Nazwisko";
            this.comboBoxIIIRota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIIIRota.FormattingEnabled = true;
            this.comboBoxIIIRota.Location = new System.Drawing.Point(135, 303);
            this.comboBoxIIIRota.Name = "comboBoxIIIRota";
            this.comboBoxIIIRota.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIIIRota.TabIndex = 36;
            this.comboBoxIIIRota.ValueMember = "FiremanId";
            // 
            // comboBoxIIIRotaPomoc
            // 
            this.comboBoxIIIRotaPomoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Marka", true));
            this.comboBoxIIIRotaPomoc.DataSource = this.firemanBindingSource;
            this.comboBoxIIIRotaPomoc.DisplayMember = "Nazwisko";
            this.comboBoxIIIRotaPomoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIIIRotaPomoc.FormattingEnabled = true;
            this.comboBoxIIIRotaPomoc.Location = new System.Drawing.Point(135, 330);
            this.comboBoxIIIRotaPomoc.Name = "comboBoxIIIRotaPomoc";
            this.comboBoxIIIRotaPomoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIIIRotaPomoc.TabIndex = 37;
            this.comboBoxIIIRotaPomoc.ValueMember = "FiremanId";
            // 
            // AccidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 428);
            this.Controls.Add(this.comboBoxIIIRotaPomoc);
            this.Controls.Add(this.comboBoxIIIRota);
            this.Controls.Add(this.comboBoxIIRotaPomoc);
            this.Controls.Add(this.comboBoxIIRota);
            this.Controls.Add(this.comboBoxIRotaPomoc);
            this.Controls.Add(this.comboBoxIRota);
            this.Controls.Add(this.comboBoxKierowca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDowodca);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPojazd);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccidentForm";
            this.Text = "AccidentForm";
            this.Load += new System.EventHandler(this.AccidentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firemanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxPojazd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.BindingSource accidentBindingSource;
        private System.Windows.Forms.ComboBox comboBoxDowodca;
        private System.Windows.Forms.BindingSource firemanBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxKierowca;
        private System.Windows.Forms.ComboBox comboBoxIRota;
        private System.Windows.Forms.ComboBox comboBoxIRotaPomoc;
        private System.Windows.Forms.ComboBox comboBoxIIRota;
        private System.Windows.Forms.ComboBox comboBoxIIRotaPomoc;
        private System.Windows.Forms.ComboBox comboBoxIIIRota;
        private System.Windows.Forms.ComboBox comboBoxIIIRotaPomoc;
    }
}