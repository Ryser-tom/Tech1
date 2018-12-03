namespace CSharp_et_SQLite
{
    partial class frmCSharp_et_SQLite
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
            this.gbxAffichage = new System.Windows.Forms.GroupBox();
            this.tbxAffichage = new System.Windows.Forms.TextBox();
            this.gbxInsert = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.tbxInsertPrenom = new System.Windows.Forms.TextBox();
            this.tbnInsert = new System.Windows.Forms.Button();
            this.tbxInsertNom = new System.Windows.Forms.TextBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUpdateId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUpdatePrenom = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateNom = new System.Windows.Forms.TextBox();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDeleteId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxAffichage.SuspendLayout();
            this.gbxInsert.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAffichage
            // 
            this.gbxAffichage.Controls.Add(this.tbxAffichage);
            this.gbxAffichage.Location = new System.Drawing.Point(12, 13);
            this.gbxAffichage.Name = "gbxAffichage";
            this.gbxAffichage.Size = new System.Drawing.Size(406, 153);
            this.gbxAffichage.TabIndex = 0;
            this.gbxAffichage.TabStop = false;
            this.gbxAffichage.Text = " Affichage Table \"TClients\" (tri par Nom croissant) ";
            // 
            // tbxAffichage
            // 
            this.tbxAffichage.Location = new System.Drawing.Point(7, 20);
            this.tbxAffichage.Multiline = true;
            this.tbxAffichage.Name = "tbxAffichage";
            this.tbxAffichage.ReadOnly = true;
            this.tbxAffichage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxAffichage.Size = new System.Drawing.Size(393, 112);
            this.tbxAffichage.TabIndex = 0;
            this.tbxAffichage.TabStop = false;
            // 
            // gbxInsert
            // 
            this.gbxInsert.Controls.Add(this.label2);
            this.gbxInsert.Controls.Add(this.Nom);
            this.gbxInsert.Controls.Add(this.tbxInsertPrenom);
            this.gbxInsert.Controls.Add(this.tbnInsert);
            this.gbxInsert.Controls.Add(this.tbxInsertNom);
            this.gbxInsert.Location = new System.Drawing.Point(12, 172);
            this.gbxInsert.Name = "gbxInsert";
            this.gbxInsert.Size = new System.Drawing.Size(406, 69);
            this.gbxInsert.TabIndex = 0;
            this.gbxInsert.TabStop = false;
            this.gbxInsert.Text = "Insert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom :";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(44, 20);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(35, 13);
            this.Nom.TabIndex = 4;
            this.Nom.Text = "Nom :";
            // 
            // tbxInsertPrenom
            // 
            this.tbxInsertPrenom.Location = new System.Drawing.Point(197, 37);
            this.tbxInsertPrenom.Name = "tbxInsertPrenom";
            this.tbxInsertPrenom.Size = new System.Drawing.Size(120, 20);
            this.tbxInsertPrenom.TabIndex = 1;
            // 
            // tbnInsert
            // 
            this.tbnInsert.Location = new System.Drawing.Point(323, 35);
            this.tbnInsert.Name = "tbnInsert";
            this.tbnInsert.Size = new System.Drawing.Size(75, 23);
            this.tbnInsert.TabIndex = 2;
            this.tbnInsert.Text = "Insert";
            this.tbnInsert.UseVisualStyleBackColor = true;
            this.tbnInsert.Click += new System.EventHandler(this.tbnInsert_Click);
            // 
            // tbxInsertNom
            // 
            this.tbxInsertNom.Location = new System.Drawing.Point(6, 37);
            this.tbxInsertNom.Name = "tbxInsertNom";
            this.tbxInsertNom.Size = new System.Drawing.Size(185, 20);
            this.tbxInsertNom.TabIndex = 0;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.label4);
            this.gbxUpdate.Controls.Add(this.tbxUpdateId);
            this.gbxUpdate.Controls.Add(this.label1);
            this.gbxUpdate.Controls.Add(this.label3);
            this.gbxUpdate.Controls.Add(this.tbxUpdatePrenom);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUpdateNom);
            this.gbxUpdate.Location = new System.Drawing.Point(12, 247);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(406, 69);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id :";
            // 
            // tbxUpdateId
            // 
            this.tbxUpdateId.Location = new System.Drawing.Point(6, 37);
            this.tbxUpdateId.Name = "tbxUpdateId";
            this.tbxUpdateId.Size = new System.Drawing.Size(35, 20);
            this.tbxUpdateId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom :";
            // 
            // tbxUpdatePrenom
            // 
            this.tbxUpdatePrenom.Location = new System.Drawing.Point(197, 37);
            this.tbxUpdatePrenom.Name = "tbxUpdatePrenom";
            this.tbxUpdatePrenom.Size = new System.Drawing.Size(120, 20);
            this.tbxUpdatePrenom.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(323, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateNom
            // 
            this.tbxUpdateNom.Location = new System.Drawing.Point(47, 37);
            this.tbxUpdateNom.Name = "tbxUpdateNom";
            this.tbxUpdateNom.Size = new System.Drawing.Size(144, 20);
            this.tbxUpdateNom.TabIndex = 1;
            // 
            // gbxDelete
            // 
            this.gbxDelete.Controls.Add(this.label5);
            this.gbxDelete.Controls.Add(this.tbxDeleteId);
            this.gbxDelete.Controls.Add(this.btnDelete);
            this.gbxDelete.Location = new System.Drawing.Point(12, 322);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(406, 55);
            this.gbxDelete.TabIndex = 2;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id :";
            // 
            // tbxDeleteId
            // 
            this.tbxDeleteId.Location = new System.Drawing.Point(41, 17);
            this.tbxDeleteId.Name = "tbxDeleteId";
            this.tbxDeleteId.Size = new System.Drawing.Size(276, 20);
            this.tbxDeleteId.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCSharp_et_SQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 389);
            this.Controls.Add(this.gbxDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxInsert);
            this.Controls.Add(this.gbxAffichage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCSharp_et_SQLite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# & SQLite (clients)...";
            this.gbxAffichage.ResumeLayout(false);
            this.gbxAffichage.PerformLayout();
            this.gbxInsert.ResumeLayout(false);
            this.gbxInsert.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxDelete.ResumeLayout(false);
            this.gbxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAffichage;
        private System.Windows.Forms.TextBox tbxAffichage;
        private System.Windows.Forms.GroupBox gbxInsert;
        private System.Windows.Forms.Button tbnInsert;
        private System.Windows.Forms.TextBox tbxInsertNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox tbxInsertPrenom;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUpdateId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUpdatePrenom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateNom;
        private System.Windows.Forms.GroupBox gbxDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDeleteId;
        private System.Windows.Forms.Button btnDelete;
    }
}

