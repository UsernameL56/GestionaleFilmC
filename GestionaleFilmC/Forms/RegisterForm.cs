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
    public partial class RegisterForm : Form
    {
        private Database db = new Database();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nome = txtNomeRegister.Text;
            string cognome = txtCognomeRegister.Text;
            string email = txtEmailRegister.Text;
            string password = txtPasswordRegister.Text;
            string ruolo = txtRuoloRegister.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(ruolo))
            {
                MessageBox.Show("Compila tutti i campi!");
                return;
            }

            // Hash della password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string query = "INSERT INTO filmDB_Users (Nome, Cognome, Email, Password, Admin) VALUES (@nome, @cognome, @email, @password, @ruolo)";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cognome", cognome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@ruolo", ruolo);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registrazione completata!");
                        this.Hide();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore: " + ex.Message);
                    }
                }
            }

        }
    }
}
