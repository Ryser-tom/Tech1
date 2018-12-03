namespace TPIV2
{
    partial class vue
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Enseignant = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.idTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbStudentTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBDDataSet = new TPIV2.SubjectBDDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeacherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.idSubjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.environnementSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSubjectAttribute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTeacherAttribute = new System.Windows.Forms.ComboBox();
            this.btnChooseSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStudentAttribute = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblImport = new System.Windows.Forms.Label();
            this.bntImportSubject = new System.Windows.Forms.Button();
            this.tbxPathSubject = new System.Windows.Forms.TextBox();
            this.bntImportStudent = new System.Windows.Forms.Button();
            this.tbxPathStudent = new System.Windows.Forms.TextBox();
            this.bntImportTeacher = new System.Windows.Forms.Button();
            this.tbxPathTeacher = new System.Windows.Forms.TextBox();
            this.cbDataToExport = new System.Windows.Forms.ComboBox();
            this.bntExportData = new System.Windows.Forms.Button();
            this.teacherTableAdapter = new TPIV2.SubjectBDDataSetTableAdapters.teacherTableAdapter();
            this.studentTableAdapter = new TPIV2.SubjectBDDataSetTableAdapters.studentTableAdapter();
            this.subjectTableAdapter = new TPIV2.SubjectBDDataSetTableAdapters.subjectTableAdapter();
            this.subjectBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Enseignant.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Enseignant
            // 
            this.Enseignant.Controls.Add(this.tabPage1);
            this.Enseignant.Controls.Add(this.tabPage2);
            this.Enseignant.Controls.Add(this.tabPage3);
            this.Enseignant.Controls.Add(this.tabPage4);
            this.Enseignant.Controls.Add(this.tabPage5);
            this.Enseignant.Location = new System.Drawing.Point(0, 0);
            this.Enseignant.Name = "Enseignant";
            this.Enseignant.SelectedIndex = 0;
            this.Enseignant.Size = new System.Drawing.Size(788, 438);
            this.Enseignant.TabIndex = 0;
            this.Enseignant.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "Enseignant";
            this.tabPage1.Controls.Add(this.btnAddTeacher);
            this.tabPage1.Controls.Add(this.btnDeleteTeacher);
            this.tabPage1.Controls.Add(this.btnUpdateTeacher);
            this.tabPage1.Controls.Add(this.dgvTeacher);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enseignant";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(652, 325);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(122, 23);
            this.btnAddTeacher.TabIndex = 7;
            this.btnAddTeacher.Text = "Ajouter";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(652, 383);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteTeacher.TabIndex = 6;
            this.btnDeleteTeacher.Text = "Effacer";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.Location = new System.Drawing.Point(652, 354);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(122, 23);
            this.btnUpdateTeacher.TabIndex = 5;
            this.btnUpdateTeacher.Text = "Mettre à jour";
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.AutoGenerateColumns = false;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTeacherDataGridViewTextBoxColumn,
            this.nameTeacherDataGridViewTextBoxColumn,
            this.firstNameTeacherDataGridViewTextBoxColumn,
            this.telTeacherDataGridViewTextBoxColumn,
            this.emailTeacherDataGridViewTextBoxColumn,
            this.nbStudentTeacherDataGridViewTextBoxColumn});
            this.dgvTeacher.DataSource = this.teacherBindingSource;
            this.dgvTeacher.Location = new System.Drawing.Point(0, 0);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.Size = new System.Drawing.Size(646, 406);
            this.dgvTeacher.TabIndex = 0;
            // 
            // idTeacherDataGridViewTextBoxColumn
            // 
            this.idTeacherDataGridViewTextBoxColumn.DataPropertyName = "IdTeacher";
            this.idTeacherDataGridViewTextBoxColumn.HeaderText = "IdTeacher";
            this.idTeacherDataGridViewTextBoxColumn.Name = "idTeacherDataGridViewTextBoxColumn";
            this.idTeacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameTeacherDataGridViewTextBoxColumn
            // 
            this.nameTeacherDataGridViewTextBoxColumn.DataPropertyName = "nameTeacher";
            this.nameTeacherDataGridViewTextBoxColumn.HeaderText = "nameTeacher";
            this.nameTeacherDataGridViewTextBoxColumn.Name = "nameTeacherDataGridViewTextBoxColumn";
            this.nameTeacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameTeacherDataGridViewTextBoxColumn
            // 
            this.firstNameTeacherDataGridViewTextBoxColumn.DataPropertyName = "firstNameTeacher";
            this.firstNameTeacherDataGridViewTextBoxColumn.HeaderText = "firstNameTeacher";
            this.firstNameTeacherDataGridViewTextBoxColumn.Name = "firstNameTeacherDataGridViewTextBoxColumn";
            this.firstNameTeacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telTeacherDataGridViewTextBoxColumn
            // 
            this.telTeacherDataGridViewTextBoxColumn.DataPropertyName = "telTeacher";
            this.telTeacherDataGridViewTextBoxColumn.HeaderText = "telTeacher";
            this.telTeacherDataGridViewTextBoxColumn.Name = "telTeacherDataGridViewTextBoxColumn";
            this.telTeacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailTeacherDataGridViewTextBoxColumn
            // 
            this.emailTeacherDataGridViewTextBoxColumn.DataPropertyName = "emailTeacher";
            this.emailTeacherDataGridViewTextBoxColumn.HeaderText = "emailTeacher";
            this.emailTeacherDataGridViewTextBoxColumn.Name = "emailTeacherDataGridViewTextBoxColumn";
            this.emailTeacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbStudentTeacherDataGridViewTextBoxColumn
            // 
            this.nbStudentTeacherDataGridViewTextBoxColumn.DataPropertyName = "nbStudentTeacher";
            this.nbStudentTeacherDataGridViewTextBoxColumn.HeaderText = "nbStudentTeacher";
            this.nbStudentTeacherDataGridViewTextBoxColumn.Name = "nbStudentTeacherDataGridViewTextBoxColumn";
            this.nbStudentTeacherDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddStudent);
            this.tabPage2.Controls.Add(this.btnDeleteStudent);
            this.tabPage2.Controls.Add(this.btnUpdateStudent);
            this.tabPage2.Controls.Add(this.dgvStudent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etudiant";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(652, 325);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(122, 23);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Ajouter";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(652, 383);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteStudent.TabIndex = 6;
            this.btnDeleteStudent.Text = "Effacer";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(652, 354);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(122, 23);
            this.btnUpdateStudent.TabIndex = 5;
            this.btnUpdateStudent.Text = "Mettre à jour";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.nameStudentDataGridViewTextBoxColumn,
            this.firstNameStudentDataGridViewTextBoxColumn,
            this.telStudentDataGridViewTextBoxColumn,
            this.emailStudentDataGridViewTextBoxColumn,
            this.idTeacherDataGridViewTextBoxColumn1,
            this.idSubjectDataGridViewTextBoxColumn});
            this.dgvStudent.DataSource = this.studentBindingSource;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(646, 406);
            this.dgvStudent.TabIndex = 1;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameStudentDataGridViewTextBoxColumn
            // 
            this.nameStudentDataGridViewTextBoxColumn.DataPropertyName = "nameStudent";
            this.nameStudentDataGridViewTextBoxColumn.HeaderText = "nameStudent";
            this.nameStudentDataGridViewTextBoxColumn.Name = "nameStudentDataGridViewTextBoxColumn";
            this.nameStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameStudentDataGridViewTextBoxColumn
            // 
            this.firstNameStudentDataGridViewTextBoxColumn.DataPropertyName = "firstNameStudent";
            this.firstNameStudentDataGridViewTextBoxColumn.HeaderText = "firstNameStudent";
            this.firstNameStudentDataGridViewTextBoxColumn.Name = "firstNameStudentDataGridViewTextBoxColumn";
            this.firstNameStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telStudentDataGridViewTextBoxColumn
            // 
            this.telStudentDataGridViewTextBoxColumn.DataPropertyName = "telStudent";
            this.telStudentDataGridViewTextBoxColumn.HeaderText = "telStudent";
            this.telStudentDataGridViewTextBoxColumn.Name = "telStudentDataGridViewTextBoxColumn";
            this.telStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailStudentDataGridViewTextBoxColumn
            // 
            this.emailStudentDataGridViewTextBoxColumn.DataPropertyName = "emailStudent";
            this.emailStudentDataGridViewTextBoxColumn.HeaderText = "emailStudent";
            this.emailStudentDataGridViewTextBoxColumn.Name = "emailStudentDataGridViewTextBoxColumn";
            this.emailStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTeacherDataGridViewTextBoxColumn1
            // 
            this.idTeacherDataGridViewTextBoxColumn1.DataPropertyName = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn1.HeaderText = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn1.Name = "idTeacherDataGridViewTextBoxColumn1";
            this.idTeacherDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idSubjectDataGridViewTextBoxColumn
            // 
            this.idSubjectDataGridViewTextBoxColumn.DataPropertyName = "idSubject";
            this.idSubjectDataGridViewTextBoxColumn.HeaderText = "idSubject";
            this.idSubjectDataGridViewTextBoxColumn.Name = "idSubjectDataGridViewTextBoxColumn";
            this.idSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.subjectBDDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddSubject);
            this.tabPage3.Controls.Add(this.btnDeleteSubject);
            this.tabPage3.Controls.Add(this.btnUpdateSubject);
            this.tabPage3.Controls.Add(this.dgvSubject);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sujet de TPI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(652, 325);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(122, 23);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Ajouter";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(652, 383);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteSubject.TabIndex = 3;
            this.btnDeleteSubject.Text = "Effacer";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(652, 354);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(122, 23);
            this.btnUpdateSubject.TabIndex = 2;
            this.btnUpdateSubject.Text = "Mettre à jour";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.AutoGenerateColumns = false;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSubjectDataGridViewTextBoxColumn1,
            this.nameSubjectDataGridViewTextBoxColumn,
            this.environnementSubject,
            this.objectiveSubject,
            this.descriptionSubject,
            this.dateSubject});
            this.dgvSubject.DataSource = this.subjectBindingSource;
            this.dgvSubject.Location = new System.Drawing.Point(0, 0);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.Size = new System.Drawing.Size(646, 406);
            this.dgvSubject.TabIndex = 1;
            // 
            // idSubjectDataGridViewTextBoxColumn1
            // 
            this.idSubjectDataGridViewTextBoxColumn1.DataPropertyName = "IdSubject";
            this.idSubjectDataGridViewTextBoxColumn1.HeaderText = "IdSubject";
            this.idSubjectDataGridViewTextBoxColumn1.Name = "idSubjectDataGridViewTextBoxColumn1";
            this.idSubjectDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameSubjectDataGridViewTextBoxColumn
            // 
            this.nameSubjectDataGridViewTextBoxColumn.DataPropertyName = "nameSubject";
            this.nameSubjectDataGridViewTextBoxColumn.HeaderText = "nameSubject";
            this.nameSubjectDataGridViewTextBoxColumn.Name = "nameSubjectDataGridViewTextBoxColumn";
            this.nameSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // environnementSubject
            // 
            this.environnementSubject.DataPropertyName = "environnementSubject";
            this.environnementSubject.HeaderText = "environnementSubject";
            this.environnementSubject.Name = "environnementSubject";
            this.environnementSubject.ReadOnly = true;
            // 
            // objectiveSubject
            // 
            this.objectiveSubject.DataPropertyName = "objectiveSubject";
            this.objectiveSubject.HeaderText = "objectiveSubject";
            this.objectiveSubject.Name = "objectiveSubject";
            this.objectiveSubject.ReadOnly = true;
            // 
            // descriptionSubject
            // 
            this.descriptionSubject.DataPropertyName = "descriptionSubject";
            this.descriptionSubject.HeaderText = "descriptionSubject";
            this.descriptionSubject.Name = "descriptionSubject";
            this.descriptionSubject.ReadOnly = true;
            // 
            // dateSubject
            // 
            this.dateSubject.DataPropertyName = "dateSubject";
            this.dateSubject.HeaderText = "dateSubject";
            this.dateSubject.Name = "dateSubject";
            this.dateSubject.ReadOnly = true;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.subjectBDDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRandom);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.cbxSubjectAttribute);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.cbxTeacherAttribute);
            this.tabPage4.Controls.Add(this.btnChooseSubject);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.cbxStudentAttribute);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(780, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Attribution des sujets";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(430, 159);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(152, 56);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Attribuer à tout les étudiants restant un sujet";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sujet";
            // 
            // cbxSubjectAttribute
            // 
            this.cbxSubjectAttribute.FormattingEnabled = true;
            this.cbxSubjectAttribute.Location = new System.Drawing.Point(92, 194);
            this.cbxSubjectAttribute.Name = "cbxSubjectAttribute";
            this.cbxSubjectAttribute.Size = new System.Drawing.Size(121, 21);
            this.cbxSubjectAttribute.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enseignant";
            // 
            // cbxTeacherAttribute
            // 
            this.cbxTeacherAttribute.FormattingEnabled = true;
            this.cbxTeacherAttribute.Location = new System.Drawing.Point(92, 140);
            this.cbxTeacherAttribute.Name = "cbxTeacherAttribute";
            this.cbxTeacherAttribute.Size = new System.Drawing.Size(121, 21);
            this.cbxTeacherAttribute.TabIndex = 3;
            // 
            // btnChooseSubject
            // 
            this.btnChooseSubject.Location = new System.Drawing.Point(29, 238);
            this.btnChooseSubject.Name = "btnChooseSubject";
            this.btnChooseSubject.Size = new System.Drawing.Size(184, 23);
            this.btnChooseSubject.TabIndex = 2;
            this.btnChooseSubject.Text = "Attribuer sujet";
            this.btnChooseSubject.UseVisualStyleBackColor = true;
            this.btnChooseSubject.Click += new System.EventHandler(this.btnChooseSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etudiant";
            // 
            // cbxStudentAttribute
            // 
            this.cbxStudentAttribute.FormattingEnabled = true;
            this.cbxStudentAttribute.Location = new System.Drawing.Point(92, 167);
            this.cbxStudentAttribute.Name = "cbxStudentAttribute";
            this.cbxStudentAttribute.Size = new System.Drawing.Size(121, 21);
            this.cbxStudentAttribute.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblImport);
            this.tabPage5.Controls.Add(this.bntImportSubject);
            this.tabPage5.Controls.Add(this.tbxPathSubject);
            this.tabPage5.Controls.Add(this.bntImportStudent);
            this.tabPage5.Controls.Add(this.tbxPathStudent);
            this.tabPage5.Controls.Add(this.bntImportTeacher);
            this.tabPage5.Controls.Add(this.tbxPathTeacher);
            this.tabPage5.Controls.Add(this.cbDataToExport);
            this.tabPage5.Controls.Add(this.bntExportData);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(780, 412);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Mise à jour des informations";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Location = new System.Drawing.Point(449, 138);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(108, 13);
            this.lblImport.TabIndex = 8;
            this.lblImport.Text = "Importer Fichier Excel";
            // 
            // bntImportSubject
            // 
            this.bntImportSubject.Enabled = false;
            this.bntImportSubject.Location = new System.Drawing.Point(622, 238);
            this.bntImportSubject.Name = "bntImportSubject";
            this.bntImportSubject.Size = new System.Drawing.Size(75, 23);
            this.bntImportSubject.TabIndex = 7;
            this.bntImportSubject.Text = "Sujets";
            this.bntImportSubject.UseVisualStyleBackColor = true;
            // 
            // tbxPathSubject
            // 
            this.tbxPathSubject.Enabled = false;
            this.tbxPathSubject.Location = new System.Drawing.Point(406, 238);
            this.tbxPathSubject.Name = "tbxPathSubject";
            this.tbxPathSubject.Size = new System.Drawing.Size(200, 20);
            this.tbxPathSubject.TabIndex = 6;
            // 
            // bntImportStudent
            // 
            this.bntImportStudent.Enabled = false;
            this.bntImportStudent.Location = new System.Drawing.Point(622, 212);
            this.bntImportStudent.Name = "bntImportStudent";
            this.bntImportStudent.Size = new System.Drawing.Size(75, 23);
            this.bntImportStudent.TabIndex = 5;
            this.bntImportStudent.Text = "Etudiants";
            this.bntImportStudent.UseVisualStyleBackColor = true;
            // 
            // tbxPathStudent
            // 
            this.tbxPathStudent.Enabled = false;
            this.tbxPathStudent.Location = new System.Drawing.Point(406, 212);
            this.tbxPathStudent.Name = "tbxPathStudent";
            this.tbxPathStudent.Size = new System.Drawing.Size(200, 20);
            this.tbxPathStudent.TabIndex = 4;
            // 
            // bntImportTeacher
            // 
            this.bntImportTeacher.Enabled = false;
            this.bntImportTeacher.Location = new System.Drawing.Point(622, 186);
            this.bntImportTeacher.Name = "bntImportTeacher";
            this.bntImportTeacher.Size = new System.Drawing.Size(75, 23);
            this.bntImportTeacher.TabIndex = 3;
            this.bntImportTeacher.Text = "Enseignants";
            this.bntImportTeacher.UseVisualStyleBackColor = true;
            // 
            // tbxPathTeacher
            // 
            this.tbxPathTeacher.Enabled = false;
            this.tbxPathTeacher.Location = new System.Drawing.Point(406, 186);
            this.tbxPathTeacher.Name = "tbxPathTeacher";
            this.tbxPathTeacher.Size = new System.Drawing.Size(200, 20);
            this.tbxPathTeacher.TabIndex = 2;
            // 
            // cbDataToExport
            // 
            this.cbDataToExport.Enabled = false;
            this.cbDataToExport.FormattingEnabled = true;
            this.cbDataToExport.Items.AddRange(new object[] {
            "Enseignants",
            "Etudiants",
            "Sujets",
            "Tout"});
            this.cbDataToExport.Location = new System.Drawing.Point(44, 183);
            this.cbDataToExport.Name = "cbDataToExport";
            this.cbDataToExport.Size = new System.Drawing.Size(200, 21);
            this.cbDataToExport.TabIndex = 1;
            // 
            // bntExportData
            // 
            this.bntExportData.Location = new System.Drawing.Point(260, 183);
            this.bntExportData.Name = "bntExportData";
            this.bntExportData.Size = new System.Drawing.Size(75, 23);
            this.bntExportData.TabIndex = 0;
            this.bntExportData.Text = "Exporter";
            this.bntExportData.UseVisualStyleBackColor = true;
            this.bntExportData.Click += new System.EventHandler(this.bntExportData_Click);
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // subjectBDDataSetBindingSource
            // 
            this.subjectBDDataSetBindingSource.DataSource = this.subjectBDDataSet;
            this.subjectBDDataSetBindingSource.Position = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // vue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enseignant);
            this.Name = "vue";
            this.Text = "Sujet TPI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enseignant.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Enseignant;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private SubjectBDDataSet subjectBDDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private SubjectBDDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbStudentTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private SubjectBDDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SubjectBDDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Button bntExportData;
        private System.Windows.Forms.ComboBox cbDataToExport;
        private System.Windows.Forms.BindingSource subjectBDDataSetBindingSource;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Button bntImportSubject;
        private System.Windows.Forms.TextBox tbxPathSubject;
        private System.Windows.Forms.Button bntImportStudent;
        private System.Windows.Forms.TextBox tbxPathStudent;
        private System.Windows.Forms.Button bntImportTeacher;
        private System.Windows.Forms.TextBox tbxPathTeacher;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSubjectAttribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTeacherAttribute;
        private System.Windows.Forms.Button btnChooseSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStudentAttribute;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubjectDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn environnementSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSubject;
    }
}

