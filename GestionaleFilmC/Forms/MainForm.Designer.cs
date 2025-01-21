namespace GestionaleFilmC.Forms
{
    partial class MainForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRuolo = new System.Windows.Forms.Label();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label1";
            // 
            // lblRuolo
            // 
            this.lblRuolo.AutoSize = true;
            this.lblRuolo.Location = new System.Drawing.Point(159, 9);
            this.lblRuolo.Name = "lblRuolo";
            this.lblRuolo.Size = new System.Drawing.Size(44, 16);
            this.lblRuolo.TabIndex = 1;
            this.lblRuolo.Text = "label2";
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Location = new System.Drawing.Point(2, 75);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.RowHeadersWidth = 51;
            this.dgvFilms.RowTemplate.Height = 24;
            this.dgvFilms.Size = new System.Drawing.Size(1063, 554);
            this.dgvFilms.TabIndex = 2;
            this.dgvFilms.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilms_CellContentDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 641);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.lblRuolo);
            this.Controls.Add(this.lblNome);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRuolo;
        private System.Windows.Forms.DataGridView dgvFilms;
    }
}