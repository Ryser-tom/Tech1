namespace Triangle
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
            this.tbxSideA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfoTriangle = new System.Windows.Forms.Button();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblSideC = new System.Windows.Forms.Label();
            this.tbxSideB = new System.Windows.Forms.TextBox();
            this.tbxSideC = new System.Windows.Forms.TextBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxSideA
            // 
            this.tbxSideA.Location = new System.Drawing.Point(69, 12);
            this.tbxSideA.Name = "tbxSideA";
            this.tbxSideA.Size = new System.Drawing.Size(100, 20);
            this.tbxSideA.TabIndex = 0;
            this.tbxSideA.TextChanged += new System.EventHandler(this.tbxSide_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "lblSideA";
            // 
            // btnInfoTriangle
            // 
            this.btnInfoTriangle.Enabled = false;
            this.btnInfoTriangle.Location = new System.Drawing.Point(288, 42);
            this.btnInfoTriangle.Name = "btnInfoTriangle";
            this.btnInfoTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnInfoTriangle.TabIndex = 2;
            this.btnInfoTriangle.Text = "Info Triange";
            this.btnInfoTriangle.UseVisualStyleBackColor = true;
            this.btnInfoTriangle.Click += new System.EventHandler(this.btnInfoTriangle_Click);
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(9, 47);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(45, 13);
            this.lblSideB.TabIndex = 3;
            this.lblSideB.Text = "lblSideB";
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Location = new System.Drawing.Point(9, 81);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(45, 13);
            this.lblSideC.TabIndex = 4;
            this.lblSideC.Text = "lblSideC";
            // 
            // tbxSideB
            // 
            this.tbxSideB.Location = new System.Drawing.Point(69, 44);
            this.tbxSideB.Name = "tbxSideB";
            this.tbxSideB.Size = new System.Drawing.Size(100, 20);
            this.tbxSideB.TabIndex = 5;
            this.tbxSideB.TextChanged += new System.EventHandler(this.tbxSide_TextChanged);
            // 
            // tbxSideC
            // 
            this.tbxSideC.Location = new System.Drawing.Point(69, 78);
            this.tbxSideC.Name = "tbxSideC";
            this.tbxSideC.Size = new System.Drawing.Size(100, 20);
            this.tbxSideC.TabIndex = 6;
            this.tbxSideC.TextChanged += new System.EventHandler(this.tbxSide_TextChanged);
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(69, 127);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(393, 144);
            this.tbxResult.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 279);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbxSideC);
            this.Controls.Add(this.tbxSideB);
            this.Controls.Add(this.lblSideC);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.btnInfoTriangle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSideA);
            this.Name = "Form1";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSideA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfoTriangle;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.TextBox tbxSideB;
        private System.Windows.Forms.TextBox tbxSideC;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label lblResult;
    }
}

