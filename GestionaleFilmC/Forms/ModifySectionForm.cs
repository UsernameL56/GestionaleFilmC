using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionaleFilmC.Classes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections;

namespace GestionaleFilmC.Forms
{
    public partial class ModifySectionForm : Form
    {
        private Database db = new Database();
        ArrayList arrayList;
        string stringa;
        public ModifySectionForm(ArrayList arrayList, string stringa)
        {
            InitializeComponent();
            LoadGeneri();
            LoadLingue();
            this.arrayList = arrayList;
            this.stringa = stringa;
            if (stringa == "film"){
                panel1.Show();
                LoadPanel1();
            }
            else if (stringa == "genere") { 
                panel2.Show();
            }else if(stringa == "lingua")
            {
                panel4.Show();
            }
        }

        private void LoadGeneri()
        {
            string query = "SELECT * FROM filmdb_generi";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            cmbGenere.DataSource = dataTable;
                            cmbGenere.DisplayMember = "Nome";
                            cmbGenere.ValueMember = "ID";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento dei generi: " + ex.Message);
                }
            }
        }

        private void LoadLingue()
        {
            string query = "SELECT * FROM filmdb_lingue";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            cmbLingua.DataSource = dataTable;
                            cmbLingua.DisplayMember = "Nome";
                            cmbLingua.ValueMember = "ID";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento delle lingue: " + ex.Message);
                }
            }
        }

        private void LoadPanel1()
        {
            txtTitolo.Text = arrayList[1].ToString();
            dtpDataUscita.Value = Convert.ToDateTime(arrayList[2]);
            txtDescrizione.Text = arrayList[3].ToString();
            txtDurata.Text = arrayList[4].ToString();
            cmbGenere.SelectedValue = Convert.ToInt32(arrayList[5]);
            cmbLingua.SelectedValue = Convert.ToInt32(arrayList[6]);
        }

        private void btnModificaFilm_Click(object sender, EventArgs e)
        {
            int idFilm = Convert.ToInt32(arrayList[0]);
            string titolo = txtTitolo.Text;
            DateTime dataUscita = dtpDataUscita.Value;
            string descrizione = txtDescrizione.Text;
            string durata = txtDurata.Text;
            int idGenere = Convert.ToInt32(cmbGenere.SelectedValue);
            int idLingua = Convert.ToInt32(cmbLingua.SelectedValue);

            string query = "UPDATE filmdb_films SET Titolo = @titolo, Data_Uscita = @dataUscita, Descrizione = @descrizione, Durata = @durata, ID_Genere = @idGenere, ID_Lingua = @idLingua WHERE ID = @idFilm";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@titolo", titolo);
                        cmd.Parameters.AddWithValue("@dataUscita", dataUscita);
                        cmd.Parameters.AddWithValue("@descrizione", descrizione);
                        cmd.Parameters.AddWithValue("@durata", durata);
                        cmd.Parameters.AddWithValue("@idGenere", idGenere);
                        cmd.Parameters.AddWithValue("@idLingua", idLingua);
                        cmd.Parameters.AddWithValue("@idFilm", idFilm);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante la modifica del film: " + ex.Message);
                }
            }
        }
    }
}
