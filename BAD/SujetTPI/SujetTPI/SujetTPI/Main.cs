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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// show the next form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStuEns_Click(object sender, EventArgs e)
        {
            Student_view show_student = new Student_view();
            show_student.Show();
            this.Hide();
        }

        /// <summary>
        /// show the next form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacher_view show_teacher = new Teacher_view();
            show_teacher.Show();
            this.Hide();
        }

        /// <summary>
        /// show the next form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeeSubject_Click(object sender, EventArgs e)
        {
            Subject_View show_subject = new Subject_View();
            show_subject.Show();
            this.Hide();
        }

        /// <summary>
        /// show the next form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random_View rndSubject = new Random_View();
            rndSubject.Show();
            this.Hide();
        }

    }
}
