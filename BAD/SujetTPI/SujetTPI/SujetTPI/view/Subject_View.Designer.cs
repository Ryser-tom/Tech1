namespace SujetTPI
{
    partial class Subject_View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverableSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesurableSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBDDataSet = new SujetTPI.SubjectBDDataSet();
            this.subjectTableAdapter = new SujetTPI.SubjectBDDataSetTableAdapters.subjectTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSubjectDataGridViewTextBoxColumn,
            this.titleSubjectDataGridViewTextBoxColumn,
            this.objectiveSubjectDataGridViewTextBoxColumn,
            this.descriptionSubjectDataGridViewTextBoxColumn,
            this.deliverableSubjectDataGridViewTextBoxColumn,
            this.mesurableSubjectDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameSubjectDataGridViewTextBoxColumn
            // 
            this.nameSubjectDataGridViewTextBoxColumn.DataPropertyName = "nameSubject";
            this.nameSubjectDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nameSubjectDataGridViewTextBoxColumn.Name = "nameSubjectDataGridViewTextBoxColumn";
            // 
            // titleSubjectDataGridViewTextBoxColumn
            // 
            this.titleSubjectDataGridViewTextBoxColumn.DataPropertyName = "titleSubject";
            this.titleSubjectDataGridViewTextBoxColumn.HeaderText = "titre";
            this.titleSubjectDataGridViewTextBoxColumn.Name = "titleSubjectDataGridViewTextBoxColumn";
            // 
            // objectiveSubjectDataGridViewTextBoxColumn
            // 
            this.objectiveSubjectDataGridViewTextBoxColumn.DataPropertyName = "objectiveSubject";
            this.objectiveSubjectDataGridViewTextBoxColumn.HeaderText = "objectif";
            this.objectiveSubjectDataGridViewTextBoxColumn.Name = "objectiveSubjectDataGridViewTextBoxColumn";
            // 
            // descriptionSubjectDataGridViewTextBoxColumn
            // 
            this.descriptionSubjectDataGridViewTextBoxColumn.DataPropertyName = "descriptionSubject";
            this.descriptionSubjectDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionSubjectDataGridViewTextBoxColumn.Name = "descriptionSubjectDataGridViewTextBoxColumn";
            // 
            // deliverableSubjectDataGridViewTextBoxColumn
            // 
            this.deliverableSubjectDataGridViewTextBoxColumn.DataPropertyName = "deliverableSubject";
            this.deliverableSubjectDataGridViewTextBoxColumn.HeaderText = "déliverable";
            this.deliverableSubjectDataGridViewTextBoxColumn.Name = "deliverableSubjectDataGridViewTextBoxColumn";
            // 
            // mesurableSubjectDataGridViewTextBoxColumn
            // 
            this.mesurableSubjectDataGridViewTextBoxColumn.DataPropertyName = "mesurableSubject";
            this.mesurableSubjectDataGridViewTextBoxColumn.HeaderText = "mesurable";
            this.mesurableSubjectDataGridViewTextBoxColumn.Name = "mesurableSubjectDataGridViewTextBoxColumn";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.subjectBDDataSet;
            // 
            // subjectBDDataSet
            // 
            this.subjectBDDataSet.DataSetName = "SubjectBDDataSet";
            this.subjectBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(731, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(731, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(731, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "retour";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(731, 12);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(148, 23);
            this.btnMore.TabIndex = 7;
            this.btnMore.Text = "Afficher plus d\'informations";
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // Subject_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Subject_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject_View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subject_view_FormClosing);
            this.Load += new System.EventHandler(this.Subject_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SubjectBDDataSet subjectBDDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SubjectBDDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverableSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesurableSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMore;
    }
}