using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionaleFilmC.Forms
{
    public partial class MainForm : Form
    {
        string nome;
        string cognome;
        string email;
        string ruolo;

        public MainForm(string nome, string cognome, string email, string ruolo)
        {
            InitializeComponent();
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.ruolo = ruolo;

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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
