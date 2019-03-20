using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fouriere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            classes.transmition_integral mon4X4 = new classes.transmition_integral(0);
            classes.transmition_integral mon4X4_2 = new classes.transmition_integral(1);
            classes.transmition_integral mon4X4_3 = new classes.transmition_integral(2);
            classes.transmition_AVAR mon2X4 = new classes.transmition_AVAR(1);
            classes.transmition_AVAR mon2X4_2 = new classes.transmition_AVAR(2);
            classes.moto moto = new classes.moto(false);
            classes.moto moto_2 = new classes.moto(true);
            classes.electrique velo_electrique = new classes.electrique(25, false);
            classes.electrique velo_electrique_2 = new classes.electrique(35, false);
            classes.electrique velo_electrique_3 = new classes.electrique(25, true);
            classes.bicyclette bicyclette = new classes.bicyclette(false, false);
            classes.bicyclette bicyclette_2 = new classes.bicyclette(true, false);
            classes.bicyclette bicyclette_3 = new classes.bicyclette(false, true);

            tbxValue.Text += velo_electrique.ToString();
        }
    }
}
