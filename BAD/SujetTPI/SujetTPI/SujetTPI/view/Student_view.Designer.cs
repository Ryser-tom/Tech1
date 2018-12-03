namespace SujetTPI
{
    partial class Student_view
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBDDataSet = new SujetTPI.SubjectBDDataSet();
            this.studentTableAdapter = new SujetTPI.SubjectBDDataSetTableAdapters.studentTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.nameStudentDataGridViewTextBoxColumn,
            this.firstNameStudentDataGridViewTextBoxColumn,
            this.telStudentDataGridViewTextBoxColumn,
            this.emailStudentDataGridViewTextBoxColumn,
            this.idTeacherDataGridViewTextBoxColumn,
            this.idSubjectDataGridViewTextBoxColumn});
            this.dgvStudent.DataSource = this.studentBindingSource;
            this.dgvStudent.Location = new System.Drawing.Point(12, 12);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(749, 426);
            this.dgvStudent.TabIndex = 0;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            // 
            // nameStudentDataGridViewTextBoxColumn
            // 
            this.nameStudentDataGridViewTextBoxColumn.DataPropertyName = "nameStudent";
            this.nameStudentDataGridViewTextBoxColumn.HeaderText = "nameStudent";
            this.nameStudentDataGridViewTextBoxColumn.Name = "nameStudentDataGridViewTextBoxColumn";
            // 
            // firstNameStudentDataGridViewTextBoxColumn
            // 
            this.firstNameStudentDataGridViewTextBoxColumn.DataPropertyName = "firstNameStudent";
            this.firstNameStudentDataGridViewTextBoxColumn.HeaderText = "firstNameStudent";
            this.firstNameStudentDataGridViewTextBoxColumn.Name = "firstNameStudentDataGridViewTextBoxColumn";
            // 
            // telStudentDataGridViewTextBoxColumn
            // 
            this.telStudentDataGridViewTextBoxColumn.DataPropertyName = "telStudent";
            this.telStudentDataGridViewTextBoxColumn.HeaderText = "telStudent";
            this.telStudentDataGridViewTextBoxColumn.Name = "telStudentDataGridViewTextBoxColumn";
            // 
            // emailStudentDataGridViewTextBoxColumn
            // 
            this.emailStudentDataGridViewTextBoxColumn.DataPropertyName = "emailStudent";
            this.emailStudentDataGridViewTextBoxColumn.HeaderText = "emailStudent";
            this.emailStudentDataGridViewTextBoxColumn.Name = "emailStudentDataGridViewTextBoxColumn";
            // 
            // idTeacherDataGridViewTextBoxColumn
            // 
            this.idTeacherDataGridViewTextBoxColumn.DataPropertyName = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn.HeaderText = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn.Name = "idTeacherDataGridViewTextBoxColumn";
            // 
            // idSubjectDataGridViewTextBoxColumn
            // 
            this.idSubjectDataGridViewTextBoxColumn.DataPropertyName = "idSubject";
            this.idSubjectDataGridViewTextBoxColumn.HeaderText = "idSubject";
            this.idSubjectDataGridViewTextBoxColumn.Name = "idSubjectDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.subjectBDDataSetBindingSource;
            // 
            // subjectBDDataSetBindingSource
            // 
            this.subjectBDDataSetBindingSource.DataSource = this.subjectBDDataSet;
            this.subjectBDDataSetBindingSource.Position = 0;
            // 
            // subjectBDDataSet
            // 
            this.subjectBDDataSet.DataSetName = "SubjectBDDataSet";
            this.subjectBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(806, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.Student_close);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(806, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(806, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Student_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvStudent);
            this.Name = "Student_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_view";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_view_FormClosing);
            this.Load += new System.EventHandler(this.Student_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.BindingSource subjectBDDataSetBindingSource;
        private SubjectBDDataSet subjectBDDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private SubjectBDDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}