using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SujetTPI
{
    public partial class Subject_View : Form
    {
        private bool exiting;
        public Subject_View()
        {
            InitializeComponent();
            exiting = false;
        }

        private void Subject_View_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'subjectBDDataSet.subject'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.subjectTableAdapter.Fill(this.subjectBDDataSet.subject);
        }

        private void Subject_close(object sender, EventArgs e)
        {
            if (!exiting) {
                if (sender is Button) {
                    exiting = true;
                    Main main_form = new Main();
                    main_form.Show();
                    this.Close();
                } else {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void Subject_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            Subject_close(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            view.Subject_add_view add_subject = new view.Subject_add_view();
            add_subject.Show();
            this.Hide();
        }
    }
}
