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
using Org.BouncyCastle.Crypto.Generators;

namespace GestionaleFilmC.Forms
{
    public partial class LoginForm : Form
    {
        private Database db = new Database();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmailLogin.Text;
            string password = txtPasswordLogin.Text;

            string query = "SELECT * FROM filmDB_Users WHERE Email = @email";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader["Password"].ToString();
                            // Confronta la password inserita con l'hash salvato
                            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                            {
                                string nome = reader["Nome"].ToString();
                                string cognome = reader["Cognome"].ToString();
                                string emailUtente = reader["Email"].ToString();
                                string ruolo = reader["Admin"].ToString();
                                int userId = Convert.ToInt32(reader["ID"]);

                                MessageBox.Show("Login effettuato con successo!");
                                // Passa alla finestra principale
                                MainForm mainForm = new MainForm(nome, cognome, emailUtente, ruolo, userId);
                                this.Hide();
                                mainForm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Password errata!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Utente non trovato!");
                        }
                    }
                }
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
