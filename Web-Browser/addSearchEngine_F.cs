using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Web_Browser
{
    public partial class addSearchEngine_F : Form
    {
        public addSearchEngine_F()
        {
            InitializeComponent();
        }
        string FName = "SE_Name.txt",FURL= "SE_URL.txt";
        private void Add_Click(object sender, EventArgs e)
        {
            if(SEName.Text==""||SEURL.Text=="")
                { MessageBox.Show("Not enough information =((");return; }
            checkName();
            using(StreamWriter sw = File.AppendText(FName))
            {
                sw.WriteLine(SEName.Text);
            }
            using (StreamWriter sw = File.AppendText(FURL))
            {
                sw.WriteLine(SEURL.Text);
            }
            this.Close();
        }

        private void addSearchEngine_F_Load(object sender, EventArgs e)
        {
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void checkName()
        {
            string[] Nlines = File.ReadAllLines(FName);
            foreach(string line in Nlines)
            {
                if(line==SEName.Text) { MessageBox.Show("Search engine's name already exist...");return; }
            }
        }
    }
}
