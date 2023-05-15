using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class verifyClearBM_F : Form
    {
        public verifyClearBM_F()
        {
            InitializeComponent();
        }

        private void verifyClearBM_F_Load(object sender, EventArgs e)
        {

        }
        private void Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

    }
}
