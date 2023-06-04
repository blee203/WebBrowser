using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Web_Browser
{
    public partial class editSE_F : Form
    {
        #region initial
        public editSE_F()
        {
            InitializeComponent();
        }
        int index;
        #endregion

        #region button
        private void editThisSEButton_Click(object sender, EventArgs e)
        {
            if (SEName_TBx.Text == "") { MessageBox.Show("Not enough information =<"); return; }
            index = indexOfLines(SEName_TBx.Text);
            if (index < 0) { MessageBox.Show("Search engine unknown :?"); return; }
            label1.Text = "Search engine";
            label2.Visible = true;
            SEURL_TBx.Visible = true;
            editThisSEButton.Visible = false;
            saveEditButton.Visible = true;
            using(StreamReader sr=new StreamReader("SE_Name.txt"))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i == index)
                    {
                        SEName_TBx.Text = line;
                        break;
                    }
                    i++;
                }
            }
            using (StreamReader sr = new StreamReader("SE_URL.txt"))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i == index)
                    {
                        SEURL_TBx.Text = line;
                        break;
                    }
                    i++;
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            if (SEName_TBx.Text == "") { MessageBox.Show("Search engine can not be emptive =<"); return; }
            if (SEURL_TBx.Text == "") { MessageBox.Show("Search engine's URL can not be emptive =<"); return; }
            editLineOfFile(index, SEName_TBx.Text, "SE_Name.txt");
            editLineOfFile(index, SEURL_TBx.Text, "SE_URL.txt");
            this.Close();
        }
        #endregion

        #region support function
        int indexOfLines(string Name)
        {
            string[] lines = File.ReadAllLines("SE_Name.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == Name) { return i; }
            }
            return -1;
        }

        void editLineOfFile(int index,string lineAF, string FileName)
        {
            string tempF = Path.GetTempFileName();
            using (StreamReader sr = new StreamReader(FileName))
            using (StreamWriter sw = new StreamWriter(tempF))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i != index)
                        sw.WriteLine(line);
                    else sw.WriteLine(lineAF);
                    i++;
                }
            }
            File.Delete(FileName);
            File.Move(tempF, FileName);
        }
        #endregion
    }
}
