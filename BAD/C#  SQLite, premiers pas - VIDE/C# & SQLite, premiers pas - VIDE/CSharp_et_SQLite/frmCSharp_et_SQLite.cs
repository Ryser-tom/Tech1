/*  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Projet  : C# et SQLite, premiers pas... (VIDE)
 * Auteur  : Alec BENEY - Anne Terrier
 * Desc.   : CRUD sur la base de données "clients.sqlite", il y a qu'une seule table :
 *         : TClients --> idClient (clé primaire, numAuto), NomClient, PrenomClient
 * Version : 1.0
 * Date    : mai 2017
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CSharp_et_SQLite
{
    public partial class frmCSharp_et_SQLite : Form
    {
        public const string CHAINE_CONNEXION = "Data Source=client.db;Version=3;";
        SQLiteConnection maConnexion = new SQLiteConnection(CHAINE_CONNEXION);

        public frmCSharp_et_SQLite()
        {
            InitializeComponent();
            updateView();
        }

        private void tbnInsert_Click(object sender, EventArgs e)
        {
            maConnexion.Open();
            string sql = string.Format("INSERT INTO clients(nom, prenom)" + 
                                        "VALUES ('{0}', '{1}')", tbxInsertNom.Text, tbxInsertPrenom.Text);
            SQLiteCommand sqlCommand = new SQLiteCommand(sql, maConnexion);
            int NbLigneMiseAJour = sqlCommand.ExecuteNonQuery();
            maConnexion.Close();
            updateView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            maConnexion.Open();
            string sql = string.Format("UPDATE clients SET prenom = '{0}', nom = '{1}'" +
                                        "WHERE id = '{2}'", tbxUpdatePrenom.Text, tbxUpdateNom.Text, tbxUpdateId.Text);
            SQLiteCommand sqlCommand = new SQLiteCommand(sql, maConnexion);
            int NbLigneMiseAJour = sqlCommand.ExecuteNonQuery();
            maConnexion.Close();
            updateView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            maConnexion.Open();
            string sql = string.Format("DELETE FROM clients " +
                                        "WHERE id = '{0}'", tbxDeleteId.Text);
            SQLiteCommand sqlCommand = new SQLiteCommand(sql, maConnexion);
            int NbLigneMiseAJour = sqlCommand.ExecuteNonQuery();
            maConnexion.Close();
            updateView();
        }
        private void updateView()
        {
            maConnexion.Open();
            string sql = "SELECT * FROM clients ORDER BY nom ASC;";
            SQLiteCommand sqlCommand = new SQLiteCommand(sql, maConnexion);

            SQLiteDataReader reader = sqlCommand.ExecuteReader();
            string affichage = "";

            while (reader.Read()) {
                affichage += string.Format("Id : {0}, Nom : {1}, Prénom : {2}, {3}",
                                            reader["id"], reader["nom"], reader["prenom"], Environment.NewLine);
            }
            tbxAffichage.Text = affichage;
            maConnexion.Close();

        }
    }
}