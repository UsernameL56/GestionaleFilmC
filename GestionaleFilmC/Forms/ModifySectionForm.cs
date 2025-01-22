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
                LoadPanel2();
            }else if(stringa == "lingua")
            {
                panel4.Show();
                LoadPanel4();
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
        private void LoadPanel2()
        {
            txtGenere.Text = arrayList[1].ToString();
        }
        private void LoadPanel4()
        {
            txtLingua.Text = arrayList[1].ToString();
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

                        MessageBox.Show("Film modificato con successo!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante la modifica del film: " + ex.Message);
                }
            }
        }

        private void btnModificaGenere_Click(object sender, EventArgs e)
        {
            int idGenere = Convert.ToInt32(arrayList[0]);
            string nome = txtGenere.Text;

            string query = "UPDATE filmdb_generi SET Nome = @nome WHERE ID = @idGenere";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@idGenere", idGenere);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Genere modificato con successo!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante la modifica del genere: " + ex.Message);
                }
            }
        }

        private void btnModificaLingua_Click(object sender, EventArgs e)
        {

        }

        private void btnModificaLingua_Click_1(object sender, EventArgs e)
        {
            int idLingua = Convert.ToInt32(arrayList[0]);
            string nome = txtLingua.Text;

            string query = "UPDATE filmdb_lingue SET Nome = @nome WHERE ID = @idLingua";

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@idLingua", idLingua);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Lingua modificata con successo!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante la modifica della lingua: " + ex.Message);
                }
            }
        }
    }
}
