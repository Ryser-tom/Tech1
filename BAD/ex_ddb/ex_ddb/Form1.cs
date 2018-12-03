using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_ddb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entreprisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.etudiantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Etudiants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.etudiantsTableAdapter.Fill(this.database1DataSet.Etudiants);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Entreprises'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.entreprisesTableAdapter.Fill(this.database1DataSet.Entreprises);

            textBox1.Text = database1DataSet.Tables[0].Rows[0][1].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
