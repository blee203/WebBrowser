using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Web_Browser
{
    public partial class editBM_F : Form
    {
        public editBM_F()
        {
            InitializeComponent();
        }
        List<int> index = new List<int> { };
        string[] linesURL = File.ReadAllLines("BM_URL.txt");
        string[] linesName = File.ReadAllLines("BM_Name.txt");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findBMButton_Click(object sender, EventArgs e)
        {
            if (BMName_TBx.Text == "") { MessageBox.Show("Not enough information =<"); return; }
            for (int i = 0; i < linesName.Length; i++)
            {
                if (linesName[i].Contains(BMName_TBx.Text))
                {
                    string[] row = { linesName[i], linesURL[i] };
                    ListViewItem lvi = new ListViewItem(row);
                    BM_List.Items.Add(lvi);
                    index.Add(i);
                }
            }
            if (index.Count == 0)
            {
                MessageBox.Show("Bookmark's name unknown :<");
                return;
            }
            label2.Visible = true;
            label3.Visible = true;
            BMURL_TBx.Visible = true;
            BM_List.Visible = true;
            editThisBMButton.Visible = true;
            findBMButton.Visible = false;
            BMName_TBx.Text = "";
            BMName_TBx.ReadOnly = true;
            BMURL_TBx.ReadOnly = true;
        }

        private void editThisBMButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < index.Count; i++)
            {
                if (linesURL[index[i]] == BMURL_TBx.Text)
                {
                    findBMButton.Visible = false;
                    editThisBMButton.Visible = false;
                    BM_List.Visible = false;
                    label3.Visible = false;
                    saveButton.Visible = true;
                    BMName_TBx.ReadOnly = false;
                    BMURL_TBx.ReadOnly = false;
                    BMURL_TBx.Text = linesURL[index[i]];
                    index[0] = index[i];
                    return;
                }
            }
            MessageBox.Show("Bookmark unknown @~@");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (BMName_TBx.Text == "") { MessageBox.Show("Bookmark's name can not be emptive =<"); return; }
            if (BMURL_TBx.Text == "") { MessageBox.Show("Bookmark's URL can not be emptive =<"); return; }
            editLineOfFile(index[0], BMName_TBx.Text, "BM_Name.txt");
            editLineOfFile(index[0], BMURL_TBx.Text, "BM_URL.txt");
            this.Close();
        }
        void editLineOfFile(int index, string lineAF, string FileName)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BM_List.SelectedItems.Count == 0) return;
            BMName_TBx.Text = BM_List.SelectedItems[0].Text;
            BMURL_TBx.Text = BM_List.SelectedItems[0].SubItems[1].Text;
        }
    }
}
