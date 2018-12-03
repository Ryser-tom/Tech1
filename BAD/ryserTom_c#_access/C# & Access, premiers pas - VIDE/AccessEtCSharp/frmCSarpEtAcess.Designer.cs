namespace AccessEtCSharp
{
    partial class frmCSarpEtAcess
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
            this.gbxListeAlbums = new System.Windows.Forms.GroupBox();
            this.tbxAlbum = new System.Windows.Forms.TextBox();
            this.gbxNouvelAlbum = new System.Windows.Forms.GroupBox();
            this.cbxInsertNomArtiste = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomAlbumInsert = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbxInsertNomAlbum = new System.Windows.Forms.TextBox();
            this.gbxSuppression = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDeleteAlbum = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxMiseAJour = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxUpdateId = new System.Windows.Forms.TextBox();
            this.cbxUpdateNomArtiste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateNomAlbum = new System.Windows.Forms.TextBox();
            this.gbxListeAlbums.SuspendLayout();
            this.gbxNouvelAlbum.SuspendLayout();
            this.gbxSuppression.SuspendLayout();
            this.gbxMiseAJour.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxListeAlbums
            // 
            this.gbxListeAlbums.Controls.Add(this.tbxAlbum);
            this.gbxListeAlbums.Location = new System.Drawing.Point(12, 13);
            this.gbxListeAlbums.Name = "gbxListeAlbums";
            this.gbxListeAlbums.Size = new System.Drawing.Size(465, 153);
            this.gbxListeAlbums.TabIndex = 0;
            this.gbxListeAlbums.TabStop = false;
            this.gbxListeAlbums.Text = " Liste des albums ";
            // 
            // tbxAlbum
            // 
            this.tbxAlbum.Location = new System.Drawing.Point(11, 21);
            this.tbxAlbum.Multiline = true;
            this.tbxAlbum.Name = "tbxAlbum";
            this.tbxAlbum.ReadOnly = true;
            this.tbxAlbum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxAlbum.ShortcutsEnabled = false;
            this.tbxAlbum.Size = new System.Drawing.Size(443, 117);
            this.tbxAlbum.TabIndex = 0;
            this.tbxAlbum.TabStop = false;
            // 
            // gbxNouvelAlbum
            // 
            this.gbxNouvelAlbum.Controls.Add(this.cbxInsertNomArtiste);
            this.gbxNouvelAlbum.Controls.Add(this.label2);
            this.gbxNouvelAlbum.Controls.Add(this.lblNomAlbumInsert);
            this.gbxNouvelAlbum.Controls.Add(this.btnInsert);
            this.gbxNouvelAlbum.Controls.Add(this.tbxInsertNomAlbum);
            this.gbxNouvelAlbum.Location = new System.Drawing.Point(12, 177);
            this.gbxNouvelAlbum.Name = "gbxNouvelAlbum";
            this.gbxNouvelAlbum.Size = new System.Drawing.Size(465, 69);
            this.gbxNouvelAlbum.TabIndex = 0;
            this.gbxNouvelAlbum.TabStop = false;
            this.gbxNouvelAlbum.Text = " Nouvel album ";
            // 
            // cbxInsertNomArtiste
            // 
            this.cbxInsertNomArtiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInsertNomArtiste.FormattingEnabled = true;
            this.cbxInsertNomArtiste.Location = new System.Drawing.Point(226, 38);
            this.cbxInsertNomArtiste.Name = "cbxInsertNomArtiste";
            this.cbxInsertNomArtiste.Size = new System.Drawing.Size(146, 21);
            this.cbxInsertNomArtiste.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom de l\'artiste :";
            // 
            // lblNomAlbumInsert
            // 
            this.lblNomAlbumInsert.AutoSize = true;
            this.lblNomAlbumInsert.Location = new System.Drawing.Point(54, 22);
            this.lblNomAlbumInsert.Name = "lblNomAlbumInsert";
            this.lblNomAlbumInsert.Size = new System.Drawing.Size(85, 13);
            this.lblNomAlbumInsert.TabIndex = 4;
            this.lblNomAlbumInsert.Text = "Nom de l\'album :";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(379, 36);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbxInsertNomAlbum
            // 
            this.tbxInsertNomAlbum.Location = new System.Drawing.Point(57, 39);
            this.tbxInsertNomAlbum.Name = "tbxInsertNomAlbum";
            this.tbxInsertNomAlbum.Size = new System.Drawing.Size(163, 20);
            this.tbxInsertNomAlbum.TabIndex = 0;
            // 
            // gbxSuppression
            // 
            this.gbxSuppression.Controls.Add(this.label5);
            this.gbxSuppression.Controls.Add(this.tbxDeleteAlbum);
            this.gbxSuppression.Controls.Add(this.btnDelete);
            this.gbxSuppression.Location = new System.Drawing.Point(12, 349);
            this.gbxSuppression.Name = "gbxSuppression";
            this.gbxSuppression.Size = new System.Drawing.Size(465, 69);
            this.gbxSuppression.TabIndex = 2;
            this.gbxSuppression.TabStop = false;
            this.gbxSuppression.Text = " Suppression d\'un album ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Id :";
            // 
            // tbxDeleteAlbum
            // 
            this.tbxDeleteAlbum.Location = new System.Drawing.Point(41, 30);
            this.tbxDeleteAlbum.Name = "tbxDeleteAlbum";
            this.tbxDeleteAlbum.Size = new System.Drawing.Size(331, 20);
            this.tbxDeleteAlbum.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(379, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxMiseAJour
            // 
            this.gbxMiseAJour.Controls.Add(this.label8);
            this.gbxMiseAJour.Controls.Add(this.tbxUpdateId);
            this.gbxMiseAJour.Controls.Add(this.cbxUpdateNomArtiste);
            this.gbxMiseAJour.Controls.Add(this.label6);
            this.gbxMiseAJour.Controls.Add(this.label7);
            this.gbxMiseAJour.Controls.Add(this.btnUpdate);
            this.gbxMiseAJour.Controls.Add(this.tbxUpdateNomAlbum);
            this.gbxMiseAJour.Location = new System.Drawing.Point(12, 264);
            this.gbxMiseAJour.Name = "gbxMiseAJour";
            this.gbxMiseAJour.Size = new System.Drawing.Size(465, 69);
            this.gbxMiseAJour.TabIndex = 1;
            this.gbxMiseAJour.TabStop = false;
            this.gbxMiseAJour.Text = " Mise à jour d\'un album ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Id :";
            // 
            // tbxUpdateId
            // 
            this.tbxUpdateId.Location = new System.Drawing.Point(16, 39);
            this.tbxUpdateId.Name = "tbxUpdateId";
            this.tbxUpdateId.Size = new System.Drawing.Size(35, 20);
            this.tbxUpdateId.TabIndex = 0;
            // 
            // cbxUpdateNomArtiste
            // 
            this.cbxUpdateNomArtiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpdateNomArtiste.FormattingEnabled = true;
            this.cbxUpdateNomArtiste.Location = new System.Drawing.Point(226, 38);
            this.cbxUpdateNomArtiste.Name = "cbxUpdateNomArtiste";
            this.cbxUpdateNomArtiste.Size = new System.Drawing.Size(146, 21);
            this.cbxUpdateNomArtiste.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nom de l\'artiste :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nom de l\'album :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(379, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateNomAlbum
            // 
            this.tbxUpdateNomAlbum.Location = new System.Drawing.Point(57, 39);
            this.tbxUpdateNomAlbum.Name = "tbxUpdateNomAlbum";
            this.tbxUpdateNomAlbum.Size = new System.Drawing.Size(163, 20);
            this.tbxUpdateNomAlbum.TabIndex = 1;
            // 
            // frmCSarpEtAcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 434);
            this.Controls.Add(this.gbxMiseAJour);
            this.Controls.Add(this.gbxSuppression);
            this.Controls.Add(this.gbxNouvelAlbum);
            this.Controls.Add(this.gbxListeAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCSarpEtAcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access & C#, premiers pas...";
            this.gbxListeAlbums.ResumeLayout(false);
            this.gbxListeAlbums.PerformLayout();
            this.gbxNouvelAlbum.ResumeLayout(false);
            this.gbxNouvelAlbum.PerformLayout();
            this.gbxSuppression.ResumeLayout(false);
            this.gbxSuppression.PerformLayout();
            this.gbxMiseAJour.ResumeLayout(false);
            this.gbxMiseAJour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxListeAlbums;
        private System.Windows.Forms.TextBox tbxAlbum;
        private System.Windows.Forms.GroupBox gbxNouvelAlbum;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbxInsertNomAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomAlbumInsert;
        private System.Windows.Forms.GroupBox gbxSuppression;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDeleteAlbum;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxInsertNomArtiste;
        private System.Windows.Forms.GroupBox gbxMiseAJour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxUpdateId;
        private System.Windows.Forms.ComboBox cbxUpdateNomArtiste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateNomAlbum;
    }
}

