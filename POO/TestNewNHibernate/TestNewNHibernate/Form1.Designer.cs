namespace TestNewNHibernate
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHQL = new System.Windows.Forms.Button();
            this.btnCriteria = new System.Windows.Forms.Button();
            this.btnQueryOver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btnHQL
            // 
            this.btnHQL.Location = new System.Drawing.Point(91, 12);
            this.btnHQL.Name = "btnHQL";
            this.btnHQL.Size = new System.Drawing.Size(116, 34);
            this.btnHQL.TabIndex = 2;
            this.btnHQL.Text = "HQL";
            this.btnHQL.UseVisualStyleBackColor = true;
            this.btnHQL.Click += new System.EventHandler(this.btnHQL_Click);
            // 
            // btnCriteria
            // 
            this.btnCriteria.Location = new System.Drawing.Point(231, 12);
            this.btnCriteria.Name = "btnCriteria";
            this.btnCriteria.Size = new System.Drawing.Size(116, 34);
            this.btnCriteria.TabIndex = 3;
            this.btnCriteria.Text = "Criteria";
            this.btnCriteria.UseVisualStyleBackColor = true;
            this.btnCriteria.Click += new System.EventHandler(this.btnCriteria_Click);
            // 
            // btnQueryOver
            // 
            this.btnQueryOver.Location = new System.Drawing.Point(365, 12);
            this.btnQueryOver.Name = "btnQueryOver";
            this.btnQueryOver.Size = new System.Drawing.Size(116, 34);
            this.btnQueryOver.TabIndex = 4;
            this.btnQueryOver.Text = "QueryOver";
            this.btnQueryOver.UseVisualStyleBackColor = true;
            this.btnQueryOver.Click += new System.EventHandler(this.btnQueryOver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQueryOver);
            this.Controls.Add(this.btnCriteria);
            this.Controls.Add(this.btnHQL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHQL;
        private System.Windows.Forms.Button btnCriteria;
        private System.Windows.Forms.Button btnQueryOver;
        private System.Windows.Forms.Button button1;
    }
}

