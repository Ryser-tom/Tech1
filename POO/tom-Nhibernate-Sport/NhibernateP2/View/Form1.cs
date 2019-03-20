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
    public partial class Form1 : Form
    {
        private model M = new model();
        private IList<Athlete> athletes;
        public Form1()
        {
            InitializeComponent();
            updateView();
        }

        private void updateView()
        {
            athletes = M.GetAthletes();

            //build the datagridview with all non deleted athlete
            dgvAthlete.DataSource = athletes.Select(o => new
            { id = o.Id, first_name = o.First, last_name = o.Last, date_birth = o.Birth }).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvAthlete.SelectedCells[0].RowIndex);
            Update UpdatesForm = new Update(athletes[index]);
            Hide();
            UpdatesForm.ShowDialog();
            updateView();
            Show();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Update UpdatesForm = new Update();
            Hide();
            UpdatesForm.ShowDialog();
            updateView();
            Show();
        }
    }
}
