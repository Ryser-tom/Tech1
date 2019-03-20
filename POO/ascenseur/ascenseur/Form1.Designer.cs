namespace ascenseur
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.tbxMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSSol = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPeoplePlus = new System.Windows.Forms.Button();
            this.btnPeopleMinus = new System.Windows.Forms.Button();
            this.numUDPersonne = new System.Windows.Forms.NumericUpDown();
            this.lblAscenseur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMax
            // 
            this.tbxMax.Location = new System.Drawing.Point(307, 12);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.Size = new System.Drawing.Size(47, 20);
            this.tbxMax.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nb étages max : ";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(219, 73);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Créer ascenseur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nb étages s-sol :";
            // 
            // tbxSSol
            // 
            this.tbxSSol.Location = new System.Drawing.Point(307, 38);
            this.tbxSSol.Name = "tbxSSol";
            this.tbxSSol.Size = new System.Drawing.Size(47, 20);
            this.tbxSSol.TabIndex = 3;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(275, 159);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(26, 23);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(275, 188);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(26, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nb personnes";
            // 
            // btnPeoplePlus
            // 
            this.btnPeoplePlus.Location = new System.Drawing.Point(233, 287);
            this.btnPeoplePlus.Name = "btnPeoplePlus";
            this.btnPeoplePlus.Size = new System.Drawing.Size(26, 23);
            this.btnPeoplePlus.TabIndex = 8;
            this.btnPeoplePlus.Text = "+";
            this.btnPeoplePlus.UseVisualStyleBackColor = true;
            this.btnPeoplePlus.Click += new System.EventHandler(this.btnPeoplePlus_Click);
            // 
            // btnPeopleMinus
            // 
            this.btnPeopleMinus.Location = new System.Drawing.Point(328, 287);
            this.btnPeopleMinus.Name = "btnPeopleMinus";
            this.btnPeopleMinus.Size = new System.Drawing.Size(26, 23);
            this.btnPeopleMinus.TabIndex = 9;
            this.btnPeopleMinus.Text = "-";
            this.btnPeopleMinus.UseVisualStyleBackColor = true;
            this.btnPeopleMinus.Click += new System.EventHandler(this.btnPeopleMinus_Click);
            // 
            // numUDPersonne
            // 
            this.numUDPersonne.Location = new System.Drawing.Point(275, 290);
            this.numUDPersonne.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUDPersonne.Name = "numUDPersonne";
            this.numUDPersonne.Size = new System.Drawing.Size(35, 20);
            this.numUDPersonne.TabIndex = 10;
            // 
            // lblAscenseur
            // 
            this.lblAscenseur.AutoSize = true;
            this.lblAscenseur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAscenseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAscenseur.ForeColor = System.Drawing.Color.Red;
            this.lblAscenseur.Location = new System.Drawing.Point(73, 220);
            this.lblAscenseur.MaximumSize = new System.Drawing.Size(84, 20);
            this.lblAscenseur.MinimumSize = new System.Drawing.Size(84, 20);
            this.lblAscenseur.Name = "lblAscenseur";
            this.lblAscenseur.Size = new System.Drawing.Size(84, 20);
            this.lblAscenseur.TabIndex = 11;
            this.lblAscenseur.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 541);
            this.Controls.Add(this.lblAscenseur);
            this.Controls.Add(this.numUDPersonne);
            this.Controls.Add(this.btnPeopleMinus);
            this.Controls.Add(this.btnPeoplePlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSSol);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMax);
            this.Name = "Form1";
            this.Text = "Ascenseur";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblAscenseur;
        private System.Windows.Forms.NumericUpDown numUDPersonne;
        private System.Windows.Forms.Button btnPeopleMinus;
        private System.Windows.Forms.Button btnPeoplePlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSSol;
    }
}

