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
    public partial class Student_view : Form
    {
        private bool exiting;
        public Student_view()
        {
            InitializeComponent();
            exiting = false;
        }

        private void Student_view_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'subjectBDDataSet.student'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.studentTableAdapter.Fill(this.subjectBDDataSet.student);

        }
        private void Student_close(object sender, EventArgs e)
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

        private void Student_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            Student_close(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string name = dgvStudent.Rows[dgvStudent.CurrentRow.Index].Cells[1].Value.ToString() + " " + dgvStudent.Rows[dgvStudent.CurrentRow.Index].Cells[2].Value.ToString();
            string message = "Vous allez supprimer " + name.ToUpper() + ", confirmer ? ";
            string caption = "Vérification avant suppréssion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes) {
                // delete student
                Delete(dgvStudent.CurrentRow.Index);
            }
        }
        private void Delete(int index)
        {

        }
    }
}
