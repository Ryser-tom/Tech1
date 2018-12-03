/*  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Projet  : Albums de musique avec artiste... (VIDE)
 * Auteur  : Alec BENEY - Anne TERRIER
 * Desc.   : Albums de musique avec Base de données Access 
 *           T_Album (idAlbum, NomAlbum, idArtiste) et T_Artiste (idArtiste, NomArtiste)
 * Version : 2.0
 * Date    : septembre 2018
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace AccessEtCSharp
{
    public partial class frmCSarpEtAcess : Form
    {
        const string CHEMIN_BD = "CSharp_et_Access.mdb";
        const string CHAINE_CONNEXION = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + CHEMIN_BD;
        const string SQL_GET_ALL = "SELECT alb.idAlbum, alb.NomAlbum, art.NomArtiste FROM T_Album AS alb, T_Artiste AS art WHERE alb.idArtiste = art.idArtiste";
        const string SQL_GET_ARTISTS = "SELECT * FROM T_Artiste ORDER BY idArtiste";
        OleDbConnection laConnexion = new OleDbConnection(CHAINE_CONNEXION);

        public frmCSarpEtAcess()
        {
            InitializeComponent();
            initDB();
            updateInfos();
            updateInfosArtist();



        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insert(tbxInsertNomAlbum.Text, (cbxInsertNomArtiste.SelectedIndex+1));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update(Convert.ToInt32(tbxUpdateId.Text), tbxUpdateNomAlbum.Text, Convert.ToInt32(cbxUpdateNomArtiste.SelectedIndex+1));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(Convert.ToInt32(tbxDeleteAlbum.Text));
        }
        private void initDB()
        {
            laConnexion.Open();
            MessageBox.Show(laConnexion.State.ToString());
            laConnexion.Close();
        }
        private void updateInfos()
        {
            DataTable data = getAll();
            foreach (DataRow row in data.Rows) {
                tbxAlbum.Text += string.Format("N° {0}, {1}, par :{2}{3}", row.Field<int>(0), row.Field<string>(1), row.Field<string>(2), Environment.NewLine);
            }
        }
        private void updateInfosArtist()
        {
            DataTable artists = getArtist();
            foreach (DataRow row in artists.Rows) {
                cbxInsertNomArtiste.Items.Add(row.Field<string>(1));
                cbxUpdateNomArtiste.Items.Add(row.Field<string>(1));
            }
        }
        private DataTable getAll()
        {
            laConnexion.Open();
            OleDbCommand oleCom = new OleDbCommand(SQL_GET_ALL, laConnexion);
            OleDbDataAdapter da = new OleDbDataAdapter(oleCom);
            DataTable dt = new DataTable("DB");
            da.Fill(dt);
            laConnexion.Close();
            return dt;
        }
        private DataTable getArtist()
        {
            laConnexion.Open();
            OleDbCommand oleCom = new OleDbCommand(SQL_GET_ARTISTS, laConnexion);
            OleDbDataAdapter da = new OleDbDataAdapter(oleCom);
            DataTable dt = new DataTable("DB");
            da.Fill(dt);
            laConnexion.Close();
            return dt;
        }
        private void insert(string nomAlbum, int idArtiste)
        {
            laConnexion.Open();
            string sql = string.Format("INSERT INTO T_Album (NomAlbum, idArtiste) VALUES ('{0}', {1})", nomAlbum, idArtiste);
            OleDbCommand oleCom = new OleDbCommand(sql, laConnexion);
            int nbAjout = oleCom.ExecuteNonQuery();
            laConnexion.Close();
            updateInfos();
        }
        private void update(int idAlbum, string nomAlbum, int idArtiste)
        {
            laConnexion.Open();
            OleDbCommand oleCom = new OleDbCommand();
            oleCom.Connection=laConnexion;
            oleCom.CommandText = "UPDATE T_Album SET NomAlbum = @nomAlbum, idArtiste = @idArtiste WHERE idAlbum = @idAlbum";
            oleCom.Parameters.AddWithValue("NomAlbum", nomAlbum);
            oleCom.Parameters.AddWithValue("idArtiste", idArtiste);
            oleCom.Parameters.AddWithValue("idAlbum", idAlbum);
            oleCom.ExecuteNonQuery();
            laConnexion.Close();
            updateInfos();
        }
        private void delete(int idAlbum)
        {
            laConnexion.Open();
            OleDbCommand oleCom = new OleDbCommand();
            oleCom.Connection = laConnexion;
            oleCom.CommandText = "DELETE FROM T_Album WHERE idAlbum = @idAlbum";
            oleCom.Parameters.AddWithValue("idAlbum", idAlbum);
            oleCom.ExecuteNonQuery();
            laConnexion.Close();
            updateInfos();
        }
    }
}