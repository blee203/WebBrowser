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
using System.Threading;

namespace Web_Browser
{
    public partial class deleteSE_F : Form
    {
        public deleteSE_F()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SETextBox.Text == "") { MessageBox.Show("Not enough information =<"); return; }
            int index=indexOfLines(SETextBox.Text);
            if (index < 0) { MessageBox.Show("Search engine unknown :?"); return; }
            deleteLineOfFile(index, "SE_Name.txt");
            deleteLineOfFile(index, "SE_URL.txt");
            this.Close();
        }
        void deleteLineOfFile(int index,string FileName)
        {
            string tempF = Path.GetTempFileName();
            using(StreamReader sr = new StreamReader(FileName))
            using (StreamWriter sw = new StreamWriter(tempF))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if(i!=index)
                        sw.WriteLine(line);
                    i++;
                }
            }
            File.Delete(FileName);
            File.Move(tempF, FileName);
        }
        int indexOfLines(string Name)
        {
            string[] lines = File.ReadAllLines("SE_Name.txt");
            for(int i=0;i<lines.Length; i++)
            {
                if (lines[i] == Name) { return i;}
            }
            return -1;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteAllSEButton_Click(object sender, EventArgs e)
        {
            Form f = new verifyClearSE_F();
            f.ShowDialog();
            if(f.DialogResult == DialogResult.No) { return; }
            File.Delete("SE_Name.txt");
            File.Delete("SE_URL.txt");
            using (var stream = File.Create("SE_Name.txt"))
            using (var stream_ = File.Create("SE_URL.txt")) { }
            this.Close();
        }
    }
}
