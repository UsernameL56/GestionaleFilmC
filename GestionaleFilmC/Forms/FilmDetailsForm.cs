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
    public partial class FilmDetailsForm : Form
    {
        private int filmID;
        private Database db = new Database();
        public FilmDetailsForm(int filmID)
        {
            InitializeComponent();
            this.filmID = filmID;
            LoadFilmDetails();
            LoadComments();
        }

        private void FilmDetailsForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadFilmDetails()
        {
            string query = @"SELECT Titolo, Data_Uscita, Descrizione, Durata, Copertina 
                             FROM filmdb_films
                             WHERE ID = @filmID";

            MessageBox.Show(query);
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filmID", filmID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblTitolo.Text = reader["Titolo"].ToString();
                                lblDataUscita.Text = reader["Data_Uscita"].ToString();
                                lblDurata.Text = reader["Durata"].ToString();
                                txtDescrizione.Text = reader["Descrizione"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento dei dettagli: " + ex.Message);
                }
            }
        }

        private void LoadComments()
        {
            string query = @"SELECT u.Nome, c.Stelle, c.Commento 
                             FROM filmdb_commenti c
                             JOIN filmdb_users u ON c.ID_User = u.ID
                             WHERE c.ID_Film = @filmID";

            MessageBox.Show(query);
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filmID", filmID);
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable commentsTable = new DataTable();
                            adapter.Fill(commentsTable);
                            dgvComments.DataSource = commentsTable;

                            dgvComments.Columns["Nome"].HeaderText = "Utente";
                            dgvComments.Columns["Stelle"].HeaderText = "Valutazione";
                            dgvComments.Columns["Commento"].HeaderText = "Commento";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento dei commenti: " + ex.Message);
                }
            }
        }
    }
}
