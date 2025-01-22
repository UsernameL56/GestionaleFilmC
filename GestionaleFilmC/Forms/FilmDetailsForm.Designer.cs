namespace GestionaleFilmC.Forms
{
    partial class FilmDetailsForm
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblDataUscita = new System.Windows.Forms.Label();
            this.lblDurata = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numValutazione = new System.Windows.Forms.NumericUpDown();
            this.btnInviaCommento = new System.Windows.Forms.Button();
            this.txtCommento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValutazione)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(121, 21);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(44, 16);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "label1";
            // 
            // lblDataUscita
            // 
            this.lblDataUscita.AutoSize = true;
            this.lblDataUscita.Location = new System.Drawing.Point(121, 71);
            this.lblDataUscita.Name = "lblDataUscita";
            this.lblDataUscita.Size = new System.Drawing.Size(44, 16);
            this.lblDataUscita.TabIndex = 1;
            this.lblDataUscita.Text = "label2";
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(121, 113);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(44, 16);
            this.lblDurata.TabIndex = 2;
            this.lblDurata.Text = "label3";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescrizione.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescrizione.Location = new System.Drawing.Point(124, 165);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.ReadOnly = true;
            this.txtDescrizione.Size = new System.Drawing.Size(383, 192);
            this.txtDescrizione.TabIndex = 4;
            // 
            // dgvComments
            // 
            this.dgvComments.AllowUserToAddRows = false;
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Location = new System.Drawing.Point(15, 51);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.ReadOnly = true;
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 24;
            this.dgvComments.Size = new System.Drawing.Size(839, 552);
            this.dgvComments.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDescrizione);
            this.panel1.Controls.Add(this.lblDataUscita);
            this.panel1.Controls.Add(this.lblDurata);
            this.panel1.Controls.Add(this.lblTitolo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 372);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Uscita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Durata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titolo";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dgvComments);
            this.panel2.Location = new System.Drawing.Point(565, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 621);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.numValutazione);
            this.panel3.Controls.Add(this.btnInviaCommento);
            this.panel3.Controls.Add(this.txtCommento);
            this.panel3.Location = new System.Drawing.Point(12, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 242);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Commento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valutazione";
            // 
            // numValutazione
            // 
            this.numValutazione.Location = new System.Drawing.Point(115, 42);
            this.numValutazione.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numValutazione.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numValutazione.Name = "numValutazione";
            this.numValutazione.Size = new System.Drawing.Size(61, 22);
            this.numValutazione.TabIndex = 2;
            this.numValutazione.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInviaCommento
            // 
            this.btnInviaCommento.Location = new System.Drawing.Point(159, 201);
            this.btnInviaCommento.Name = "btnInviaCommento";
            this.btnInviaCommento.Size = new System.Drawing.Size(197, 23);
            this.btnInviaCommento.TabIndex = 1;
            this.btnInviaCommento.Text = "Invia";
            this.btnInviaCommento.UseVisualStyleBackColor = true;
            this.btnInviaCommento.Click += new System.EventHandler(this.btnInviaCommento_Click);
            // 
            // txtCommento
            // 
            this.txtCommento.Location = new System.Drawing.Point(115, 75);
            this.txtCommento.Multiline = true;
            this.txtCommento.Name = "txtCommento";
            this.txtCommento.Size = new System.Drawing.Size(392, 93);
            this.txtCommento.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Scrivi un commento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Commenti";
            // 
            // FilmDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FilmDetailsForm";
            this.Text = "FilmDetailsForm";
            this.Load += new System.EventHandler(this.FilmDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValutazione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblDataUscita;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numValutazione;
        private System.Windows.Forms.Button btnInviaCommento;
        private System.Windows.Forms.TextBox txtCommento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}