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

namespace GestionaleFilmC.Forms
{
    public partial class AddSectionForm : Form
    {
        private Database db = new Database();

        public AddSectionForm()
        {
            InitializeComponent();
            LoadGeneri();
            LoadLingue();
            txtDurata.Text = "02:00:00";
            cmbGenere.SelectedIndex = -1;
            cmbLingua.SelectedIndex = -1;
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

        private void btnAggiungiFilm_Click(object sender, EventArgs e)
        {
            string titolo = txtTitolo.Text.Trim();
            DateTime dataUscita = dtpDataUscita.Value;
            string descrizione = txtDescrizione.Text.Trim();
            string durata = txtDurata.Text.Trim();
            int idGenere = Convert.ToInt32(cmbGenere.SelectedValue);
            int idLingua = Convert.ToInt32(cmbLingua.SelectedValue);

            if (string.IsNullOrEmpty(titolo) || string.IsNullOrEmpty(descrizione) || string.IsNullOrEmpty(durata))
            {
                MessageBox.Show("Compila tutti i campi obbligatori per il film.");
                return;
            }

            string query = @"INSERT INTO filmdb_films (Titolo, Data_Uscita, Descrizione, Durata, ID_Genere, ID_Lingua) 
                             VALUES (@titolo, @dataUscita, @descrizione, @durata, @idGenere, @idLingua)";

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

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Film aggiunto con successo!");
                        ClearFilmFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante l'aggiunta del film: " + ex.Message);
                }
            }
        }

        private void ClearFilmFields()
        {
            txtTitolo.Text = "";
            txtDescrizione.Text = "";
            txtDurata.Text = "02:00:00";
            cmbGenere.SelectedIndex = -1;
            cmbLingua.SelectedIndex = -1;
            dtpDataUscita.Value = DateTime.Now;
        }

        private void btnAggiungiGenere_Click(object sender, EventArgs e)
        {
            string nomeGenere = txtGenere.Text.Trim();

            if (string.IsNullOrEmpty(nomeGenere))
            {
                MessageBox.Show("Inserisci il nome del genere.");
                return;
            }

            string query = "INSERT INTO filmdb_generi (Nome) VALUES (@nomeGenere)";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomeGenere", nomeGenere);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Genere aggiunto con successo!");
                        txtGenere.Text = "";
                        LoadGeneri();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante l'aggiunta del genere: " + ex.Message);
                }
            }
        }

        private void btnAggiungiLingua_Click(object sender, EventArgs e)
        {
            string nomeLingua = txtLingua.Text.Trim();

            if (string.IsNullOrEmpty(nomeLingua))
            {
                MessageBox.Show("Inserisci il nome della lingua.");
                return;
            }

            string query = "INSERT INTO filmdb_lingue (Nome) VALUES (@nomeLingua)";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomeLingua", nomeLingua);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lingua aggiunta con successo!");
                        txtLingua.Text = "";
                        LoadLingue();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante l'aggiunta della lingua: " + ex.Message);
                }
            }
        }
    }
}
