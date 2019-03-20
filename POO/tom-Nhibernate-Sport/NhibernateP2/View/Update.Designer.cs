namespace NhibernateP2
{
    partial class Update
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
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFirst = new System.Windows.Forms.TextBox();
            this.tbxLast = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAddresses = new System.Windows.Forms.ComboBox();
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.btnAddAdress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Location = new System.Drawing.Point(569, 53);
            this.tbxEmail.Multiline = true;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(195, 123);
            this.tbxEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emails";
            // 
            // tbxFirst
            // 
            this.tbxFirst.Location = new System.Drawing.Point(61, 50);
            this.tbxFirst.Name = "tbxFirst";
            this.tbxFirst.Size = new System.Drawing.Size(253, 20);
            this.tbxFirst.TabIndex = 2;
            // 
            // tbxLast
            // 
            this.tbxLast.Location = new System.Drawing.Point(47, 76);
            this.tbxLast.Name = "tbxLast";
            this.tbxLast.Size = new System.Drawing.Size(267, 20);
            this.tbxLast.TabIndex = 3;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(114, 102);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpBirth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Addresses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Results";
            // 
            // tbxResult
            // 
            this.tbxResult.Enabled = false;
            this.tbxResult.Location = new System.Drawing.Point(353, 50);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(195, 123);
            this.tbxResult.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date de naissance";
            // 
            // cbAddresses
            // 
            this.cbAddresses.FormattingEnabled = true;
            this.cbAddresses.Location = new System.Drawing.Point(75, 280);
            this.cbAddresses.Name = "cbAddresses";
            this.cbAddresses.Size = new System.Drawing.Size(239, 21);
            this.cbAddresses.TabIndex = 14;
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(171, 309);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(103, 23);
            this.btnAddress.TabIndex = 15;
            this.btnAddress.Text = "Modifier l\'addresse ";
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(493, 309);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(195, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Modifier l\'Athlète";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.Location = new System.Drawing.Point(280, 309);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteAddress.TabIndex = 17;
            this.btnDeleteAddress.Text = "Supprimer l\'addresse";
            this.btnDeleteAddress.UseVisualStyleBackColor = true;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // btnAddAdress
            // 
            this.btnAddAdress.Location = new System.Drawing.Point(47, 309);
            this.btnAddAdress.Name = "btnAddAdress";
            this.btnAddAdress.Size = new System.Drawing.Size(118, 23);
            this.btnAddAdress.TabIndex = 18;
            this.btnAddAdress.Text = "Ajouter une addresse";
            this.btnAddAdress.UseVisualStyleBackColor = true;
            this.btnAddAdress.Click += new System.EventHandler(this.btnAddAdress_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.btnAddAdress);
            this.Controls.Add(this.btnDeleteAddress);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.cbAddresses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.tbxLast);
            this.Controls.Add(this.tbxFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxEmail);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFirst;
        private System.Windows.Forms.TextBox tbxLast;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAddresses;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Button btnAddAdress;
    }
}