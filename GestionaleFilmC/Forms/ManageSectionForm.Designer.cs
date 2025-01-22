namespace GestionaleFilmC.Forms
{
    partial class ManageSectionForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.dgvGeneri = new System.Windows.Forms.DataGridView();
            this.dgvLingue = new System.Windows.Forms.DataGridView();
            this.rbtnModifica = new System.Windows.Forms.RadioButton();
            this.rbtnElimina = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLingue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFilms);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 618);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvLingue);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(1102, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 486);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(343, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 618);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvGeneri);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(759, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 487);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(343, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 618);
            this.panel3.TabIndex = 2;
            // 
            // dgvFilms
            // 
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Location = new System.Drawing.Point(15, 25);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.RowHeadersWidth = 51;
            this.dgvFilms.RowTemplate.Height = 24;
            this.dgvFilms.Size = new System.Drawing.Size(705, 567);
            this.dgvFilms.TabIndex = 0;
            this.dgvFilms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilms_CellDoubleClick);
            // 
            // dgvGeneri
            // 
            this.dgvGeneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneri.Location = new System.Drawing.Point(19, 26);
            this.dgvGeneri.Name = "dgvGeneri";
            this.dgvGeneri.RowHeadersWidth = 51;
            this.dgvGeneri.RowTemplate.Height = 24;
            this.dgvGeneri.Size = new System.Drawing.Size(299, 416);
            this.dgvGeneri.TabIndex = 3;
            // 
            // dgvLingue
            // 
            this.dgvLingue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLingue.Location = new System.Drawing.Point(16, 25);
            this.dgvLingue.Name = "dgvLingue";
            this.dgvLingue.RowHeadersWidth = 51;
            this.dgvLingue.RowTemplate.Height = 24;
            this.dgvLingue.Size = new System.Drawing.Size(299, 416);
            this.dgvLingue.TabIndex = 4;
            // 
            // rbtnModifica
            // 
            this.rbtnModifica.AutoSize = true;
            this.rbtnModifica.Location = new System.Drawing.Point(778, 548);
            this.rbtnModifica.Name = "rbtnModifica";
            this.rbtnModifica.Size = new System.Drawing.Size(79, 20);
            this.rbtnModifica.TabIndex = 4;
            this.rbtnModifica.TabStop = true;
            this.rbtnModifica.Text = "Modifica";
            this.rbtnModifica.UseVisualStyleBackColor = true;
            // 
            // rbtnElimina
            // 
            this.rbtnElimina.AutoSize = true;
            this.rbtnElimina.Location = new System.Drawing.Point(880, 548);
            this.rbtnElimina.Name = "rbtnElimina";
            this.rbtnElimina.Size = new System.Drawing.Size(72, 20);
            this.rbtnElimina.TabIndex = 5;
            this.rbtnElimina.TabStop = true;
            this.rbtnElimina.Text = "Elimina";
            this.rbtnElimina.UseVisualStyleBackColor = true;
            // 
            // ManageSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 643);
            this.Controls.Add(this.rbtnElimina);
            this.Controls.Add(this.rbtnModifica);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSectionForm";
            this.Text = "ManageSectionForm";
            this.Load += new System.EventHandler(this.ManageSectionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLingue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLingue;
        private System.Windows.Forms.DataGridView dgvGeneri;
        private System.Windows.Forms.RadioButton rbtnModifica;
        private System.Windows.Forms.RadioButton rbtnElimina;
    }
}