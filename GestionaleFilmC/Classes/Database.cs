using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionaleFilmC.Classes
{
    public class Database
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=gestionaleFilm;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }
            return new MySqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                var conn = GetConnection();
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore di connessione: " + ex.Message);
                return false;
            }
        }
    }
}
