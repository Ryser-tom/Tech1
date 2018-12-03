using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_to_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestBDDataContext testBD = new TestBDDataContext();
            var result = from clients in testBD.T_Clients select clients;
            dataGridView1.DataSource = result.ToArray();

        }
        private void updateView()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestBDDataContext testBD = new TestBDDataContext();
            var result = from clients in testBD.T_Clients
                         join commandes in testBD.T_Commandes
                         on clients.IdClient equals commandes.IdClient
                         where commandes.DateCommande == Convert.ToDateTime("01/11/2014 12:10:00")
                         select new { clients.Nom, clients.Prenom };
            foreach (var name in result) {
                textBox1.Text = name.Nom + " " + name.Prenom + " - ";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TestBDDataContext TestDb = new TestBDDataContext();
            T_Clients cl = new T_Clients();
            cl.IdClient = 4;
            cl.Nom = "Terrier";
            cl.Prenom = "Arlette";
            cl.Adresse = "22 ch. des Aulx";
            cl.Localite = "Plan - les_Ouates";
            cl.CodePostal = "1228" ;
            TestDb.T_Clients.InsertOnSubmit(cl);

            try{
                TestDb.SubmitChanges();
                MessageBox.Show(" Client inséré");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                // ici éventuellement réessayer 
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            TestBDDataContext TestDb = new TestBDDataContext();
            var requete = from clients in TestDb.T_Clients
                          where clients.Nom == "Terrier"
                          select clients;

            foreach (var UnClient in requete) {
                TestDb.T_Clients.DeleteOnSubmit(UnClient);
            }
            try 
            {
                TestDb.SubmitChanges();
                MessageBox.Show("Client supprimé");
            } 
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                // ici éventuellement réessayer 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TestBDDataContext TestDb = new TestBDDataContext();
            var requete = from clients in TestDb.T_Clients
                          where clients.Nom == "Terrier"
                          select clients;

            foreach(var UnClient in requete) {
                UnClient.Prenom = "Anne";
            }
            try {
                TestDb.SubmitChanges();
                MessageBox.Show("Client changé");
            } 
            catch(Exception ex) 
            {
                MessageBox
                .Show(ex.Message);
                // ici éventuellement réessayer 
            }
        }
    }
}
