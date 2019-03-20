using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        private controller control = new controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxSide_TextChanged(object sender, EventArgs e)
        {
            if (tbxSideA.Text != "" && tbxSideB.Text != "" && tbxSideC.Text != "") {
                btnInfoTriangle.Enabled = true;
            } else {
                btnInfoTriangle.Enabled = false;
            }
        }

        private void btnInfoTriangle_Click(object sender, EventArgs e)
        {
            control.SetSideLenghts(Convert.ToDouble(tbxSideA.Text), Convert.ToDouble(tbxSideB.Text), Convert.ToDouble(tbxSideC.Text));
            tbxResult.Text = control.Classify() + Environment.NewLine;
            tbxResult.Text += "Le permimètre vaut : " + control.GetPerimeter() + Environment.NewLine;
            tbxResult.Text += "La surface vaut : " + control.GetArea() + Environment.NewLine;
        }
    }
}
