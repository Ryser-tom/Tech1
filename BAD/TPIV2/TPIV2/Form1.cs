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
    public partial class vue : Form
    {
        
        private student[] avaibleStudent;
        private student[] notAvaibleStudent;
        private teacher[] avaibleTeacher;
        private teacher[] allTeacher;
        private subject[] avaibleSubject;

        private databaseLinq db = new databaseLinq();
        public vue()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'subjectBDDataSet.student'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.studentTableAdapter.Fill(this.subjectBDDataSet.student);
            // TODO: cette ligne de code charge les données dans la table 'subjectBDDataSet.teacher'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.teacherTableAdapter.Fill(this.subjectBDDataSet.teacher);
            // TODO: cette ligne de code charge les données dans la table 'subjectBDDataSet.subject'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.subjectTableAdapter.Fill(this.subjectBDDataSet.subject);
            UpdateCheckBox();

        }

        private void UpdateCheckBox()
        {
            //clear checkbox
            cbxStudentAttribute.Items.Clear();
            cbxSubjectAttribute.Items.Clear();
            cbxTeacherAttribute.Items.Clear();
            
            //get all data
            avaibleStudent = db.GetAvaibleStudent();
            notAvaibleStudent = db.GetNotAvaibleStudent();
            avaibleSubject = db.GetAvaibleSubject();
            allTeacher = db.GetAllTeacher();

            

            if (avaibleStudent.Count() > 0)
            {
                btnChooseSubject.Enabled = true;

                //updating combobox for student
                foreach (var item in avaibleStudent)
                {
                    cbxStudentAttribute.DisplayMember = "Text";
                    cbxStudentAttribute.ValueMember = "Value";
                    cbxStudentAttribute.Items.Add(new { Text = item.nameStudent + " " + item.firstNameStudent, Value = item.IdStudent });
                }
                cbxStudentAttribute.Enabled = true;
                cbxStudentAttribute.SelectedIndex = 0;

                //updating combobox for subject
                foreach (var item in avaibleSubject)
                {
                    cbxSubjectAttribute.DisplayMember = "Text";
                    cbxSubjectAttribute.ValueMember = "Value";
                    cbxSubjectAttribute.Items.Add(new { Text = item.nameSubject, Value = item.IdSubject });
                }
                cbxSubjectAttribute.Enabled = true;
                cbxSubjectAttribute.SelectedIndex = 0;

                //updating combobox for teacher
                List<teacher> teacherList = new List<teacher>();
                foreach (var item in allTeacher)
                {
                    int countNbStudentForTeacher = 0;
                    foreach (var student in notAvaibleStudent)
                    {
                        if (student.idTeacher == item.IdTeacher)
                            countNbStudentForTeacher++;
                    }
                    if (countNbStudentForTeacher < item.nbStudentTeacher)
                    {
                        cbxTeacherAttribute.DisplayMember = "Text";
                        cbxTeacherAttribute.ValueMember = "Value";
                        cbxTeacherAttribute.Items.Add(new { Text = item.nameTeacher + " " + item.firstNameTeacher, Value = item.IdTeacher });
                        teacherList.Add(item);
                    }
                }

                avaibleTeacher = teacherList.ToArray();
                cbxTeacherAttribute.Enabled = true;
                cbxTeacherAttribute.SelectedIndex = 0;
            }
            else
            {
                btnChooseSubject.Enabled = false;
                cbxStudentAttribute.Text = "vide";
                cbxStudentAttribute.Enabled = false;
                cbxSubjectAttribute.Text = "vide";
                cbxSubjectAttribute.Enabled = false;
                cbxTeacherAttribute.Text = "vide";
                cbxTeacherAttribute.Enabled = false;
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            Teacher T = new Teacher(dgvTeacher.RowCount);
            T.ShowDialog();
            this.teacherTableAdapter.Fill(this.subjectBDDataSet.teacher);
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvTeacher.Rows[dgvTeacher.SelectedCells[0].RowIndex].Cells["idTeacherDataGridViewTextBoxColumn"].Value);
            Teacher T = new Teacher(dgvTeacher.RowCount, index);
            T.ShowDialog();
            this.teacherTableAdapter.Fill(this.subjectBDDataSet.teacher);
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            string name = dgvTeacher.Rows[dgvTeacher.SelectedCells[0].RowIndex].Cells["firstNameTeacherDataGridViewTextBoxColumn"].Value.ToString() +
                " " + dgvTeacher.Rows[dgvTeacher.SelectedCells[0].RowIndex].Cells["nameTeacherDataGridViewTextBoxColumn"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Êtes-vous sur de vouloir effacer " + name.ToUpper() + "?", "Supprimer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                int index = Convert.ToInt32(dgvTeacher.Rows[dgvTeacher.SelectedCells[0].RowIndex].Cells["idTeacherDataGridViewTextBoxColumn"].Value);
                db.DeleteTeacher(index);
                this.teacherTableAdapter.Fill(this.subjectBDDataSet.teacher);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student ST = new Student(dgvStudent.RowCount);
            ST.ShowDialog();
            this.studentTableAdapter.Fill(this.subjectBDDataSet.student);
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvStudent.Rows[dgvStudent.SelectedCells[0].RowIndex].Cells["idStudentDataGridViewTextBoxColumn"].Value);
            Student ST = new Student(dgvStudent.RowCount, index);
            ST.ShowDialog();
            this.studentTableAdapter.Fill(this.subjectBDDataSet.student);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string name = dgvStudent.Rows[dgvStudent.SelectedCells[0].RowIndex].Cells["firstNameStudentDataGridViewTextBoxColumn"].Value.ToString() +
                " " + dgvStudent.Rows[dgvStudent.SelectedCells[0].RowIndex].Cells["nameStudentDataGridViewTextBoxColumn"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Êtes - vous sur de vouloir effacer " + name.ToUpper() + " ? ", "Supprimer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                int index = Convert.ToInt32(dgvStudent.Rows[dgvStudent.SelectedCells[0].RowIndex].Cells["idStudentDataGridViewTextBoxColumn"].Value);

                db.DeleteStudent(index);
                this.studentTableAdapter.Fill(this.subjectBDDataSet.student);
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            Subject SU = new Subject(dgvSubject.RowCount);
            SU.ShowDialog();
            this.subjectTableAdapter.Fill(this.subjectBDDataSet.subject);
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvSubject.Rows[dgvSubject.SelectedCells[0].RowIndex].Cells["idSubjectDataGridViewTextBoxColumn1"].Value);
            Subject SU = new Subject(dgvSubject.RowCount, index);
            SU.ShowDialog();
            this.subjectTableAdapter.Fill(this.subjectBDDataSet.subject);
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            string name = dgvSubject.Rows[dgvSubject.SelectedCells[0].RowIndex].Cells["nameSubjectDataGridViewTextBoxColumn"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Êtes - vous sur de vouloir effacer " + name.ToUpper() + " ? ", "Supprimer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                int index = Convert.ToInt32(dgvSubject.Rows[dgvSubject.SelectedCells[0].RowIndex].Cells["idSubjectDataGridViewTextBoxColumn1"].Value);

                db.DeleteSubject(index);
                this.subjectTableAdapter.Fill(this.subjectBDDataSet.subject);
            }
        }

        private void btnChooseSubject_Click(object sender, EventArgs e)
        {
            object itemStudent = cbxStudentAttribute.SelectedItem;
            System.Reflection.PropertyInfo valueStudent = itemStudent.GetType().GetProperty("Value");
            int selectedStudent = (Int32)(valueStudent.GetValue(itemStudent, null));

            object itemSubject = cbxSubjectAttribute.SelectedItem;
            System.Reflection.PropertyInfo valueSubject = itemSubject.GetType().GetProperty("Value");
            int selectedSubject = (Int32)(valueSubject.GetValue(itemSubject, null));

            object itemTeacher = cbxTeacherAttribute.SelectedItem;
            System.Reflection.PropertyInfo valueTeacher = itemTeacher.GetType().GetProperty("Value");
            int selectedTeacher = (Int32)(valueSubject.GetValue(itemTeacher, null));


            db.SetSubjectToStudentAndTeacher(selectedStudent, selectedSubject, selectedTeacher);
            Form1_Load(sender, e);

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            foreach (var s in avaibleStudent)
            {
                Random random = new Random();
                int rSubject = random.Next(0, avaibleSubject.Count() - 1);
                int rTeacher = random.Next(0, avaibleTeacher.Count() - 1);
                db.SetSubjectToStudentAndTeacher(s.IdStudent, avaibleSubject[rSubject].IdSubject, avaibleTeacher[rTeacher].IdTeacher);
                Form1_Load(sender, e);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try {
                this.studentTableAdapter.FillBy(this.subjectBDDataSet.student);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void freeStudentToolStripButton_Click(object sender, EventArgs e)
        {
            try {
                this.studentTableAdapter.freeStudent(this.subjectBDDataSet.student);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void bntExportData_Click(object sender, EventArgs e)
        {
            linkExcel LE = new linkExcel();
            LE.createFile();
        }
    }
}
