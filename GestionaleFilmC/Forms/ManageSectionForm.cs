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
    public partial class ManageSectionForm : Form
    {
        private Database db = new Database();
        public ManageSectionForm()
        {
            InitializeComponent();
            LoadFilms();
            LoadGeneri();
            LoadLingue();
        }

        private void LoadFilms()
        {
            string query = @"SELECT f.ID, f.Titolo, f.Data_Uscita, f.Descrizione, f.Durata, f.ID_Genere, f.ID_Lingua, g.Nome AS Genere, l.Nome AS Lingua
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
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dgvFilms.DataSource = dataTable;

                            dgvFilms.Columns["ID"].Visible = false;
                            dgvFilms.Columns["Descrizione"].Visible = false;
                            dgvFilms.Columns["ID_Genere"].Visible = false; 
                            dgvFilms.Columns["ID_Lingua"].Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento dei film: " + ex.Message);
                }
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
                            dgvGeneri.DataSource = dataTable;
                            dgvGeneri.Columns["ID"].Visible = false;
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
                            dgvLingue.DataSource = dataTable;
                            dgvLingue.Columns["ID"].Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante il caricamento delle lingue: " + ex.Message);
                }
            }
        }


        private void ManageSectionForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filmId = Convert.ToInt32(dgvFilms.Rows[e.RowIndex].Cells["ID"].Value);
                if (rbtnModifica.Checked) 
                {
                    string Titolo = dgvFilms.Rows[e.RowIndex].Cells["Titolo"].Value.ToString();
                    DateTime dataUscita = Convert.ToDateTime(dgvFilms.Rows[e.RowIndex].Cells["Data_Uscita"].Value);
                    string Descrizione = dgvFilms.Rows[e.RowIndex].Cells["Descrizione"].Value.ToString();
                    string Durata = dgvFilms.Rows[e.RowIndex].Cells["Durata"].Value.ToString();
                    int Genere = Convert.ToInt32(dgvFilms.Rows[e.RowIndex].Cells["ID_Genere"].Value);
                    int Lingua = Convert.ToInt32(dgvFilms.Rows[e.RowIndex].Cells["ID_Lingua"].Value); 

                    ArrayList arrayList = new ArrayList
                    {
                        filmId,
                        Titolo,
                        dataUscita,
                        Descrizione,
                        Durata,
                        Genere,
                        Lingua
                    };


                    ModifySectionForm modifySectionForm = new ModifySectionForm(arrayList, "film");
                    modifySectionForm.ShowDialog();
                    LoadFilms();
                }
                else if (rbtnElimina.Checked)
                {
                    DialogResult result = MessageBox.Show("Sei sicuro di voler eliminare il film selezionato?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM filmdb_films WHERE ID = @id";
                        using (var conn = db.GetConnection())
                        {
                            try
                            {
                                conn.Open();
                                using (var cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", filmId);
                                    cmd.ExecuteNonQuery();
                                    LoadFilms();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Errore durante l'eliminazione del film: " + ex.Message);
                            }
                        }
                    }
                }
            }

        }

        private void dgvGeneri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idGenere = Convert.ToInt32(dgvGeneri.Rows[e.RowIndex].Cells["ID"].Value);
                if (rbtnModifica.Checked)
                {
                    string nome = dgvGeneri.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                    ArrayList arrayList = new ArrayList
                    {
                        idGenere,
                        nome
                    };

                    ModifySectionForm modifySectionForm = new ModifySectionForm(arrayList, "genere");
                    modifySectionForm.ShowDialog();
                    LoadGeneri();
                }
                else if (rbtnElimina.Checked)
                {
                    DialogResult result = MessageBox.Show("Sei sicuro di voler eliminare il genere selezionato?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM filmdb_generi WHERE ID = @id";
                        using (var conn = db.GetConnection())
                        {
                            try
                            {
                                conn.Open();
                                using (var cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", idGenere);
                                    cmd.ExecuteNonQuery();
                                    LoadGeneri();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Errore durante l'eliminazione del genere: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void dgvLingue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idLingua = Convert.ToInt32(dgvLingue.Rows[e.RowIndex].Cells["ID"].Value);
                if (rbtnModifica.Checked)
                {
                    string nome = dgvLingue.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                    ArrayList arrayList = new ArrayList
                    {
                        idLingua,
                        nome
                    };

                    ModifySectionForm modifySectionForm = new ModifySectionForm(arrayList, "lingua");
                    modifySectionForm.ShowDialog();
                    LoadLingue();
                }
                else if (rbtnElimina.Checked)
                {
                    DialogResult result = MessageBox.Show("Sei sicuro di voler eliminare la lingua selezionata?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM filmdb_lingue WHERE ID = @id";
                        using (var conn = db.GetConnection())
                        {
                            try
                            {
                                conn.Open();
                                using (var cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", idLingua);
                                    cmd.ExecuteNonQuery();
                                    LoadLingue();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Errore durante l'eliminazione della lingua: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }
    }
}
