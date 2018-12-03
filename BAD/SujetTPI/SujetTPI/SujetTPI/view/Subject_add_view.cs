using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SujetTPI.view
{
    public partial class Subject_add_view : Form
    {
        private bool exiting;
        public Subject_add_view()
        {
            InitializeComponent();
            exiting = false;
        }

        private void Subject_add_close(object sender, EventArgs e)
        {
            if (!exiting) {
                if (sender is Button) {
                    exiting = true;
                    Main main_form = new Main();
                    main_form.Show();
                    this.Close();
                } else {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void Subject_add_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            Subject_add_close(sender, e);
        }
    }
}
