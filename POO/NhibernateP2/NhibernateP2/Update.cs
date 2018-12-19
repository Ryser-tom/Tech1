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

        private void updateView()
        {
            IList<Email> emails = M.GetEmails(athlete);
            tbxEmail.Text = "";
            foreach (var item in emails) {
                tbxEmail.Text += item.EmailText;
                tbxEmail.Text += Environment.NewLine;
            }
        }
    }
}
