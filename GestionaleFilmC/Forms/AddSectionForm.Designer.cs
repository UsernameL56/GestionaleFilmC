namespace GestionaleFilmC.Forms
{
    partial class AddSectionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.cmbLingua = new System.Windows.Forms.ComboBox();
            this.dtpDataUscita = new System.Windows.Forms.DateTimePicker();
            this.txtGenere = new System.Windows.Forms.TextBox();
            this.btnAggiungiFilm = new System.Windows.Forms.Button();
            this.btnAggiungiGenere = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAggiungiLingua = new System.Windows.Forms.Button();
            this.txtLingua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDurata = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtDurata);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAggiungiFilm);
            this.panel1.Controls.Add(this.dtpDataUscita);
            this.panel1.Controls.Add(this.cmbLingua);
            this.panel1.Controls.Add(this.cmbGenere);
            this.panel1.Controls.Add(this.txtDescrizione);
            this.panel1.Controls.Add(this.txtTitolo);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 620);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAggiungiGenere);
            this.panel2.Controls.Add(this.txtGenere);
            this.panel2.Location = new System.Drawing.Point(487, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 235);
            this.panel2.TabIndex = 1;
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(148, 84);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(277, 22);
            this.txtTitolo.TabIndex = 0;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(148, 200);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(277, 94);
            this.txtDescrizione.TabIndex = 1;
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Location = new System.Drawing.Point(148, 369);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(277, 24);
            this.cmbGenere.TabIndex = 2;
            // 
            // cmbLingua
            // 
            this.cmbLingua.FormattingEnabled = true;
            this.cmbLingua.Location = new System.Drawing.Point(148, 416);
            this.cmbLingua.Name = "cmbLingua";
            this.cmbLingua.Size = new System.Drawing.Size(277, 24);
            this.cmbLingua.TabIndex = 3;
            // 
            // dtpDataUscita
            // 
            this.dtpDataUscita.Location = new System.Drawing.Point(148, 141);
            this.dtpDataUscita.Name = "dtpDataUscita";
            this.dtpDataUscita.Size = new System.Drawing.Size(277, 22);
            this.dtpDataUscita.TabIndex = 4;
            // 
            // txtGenere
            // 
            this.txtGenere.Location = new System.Drawing.Point(172, 84);
            this.txtGenere.Name = "txtGenere";
            this.txtGenere.Size = new System.Drawing.Size(277, 22);
            this.txtGenere.TabIndex = 5;
            // 
            // btnAggiungiFilm
            // 
            this.btnAggiungiFilm.Location = new System.Drawing.Point(148, 503);
            this.btnAggiungiFilm.Name = "btnAggiungiFilm";
            this.btnAggiungiFilm.Size = new System.Drawing.Size(277, 23);
            this.btnAggiungiFilm.TabIndex = 6;
            this.btnAggiungiFilm.Text = "Aggiungi Film";
            this.btnAggiungiFilm.UseVisualStyleBackColor = true;
            this.btnAggiungiFilm.Click += new System.EventHandler(this.btnAggiungiFilm_Click);
            // 
            // btnAggiungiGenere
            // 
            this.btnAggiungiGenere.Location = new System.Drawing.Point(172, 176);
            this.btnAggiungiGenere.Name = "btnAggiungiGenere";
            this.btnAggiungiGenere.Size = new System.Drawing.Size(277, 23);
            this.btnAggiungiGenere.TabIndex = 7;
            this.btnAggiungiGenere.Text = "Aggiungi Genere";
            this.btnAggiungiGenere.UseVisualStyleBackColor = true;
            this.btnAggiungiGenere.Click += new System.EventHandler(this.btnAggiungiGenere_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnAggiungiLingua);
            this.panel4.Controls.Add(this.txtLingua);
            this.panel4.Location = new System.Drawing.Point(487, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 235);
            this.panel4.TabIndex = 8;
            // 
            // btnAggiungiLingua
            // 
            this.btnAggiungiLingua.Location = new System.Drawing.Point(172, 176);
            this.btnAggiungiLingua.Name = "btnAggiungiLingua";
            this.btnAggiungiLingua.Size = new System.Drawing.Size(277, 23);
            this.btnAggiungiLingua.TabIndex = 7;
            this.btnAggiungiLingua.Text = "Aggiungi Lingua";
            this.btnAggiungiLingua.UseVisualStyleBackColor = true;
            this.btnAggiungiLingua.Click += new System.EventHandler(this.btnAggiungiLingua_Click);
            // 
            // txtLingua
            // 
            this.txtLingua.Location = new System.Drawing.Point(172, 84);
            this.txtLingua.Name = "txtLingua";
            this.txtLingua.Size = new System.Drawing.Size(277, 22);
            this.txtLingua.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sezione Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sezione Genere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "SezioneLingua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Titolo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descrizione";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Genere";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lingua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data Uscita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Durata";
            // 
            // txtDurata
            // 
            this.txtDurata.Location = new System.Drawing.Point(148, 318);
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.Size = new System.Drawing.Size(277, 22);
            this.txtDurata.TabIndex = 15;
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 645);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSectionForm";
            this.Text = "AddSectionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAggiungiFilm;
        private System.Windows.Forms.DateTimePicker dtpDataUscita;
        private System.Windows.Forms.ComboBox cmbLingua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAggiungiGenere;
        private System.Windows.Forms.TextBox txtGenere;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungiLingua;
        private System.Windows.Forms.TextBox txtLingua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDurata;
    }
}