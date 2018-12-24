/* Project : NhibernateP2
 * Description : C# application who usen Nhibernate to manipulate database
 * Author : Tom RYSER
 * Version : 1.0
 * Last update : 24.12.2018
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhibernateP2
{
    public partial class Update : Form
    {
        private Athlete athlete;
        private model M = new model();
        public Update(Athlete a)
        {
            InitializeComponent();
            this.athlete = a;
            updateView();
        }
        public Update()
        {
            InitializeComponent();
            athlete = new Athlete();
            athlete.Birth = DateTime.Today;
        }

        private void updateView()
        {
            tbxFirst.Text = athlete.First;
            tbxLast.Text = athlete.Last;
            dtpBirth.Value = athlete.Birth;

            IList<Email> emails = M.GetEmails(athlete);
            tbxEmail.Text = "";
            foreach (var item in emails) {
                tbxEmail.Text += item.EmailText;
                tbxEmail.Text += Environment.NewLine;
            }

            ISet<Address> Addresses = athlete.Addresses;
            cbAddresses.Items.Clear();
            foreach (var item in Addresses)
            {
                cbAddresses.Items.Add(item.Location + " : " + item.Postal_code + " " + item.Street + " " + item.Street_nr + ", " + item.Country);
            }
            if(cbAddresses.Items.Count > 0)
            {
                cbAddresses.SelectedIndex = 0; 
            }
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            int index = cbAddresses.SelectedIndex;
            List<Address> Addresses = athlete.Addresses.ToList();


            Addresse Addresse = new Addresse(Addresses[index]);
            Hide();
            Addresse.ShowDialog();
            updateView();
            Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            athlete.First = tbxFirst.Text;
            athlete.Last = tbxLast.Text;
            athlete.Birth = dtpBirth.Value;

            M.CreateOrUpdateAthlete(athlete);
            this.Close();
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            int index = cbAddresses.SelectedIndex;
            List<Address> Addresses = athlete.Addresses.ToList();

            M.DeleteAdress(Addresses[index]);
            athlete.Addresses.Remove(Addresses[index]);
            updateView();
        }

        private void btnAddAdress_Click(object sender, EventArgs e)
        {
            Addresse Addresse = new Addresse(athlete);
            Hide();
            Addresse.ShowDialog();
            updateView();
            Show();
        }
    }
}
