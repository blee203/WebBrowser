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
    public partial class verifyClearSE_F : Form
    {
        public verifyClearSE_F()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //----------------------------------------------
        private void No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
