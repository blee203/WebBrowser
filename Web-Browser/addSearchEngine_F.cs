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
        #region initial

        public addSearchEngine_F()
        {
            InitializeComponent();
        }
        private void addSearchEngine_F_Load(object sender, EventArgs e)
        {
        }
        string FName = "SE_Name.txt",FURL= "SE_URL.txt";

        #endregion

        #region buttons

        private void Add_Click(object sender, EventArgs e) //add button
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
        private void Cancel_Click(object sender, EventArgs e)//cancel button
        {
            this.Close();   
        }
        #endregion

        #region support functions 
        private void checkName()
        {
            string[] Nlines = File.ReadAllLines(FName);
            foreach(string line in Nlines)
            {
                if(line==SEName.Text) { MessageBox.Show("Search engine's name already exist...");return; }
            }
        }
        #endregion
    }
}
