/*
 Project name :             TPI
 Author :                   Tom Ryser
 Last modification date :   25.11.2018
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

namespace TPIV2
{
    public partial class Teacher : Form
    {
        private int count = 0;
        private bool update = false;
        private Dictionary<string, string> teacherD = new Dictionary<string, string>();

        public Teacher(int count)
        {
            this.count = count;
            InitializeComponent();
        }

        public Teacher(int count, int idTeacher)
        {
            this.count = count;
            GetTeacher(idTeacher);
            InitializeComponent();
            update = true;

            this.Text = teacherD["TeacherName"] + " " + teacherD["TeacherFirstName"];
            tbxName.Text = teacherD["TeacherName"];
            tbxFirstName.Text = teacherD["TeacherFirstName"];
            tbxPhone.Text = teacherD["TeacherPhone"];
            tbxMail.Text = teacherD["TeacherMail"];
            nudNbStudent.Value = Convert.ToInt32(teacherD["TeacherNbStudent"]);
        }

        private void GetTeacher(int index)
        {
            DataClassesDataContext DB = new DataClassesDataContext();
            var requete = from teacher in DB.teacher
                          where teacher.IdTeacher == index
                          select teacher;

            foreach (var teacher in requete) {
                teacherD.Add("TeacherId", Convert.ToString(teacher.IdTeacher));
                teacherD.Add("TeacherName", teacher.nameTeacher);
                teacherD.Add("TeacherFirstName", teacher.firstNameTeacher);
                teacherD.Add("TeacherPhone", teacher.telTeacher);
                teacherD.Add("TeacherMail", teacher.emailTeacher);
                teacherD.Add("TeacherNbStudent", Convert.ToString(teacher.nbStudentTeacher));
            }
            try { DB.SubmitChanges();} 
            catch (Exception ex) {
                MessageBox.Show(ex.Message); // ici éventuellement réessayer }
            }
        }

        private void UpdateTeacher()
        {
            DataClassesDataContext DB = new DataClassesDataContext();

            var requete = from teacher in DB.teacher
                          where teacher.IdTeacher == Convert.ToInt32(teacherD["TeacherId"])
                          select teacher;

            foreach (var teacher in requete) {
                teacher.nameTeacher = tbxName.Text;
                teacher.firstNameTeacher = tbxFirstName.Text;
                teacher.telTeacher = tbxPhone.Text;
                teacher.emailTeacher = tbxMail.Text;
                teacher.nbStudentTeacher = Convert.ToInt32(nudNbStudent.Value);
                try {
                    DB.SubmitChanges();
                    this.Close();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message); 
                }
            }
        }

        private void CreateTeacher()
        {
            DataClassesDataContext DB = new DataClassesDataContext(); teacher cl = new teacher();

            cl.IdTeacher = count;
            cl.nameTeacher = tbxName.Text;
            cl.firstNameTeacher = tbxFirstName.Text;
            cl.telTeacher = tbxPhone.Text;
            cl.emailTeacher = tbxMail.Text;
            cl.nbStudentTeacher = Convert.ToInt32(nudNbStudent.Value);
            DB.teacher.InsertOnSubmit(cl);
            try {
                DB.SubmitChanges();
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (update) {
                UpdateTeacher();
            } else {
                CreateTeacher();
            }
        }
    }
}
