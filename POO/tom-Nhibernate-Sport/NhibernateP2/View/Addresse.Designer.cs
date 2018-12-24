namespace NhibernateP2
{
    partial class Addresse
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
            if (disposing && (components != null))
            {
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
            this.LblNationality = new System.Windows.Forms.Label();
            this.TbxLocation = new System.Windows.Forms.TextBox();
            this.TbxPostalCode = new System.Windows.Forms.TextBox();
            this.LblPostalCode = new System.Windows.Forms.Label();
            this.TbxAddressNum = new System.Windows.Forms.TextBox();
            this.LblAddressNum = new System.Windows.Forms.Label();
            this.TbxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.LblLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkFin = new System.Windows.Forms.CheckBox();
            this.clbCountry = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // LblNationality
            // 
            this.LblNationality.AutoSize = true;
            this.LblNationality.Location = new System.Drawing.Point(353, 10);
            this.LblNationality.Name = "LblNationality";
            this.LblNationality.Size = new System.Drawing.Size(68, 13);
            this.LblNationality.TabIndex = 33;
            this.LblNationality.Text = "Nationalités :";
            // 
            // TbxLocation
            // 
            this.TbxLocation.Location = new System.Drawing.Point(120, 86);
            this.TbxLocation.Name = "TbxLocation";
            this.TbxLocation.Size = new System.Drawing.Size(200, 20);
            this.TbxLocation.TabIndex = 25;
            // 
            // TbxPostalCode
            // 
            this.TbxPostalCode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TbxPostalCode.Location = new System.Drawing.Point(262, 54);
            this.TbxPostalCode.Name = "TbxPostalCode";
            this.TbxPostalCode.Size = new System.Drawing.Size(58, 20);
            this.TbxPostalCode.TabIndex = 24;
            // 
            // LblPostalCode
            // 
            this.LblPostalCode.AutoSize = true;
            this.LblPostalCode.Location = new System.Drawing.Point(184, 57);
            this.LblPostalCode.Name = "LblPostalCode";
            this.LblPostalCode.Size = new System.Drawing.Size(73, 13);
            this.LblPostalCode.TabIndex = 30;
            this.LblPostalCode.Text = "Code postal* :";
            // 
            // TbxAddressNum
            // 
            this.TbxAddressNum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TbxAddressNum.Location = new System.Drawing.Point(120, 54);
            this.TbxAddressNum.Name = "TbxAddressNum";
            this.TbxAddressNum.Size = new System.Drawing.Size(58, 20);
            this.TbxAddressNum.TabIndex = 23;
            // 
            // LblAddressNum
            // 
            this.LblAddressNum.AutoSize = true;
            this.LblAddressNum.Location = new System.Drawing.Point(12, 57);
            this.LblAddressNum.Name = "LblAddressNum";
            this.LblAddressNum.Size = new System.Drawing.Size(50, 13);
            this.LblAddressNum.TabIndex = 29;
            this.LblAddressNum.Text = "Numéro :";
            // 
            // TbxAddress
            // 
            this.TbxAddress.Location = new System.Drawing.Point(120, 26);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.Size = new System.Drawing.Size(200, 20);
            this.TbxAddress.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adresse* :";
            // 
            // CbxCountry
            // 
            this.CbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCountry.FormattingEnabled = true;
            this.CbxCountry.Location = new System.Drawing.Point(120, 115);
            this.CbxCountry.Name = "CbxCountry";
            this.CbxCountry.Size = new System.Drawing.Size(200, 21);
            this.CbxCountry.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pays*";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(15, 232);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 35;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(245, 232);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 34;
            this.BtnConfirm.Text = "Confirmer";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(120, 151);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 36;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(120, 187);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 37;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(9, 89);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(81, 13);
            this.LblLocation.TabIndex = 38;
            this.LblLocation.Text = "Emplacement* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Date debut";
            // 
            // checkFin
            // 
            this.checkFin.AutoSize = true;
            this.checkFin.Location = new System.Drawing.Point(10, 190);
            this.checkFin.Name = "checkFin";
            this.checkFin.Size = new System.Drawing.Size(63, 17);
            this.checkFin.TabIndex = 41;
            this.checkFin.Text = "Date fin";
            this.checkFin.UseVisualStyleBackColor = true;
            this.checkFin.CheckedChanged += new System.EventHandler(this.checkFin_CheckedChanged);
            // 
            // clbCountry
            // 
            this.clbCountry.FormattingEnabled = true;
            this.clbCountry.Location = new System.Drawing.Point(356, 29);
            this.clbCountry.Name = "clbCountry";
            this.clbCountry.Size = new System.Drawing.Size(209, 229);
            this.clbCountry.TabIndex = 42;
            // 
            // Addresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 291);
            this.Controls.Add(this.clbCountry);
            this.Controls.Add(this.checkFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LblNationality);
            this.Controls.Add(this.TbxLocation);
            this.Controls.Add(this.TbxPostalCode);
            this.Controls.Add(this.LblPostalCode);
            this.Controls.Add(this.TbxAddressNum);
            this.Controls.Add(this.LblAddressNum);
            this.Controls.Add(this.TbxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxCountry);
            this.Controls.Add(this.label1);
            this.Name = "Addresse";
            this.Text = "Addresse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNationality;
        private System.Windows.Forms.TextBox TbxLocation;
        private System.Windows.Forms.TextBox TbxPostalCode;
        private System.Windows.Forms.Label LblPostalCode;
        private System.Windows.Forms.TextBox TbxAddressNum;
        private System.Windows.Forms.Label LblAddressNum;
        private System.Windows.Forms.TextBox TbxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkFin;
        private System.Windows.Forms.CheckedListBox clbCountry;
    }
}