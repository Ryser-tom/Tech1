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
    public partial class Student : Form
    {
        private int count = 0;
        private bool update = false;
        private Dictionary<string, string> studentD = new Dictionary<string, string>();
        databaseLinq db = new databaseLinq();
        public Student(int count)
        {
            this.count = count;
            InitializeComponent();
        }

        public Student(int count, int idStudent)
        {
            this.count = count;
            GetStudent(idStudent);
            InitializeComponent();
            update = true;

            this.Text = studentD["StudentName"] + " " + studentD["StudentFirstName"];
            tbxName.Text = studentD["StudentName"];
            tbxFirstName.Text = studentD["StudentFirstName"];
            tbxPhone.Text = studentD["StudentPhone"];
            tbxMail.Text = studentD["StudentMail"];
        }

        private void GetStudent(int index)
        {
            try {
                foreach (var Student in db.GetStudent(index)) {
                    studentD.Add("StudentId", Convert.ToString(Student.IdStudent));
                    studentD.Add("StudentName", Student.nameStudent);
                    studentD.Add("StudentFirstName", Student.firstNameStudent);
                    studentD.Add("StudentPhone", Student.telStudent);
                    studentD.Add("StudentMail", Student.emailStudent);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message); // ici éventuellement réessayer }
            }
        }

        private void UpdateStudent()
        {
            try {
                db.UpdateStudent(Convert.ToInt32(studentD["StudentId"]), studentD["StudentName"], studentD["StudentFirstName"], studentD["StudentPhone"], studentD["StudentMail"]);
                this.Close();
            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void CreateStudent()
        {
            try {
                db.CreateStudent(count, tbxName.Text, tbxFirstName.Text, tbxPhone.Text, tbxMail.Text);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (update) {
                UpdateStudent();
            } else {
                CreateStudent();
            }
        }
    }
}
