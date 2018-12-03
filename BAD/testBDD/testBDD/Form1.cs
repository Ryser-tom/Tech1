using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void t_ClientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_ClientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testBDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'testBDDataSet.T_Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.t_ClientsTableAdapter.Fill(this.testBDDataSet.T_Clients);

        }
    }
}
