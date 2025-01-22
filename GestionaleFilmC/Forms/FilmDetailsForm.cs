using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GestionaleFilmC.Classes;
using MySql.Data.MySqlClient;

namespace GestionaleFilmC.Forms
{
    public partial class FilmDetailsForm : Form
    {
        private int filmID;
        private int userID;
        private Database db = new Database();
        public FilmDetailsForm(int filmID, int userID)
        {
            InitializeComponent();
            this.filmID = filmID;
            this.userID = userID;
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
                finally 
                {
                    conn.Close();
                }
            }
            
        }

        private void LoadComments()
        {
            string query = @"SELECT u.Nome, c.Stelle, c.Commento 
                             FROM filmdb_commenti c
                             JOIN filmdb_users u ON c.ID_User = u.ID
                             WHERE c.ID_Film = @filmID";

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
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnInviaCommento_Click(object sender, EventArgs e)
        {
            string comment = txtCommento.Text.Trim();
            int rating = (int)numValutazione.Value;

            // Validazione dell'input
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Inserisci un commento valido.");
                return;
            }


            string query = "INSERT INTO filmdb_commenti (Stelle, Commento, ID_User, ID_Film) VALUES (@rating, @comment, @userId, @filmId)";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@comment", comment);
                        cmd.Parameters.AddWithValue("@userId", userID);
                        cmd.Parameters.AddWithValue("@filmId", filmID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Commento aggiunto con successo!");
                        numValutazione.Value= 1;
                        txtCommento.Text = "";
                        LoadComments(); // Aggiorna la lista dei commenti
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante l'invio del commento: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
