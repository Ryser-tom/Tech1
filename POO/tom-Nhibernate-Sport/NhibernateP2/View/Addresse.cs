/* Project : NhibernateP2
 * Description : C# application who usen Nhibernate to manipulate database
 * Author : Tom RYSER
 * Version : 1.0
 * Last update : 24.12.2018
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhibernateP2
{
    public partial class Addresse : Form
    {
        private Address A = new Address();
        private model M = new model();
        private IList<Country> Country;

        public Addresse(Athlete Athlete)
        {
            A.Athlete = Athlete;
            InitializeComponent();
            Country = M.GetCountry();
        }
        public Addresse(Address addresse)
        {
            A = addresse;
            InitializeComponent();
            TbxAddressNum.Text = addresse.Street_nr;
            TbxAddress.Text = addresse.Street;
            TbxLocation.Text = addresse.Location;
            TbxPostalCode.Text = addresse.Postal_code;
            dtpStart.Value = addresse.Valid_from;
            if (addresse.Valid_to != default(DateTime))
            {
                dtpEnd.Value = addresse.Valid_to;
                checkFin.Checked = true;
            }
            else
            {
                checkFin.Checked = false;
            }

            var checkBoxList = (ListBox)clbCountry;
            checkBoxList.DataSource = M.GetCountry();
            checkBoxList.DisplayMember = "name";
            checkBoxList.ValueMember = "id";
            Updateview();
        }
        public void Updateview()
        {
            if (checkFin.Checked == true)
            {
                dtpEnd.Enabled = true;
            }
            else
            {
                dtpEnd.Enabled = false;
            }
        }

        private void checkFin_CheckedChanged(object sender, EventArgs e)
        {
            Updateview();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Address Address = new Address();
            Address = A;
            Address.Location = TbxLocation.Text;
            Address.Postal_code = TbxPostalCode.Text;
            Address.Street = TbxAddress.Text;
            Address.Street_nr = TbxAddressNum.Text;
            Address.Valid_from = dtpStart.Value;
            if (checkFin.Checked == false)
            {
                Address.Valid_to = default(DateTime);
            }else{
                Address.Valid_to = dtpEnd.Value;
            }
            M.CreateOrUpdateAddress(Address);
            this.Close();
        }
    }
}
