using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class deleteBM_F : Form
    {
        public deleteBM_F()
        {
            InitializeComponent();
        }

        private void deleteBM_F_Load(object sender, EventArgs e)
        {

        }
        List<int> index=new List<int> { };
        private void button2_Click(object sender, EventArgs e)
        {
            string[] linesURL = File.ReadAllLines("BM_URL.txt");
            for(int i = 0; i < index.Count; i++)
            {
                if (linesURL[index[i]] == BMURL_TBx.Text)
                {
                    deleteLineOfFile(index[i], "BM_Name.txt");
                    deleteLineOfFile(index[i], "BM_URL.txt");
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Bookmark unknown @~@");
        }
        void deleteLineOfFile(int index, string FileName)
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
                    i++;
                }
            }
            File.Delete(FileName);
            File.Move(tempF, FileName);
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteAllBMButton_Click(object sender, EventArgs e)
        {
            Form f = new verifyClearBM_F();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.No) { return; }
            File.Delete("BM_Name.txt");
            File.Delete("BM_URL.txt");
            using (var stream = File.Create("BM_Name.txt"))
                File.Create("BM_URL.txt");
            this.Close();
        }

        private void findBM_Click(object sender, EventArgs e)
        {
            if (BMName_TBx.Text == "") { MessageBox.Show("Not enough information =<"); return; }
            string[] linesURL = File.ReadAllLines("BM_URL.txt");
            string[] linesName = File.ReadAllLines("BM_Name.txt");
            for (int i = 0; i < linesName.Length; i++)
            {
                if (linesName[i] == BMName_TBx.Text) 
                {
                    URLList.Text += linesURL[i]+"\n";
                    index.Add(i);
                }
            }
            if(index.Count==0) 
            { 
                MessageBox.Show("Bookmark's name unknown :<");
                return;
            }
            label2.Visible = true;
            label3.Visible = true;
            BMURL_TBx.Visible=true;
            URLList.Visible=true;
            deleteButton.Visible=true;
            deleteAllBMButton.Visible=true;
            findBM.Visible=false;
            BMName_TBx.ReadOnly = true;
        }
    }
}
