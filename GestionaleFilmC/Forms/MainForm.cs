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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionaleFilmC.Forms
{
    public partial class MainForm : Form
    {
        private Database db = new Database();
        string nome;
        string cognome;
        string email;
        string ruolo;
        int userId;

        public MainForm(string nome, string cognome, string email, string ruolo, int userId)
        {
            InitializeComponent();
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.ruolo = ruolo;
            this.userId = userId;

            lblNome.Text = $"Benvenuto, {nome}";
            lblRuolo.Text = $"Ruolo: {ruolo}";

            // Mostra funzionalità diverse in base al ruolo
            if (ruolo == "1")
            {
                // Abilita pulsanti per CRUD sui film
            }
            else
            {
                // Abilita pulsanti per visualizzare film e preferiti
            }
            LoadFilms();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadFilms()
        {
            // Query per ottenere i dettagli dei film con genere e lingua
            string query = @"SELECT f.ID, f.Titolo, f.Durata, g.Nome AS Genere, l.Nome AS Lingua 
                             FROM filmdb_films f
                             JOIN filmdb_generi g ON f.ID_Genere = g.ID
                             JOIN filmdb_lingue l ON f.ID_Lingua = l.ID";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable filmsTable = new DataTable();
                            adapter.Fill(filmsTable);
                            dgvFilms.DataSource = filmsTable; // Associa la tabella al DataGridView

                            // Imposta le colonne del DataGridView
                            dgvFilms.Columns["ID"].Visible = false; // Nascondi la colonna ID
                            dgvFilms.Columns["Titolo"].HeaderText = "Titolo del Film";
                            dgvFilms.Columns["Durata"].HeaderText = "Durata";
                            dgvFilms.Columns["Genere"].HeaderText = "Genere";
                            dgvFilms.Columns["Lingua"].HeaderText = "Lingua";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento dei dati: " + ex.Message);
                }
            }
        }

        private void dgvFilms_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ottieni l'ID del film dalla riga selezionata
                int filmId = Convert.ToInt32(dgvFilms.Rows[e.RowIndex].Cells["ID"].Value);

                // Apri il form con i dettagli del film
                FilmDetailsForm detailsForm = new FilmDetailsForm(filmId,userId);
                detailsForm.ShowDialog();
            }
        }
    }
}
