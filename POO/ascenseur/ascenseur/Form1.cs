using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ascenseur
{
    public partial class Form1 : Form
    {
        private controller c = new controller();
        private const int DEFAULT_POSITION_X = 12;
        private const int DEFAULT_POSITION_Y = 19;
        private const int DEFAULT_POSITION_INCREMENTATION = 30;
        private Label[] labels;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
                int result = c.CreatAscenseur(tbxMax.Text, tbxSSol.Text);
            switch (result) {
                case 0:
                    btnCreate.Enabled = false;
                    createView(Convert.ToInt32(tbxMax.Text), Convert.ToInt32(tbxSSol.Text));
                    break;
                case 1:
                    MessageBox.Show("les nombres d'étages ne peuvent pas êtres vides");
                    break;
                case 2:
                    MessageBox.Show("les nombres d'étages doivent uniquement contenir des chiffres");
                    break;
                default:
                    break;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            c.Monter();
            updateView();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            c.Descendre();
            updateView();
        }

        private void btnPeoplePlus_Click(object sender, EventArgs e)
        {
            c.Prendre((int) numUDPersonne.Value);
            updateView();
        }

        private void btnPeopleMinus_Click(object sender, EventArgs e)
        {
            c.Laisser((int)numUDPersonne.Value);
            updateView();
        }

        private void lab_Click(object sender, EventArgs e)
        {
            int destination = Convert.ToInt32((sender as Label).Text);
            int actualEtage = c.GetActualLocation() * -1;
            while (actualEtage != destination) {
                if (actualEtage > destination) {
                    c.Descendre();
                    updateView();
                } else {
                    c.Monter();
                    updateView();
                }
                actualEtage = c.GetActualLocation() * -1;
                Thread.Sleep(500);
                updateView();
            }
        }
        private void updateView()
        {
            lblAscenseur.Location = new System.Drawing.Point(DEFAULT_POSITION_X + 30, DEFAULT_POSITION_Y + ((c.GetActualLocation() + c.GetMaxEtage()) * DEFAULT_POSITION_INCREMENTATION));
            string personnes = "";
            for (int i = 0; i < c.getNbPersonnes(); i++) {
                personnes += "O";
            }
            lblAscenseur.Text = personnes;
        }
        private void createView(int nbEtages, int nbSSol)
        {
            //+1 pour le rez de chaussé.
            for (int i = 0; i < nbEtages + nbSSol + 1; i++) {
                Label lbl = new Label();
                lbl.Name = "lblEtage" + Convert.ToString(nbEtages - i);
                lbl.Text = Convert.ToString(nbEtages - i);
                lbl.Location = new System.Drawing.Point(DEFAULT_POSITION_X, DEFAULT_POSITION_Y + (i * DEFAULT_POSITION_INCREMENTATION));
                lbl.AutoSize = true;
                lbl.Click += lab_Click;
                this.Controls.Add(lbl);
            }
            lblAscenseur.Visible = true;
            updateView();
        }
    }
}
