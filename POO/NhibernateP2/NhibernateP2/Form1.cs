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
    public partial class Form1 : Form
    {
        private model M = new model();
        private IList<Athlete> athletes;
        public Form1()
        {
            InitializeComponent();
            athletes = M.GetAthletes();

            dgvAthlete.DataSource = athletes.Select(o => new
            { id = o.id,  first_name = o.first, last_name = o.last, date_birth = o.birth }).ToList();
        }

        private void cbxAthlete_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateView();
        }

        private void updateView()
        {
            athletes = M.GetAthletes();
            dgvAthlete.DataSource = athletes.Select(o => new { id = o.id, first_name = o.first, last_name = o.last, date_birth = o.birth }).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = (Convert.ToInt32(dgvAthlete.Rows[dgvAthlete.SelectedCells[0].RowIndex].Cells["id"].Value)-1);
            Update UpdatesForm = new Update(athletes[index]);
            UpdatesForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = (Convert.ToInt32(dgvAthlete.Rows[dgvAthlete.SelectedCells[0].RowIndex].Cells["id"].Value)-1);
            try {
                M.DeleteAthlete(athletes[index]);
                updateView();
            } catch (Exception) {

                throw;
            }
        }
    }
}
