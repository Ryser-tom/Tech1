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
    public partial class Random_View : Form
    {
        private bool exiting;
        public Random_View()
        {
            InitializeComponent();
            exiting = false;
            UpdateView();
        }

        private void Random_close(object sender, EventArgs e)
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

        private void Random_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            Random_close(sender, e);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {


            int subject = cbSubject.SelectedIndex;
            int teacher = cbTeacher.SelectedIndex;
            int student = cbStudent.SelectedIndex;
        }
        private void UpdateView()
        {
            SubjectBDDataSet DB = new SubjectBDDataSet();
            var result = from teacher in DB.teacher select teacher;

            foreach (var item in result) {
                cbTeacher.Items.Add(item.nameTeacher + " " + item.firstNameTeacher);
            }
            foreach (var item in subjectBDDataSet.student) {
                cbTeacher.Items.Add(item.nameStudent + " " + item.firstNameStudent);
            }
            foreach (var item in subjectBDDataSet.subject) {
                cbTeacher.Items.Add(item.titleSubject);
            }
        }
    }
}
