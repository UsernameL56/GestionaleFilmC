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
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(184, 87);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(44, 16);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "label1";
            // 
            // lblDataUscita
            // 
            this.lblDataUscita.AutoSize = true;
            this.lblDataUscita.Location = new System.Drawing.Point(253, 101);
            this.lblDataUscita.Name = "lblDataUscita";
            this.lblDataUscita.Size = new System.Drawing.Size(44, 16);
            this.lblDataUscita.TabIndex = 1;
            this.lblDataUscita.Text = "label2";
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(307, 127);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(44, 16);
            this.lblDurata.TabIndex = 2;
            this.lblDurata.Text = "label3";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(372, 199);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(203, 118);
            this.txtDescrizione.TabIndex = 4;
            // 
            // dgvComments
            // 
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Location = new System.Drawing.Point(640, 153);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 24;
            this.dgvComments.Size = new System.Drawing.Size(240, 150);
            this.dgvComments.TabIndex = 5;
            // 
            // FilmDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 645);
            this.Controls.Add(this.dgvComments);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.lblDurata);
            this.Controls.Add(this.lblDataUscita);
            this.Controls.Add(this.lblTitolo);
            this.Name = "FilmDetailsForm";
            this.Text = "FilmDetailsForm";
            this.Load += new System.EventHandler(this.FilmDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblDataUscita;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.DataGridView dgvComments;
    }
}