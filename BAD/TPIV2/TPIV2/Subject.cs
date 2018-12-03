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
    public partial class Subject : Form
    {
        private int count = 0;
        private bool update = false;
        private Dictionary<string, string> subjectD = new Dictionary<string, string>();
        private Dictionary<int, string> typeD = new Dictionary<int, string>();

        public Subject(int count)
        {
            this.GetType();
            this.count = count;
            InitializeComponent();

            cbxType.DataSource = new BindingSource(typeD, null);
            cbxType.DisplayMember = "Value";
            cbxType.ValueMember = "Key";
        }

        public Subject(int count, int idSubject)
        {
            this.count = count;
            GetSubject(idSubject);
            this.GetType();
            InitializeComponent();
            update = true;

            this.Text = subjectD["SubjectName"];
            tbxName.Text = subjectD["SubjectName"];
            dtpDate.Text = subjectD["SubjectDate"];
            cbxType.DataSource = new BindingSource(typeD, null);
            cbxType.DisplayMember = "Value";
            cbxType.ValueMember = "Key";
            tbxEnvironnement.Text = subjectD["SubjectEnvironnement"];
            tbxObjective.Text = subjectD["SubjectObjective"];
            tbxDescription.Text = subjectD["SubjectDescription"];
        }

        private void GetSubject(int index)
        {
            DataClassesDataContext DB = new DataClassesDataContext();
            var requete = from subject in DB.subject
                          where subject.IdSubject == index
                          select subject;

            foreach (var subject in requete) {
                subjectD.Add("SubjectId", Convert.ToString(subject.IdSubject));
                subjectD.Add("SubjectName", subject.nameSubject);
                subjectD.Add("SubjectDate", subject.dateSubject);
                subjectD.Add("SubjectEnvironnement", subject.environnementSubject);
                subjectD.Add("SubjectObjective", subject.objectiveSubject);
                subjectD.Add("SubjectDescription", subject.descriptionSubject);
                subjectD.Add("SubjectType", Convert.ToString(subject.idType));
            }
            try { DB.SubmitChanges(); } catch (Exception ex) {
                MessageBox.Show(ex.Message); // ici éventuellement réessayer }
            }
        }
        private new void GetType()
        {
            DataClassesDataContext DB = new DataClassesDataContext();
            var requete = from type in DB.type
                          select type;

            foreach (var type in requete) {
                typeD.Add(type.IdType, type.nameType);
            }
            try { DB.SubmitChanges(); } catch (Exception ex) {
                MessageBox.Show(ex.Message); // ici éventuellement réessayer }
            }
        }

        private void UpdateSubject()
        {
            DataClassesDataContext DB = new DataClassesDataContext();

            var requete = from subject in DB.subject
                          where subject.IdSubject == Convert.ToInt32(subjectD["SubjectId"])
                          select subject;

            foreach (var subject in requete) {
                subject.nameSubject = tbxName.Text;
                subject.dateSubject = dtpDate.Text;
                subject.environnementSubject = tbxEnvironnement.Text;
                subject.objectiveSubject = tbxObjective.Text;
                subject.descriptionSubject = tbxDescription.Text;
                try {
                    DB.SubmitChanges();
                    this.Close();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CreateSubject()
        {
            DataClassesDataContext DB = new DataClassesDataContext(); subject cl = new subject();

            cl.IdSubject = count;
            cl.nameSubject = tbxName.Text;
            cl.dateSubject = dtpDate.Text;
            cl.environnementSubject = tbxEnvironnement.Text;
            cl.objectiveSubject = tbxObjective.Text;
            cl.descriptionSubject = tbxDescription.Text;
            DB.subject.InsertOnSubmit(cl);
            try {
                DB.SubmitChanges();
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (update) {
                UpdateSubject();
            } else {
                CreateSubject();
            }
        }
    }
}
