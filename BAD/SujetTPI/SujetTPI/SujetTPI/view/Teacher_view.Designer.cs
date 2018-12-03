namespace SujetTPI
{
    partial class Teacher_view
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
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.dgv_teacher = new System.Windows.Forms.DataGridView();
            this.nameTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbStudentTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBDDataSet = new SujetTPI.SubjectBDDataSet();
            this.teacherTableAdapter = new SujetTPI.SubjectBDDataSetTableAdapters.teacherTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter un enseignant";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_delete
            // 
            this.Btn_delete.Location = new System.Drawing.Point(660, 12);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(128, 23);
            this.Btn_delete.TabIndex = 1;
            this.Btn_delete.Text = "effacer un enseignant";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // dgv_teacher
            // 
            this.dgv_teacher.AutoGenerateColumns = false;
            this.dgv_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameTeacherDataGridViewTextBoxColumn,
            this.firstNameTeacherDataGridViewTextBoxColumn,
            this.telTeacherDataGridViewTextBoxColumn,
            this.emailTeacherDataGridViewTextBoxColumn,
            this.nbStudentTeacherDataGridViewTextBoxColumn});
            this.dgv_teacher.DataSource = this.teacherBindingSource;
            this.dgv_teacher.Location = new System.Drawing.Point(0, 0);
            this.dgv_teacher.Name = "dgv_teacher";
            this.dgv_teacher.Size = new System.Drawing.Size(654, 450);
            this.dgv_teacher.TabIndex = 2;
            this.dgv_teacher.SelectionChanged += new System.EventHandler(this.dgv_teacher_SelectionChanged);
            // 
            // nameTeacherDataGridViewTextBoxColumn
            // 
            this.nameTeacherDataGridViewTextBoxColumn.DataPropertyName = "nameTeacher";
            this.nameTeacherDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nameTeacherDataGridViewTextBoxColumn.Name = "nameTeacherDataGridViewTextBoxColumn";
            // 
            // firstNameTeacherDataGridViewTextBoxColumn
            // 
            this.firstNameTeacherDataGridViewTextBoxColumn.DataPropertyName = "firstNameTeacher";
            this.firstNameTeacherDataGridViewTextBoxColumn.HeaderText = "prénom";
            this.firstNameTeacherDataGridViewTextBoxColumn.Name = "firstNameTeacherDataGridViewTextBoxColumn";
            // 
            // telTeacherDataGridViewTextBoxColumn
            // 
            this.telTeacherDataGridViewTextBoxColumn.DataPropertyName = "telTeacher";
            this.telTeacherDataGridViewTextBoxColumn.HeaderText = "téléphone";
            this.telTeacherDataGridViewTextBoxColumn.Name = "telTeacherDataGridViewTextBoxColumn";
            // 
            // emailTeacherDataGridViewTextBoxColumn
            // 
            this.emailTeacherDataGridViewTextBoxColumn.DataPropertyName = "emailTeacher";
            this.emailTeacherDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailTeacherDataGridViewTextBoxColumn.Name = "emailTeacherDataGridViewTextBoxColumn";
            // 
            // nbStudentTeacherDataGridViewTextBoxColumn
            // 
            this.nbStudentTeacherDataGridViewTextBoxColumn.DataPropertyName = "nbStudentTeacher";
            this.nbStudentTeacherDataGridViewTextBoxColumn.HeaderText = "nombre d\'étudiant max";
            this.nbStudentTeacherDataGridViewTextBoxColumn.Name = "nbStudentTeacherDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.subjectBDDataSet;
            // 
            // subjectBDDataSet
            // 
            this.subjectBDDataSet.DataSetName = "SubjectBDDataSet";
            this.subjectBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(660, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.Teacher_close);
            // 
            // Teacher_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgv_teacher);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.button1);
            this.Name = "Teacher_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher_view";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Teacher_view_FormClosing);
            this.Load += new System.EventHandler(this.Teacher_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.DataGridView dgv_teacher;
        private SubjectBDDataSet subjectBDDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private SubjectBDDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbStudentTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
    }
}