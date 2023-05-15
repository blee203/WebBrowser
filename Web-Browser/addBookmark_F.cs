using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Web_Browser
{
    public partial class addBookmark_F : Form
    {
        public addBookmark_F()
        {
            InitializeComponent();
        }

        private void addBookmark_F_Load(object sender, EventArgs e)
        {

        }
        string FName = "BM_Name.txt", FURL = "BM_URL.txt";
        private void Add_Click(object sender, EventArgs e)
        {
            if (BMName.Text == "" || BMURL.Text == "")
            { MessageBox.Show("Not enough information =(("); return; }
            using (StreamWriter sw = File.AppendText(FName))
            {
                sw.WriteLine(BMName.Text);
            }
            using (StreamWriter sw = File.AppendText(FURL))
            {
                sw.WriteLine(BMURL.Text);
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
