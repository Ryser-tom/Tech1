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
    public partial class Teacher_view : Form
    {
        private bool exiting;
        public Teacher_view()
        {
            InitializeComponent();
            exiting = false;
        }

        private void Teacher_view_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'subjectBDDataSet.teacher'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.teacherTableAdapter.Fill(this.subjectBDDataSet.teacher);

        }

        private void Teacher_close(object sender, EventArgs e)
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

        private void Teacher_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            Teacher_close(sender, e);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            string to_delete = dgv_teacher.CurrentRow.Index.ToString();
        }

        private void dgv_teacher_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
